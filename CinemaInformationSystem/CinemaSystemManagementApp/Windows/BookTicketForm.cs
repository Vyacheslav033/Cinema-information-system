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
        public BookTicketForm()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int rowNumber = 0;
            int placeNumber = 0;
            int sessionId = 0;
            // TODO: айди сотрудника
            int employeeId = 1;

            if (!int.TryParse(RowNumberBox.Text, out rowNumber))
            {
                MessageBox.Show("Номер ряда введён не корректно!");
                return;
            }
            else if (!int.TryParse(PlaceNumberBox.Text, out placeNumber))
            {
                MessageBox.Show("Номер места введён не корректно!");
                return;
            }
            else if (!int.TryParse(SessionNumberBox.Text, out sessionId))
            {
                MessageBox.Show("Номер сеанса введён не корректно!");
                return;
            }

            try
            {
                DateTime time = DateTime.Now;

                var ticket = new Ticket(time, time,employeeId,
                    PaymentTypeBox.Text, sessionId, rowNumber, placeNumber);

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

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }   
    }
}
