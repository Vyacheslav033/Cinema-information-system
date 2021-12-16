using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма добавления/обновления сеанса.
    /// </summary>
    public partial class AddSessionForm : Form
    {
        /// <summary>
        /// Тип запроса.
        /// </summary>
        private RequestType requestType;


        /// <summary>
        /// Номер сеанса.
        /// </summary>
        private int sessionId;

        /// <summary>
        /// Инициализатор класса AddSessionForm.
        /// </summary>
        /// <param name="requestType"> Тип запроса. </param>
        /// <param name="sessionId"> Номер сеанса. </param>
        public AddSessionForm(RequestType requestType, int sessionId)
        {
            InitializeComponent();

            this.sessionId = sessionId;
            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            HallNameBox.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                if (requestType == RequestType.Update)
                {
                    HeaderLabel.Text = "Редактировать сеанс";
                    AddOrUpdateButton.Text = "Редактировать";

                    Session session = GetSession(sessionId);
                    OutputSessionInfo(session);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        /// <summary>
        /// Получить сеанс по номеру.
        /// </summary>
        /// <param name="sessionId"> Номер сеанса. </param>
        /// <returns> Обект типа Session. </returns>
        private Session GetSession(int sessionId)
        {
            var myDatabase = new MyDatabase();
            var movieData = myDatabase.MyСommand.GetReadData(Requests.GetSessionById(sessionId));

            if (movieData.Count != 5)
            {
                MessageBox.Show("Данный сеанс не найден.");
            }

            var dateAndTime = movieData[1].Split(' ');
            DateTime sessionData = Convert.ToDateTime(dateAndTime[0]);
            DateTime sessionTime = Convert.ToDateTime(dateAndTime[1]);
            int price = Convert.ToInt32(movieData[2]);
            string halleName = movieData[3];
            int movieId = Convert.ToInt32(movieData[4]);

            return new Session(sessionData, sessionTime, price, halleName, movieId);  
        }

        /// <summary>
        /// Вывести информацию о сеанса.
        /// </summary>
        /// <param name="session"> Сеанс. </param>
        private void OutputSessionInfo(Session session)
        {
            MovieIdBox.Text = session.MovieId.ToString();
            MoviePriceBox.Text = session.Price.ToString();
            SessionDatePicker.Value = session.Data;
            SessionTimePicker.Value = session.Time;
        }

        /// <summary>
        /// Логика кнопки добавить/редактировать..
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {         
            try
            {
                int movieId = 0;
                int moviePrice = 0;

                if (!int.TryParse(MovieIdBox.Text, out movieId))
                {
                    MessageBox.Show("Номер фильма введён не корректно!");
                    return;
                }
                else if (!int.TryParse(MoviePriceBox.Text, out moviePrice))
                {
                    MessageBox.Show("Цена фильма введена не корректно!");
                    return;
                }

                var session = new Session(SessionDatePicker.Value, SessionTimePicker.Value,
                    moviePrice, HallNameBox.Text, movieId);

                string request = "";
                string messege = "";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateSessionById(sessionId, session);
                    messege = "изменён";
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddSession(session);
                    messege = "добавлен";
                }

                var myDatabase = new MyDatabase();

                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Сеанс " + messege);
                else
                    MessageBox.Show("Сеанс не был " + messege );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        /// <summary>
        /// Логика кнопки выйти.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    }
}
