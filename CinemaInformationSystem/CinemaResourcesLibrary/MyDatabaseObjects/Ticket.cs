using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Билет.
    /// </summary>
    public class Ticket
    {
        public DateTime PaymentData { get; }
        public DateTime PaymentTime { get; }
        public int EmployeeId { get; }
        public string PaymentType { get; }
        public int SessionId { get; }
        public Seat Seat { get; }

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
