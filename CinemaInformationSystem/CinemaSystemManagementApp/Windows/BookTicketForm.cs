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
        private int sessionId;
        private Seat selectedSeat;

        public BookTicketForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            SeatInfoLabel.Text = "";
            sessionId = 0;
            selectedSeat = null;
        }

        public BookTicketForm(int sessionId, Seat selectedSeat)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.sessionId = sessionId;
            this.selectedSeat = selectedSeat;

            SessionNumberBox.Text = sessionId.ToString();
            SeatInfoLabel.Text = selectedSeat.ToString();

        }

        /// <summary>
        /// Логика кнопкии добавления бмлета.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: айди сотрудника
                int employeeId = 1;

                int sessionId = CheckSessionId(SessionNumberBox.Text);

                if (sessionId < 1)
                {
                    return;
                }

                DateTime time = DateTime.Now;

                var ticket = new Ticket(time, time, employeeId,
                    PaymentTypeBox.Text, sessionId, selectedSeat);

                string request = Requests.AddTicket(ticket);

                var myDatabase = new MyDatabase();

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetSeatButton_Click(object sender, EventArgs e)
        {
            try
            {
                int sessionId = CheckSessionId(SessionNumberBox.Text);

                if (sessionId < 1)
                {
                    return;
                }

                var myDatabase = new MyDatabase();
                var hallData = myDatabase.MyСommand.GetReadData(Requests.GetInfoAboutHall(sessionId));

                if (hallData.Count < 2)
                {
                    MessageBox.Show("Информация о зале данного сеанса не указана.");
                    return;
                }

                int rows = Convert.ToInt32(hallData[0]);
                int seats = Convert.ToInt32(hallData[1]);

                this.Close();
                var choseSeatForm = new ChoseSeatForm(sessionId, rows, seats);
                choseSeatForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Проверяем введённый номер сеанса.
        /// </summary>
        /// <param name="expectedSessionId"> Номер сеанса. </param>
        /// <returns> Возращает номер сеанса, если номер санса не корректный возвращает -1. </returns>
        private int CheckSessionId(string expectedSessionId)
        {
            int sessionId = -1;

            if (!int.TryParse(expectedSessionId, out sessionId))
            {
                MessageBox.Show("Номер сеанса не был выбран.");
                return -1;
            }
            else if (sessionId <= 0)
            {
                MessageBox.Show("Номер сеанса должен быть > 0.");
                return -1;
            }

            return sessionId;
        }

        /// <summary>
        /// Если номер сеанса изменился, то обнуляем выбранное место.
        /// </summary>
        private void SessionNumberBox_TextChanged(object sender, EventArgs e)
        {
            string newId = SessionNumberBox.Text;

            if (this.sessionId.ToString() != newId)
            {
                selectedSeat = null;
                SeatInfoLabel.Text = "";
            }
        }
    }
}
