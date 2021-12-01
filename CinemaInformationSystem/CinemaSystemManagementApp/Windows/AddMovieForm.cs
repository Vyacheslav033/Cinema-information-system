using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            AllowedAgeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadAgeData();
        }       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int movieDuration = 0;
            string movieName = MovieNameBox.Text; //название
            string movieProduce = MovieProduceBox.Text; //продюссер
            DateTime movieDate = MovieDatePicker.Value; //дата
            string movieCountry = MovieCountryBox.Text; //получение страны
            string allowedAge = AllowedAgeBox.Text;

            if (IsEmptyValue(movieName))
            {
                MessageBox.Show("Введите название фильма!");
                return;
            }
            else if ( !int.TryParse(MovieDurationBox.Text, out movieDuration) )
            {
                MessageBox.Show("Введите продолжительность фильма!");
                return;
            }
            else if (movieDuration < 60)
            {
                MessageBox.Show("Продолжительность фильма должна быть не меньше 60 минут!");
                return;
            }
            else if(IsEmptyValue(movieProduce))
            {
                MessageBox.Show("Введите режисёра фильма!");
                return;
            }
            else if (GenresBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Выберите хоть 1 жанр!");
                return;
            }
            else if(IsEmptyValue(movieCountry))
            {
                MessageBox.Show("Введите страну фильма!");
                return;
            }
            else if(IsEmptyValue(allowedAge))
            {
                MessageBox.Show("Введите возрастное ограничение фильма!");
                return;
            }           
               
            var genre = new List<string>(); //лист жанров

            foreach (string value in GenresBox.CheckedItems) //перенос в массив отмеченных галочек
            {
                genre.Add(value);
            }
            
            try
            {
                var connector = new MySqlConnector("localhost", "filmoteka", "root", "password");
                connector.Connect();

                // TODO: Айди разрешённого возраста находить по значению в комбобокс
                // TODO: Айди режиссёра находить по значению в комбобокс

                string request = Requests.AddMovie(movieName, movieDate, movieDuration, 2, 2);

                var commandIns = new MySqlCommand(request, connector.Connection);

                if (commandIns.ExecuteNonQuery() == 1)
                    MessageBox.Show("Фильм добавлен");
                else
                    MessageBox.Show("Фильм не был добавлен");

                connector.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadAgeData()
        {

            //MessageBox.Show("----");
        //    var connector = new MySqlConnector("localhost", "filmoteka", "root", "password");


        //    connector.Connect();

        //    MySqlCommand command = new MySqlCommand("SELECT `возраст`.`id`, `возраст`.`возраст` FROM возраст", connector.Connection);

        //    MySqlDataReader reader = command.ExecuteReader();

        //    var data = new List<AgeDTO[]>();

        //    int count = 0;

        //    while (reader.Read())
        //    {
        //        data.Add(new AgeDTO()[]);

        //        data[data.Count - 1].id = Convert.ToInt32(reader[0]);
        //        data[data.Count - 1].age = reader[1].ToString();
        //        data[data.Count - 1].number = count;

        //        AgeComBox.Items.Add(data[data.Count - 1][1].age);

        //        count++;
        //    }
        //    reader.Close();
        //    connector.Disconnect();

        }

        private bool IsEmptyValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }

            return false;
        }
            


        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }     
    }
}
