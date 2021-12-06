using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class DeleteFromDatabaseForm : Form
    {
        private RequestType requestType;

        public DeleteFromDatabaseForm(RequestType requestType)
        {
            InitializeComponent();

            string headerPanelValue = "";
            string getNumberPanelValue = "";

            if (requestType == RequestType.Movies)
            {
                headerPanelValue = "Удалить фильм";
                getNumberPanelValue = "Номер фильма";               
            }
            else if (requestType == RequestType.Sessions)
            {
                headerPanelValue = "Удалить сеанс";
                getNumberPanelValue = "Номер сеанса";
            }
            else if (requestType == RequestType.Tickets)
            {
                headerPanelValue = "Удалить билет";
                getNumberPanelValue = "Номер билета";
            }

            HeaderPanel.Text = headerPanelValue;
            InputPanelTitle.Text = getNumberPanelValue;

            this.requestType = requestType;
        }

   
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int number = 0;

            if (!int.TryParse(RecordNumberBox.Text, out number))
            {
                MessageBox.Show("Введите номер записи!");
                return;
            }
            if (number <= 0)
            {
                MessageBox.Show("Номер записи должен быть больше 0!");
                return;
            }

            string request = "";

            if (requestType == RequestType.Movies)
            {               
                request = Requests.DeleteMovieById(number);
            }
            else if (requestType == RequestType.Sessions)
            {
                request = Requests.DeleteSessionById(number);
            }
            else if (requestType == RequestType.Tickets)
            {
                request = Requests.DeleteTicketById(number);
            }

            try
            {
                var myDatabase = new MyDatabase();

                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Запись добавлена.");
                else
                    MessageBox.Show("Запись не была добавлена.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
