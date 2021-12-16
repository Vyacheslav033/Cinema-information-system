using System;
using System.Drawing;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма главного меню.
    /// </summary>
    public partial class MenuForm : Form
    {
        //передвижение окна
        private Point lastPoint;

        /// <summary>
        /// Инициализатор формы MenuForm.
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
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
      
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void EnterAdm_MouseEnter(object sender, EventArgs e)
        {
            EnterAdm.ForeColor = Color.FromArgb(205, 254, 247);
        }

        private void EnterAdm_MouseLeave(object sender, EventArgs e)
        {
            EnterAdm.ForeColor = Color.FromArgb(244, 244, 244);
        }

        /// <summary>
        /// Открыть панель авторизации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        /// <summary>
        /// Вывести фильмы.
        /// </summary>
        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            var movies = new DataForUsersForm(RequestName.Movies);
            movies.Show();
        }

        /// <summary>
        /// Вывести сеансы.
        /// </summary>
        private void PrintSeans_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sessions = new DataForUsersForm(RequestName.Sessions);
            sessions.Show();
        }

        /// <summary>
        /// Открыть форму для бронирования билетов.
        /// </summary>
        private void BuyPlace_Click(object sender, EventArgs e)
        {
            var form = new BookTicketForm();
            form.Show();
        }
    }
}
