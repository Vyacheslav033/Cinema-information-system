using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class DeleteFromDatabaseForm : Form
    {
        private RequestName requestType;

        public DeleteFromDatabaseForm(RequestName requestType)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            string headerPanelValue = "";
            string getNumberPanelValue = "";

            if (requestType == RequestName.Movies)
            {
                headerPanelValue = "Удалить фильм";
                getNumberPanelValue = "Номер фильма";               
            }
            else if (requestType == RequestName.Sessions)
            {
                headerPanelValue = "Удалить сеанс";
                getNumberPanelValue = "Номер сеанса";
            }
            else if (requestType == RequestName.Tickets)
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

            if (requestType == RequestName.Movies)
            {               
                request = Requests.DeleteMovieById(number);
            }
            else if (requestType == RequestName.Sessions)
            {
                request = Requests.DeleteSessionById(number);
            }
            else if (requestType == RequestName.Tickets)
            {
                request = Requests.DeleteTicketById(number);
            }

            try
            {
                var myDatabase = new MyDatabase();

                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Запись удалена.");
                else
                    MessageBox.Show("Запись не была удалена.");
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
