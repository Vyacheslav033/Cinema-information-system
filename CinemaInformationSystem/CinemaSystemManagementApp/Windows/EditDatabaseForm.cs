using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class EditDatabaseForm : Form
    {
        private RequestName requestType;

        public EditDatabaseForm(RequestName requestType)
        {           
            InitializeComponent();

            string title = "";

            if (requestType == RequestName.Movies)
            {
                title = "Фильмы";
            }
            else if (requestType == RequestName.Sessions)
            {
                title = "Сеансы";
            }
            else if (requestType == RequestName.Tickets)
            {
                title = "Билеты";
            }

            HeadPanel.Text = title;
            this.requestType = requestType;

            FillTable();
        }

        private void FillTable()
        {
            string request = "";

            if (requestType == RequestName.Movies)
            {
                request = Requests.GetMovies();
            }
            else if (requestType == RequestName.Sessions)
            {
                request = Requests.GetSessions();
            }
            else if (requestType == RequestName.Tickets)
            {
                request = Requests.GetTickets();
            }

            var myDatabase = new MyDatabase();

            DataTable.DataSource = myDatabase.GetDataTable(request);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var deleteForm = new DeleteFromDatabaseForm(requestType);
            deleteForm.Show();            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            FillTable();
        }
    }
}
