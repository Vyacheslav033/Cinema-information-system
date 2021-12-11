using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Информация о пасадочном месте.
    /// </summary>
    public class Seat
    {
        private int seatNumber;
        private int rowNumber;

        /// <summary>
        /// Инициализатор класса Seat.
        /// </summary>
        /// <param name="seatNumber"> Номер места. </param>
        /// <param name="rowNumber"> Номер ряда. </param>
        public Seat(int seatNumber, int rowNumber)
        {
            if (seatNumber <= 0)
            {
                throw new ArgumentException("Номер места указан не верно.");
            }
            if (rowNumber <= 0)
            {
                throw new ArgumentException("Номер ряда указан не верно.");
            }

            this.seatNumber = seatNumber;
            this.rowNumber = rowNumber;
        }

        /// <summary>
        /// Номер места.
        /// </summary>
        public int SeatNumber { get => seatNumber; }

        /// <summary>
        /// Номер ряда.
        /// </summary>
        public int RowNumber { get => rowNumber; }

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

                return (this.seatNumber == s.SeatNumber) && (this.rowNumber == s.RowNumber);
            }

            return false;
            
        }
    }
}
