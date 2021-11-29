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
    public partial class RegistrationForm : Form
    {
        private Point lastPoint;

        public RegistrationForm()
        {
            InitializeComponent();
            this.UserPassword.UseSystemPasswordChar = false;
            UserLogin.Text = "Введите логин";
            UserLogin.ForeColor = Color.Gray;
            UserPassword.Text = "Введите пароль";
            UserPassword.ForeColor = Color.Gray;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            //Menu menu = new Menu();
            //menu.Show();
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

        private void UserLogin_Enter(object sender, EventArgs e)
        {
            if (UserLogin.Text == "Введите логин")
            {
                UserLogin.Text = "";
                UserLogin.ForeColor = Color.Black;
            }
        }

        private void UserLogin_Leave(object sender, EventArgs e)
        {
            if (UserLogin.Text == "")
            {
                UserLogin.Text = "Введите логин";
                UserLogin.ForeColor = Color.Gray;

            }
        }

        private void UserPassword_Enter(object sender, EventArgs e)
        {
            if (UserPassword.Text == "Введите пароль")
            {
                this.UserPassword.UseSystemPasswordChar = true;
                UserPassword.Text = "";
                UserPassword.ForeColor = Color.Black;
            }
        }

        private void UserPassword_Leave(object sender, EventArgs e)
        {
            if (UserPassword.Text == "")
            {
                this.UserPassword.UseSystemPasswordChar = false;
                UserPassword.Text = "Введите пароль";
                UserPassword.ForeColor = Color.Gray;

            }
        }

        //авторизация
        private void ButtLogin_Click(object sender, EventArgs e)
        {
            String loginUser = UserLogin.Text;
            String passUser = UserPassword.Text;

            if (loginUser == "Введите логин")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passUser == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            DB db = new DB();

            DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            //MySqlCommand command = new MySqlCommand("SELECT login, password FROM `сотрудники` WHERE `login` = @uL AND `password` = @uP", db.GetConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            //command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            //adapter.SelectCommand = command;
            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    MessageBox.Show("Успешно");
            //    this.Hide();
            //    AdmMenu admin = new AdmMenu();
            //    admin.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Не успешно");
            //    this.UserPassword.UseSystemPasswordChar = false;
            //    UserLogin.Text = "Введите логин";
            //    UserLogin.ForeColor = Color.Gray;
            //    UserPassword.Text = "Введите пароль";
            //    UserPassword.ForeColor = Color.Gray;
            //}
        }
    }
}
