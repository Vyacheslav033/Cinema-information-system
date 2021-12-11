using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class ChoseSeatForm : Form
    {
        private Seat currentSeat;
        private Color currentButtonColor;

        public ChoseSeatForm()
        {
            InitializeComponent();

            currentSeat = null;
            currentButtonColor = Color.Green;

            var list = new List<Seat>()
            {
                new Seat(1, 1),
                new Seat(5, 9),
                new Seat(10, 8),
                new Seat(3, 4),
                new Seat(15, 2),
                new Seat(7, 8),
                new Seat(11, 5)
            };


            FillCinemaHall(9, 15, list);
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
                        Color seatColor = Color.Green;

                        var seat = new Seat(seatNumber, i + 1);

                        foreach (Seat reservedSeat in reservedSeats)
                        {
                            if (reservedSeat.Equals(seat))
                            {
                                seatColor = Color.Red;
                                break;
                            }
                        }

                        var button = new SeatElement(seat)
                        {
                            Width = buttonWidth,
                            Height = buttonHeight,
                            BackColor = seatColor,
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

        private void Button_Leave(object sender, EventArgs e)
        {
            SeatElement button = (SeatElement)sender;

            button.BackColor = currentButtonColor;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Color newColor = Color.Blue;

            SeatElement button = (SeatElement)sender;

            if (button.BackColor == newColor)
            {         
                button.BackColor = currentButtonColor;

                currentSeat = null;
            }
            else
            {
                currentButtonColor = button.BackColor;
                button.BackColor = newColor;

                currentSeat = button.Seat;
            }


        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetSeatButton_Click(object sender, EventArgs e)
        {
            if (currentSeat == null)
            {
                MessageBox.Show("Место не выбрано!");
            }
            else
            {
                MessageBox.Show($"ряд - {currentSeat.RowNumber}, место - {currentSeat.SeatNumber}");

            }
        }
    }
}
