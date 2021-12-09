using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddSessionForm : Form
    {
        private RequestType requestType;

        private int idForEdit;


        public AddSessionForm(RequestType requestType, int idForEdit)
        {
            InitializeComponent();

            this.idForEdit = idForEdit;
            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            HallNameBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (requestType == RequestType.Update)
            {
                HeaderLabel.Text = "Редактировать сеанс";
                AddOrUpdateButton.Text = "Редактировать";
                GetSessionFromDatabase(idForEdit);
            }
        }

        private void GetSessionFromDatabase(int id)
        {
            try
            {
                var myDatabase = new MyDatabase();
                var movieData = myDatabase.MyСommand.GetReadData(Requests.GetSessionById(id));

                if (movieData.Count != 5)
                {
                    MessageBox.Show("Данный сеанс не найден.");
                }

                var dateAndTime = movieData[1].Split(' ');
                DateTime sessionData = Convert.ToDateTime(dateAndTime[0]);
                DateTime sessionTime = Convert.ToDateTime(dateAndTime[1]);
                int price = Convert.ToInt32(movieData[2]);
                int halleId = Convert.ToInt32(movieData[3]);
                int movieId = Convert.ToInt32(movieData[4]);

                MovieIdBox.Text = movieId.ToString();
                MoviePriceBox.Text = price.ToString();
                SessionDatePicker.Value = sessionData;
                SessionTimePicker.Value = sessionTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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

            try
            {
                var session = new Session(SessionDatePicker.Value, SessionTimePicker.Value,
                    moviePrice, HallNameBox.Text, movieId);

                string request = "";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateSessionById(idForEdit, session);
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddSession(session);
                }

                var myDatabase = new MyDatabase();

                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Сеанс добавлен/изменён");
                else
                    MessageBox.Show("Сеанс не был добавлен/изменён");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    }
}
