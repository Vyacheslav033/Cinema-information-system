using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    public partial class MenuForm : Form
    {
        //передвижение окна
        private Point lastPoint;

        public MenuForm()
        {
            InitializeComponent();
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

        private void printAllFilms_Click(object sender, EventArgs e)
        {
            DB db;
        }

        private void EnterAdm_MouseEnter(object sender, EventArgs e)
        {
            EnterAdm.ForeColor = Color.FromArgb(205, 254, 247);
        }

        private void EnterAdm_MouseLeave(object sender, EventArgs e)
        {
            EnterAdm.ForeColor = Color.FromArgb(244, 244, 244);
        }

        private void EnterAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void BtnPrintAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Allfilms = new MoviePosterForm();
            Allfilms.Show();
        }
    }
}
