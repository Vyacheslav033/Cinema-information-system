using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Сеанс.
    /// </summary>
    public class Session
    {
        public DateTime MovieData { get; }
        public DateTime MovieTime { get; }
        public int MoviePrice { get; }
        public string HallName { get; }
        public int MovieId { get; }

        public Session(DateTime movieData, DateTime movieTime, int moviePrice,
                       string hallName, int movieId)
        {
            if (movieData == null)
            {
                throw new ArgumentNullException("Дата фильма является null.");
            }
            if (movieTime == null)
            {
                throw new ArgumentNullException("Время фильма является null.");
            }
            if (moviePrice < 0)
            {
                throw new ArgumentException("Стоимость фильма должна быть >= 0.");
            }
            if (string.IsNullOrWhiteSpace(hallName))
            {
                throw new ArgumentException("Название зала не было задано.");
            }
            if (movieId <= 0)
            {
                throw new ArgumentException("Номер фильма должен быть > 0.");
            }

            MovieData = movieData;
            MovieTime = movieTime;
            MoviePrice = moviePrice;
            HallName = hallName;
            MovieId = movieId;
        }

        
    }
}
