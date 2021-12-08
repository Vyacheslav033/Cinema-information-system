using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Фильм.
    /// </summary>
    public class Movie
    {
        public string Name { get; }
        public DateTime ReleaseDate { get; }
        public int Duration { get; }
        public string AllowedAge { get; }
        public int ProducerId { get; }

        public Movie(string name, DateTime releaseDate, int duration, string allowedAge, int producerId)
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
            if (producerId <= 0)
            {
                throw new ArgumentException("Айди продюсера должно быть > 0.");
            }

            Name = name;
            ReleaseDate = releaseDate;
            Duration = duration;
            AllowedAge = allowedAge;
            ProducerId = producerId;
        }  
    }
}
