using System;
using System.Data;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма с администратора с возможностью вывода, редактирования, удаления записей.
    /// </summary>
    public partial class EditDatabaseForm : Form
    {
        /// <summary>
        /// Тип запроса.
        /// </summary>
        private RequestName requestName;

        /// <summary>
        /// Запрос.
        /// </summary>
        private string request;

        /// <summary>
        /// Инициализатор формы EditDatabaseForm.
        /// </summary>
        /// <param name="requestName"> Тип запроса. </param>
        public EditDatabaseForm(RequestName requestName)
        {           
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.requestName = requestName;

            ChooseForm(RequestType.Add, 1);

            LoadData();
        }

        /// <summary>
        /// Заполнить таблицу данными.
        /// </summary>
        private void LoadData()
        {
            try
            {
                var myDatabase = new MyDatabase();

                DataTable.DataSource = myDatabase.MyСommand.GetDataTable(request);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Логика кнопки выйти.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Логика кнопки обновления.
        /// </summary>
        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            LoadData();           
        }

        /// <summary>
        /// Логика кнопки обновления.
        /// </summary>
        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            int id = CheckSelectedRecord("редактирования");

            if (id != -1)
            {
                var form = ChooseForm(RequestType.Update, id);
                form.Show();
            }
        }

        /// <summary>
        /// Проверка выбора записи для редактирования/удаления.
        /// </summary>
        /// <param name="errorMessegeType"> Сообщение об ошибке. </param>
        /// <returns> Возращает номер выбранной записи. </returns>
        private int CheckSelectedRecord(string errorMessegeType)
        {
            int selectedCellCount = DataTable.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount != 1)
            {
                MessageBox.Show($"Выберите одну запись для {errorMessegeType}.");
                return -1;
            }

            int row = DataTable.SelectedCells[0].RowIndex;
            int column = DataTable.SelectedCells[0].ColumnIndex;

            if (column != 0)
            {
                MessageBox.Show($"Выберите номер записи для {errorMessegeType}.");
                return -1;
            }

            int id = 0;
            string value = DataTable.Rows[row].Cells[column].Value.ToString();

            if (!int.TryParse(value, out id))
            {
                MessageBox.Show("Ячейка с предполагаемым айди записи имеет неверный формат.");
                return -1;
            }

            return id;
        }


        /// <summary>
        /// Логика кнопки добавления.
        /// </summary>
        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            var form = ChooseForm(RequestType.Add, 0);
            form.Show();
        }

        /// <summary>
        /// Логика кнопки удаления.
        /// </summary>
        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = CheckSelectedRecord("удаления");

                if (id != -1)
                {
                    string request = "";

                    if (requestName == RequestName.Movies)
                    {
                        request = Requests.DeleteMovieById(id);
                    }
                    else if (requestName == RequestName.Sessions)
                    {
                        request = Requests.DeleteSessionById(id);
                    }
                    else if (requestName == RequestName.Tickets)
                    {
                        request = Requests.DeleteTicketById(id);
                    }

                    var myDatabase = new MyDatabase();

                    if (myDatabase.MyСommand.RunRequest(request))
                        MessageBox.Show("Запись удалена.");
                    else
                        MessageBox.Show("Запись не была удалена.");
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Получение формы по типу запроса.
        /// </summary>
        /// <param name="type"> Тип запроса. </param>
        /// <param name="idForEdit"> Номер записи для изменения. </param>
        /// <returns> Форму. </returns>
        private Form ChooseForm(RequestType type, int idForEdit)
        {

            if (requestName == RequestName.Movies)
            {
                HeadPanel.Text = "Фильмы";
                this.request = Requests.GetMovies();

                return new AddMovieForm(type, idForEdit);
            }
            else if (requestName == RequestName.Sessions)
            {
                HeadPanel.Text = "Сеансы";
                this.request = Requests.GetSessions();

                return new AddSessionForm(type, idForEdit);
            }
            else if (requestName == RequestName.Tickets)
            {
                HeadPanel.Text = "Билеты";
                this.request = Requests.GetTickets();

                return new AddTicketForm(type, idForEdit);
            }

            return null;
        }

        /// <summary>
        /// Логика поиска.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string movieName = ValueForSearchBox.Text;
                string searchRequest = "";

                if ( !string.IsNullOrWhiteSpace(movieName) )
                {
                    if (requestName == RequestName.Movies)
                    {
                        searchRequest = Requests.GetMovieByName(movieName);
                    }
                    else if (requestName == RequestName.Sessions)
                    {
                        searchRequest = Requests.GetSessionsByMovieName(movieName);
                    }
                    else if (requestName == RequestName.Tickets)
                    {
                        searchRequest = Requests.GetTicketsByMovieName(movieName);
                    }

                    var myDatabase = new MyDatabase();

                    DataTable.DataSource = myDatabase.MyСommand.GetDataTable(searchRequest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
