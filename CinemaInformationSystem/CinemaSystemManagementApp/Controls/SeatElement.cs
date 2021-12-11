using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Кнопка, описывающая элемент посадочного места.
    /// </summary>
    class SeatElement : Button
    {
        private Seat seat;

        /// <summary>
        /// Инициализатор класса SeatElement.
        /// </summary>
        /// <param name="seat"> Место. </param>
        public SeatElement(Seat seat)
        {
            if (seat == null)
            {
                throw new ArgumentNullException("Посадочное место не было указано.");
            }

            this.seat = seat;

            Text = seat.SeatNumber.ToString();
        }

        /// <summary>
        /// Место.
        /// </summary>
        public Seat Seat { get => seat; }

    }
}
