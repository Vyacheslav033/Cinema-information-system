using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма добавления/обновления фильма.
    /// </summary>
    public partial class AddMovieForm : Form
    {
        /// <summary>
        /// Тип запроса добавление/обновление.
        /// </summary>
        private RequestType requestType;

        /// <summary>
        /// Номер фильма.
        /// </summary>
        private int movieId;

        /// <summary>
        /// Инициализатор формы AddMovieForm.
        /// </summary>
        /// <param name="requestType"> Тип запроса добавление/обновление.</param>
        /// <param name="movieId"> Номер фильма. </param>
        public AddMovieForm(RequestType requestType, int movieId)
        {
            InitializeComponent();
           
            this.StartPosition = FormStartPosition.CenterScreen;
            AllowedAgeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MovieTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.movieId = movieId;
            this.requestType = requestType;

            try
            {
                if (requestType == RequestType.Update)
                {
                    HeaderLabel.Text = "Редактировать фильм";
                    AddOrUpdateButton.Text = "Редактировать";

                    Movie movie = GetMovie(movieId);
                    OutputMovieInfo(movie);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /// <summary>
        /// Логика кнопки добавить/редактировать.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {                                                 
            try
            {
                int movieDuration = 0;
                string movieCountry = MovieCountryBox.Text;

                if (!int.TryParse(MovieDurationBox.Text, out movieDuration))
                {
                    MessageBox.Show("Введите продолжительность фильма!");
                    return;
                }
                else if (GenresBox.CheckedItems.Count != 1)
                {
                    MessageBox.Show("Выберите 1 жанр!");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(movieCountry))
                {
                    MessageBox.Show("Введите страну фильма!");
                    return;
                }

                string movieType = (string.IsNullOrWhiteSpace(MovieTypeBox.Text)) ? null : MovieTypeBox.Text;

                var movie = new Movie(MovieNameBox.Text, MovieDatePicker.Value,
                    movieDuration, AllowedAgeBox.Text, ProducerNameBox.Text, ProducerSurnameBox.Text, movieType);

                string request = " ";
                string messege = " ";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateMovieById(movieId, movie);
                    messege = "изменён";
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddMovie(movie);
                    messege = "добавлен";
                }

                var myDatabase = new MyDatabase();

                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Фильм " + messege);
                else
                    MessageBox.Show("Фильм не был " + messege);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Получить фильм с бд.
        /// </summary>
        /// <param name="movieId"> Номер фильма. </param>
        /// <returns> Возращает объект типа Movie. </returns>
        private Movie GetMovie(int movieId)
        {
            var myDatabase = new MyDatabase();
            var movieData = myDatabase.MyСommand.GetReadData(Requests.GetMovieById(movieId));

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

            return new Movie(movieName, releaseData, duration, allowedAgeId,
                    producerName, producerSurname, movieType);     
        }

        /// <summary>
        /// Вывод информации о фильме в форму.
        /// </summary>
        /// <param name="movie"> Фильм. </param>
        private void OutputMovieInfo(Movie movie)
        {
            MovieNameBox.Text = movie.Name;
            MovieDatePicker.Value = movie.ReleaseDate;
            MovieDurationBox.Text = movie.Duration.ToString();
            ProducerNameBox.Text = movie.ProducerName;
            ProducerSurnameBox.Text = movie.ProducerSurname;
        }

        /// <summary>
        /// Логика кнопки выход.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }     
    }
}
