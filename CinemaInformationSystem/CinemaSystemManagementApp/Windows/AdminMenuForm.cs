using CinemaResourcesLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    public partial class AdminMenuForm : Form
    {

        public AdminMenuForm(string adminLogin)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            HeadPanel.Text += adminLogin;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.White;
        }

        private void ShowMoviesPanelButton_Click(object sender, EventArgs e)
        {
            var adminMoviesPanel = new EditDatabaseForm(RequestType.Movies);
            adminMoviesPanel.Show();
        }

        private void ShowSessionsPanelButton_Click(object sender, EventArgs e)
        {
            var adminSessionsPanel = new EditDatabaseForm(RequestType.Sessions);
            adminSessionsPanel.Show();
        }

        private void ShowTicketsPanelButton_Click(object sender, EventArgs e)
        {
            var adminTicketsPanel = new EditDatabaseForm(RequestType.Tickets);
            adminTicketsPanel.Show();
        }


        private void GoBackButton_Click(object sender, EventArgs e)
        {
            var menu = new MenuForm();
            menu.Show();
        }

        
    }
}
