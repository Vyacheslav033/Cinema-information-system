﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    public partial class AddSessionForm : Form
    {
        public AddSessionForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            HallName_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int movieId = 0;
            int moviePrice = 0;
            DateTime movieData = MovieDatePicker.Value;
            DateTime movieTime = MovieTimePicker.Value;
            string hallName = HallName_comboBox.Text;

            if (!int.TryParse(MovieIdBox.Text, out movieId))
            {
                MessageBox.Show("Введите айди фильма!");
                return;
            }         
            else if (movieId <= 0 )
            {
                MessageBox.Show("Айди фильма введено не корректно!");
                return;
            }
            if (!int.TryParse(MoviePriceBox.Text, out moviePrice))
            {
                MessageBox.Show("Введите цену фильма!");
                return;
            }
            else if (movieId < 0)
            {
                MessageBox.Show("Цену фильма введена не корректно!");
                return;
            }
            else if (IsEmptyValue(hallName))
            {
                MessageBox.Show("Введите название зала!");
                return;
            }
      
            try
            {
                var connector = new MySqlConnector("localhost", "filmoteka", "root", "password");
                connector.Connect();

                // TODO: Айди зала находить по названию зала
                int hallId = 1;

                string request = Requests.AddSession(movieData, movieTime, moviePrice, hallId, movieId);
                var commandIns = new MySqlCommand(request, connector.Connection);

                if (commandIns.ExecuteNonQuery() == 1)
                    MessageBox.Show("Сеанс добавлен");
                else
                    MessageBox.Show("Сеанс не был добавлен");

                connector.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    

        private bool IsEmptyValue(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }

            return false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
   
    }
}