using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма добавления/обновления билетов.
    /// </summary>
    public partial class AddTicketForm : Form
    {
        /// <summary>
        /// Тип запроса.
        /// </summary>
        private RequestType requestType;

        /// <summary>
        /// Номер билета.
        /// </summary>
        private int ticketId;

        /// <summary>
        /// Инициализатор формы AddTicketForm.
        /// </summary>
        /// <param name="requestType"> Тип запроса. </param>
        /// <param name="ticketId"> Номер билета. </param>
        public AddTicketForm(RequestType requestType, int ticketId)
        {
            InitializeComponent();

            this.ticketId = ticketId;
            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                if (requestType == RequestType.Update)
                {
                    HeaderLabel.Text = "Редактировать билет";
                    AddOrUpdateButton.Text = "Редактировать";

                    Ticket ticket = GetTicket(ticketId);
                    OutputTicketInfo(ticket);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        /// <summary>
        /// Получить билет.
        /// </summary>
        /// <param name="id"> Номер билета. </param>
        /// <returns> Объекта типа Ticket.</returns>
        private Ticket GetTicket(int id)
        {
            var myDatabase = new MyDatabase();
            var movieData = myDatabase.MyСommand.GetReadData(Requests.GetTicketById(id));

            if (movieData.Count != 7)
            {
                MessageBox.Show("Данный билет не найден.");
            }

            var dateAndTime = movieData[1].Split(' ');
            DateTime paymentData = Convert.ToDateTime(dateAndTime[0]);
            DateTime paymentTime = Convert.ToDateTime(dateAndTime[1]);

            int employeeId = Convert.ToInt32(movieData[2]);
            string paymentType = movieData[3];
            int sessionId = Convert.ToInt32(movieData[4]);
            int rowNumber = Convert.ToInt32(movieData[5]);
            int seatNumber = Convert.ToInt32(movieData[6]);

            return new Ticket(paymentData, paymentTime, employeeId,
                paymentType, sessionId, new Seat(seatNumber, rowNumber));      
        }

        /// <summary>
        /// Вывести информацию о билете.
        /// </summary>
        /// <param name="ticket"> Билет. </param>
        private void OutputTicketInfo(Ticket ticket)
        {
            RowNumberBox.Text = ticket.Seat.RowNumber.ToString();
            PlaceNumberBox.Text = ticket.Seat.SeatNumber.ToString();
            TicketDatePicker.Value = ticket.PaymentData;
            TicketTimePicker.Value = ticket.PaymentTime;
            SessionNumberBox.Text = ticket.SessionId.ToString();
            EmployeeIdBox.Text = ticket.EmployeeId.ToString();
        }

        /// <summary>
        /// Логика кнопки добавления/редактирования.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int rowNumber = 0;
                int seatNumber = 0;
                int employeeId = 0;
                int sessionId = 0;

                if (!int.TryParse(RowNumberBox.Text, out rowNumber))
                {
                    MessageBox.Show("Номер ряда введён не корректно!");
                    return;
                }
                else if (!int.TryParse(PlaceNumberBox.Text, out seatNumber))
                {
                    MessageBox.Show("Номер места введён не корректно!");
                    return;
                }
                else if (!int.TryParse(EmployeeIdBox.Text, out employeeId))
                {
                    MessageBox.Show("Номер сотрудника введён не корректно!");
                    return;
                }
                else if (!int.TryParse(SessionNumberBox.Text, out sessionId))
                {
                    MessageBox.Show("Номер сеанса введён не корректно!");
                    return;
                }

                var ticket = new Ticket(TicketDatePicker.Value, TicketTimePicker.Value,
                    employeeId, PaymentTypeBox.Text, sessionId, new Seat(seatNumber, rowNumber));

                string request = "";
                string messege = "";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateTicketById(ticketId, ticket);
                    messege = "изменён";
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddTicket(ticket);
                    messege = "добавлен";
                }

                var myDatabase = new MyDatabase();

                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Билет " + messege);
                else
                    MessageBox.Show("Билет не был " + messege);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Логика кнопки выхода.
        /// </summary>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
