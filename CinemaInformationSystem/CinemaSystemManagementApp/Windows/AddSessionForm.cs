using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddSessionForm : Form
    {
        private RequestType requestType;


        public AddSessionForm(RequestType requestType)
        {
            InitializeComponent();

            if (requestType == RequestType.Update)
            {
                HeaderLabel.Text = "Редактировать сеанс";
                AddOrUpdateButton.Text = "Редактировать";
            }

            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            HallNameBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                var session = new Session(MovieDatePicker.Value, MovieTimePicker.Value, moviePrice, HallNameBox.Text, movieId);

                string request = Requests.AddSession(session);

                var myDatabase = new MyDatabase();

                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Сеанс добавлен");
                else
                    MessageBox.Show("Сеанс не был добавлен");
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
