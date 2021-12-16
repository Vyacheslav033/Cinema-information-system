using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Билет.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Дата покупки.
        /// </summary>
        public DateTime PaymentData { get; }

        /// <summary>
        /// Время покупки.
        /// </summary>
        public DateTime PaymentTime { get; }
        
        /// <summary>
        /// Номер сотрудника.
        /// </summary>
        public int EmployeeId { get; }

        /// <summary>
        /// Тип оплаты.
        /// </summary>
        public string PaymentType { get; }

        /// <summary>
        /// Номер сеанса.
        /// </summary>
        public int SessionId { get; }

        /// <summary>
        /// Место.
        /// </summary>
        public Seat Seat { get; }

        /// <summary>
        /// Инициализатор класса Ticket.
        /// </summary>
        /// <param name="paymentData"> Дата покупки. </param>
        /// <param name="paymentTime"> Время покупки. </param>
        /// <param name="employeeId"> Номер сотрудника. </param>
        /// <param name="paymentType"> Тип оплаты. </param>
        /// <param name="sessionId"> Номер сеанса. </param>
        /// <param name="seat"> Место. </param>
        public Ticket(DateTime paymentData, DateTime paymentTime, int employeeId,
                      string paymentType, int sessionId, Seat seat)
        {
            if (paymentData == null)
            {
                throw new ArgumentNullException("Дата оплаты является null.");
            }
            if (paymentTime == null)
            {
                throw new ArgumentNullException("Время оплаты является null.");
            }
            if (employeeId <= 0)
            {
                throw new ArgumentException("Номер сотрудника должен быть > 0.");
            }
            if (string.IsNullOrWhiteSpace(paymentType))
            {
                throw new ArgumentException("Тип оплаты не был задан.");
            }
            if (sessionId <= 0)
            {
                throw new ArgumentException("Номер сеанса должен быть > 0.");
            }
            if (seat == null)
            {
                throw new ArgumentException("Место не было указано.");
            }

            PaymentData = paymentData;
            PaymentTime = paymentTime;
            EmployeeId = employeeId;
            PaymentType = paymentType;
            SessionId = sessionId;
            Seat = seat;
        }      
    }
}
