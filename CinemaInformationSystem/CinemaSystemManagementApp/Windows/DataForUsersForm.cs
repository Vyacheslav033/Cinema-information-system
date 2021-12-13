using System;
using System.Drawing;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма демонстрируюзая информацию для пользователей.
    /// </summary>
    public partial class DataForUsersForm : Form
    {
        private RequestName requestName;
        private string request;

        public DataForUsersForm(RequestName requestName)
        {
            InitializeComponent();

            if (requestName == RequestName.Movies)
            {
                this.request = Requests.GetMovies();
                this.panelHead.Text = "Фильмы";
            }
            else if (requestName == RequestName.Sessions)
            {
                this.request = Requests.GetSessions();
                this.panelHead.Text = "Сеансы";
            }

            this.requestName = requestName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

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

        /// <summary>
        /// Загрузка данных в таблицу.
        /// </summary>
        private void LoadData()
        {
            try
            {
                var myDatabase = new MyDatabase();          

                DataTable.DataSource = myDatabase.MyСommand.GetDataTable(request);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Логика поиска.
        /// </summary>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string movieName = ValueForSearchBox.Text;
                string searchRequest = "";

                if ( !string.IsNullOrWhiteSpace(movieName) )
                {
                    if (requestName == RequestName.Movies)
                    {
                        searchRequest = Requests.GetMovieByName(movieName);
                    }
                    else if (requestName == RequestName.Sessions)
                    {
                        searchRequest = Requests.GetSessionsByMovieName(movieName);
                    }

                    var myDatabase = new MyDatabase();

                    DataTable.DataSource = myDatabase.MyСommand.GetDataTable(searchRequest);
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Обновление таблицы с данными.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateDataButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
