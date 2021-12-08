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
        public int RowNumber { get; }
        public int PlaceNumber { get; }

        public Ticket(DateTime paymentData, DateTime paymentTime, int employeeId,
                      string paymentType, int sessionId, int rowNumber, int placeNumber)
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
            if (rowNumber <= 0)
            {
                throw new ArgumentException("Номер ряда должен быть > 0.");
            }
            if (placeNumber <= 0)
            {
                throw new ArgumentException("Номер места должно быть > 0.");
            }

            PaymentData = paymentData;
            PaymentTime = paymentTime;
            EmployeeId = employeeId;
            PaymentType = paymentType;
            SessionId = sessionId;
            RowNumber = rowNumber;
            PlaceNumber = placeNumber;
        }      
    }
}
