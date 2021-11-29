using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    public partial class MoviePosterForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter adapter = null;
        private DataTable table = null;

        public MoviePosterForm()
        {
            InitializeComponent();
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
            /*
            DB db = new DB();
            db.OpenConnection();
            MySqlCommand command = new MySqlCommand("SELECT `фильмы`.`id`, `фильмы`.`название`, `фильмы`.`дата выхода`, `фильмы`.`длительность`,`фильмы`.`тип`,`возраст`.`возраст`,`режиссер`.`фамилия`  FROM фильмы INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id`", db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();
            List<String[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            db.CloseConnection();

            foreach (string[] s in data)
                tableFilms.Rows.Add(s);
            */
        }

        private async void PrintFilms_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\DataForKino\PIC\Database1.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection = new SqlConnection(connection);
            await sqlConnection.OpenAsync();

            adapter = new SqlDataAdapter("SELECT [Фильмы].[Название], [Жанры].[Жанр], [Фильмы].[Дата выхода], [Фильмы].[Длительность], [Возраст].[Возраст], [Режиссер].[Режиссер] FROM[Фильмы] INNER JOIN[Возраст] ON [Фильмы].[Возраст_ID] = [Возраст].[ID] INNER JOIN [Режиссер] ON [Фильмы].[Режиссер_ID] =[Режиссер].[ID] INNER JOIN [Фильмы-Жанры] ON [Фильмы-Жанры].[Фильмы_ID] = [Фильмы].[ID] INNER JOIN [Жанры] ON [Фильмы-Жанры].[Жанры_ID] = [Жанры].[ID]", sqlConnection);
            table = new DataTable();
            adapter.Fill(table);
            tableFilms.DataSource = table;
        }
    }
}
