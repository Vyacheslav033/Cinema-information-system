using System;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddTicketForm : Form
    {
        private RequestType requestType;

        private int idForEdit;

        public AddTicketForm(RequestType requestType, int idForEdit)
        {
            InitializeComponent();

            this.idForEdit = idForEdit;
            this.requestType = requestType;
            this.StartPosition = FormStartPosition.CenterScreen;
            PaymentTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if (requestType == RequestType.Update)
            {
                HeaderLabel.Text = "Редактировать билет";
                AddOrUpdateButton.Text = "Редактировать";
                GetTicketFromDatabase(idForEdit);
            }
        }

        private void GetTicketFromDatabase(int id)
        {
            try
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
                int paymentTypeId = Convert.ToInt32(movieData[3]);
                int sessionId = Convert.ToInt32(movieData[4]);
                int rowNumber = Convert.ToInt32(movieData[5]);
                int placeNumber = Convert.ToInt32(movieData[6]);

                RowNumberBox.Text = rowNumber.ToString();
                PlaceNumberBox.Text = placeNumber.ToString();
                TicketDatePicker.Value = paymentData;
                TicketTimePicker.Value = paymentTime;
                SessionNumberBox.Text = sessionId.ToString();
                EmployeeIdBox.Text = employeeId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
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

            try
            {
                var ticket = new Ticket(TicketDatePicker.Value, TicketTimePicker.Value,
                    employeeId, PaymentTypeBox.Text, sessionId, new Seat(seatNumber, rowNumber));

                string request = "";

                if (requestType == RequestType.Update)
                {
                    request = Requests.UpdateTicketById(idForEdit, ticket);
                }
                else if (requestType == RequestType.Add)
                {
                    request = Requests.AddTicket(ticket);
                }

                var myDatabase = new MyDatabase();

                if (myDatabase.MyСommand.RunRequest(request))
                    MessageBox.Show("Билет добавлен/изменён");
                else
                    MessageBox.Show("Билет не был добавлен/изменён");
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
