using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Сеанс.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Дата сеанса.
        /// </summary>
        public DateTime Data { get; }

        /// <summary>
        /// Время сеанса.
        /// </summary>
        public DateTime Time { get; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public int Price { get; }

        /// <summary>
        /// Зал.
        /// </summary>
        public string HallName { get; }

        /// <summary>
        /// Номер фильма.
        /// </summary>
        public int MovieId { get; }

        /// <summary>
        /// Инициализатор класса Session.
        /// </summary>
        /// <param name="data"> Дата сеанса. </param>
        /// <param name="time"> Время сеанса. </param>
        /// <param name="price"> Стоимость.</param>
        /// <param name="hallName"> Зал. </param>
        /// <param name="movieId"> Номер фильма. </param>
        public Session(DateTime data, DateTime time, int price,
                       string hallName, int movieId)
        {
            if (data == null)
            {
                throw new ArgumentNullException("Дата фильма является null.");
            }
            if (time == null)
            {
                throw new ArgumentNullException("Время фильма является null.");
            }
            if (price < 0)
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

            Data = data;
            Time = time;
            Price = price;
            HallName = hallName;
            MovieId = movieId;
        } 
    }
}
