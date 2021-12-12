using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Информация о пасадочном месте.
    /// </summary>
    public class Seat
    {
        private int rowNumber;
        private int seatNumber;

        /// <summary>
        /// Инициализатор класса Seat.
        /// </summary>
        /// <param name="seatNumber"> Номер места. </param>
        /// <param name="rowNumber"> Номер ряда. </param>
        public Seat(int seatNumber, int rowNumber)
        {
            if ( seatNumber <= 0 )
            {
                throw new ArgumentException("Места начинаются с номера 1.");
            }
            if ( rowNumber <= 0)
            {
                throw new ArgumentException("Ряды начинаются с номера 1.");
            }

            this.seatNumber = seatNumber;
            this.rowNumber = rowNumber;
        }  

        /// <summary>
        /// Номер ряда.
        /// </summary>
        public int RowNumber { get => rowNumber; }

        /// <summary>
        /// Номер места.
        /// </summary>
        public int SeatNumber { get => seatNumber; }

        /// <summary>
        /// Сравнение мест на равенство.
        /// </summary>
        /// <param name="obj"> Объект. </param>
        /// <returns> Возращает true если места равны, в противном случае возращает false. </returns>
        public override bool Equals(object obj)
        {
            if ( (obj != null) || (obj.GetType() == this.GetType()) )
            {
                Seat s = (Seat)obj;

                return (this.rowNumber == s.RowNumber) && (this.seatNumber == s.SeatNumber);
            }

            return false;
            
        }

        /// <summary>
        /// Информация о месте.
        /// </summary>
        /// <returns> Возвращает информацию о месте. </returns>
        public override string ToString()
        {
            return $"Ряд - {rowNumber}, место - {seatNumber}"; 
        }
    }
}
