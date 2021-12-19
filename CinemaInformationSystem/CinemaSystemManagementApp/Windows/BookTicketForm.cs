using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма бронирования билетов.
    /// </summary>
    public partial class BookTicketForm : Form
    {
        /// <summary>
        ///  Номер сеанса.
        /// </summary>
        private int sessionId;

        /// <summary>
        /// Выбранное место.
        /// </summary>
        private Seat selectedSeat;

        /// <summary>
        /// Инициализатор формы BookTicketForm.
        /// </summary>
        /// <param name="sessionId"> Номер сеанса. </param>
        /// <param name="selectedSeat"></param>
        public BookTicketForm(int sessionId, Seat selectedSeat)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.sessionId = sessionId;
            this.selectedSeat = selectedSeat;

            SessionNumberLabel.Text += sessionId.ToString();

            if (selectedSeat != null)
            {
                SeatInfoLabel.Text = selectedSeat.ToString();
            }
        }

        /// <summary>
        /// Логика кнопкии добавления билета.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: айди сотрудника
                int employeeId = 1;

                DateTime time = DateTime.Now;

                var ticket = new Ticket(time, time, employeeId,
                    PaymentTypeBox.Text, this.sessionId, selectedSeat);


                string request = Requests.AddTicket(ticket);

                var myDatabase = new MyDatabase();

                // Добавляем билет.
                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Билет забронирован.");
                else
                    MessageBox.Show("Билет не был забронирован");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        /// <summary>
        /// Логика кнопки закрыть окно.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Логика кнопки выбора места.
        /// </summary>
        private void SetSeatButton_Click(object sender, EventArgs e)
        {
            try
            {
                var myDatabase = new MyDatabase();

                // Получаем информацию о зале.
                var hallData = myDatabase.MyСommand.GetReadData(Requests.GetInfoAboutHall(this.sessionId));

                if (hallData.Count < 2)
                {
                    MessageBox.Show("Информация о зале данного сеанса не указана.");
                    return;
                }

                int rowsCount = Convert.ToInt32(hallData[0]);
                int seatsCount = Convert.ToInt32(hallData[1]);

                this.Close();
                // Открываем форму с выбором места.
                var choseSeatForm = new ChoseSeatForm(sessionId, rowsCount, seatsCount);
                choseSeatForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
