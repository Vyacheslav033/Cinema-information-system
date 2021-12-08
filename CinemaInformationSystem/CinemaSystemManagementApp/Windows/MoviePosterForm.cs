using CinemaResourcesLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace CinemaSystemManagementApp
{
    public partial class MoviePosterForm : Form
    {
        private string request;

        public MoviePosterForm(string request, string title)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.request = request;
            this.panelHead.Text = title;

            LoadData();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_MouseEnter(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.FromArgb(255, 0, 0);
        }

        private void Exit_MouseLeave(object sender, EventArgs e)
        {
            Exit.ForeColor = Color.White;
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            var menu = new MenuForm();
            menu.Show();
        }


        private void LoadData()
        {
            try
            {
                var connector = new MySQLConnector("localhost", "filmoteka", "root", "password");

                var command = new MySQLСommand(connector);

                DataTable.DataSource = command.GetDataTable(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
