using CinemaResourcesLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма авторизации администратора.
    /// </summary>
    public partial class RegistrationForm : Form
    {
        private Point lastPoint;

        /// <summary>
        /// Инициализатор формы RegistrationForm.
        /// </summary>
        public RegistrationForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.UserPassword.UseSystemPasswordChar = false;

            FillLoginBox();
            FillPasswordBox();
        }

        /// <summary>
        /// Заполнить поля логина.
        /// </summary>
        private void FillLoginBox()
        {
            UserLogin.Text = "Введите логин";
            UserLogin.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Заполнить поля пароля.
        /// </summary>
        private void FillPasswordBox()
        {
            UserPassword.Text = "Введите пароль";
            UserPassword.ForeColor = Color.Gray;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            var menu = new MenuForm();
            menu.Show();
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
                FillLoginBox();              
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
                FillPasswordBox();
            }
        }

        /// <summary>
        /// Логика кнопки войти.
        /// Авторизация.
        /// </summary>
        private void ButtLogin_Click(object sender, EventArgs e)
        {           
            try
            {
                string login = UserLogin.Text;
                string password = UserPassword.Text;

                var myDatabase = new MyDatabase();
                string request = Requests.IsAdministrator(login, password);
                var adminData = myDatabase.MyСommand.GetReadData(request);

                // 4 так как строка с информацие о админе содержит 4 столбца.
                if (adminData.Count != 4)
                {
                    MessageBox.Show("Авторизация не пройдена.");
                    this.UserPassword.UseSystemPasswordChar = false;
                    FillLoginBox();
                    FillPasswordBox();
                }
                else
                {
                    int id = Convert.ToInt32(adminData[0]);
                    string actualLogin = adminData[1];
                    string actualPassword = adminData[2];
                    int employeeId = Convert.ToInt32(adminData[3]);

                    MessageBox.Show("Авторизация прошла успешно.");

                    this.Hide();
                    var admin = new AdminMenuForm(actualLogin);
                    admin.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
