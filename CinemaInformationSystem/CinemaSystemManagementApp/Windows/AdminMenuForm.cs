using CinemaResourcesLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма меню админа.
    /// </summary>
    public partial class AdminMenuForm : Form
    {
        /// <summary>
        /// Инициализатор формы AdminMenuForm.
        /// </summary>
        /// <param name="adminLogin"> Логин админа. </param>
        public AdminMenuForm(string adminLogin)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
            HeadPanel.Text += "Администратор: " + adminLogin;
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            GoBackButton.ForeColor = Color.White;
        }

        /// <summary>
        /// Открыть форму с фильмами.
        /// </summary>
        private void ShowMoviesPanelButton_Click(object sender, EventArgs e)
        {
            var adminMoviesPanel = new EditDatabaseForm(RequestName.Movies);
            adminMoviesPanel.Show();
        }

        /// <summary>
        /// Открыть форму с сеансами.
        /// </summary>
        private void ShowSessionsPanelButton_Click(object sender, EventArgs e)
        {
            var adminSessionsPanel = new EditDatabaseForm(RequestName.Sessions);
            adminSessionsPanel.Show();
        }

        /// <summary>
        /// Открыть форму с билетами.
        /// </summary>
        private void ShowTicketsPanelButton_Click(object sender, EventArgs e)
        {
            var adminTicketsPanel = new EditDatabaseForm(RequestName.Tickets);
            adminTicketsPanel.Show();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            var menu = new MenuForm();
            menu.Show();
        }
  
    }
}
