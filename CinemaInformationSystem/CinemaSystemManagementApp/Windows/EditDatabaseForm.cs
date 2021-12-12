using System;
using System.Data;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class EditDatabaseForm : Form
    {
        private RequestName requestType;
        private string request;

        public EditDatabaseForm(RequestName requestType)
        {           
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.requestType = requestType;

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


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            LoadData();           
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            int selectedCellCount = DataTable.GetCellCount(DataGridViewElementStates.Selected);

            if (selectedCellCount != 1)
            {
                MessageBox.Show("Выберите одну запись для редактирования.");
                return;
            }

            int row = DataTable.SelectedCells[0].RowIndex;
            int column = DataTable.SelectedCells[0].ColumnIndex;

            if (column != 0)
            {
                MessageBox.Show("Выберите номер запись для редактирования.");
                return;
            }

            string value = DataTable.Rows[row].Cells[column].Value.ToString();
            int intValue = 0;

            if ( !int.TryParse(value, out intValue) )
            {
                MessageBox.Show("Ячейка с предполагаемым айди записи имеет не верный формат.");
            }

            var form = ChooseForm(RequestType.Update, intValue);
            form.Show();
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            var form = ChooseForm(RequestType.Add, 0);
            form.Show();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteFromDatabaseForm(requestType);
            deleteForm.Show();
        }

        private Form ChooseForm(RequestType type, int idForEdit)
        {

            if (requestType == RequestName.Movies)
            {
                HeadPanel.Text = "Фильмы";
                this.request = Requests.GetMovies();

                return new AddMovieForm(type, idForEdit);
            }
            else if (requestType == RequestName.Sessions)
            {
                HeadPanel.Text = "Сеансы";
                this.request = Requests.GetSessions();

                return new AddSessionForm(type, idForEdit);
            }
            else if (requestType == RequestName.Tickets)
            {
                HeadPanel.Text = "Билеты";
                this.request = Requests.GetTickets();

                return new AddTicketForm(type, idForEdit);
            }

            return null;
        }
    }
}
