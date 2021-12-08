using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        }       

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int movieDuration = 0;
            string movieProduce = MovieProduceBox.Text;
            string movieCountry = MovieCountryBox.Text; 

            if ( !int.TryParse(MovieDurationBox.Text, out movieDuration) )
            {
                MessageBox.Show("Введите продолжительность фильма!");
                return;
            }
            else if(IsEmptyValue(movieProduce))
            {
                MessageBox.Show("Введите режисёра фильма!");
                return;
            }
            else if (GenresBox.CheckedItems.Count != 1)
            {
                MessageBox.Show("Выберите 1 жанр!");
                return;
            }
            else if(IsEmptyValue(movieCountry))
            {
                MessageBox.Show("Введите страну фильма!");
                return;
            }
                                        
            try
            {
                // TODO: Айди режиссёра находить по значению в комбобокс

                var movie = new Movie(MovieNameBox.Text, MovieDatePicker.Value,
                    movieDuration, AllowedAgeBox.Text, 2);

                string request = Requests.AddMovie(movie);

                var myDatabase = new MyDatabase();

                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Фильм добавлен");
                else
                    MessageBox.Show("Фильм не был добавлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
