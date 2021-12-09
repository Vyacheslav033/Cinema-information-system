using System;
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

            string title = "";
            request = "";

            if (requestType == RequestName.Movies)
            {
                title = "Фильмы";
                request = Requests.GetMovies();
            }
            else if (requestType == RequestName.Sessions)
            {
                title = "Сеансы";
                request = Requests.GetSessions();
            }
            else if (requestType == RequestName.Tickets)
            {
                title = "Билеты";
                request = Requests.GetTickets();
            }

            HeadPanel.Text = title;
            this.requestType = requestType;

            FillTable();
        }

        private void FillTable()
        {
            var myDatabase = new MyDatabase();

            DataTable.DataSource = myDatabase.MyСommand.GetDataTable(request);
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void EditEntryButton_Click(object sender, EventArgs e)
        {
            var form = ChooseForm(RequestType.Update);
            form.Show();

            //var myDatabase = new MyDatabase();
            //var list = myDatabase.MyСommand.GetReadData("SELECT * FROM filmoteka.фильмы;");
        }

        private void AddEntryButton_Click(object sender, EventArgs e)
        {
            var form = ChooseForm(RequestType.Add);
            form.Show();
        }

        private void DeleteEntryButton_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteFromDatabaseForm(requestType);
            deleteForm.Show();
        }

        private Form ChooseForm(RequestType type)
        {
            if (requestType == RequestName.Movies)
            {
                return new AddMovieForm(type);
            }
            else if (requestType == RequestName.Sessions)
            {
                return new AddSessionForm(type);
            }
            else if (requestType == RequestName.Tickets)
            {
                return new AddTicketForm(type);
            }

            return null;
        }
        
    }
}
