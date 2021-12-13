using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddMovieForm : Form
    {
        private RequestType requestType;
        private int idForEdit;

        public AddMovieForm(RequestType requestType, int idForEdit)
        {
            InitializeComponent();

            this.idForEdit = idForEdit;
            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            AllowedAgeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (requestType == RequestType.Update)
            {
                HeaderLabel.Text = "Редактировать фильм";
                AddOrUpdateButton.Text = "Редактировать";
                GetMovieFromDatabase(idForEdit);
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int movieDuration = 0;
            string movieCountry = MovieCountryBox.Text; 

            if ( !int.TryParse(MovieDurationBox.Text, out movieDuration) )
            {
                MessageBox.Show("Введите продолжительность фильма!");
                return;
            }
            else if (GenresBox.CheckedItems.Count != 1)
            {
                MessageBox.Show("Выберите 1 жанр!");
                return;
            }
            else if(string.IsNullOrWhiteSpace(movieCountry))
            {
                MessageBox.Show("Введите страну фильма!");
                return;
            }
                                        
            try
            {
                // TODO: Айди режиссёра находить по значению в комбобокс

                var movie = new Movie(MovieNameBox.Text, MovieDatePicker.Value,
                    movieDuration, AllowedAgeBox.Text, ProducerNameBox.Text, ProducerSurnameBox.Text);

                string request = " ";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateMovieById(idForEdit, movie);
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddMovie(movie);
                }

                var myDatabase = new MyDatabase();

                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Фильм добавлен/изменён");
                else
                    MessageBox.Show("Фильм не был добавлен/изменён");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void GetMovieFromDatabase(int id)
        {
            try
            {
                var myDatabase = new MyDatabase();
                var movieData = myDatabase.MyСommand.GetReadData(Requests.GetMovieById(id));

                if (movieData.Count != 8)
                {
                    MessageBox.Show("Запрос на вывод фильма по ID нарушен.");
                }

                string movieName = movieData[1];
                int duration = Convert.ToInt32(movieData[2]);
                DateTime releaseData = Convert.ToDateTime(movieData[3]);
                string producerName = movieData[4];
                string producerSurname = movieData[5];
                string movieType = movieData[6];
                string allowedAgeId = movieData[7];

                MovieNameBox.Text = movieName;
                MovieDatePicker.Value = releaseData;
                MovieDurationBox.Text = duration.ToString();
                ProducerNameBox.Text = producerName;
                ProducerSurnameBox.Text = producerSurname;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }     
    }
}
