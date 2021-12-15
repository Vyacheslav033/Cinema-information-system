using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    /// <summary>
    /// Форма выбра места в кинозале.
    /// </summary>
    public partial class ChoseSeatForm : Form
    {
        private Seat selectedSeat;
        private Color selectedButtonColor;
        private Color reservedSeatColor;
        private Color freeSeatColor;
        private Color selectedSeatColor;
        private int sessionId;

        public ChoseSeatForm(int sessionId, int rowsNumber, int seatsNumber)
        {
            InitializeComponent();


            selectedSeat = null;
            this.sessionId = sessionId;
            selectedButtonColor = Color.Green;
            reservedSeatColor = Color.Red;
            freeSeatColor = Color.Green;
            selectedSeatColor = Color.Blue;

            this.StartPosition = FormStartPosition.CenterScreen;
            ReservedSeatColorPanel.BackColor = reservedSeatColor;
            FreeSeatColorPanel.BackColor = freeSeatColor;
            SelectedSeatColorPanel.BackColor = selectedSeatColor;

            try
            {               
                var seats = GetReservedSeats(sessionId);             

                FillCinemaHall(rowsNumber, seatsNumber, seats);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MainPanel.Location = new Point( (this.Width - MainPanel.Width) / 2, MainPanel.Location.Y);

            ScreenPanel.Width = MainPanel.Width;
            ScreenPanel.Location = new Point(MainPanel.Location.X, ScreenPanel.Location.Y);
            SetSeatButton.Location = new Point((this.Width - SetSeatButton.Width) / 2, MainPanel.Location.Y + MainPanel.Height + 20);
            InfoPanel.Location = new Point((this.Width - InfoPanel.Width) / 2, InfoPanel.Location.Y);
            GoBackButton.Location = new Point(this.Width - 10, GoBackButton.Location.Y);
            
        }

        /// <summary>
        /// Получить список забранированных мест по сеансу.
        /// </summary>
        /// <param name="sessionId"> Носер сеанса. </param>
        private List<Seat> GetReservedSeats(int sessionId)
        {
            var seats = new List<Seat>();

            var myDatabase = new MyDatabase();
            var seatsData = myDatabase.MyСommand.GetReadData(Requests.GetReservedSeatsBySessionId(sessionId));

            if (seatsData.Count == 0)
            {
                return seats;
            }
            if (seatsData.Count % 2 != 0)
            {
                throw new ArgumentException("Данные о забронированных местах были нарушены.");
            }

            for (var i = seatsData.Count - 1; i >= 1; i = i - 2)
            {
                int seatN = Convert.ToInt32(seatsData[i]);
                int rowN = Convert.ToInt32(seatsData[i - 1]);

                seats.Add(new Seat(seatN, rowN));
            }

            return seats;
        }

        /// <summary>
        /// Заполнить зал местами.
        /// </summary>
        /// <param name="rows"> Количество рядов. </param>
        /// <param name="columns"> Количество мест. </param>
        /// <param name="reservedSeats"> Список забронирванных мест. </param>
        private void FillCinemaHall(int rows, int columns, List<Seat> reservedSeats)
        {
            columns = columns + 2;

            int buttonWidth = 35;
            int buttonHeight = 30;
            int positionY = 20;
            int margin = 10;

            for (var i = 0; i < rows; i++)
            {
                int positionX = 5;
                int seatNumber = 1;

                for (var j = 0; j < columns; j++)
                {
                    if ( (j == 0) || (j == columns - 1) )
                    {
                        var label = new Label
                        {
                            Width = buttonWidth,
                            Height = buttonHeight,
                            BackColor = Color.Pink,
                            Location = new Point(positionX, positionY),
                            Text = "Ряд " + (i + 1).ToString(),
                        };

                        MainPanel.Controls.Add(label);
                    }
                    else
                    {
                        Color seatColor = freeSeatColor;
                        bool enabledValue = true;

                        var seat = new Seat(seatNumber, i + 1);

                        foreach (Seat reservedSeat in reservedSeats)
                        {
                            if (seat.Equals(reservedSeat))
                            {
                                seatColor = reservedSeatColor;
                                enabledValue = false;
                                break;
                            }
                        }

                        var button = new SeatElement(seat)
                        {
                            Width = buttonWidth,
                            Height = buttonHeight,
                            BackColor = seatColor,
                            Enabled = enabledValue,
                            Location = new Point(positionX, positionY)
                        };

                        button.Click += Button_Click;
                        button.Leave += Button_Leave;

                        MainPanel.Controls.Add(button);
                        seatNumber++;
                    }

                    positionX += buttonWidth + margin;
                }

                positionY += buttonHeight + margin;
            }
        }

        /// <summary>
        /// Перекрасить кнопку в родной цвет, после перехода на следующую.
        /// </summary>
        private void Button_Leave(object sender, EventArgs e)
        {
            SeatElement button = (SeatElement)sender;

            button.BackColor = selectedButtonColor;
        }

        /// <summary>
        /// При выборе кнопки (места) устанавливаем его значение.
        /// </summary>
        private void Button_Click(object sender, EventArgs e)
        {
            SeatElement button = (SeatElement)sender;

            if (button.BackColor == selectedSeatColor)
            {         
                button.BackColor = selectedButtonColor;

                selectedSeat = null;
            }
            else
            {
                selectedButtonColor = button.BackColor;
                button.BackColor = selectedSeatColor;

                selectedSeat = button.Seat;
            }
        }

        /// <summary>
        /// Логика кнопки выбора места.
        /// </summary>
        private void SetSeatButton_Click(object sender, EventArgs e)
        {
            if (selectedSeat == null)
            {
                MessageBox.Show("Место не выбрано!");
            }
            else
            {
                this.Close();
                var form = new BookTicketForm(sessionId, selectedSeat);
                form.Show();
            }
        }

        /// <summary>
        /// Логика кнопки закрыть окно.
        /// </summary>
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
