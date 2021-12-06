using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class EditDatabaseForm : Form
    {
        private RequestType requestType;

        public EditDatabaseForm(RequestType requestType)
        {           
            InitializeComponent();

            string title = "";

            if (requestType == RequestType.Movies)
            {
                title = "Фильмы";
            }
            else if (requestType == RequestType.Sessions)
            {
                title = "Сеансы";
            }
            else if (requestType == RequestType.Tickets)
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

            if (requestType == RequestType.Movies)
            {
                request = Requests.GetMovies();
            }
            else if (requestType == RequestType.Sessions)
            {
                request = Requests.GetSessions();
            }
            else if (requestType == RequestType.Tickets)
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
    }
}
