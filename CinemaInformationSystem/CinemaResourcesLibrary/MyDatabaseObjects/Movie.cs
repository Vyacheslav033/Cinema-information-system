using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Фильм.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Дата выхода.
        /// </summary>
        public DateTime ReleaseDate { get; }

        /// <summary>
        /// Длительность.
        /// </summary>
        public int Duration { get; }

        /// <summary>
        /// Разрешённый возраст.
        /// </summary>
        public string AllowedAge { get; }
        
        /// <summary>
        /// Имя режиссёра.
        /// </summary>
        public string ProducerName { get; }

        /// <summary>
        /// Фамилия режиссёра.
        /// </summary>
        public string ProducerSurname { get; }

        /// <summary>
        /// Тип.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Инициализатор класса Movie.
        /// </summary>
        /// <param name="name"> Название. </param>
        /// <param name="releaseDate"> Дата выхода. </param>
        /// <param name="duration"> Длительность. </param>
        /// <param name="allowedAge"> Разрешённый возраст. </param>
        /// <param name="producerName"> Имя режиссёра. </param>
        /// <param name="producerSurname"> Фамилия режиссёра. </param>
        /// <param name="type"> Тип. </param>
        public Movie(string name, DateTime releaseDate, int duration,
            string allowedAge, string producerName, string producerSurname, string type)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название фильма не было задано.");
            }
            if (releaseDate == null)
            {
                throw new ArgumentNullException("Дата выхода фильма является null.");
            }
            if (duration < 60)
            {
                throw new ArgumentException("Продолжительность фильма должна быть не меньше 60 минут.");
            }
            if (string.IsNullOrWhiteSpace(allowedAge))
            {
                throw new ArgumentException("Возрастное ограничение не было задано.");
            }
            if (string.IsNullOrWhiteSpace(producerName))
            {
                throw new ArgumentException("Имя режиссёра не было задано.");
            }
            if (string.IsNullOrWhiteSpace(producerSurname))
            {
                throw new ArgumentException("Фамилия режиссёра не была задана.");
            }

            Name = name;
            ReleaseDate = releaseDate;
            Duration = duration;
            AllowedAge = allowedAge;
            ProducerName = producerName;
            ProducerSurname = producerSurname;
            Type = type;
        }  
    }
}
