using System;
using System.Windows.Forms;
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
                // TODO: Айди зала находить по названию зала
                int hallId = 1;

                string request = Requests.AddSession(movieData, movieTime, moviePrice, hallId, movieId);

                var myDatabase = new MyDatabase();
                
                if ( myDatabase.MyСommand.RunRequest(request) )
                    MessageBox.Show("Сеанс добавлен");
                else
                    MessageBox.Show("Сеанс не был добавлен");
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
