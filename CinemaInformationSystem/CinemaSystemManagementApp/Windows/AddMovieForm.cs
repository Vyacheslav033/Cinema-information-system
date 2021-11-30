using CinemaResourcesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaSystemManagementApp
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
            LoadAgeData();
        }

        private void AgeCom()
        {

        }

        void ShowError(string Text)
        {
            pnlError.Text = Text;
            pnlError.Visible = true;
            tmrError.Start();
        }

        private void tmrError_Tick(object sender, EventArgs e)
        {
            tmrError.Stop();
            pnlError.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //прописать валидаторы ко всем
            if (NameTxt.Text == "")
            {
                ShowError("Название фильма");
                return;
            }

            if (TxtDuration.Text == "")
            {
                ShowError("Продолжительность");
                return;
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtDuration.Text);
                }
                catch
                {
                    ShowError("Введите в продолжительность числа");
                    return;
                }
            }

            //?????????????????????????
            if (TxtProduce.Text == "")
            {
                ShowError("Режиссер");
                return;
            }
            else
            {
                try
                {
                    Convert.ToString(TxtProduce.Text);
                }
                catch
                {
                    ShowError("Режиссер не может быть в цифрах");
                    return;
                }
            }

            if (GenreBox.CheckedItems.Count == 0)
            {
                ShowError("Выберите хоть 1 жанр");
                return;
            }

            int count = GenreBox.CheckedItems.Count; //кол-во флажков
            string[] genre = new string[15]; //массив жанров

            foreach (string s in GenreBox.CheckedItems) //перенос в массив отмеченных галочек
            {
                for (int i = 0; i < count; i++)
                {
                    genre[i] = s;
                }
            }
            /*
            String FilmName = NameTxt.Text; //название
            String FilmDur = TxtDuration.Text; //продолжительность
            String FilmProd = TxtProduce.Text; //продюссер
            DateTime FilmDateTime = new DateTime(); //дата
            FilmDateTime = DatePicker.Value; //получение даты
            String FilmCountry = TxtCountry.Text; //получение страны

            String FilmAge = AgeComBox.Text;
            */
            //ХЗ КАК С РЕЖИССЕРОМ
            DB db = new DB();

            //MySqlCommand commandIns = new MySqlCommand("INSERT INTO `фильмы` (`Название`, `Дата выхода`, `Длительность`, `Тип`, `Возраст_ID`, `Режиссер_ID`) VALUES ('@FilmName', @FilmDateTime, @FilmDuration, NULL, @FilmAge, @FilmProd) ", db.GetConnection());

            //DateTime date = DatePicker.Value;

            ////заглушки
            //commandIns.Parameters.Add("@FilmName", MySqlDbType.VarChar).Value = NameTxt.Text;
            //commandIns.Parameters.Add("@FilmDateTime", MySqlDbType.Date).Value = DatePicker.Text;
            //commandIns.Parameters.Add("@FilmDuration", MySqlDbType.Int32).Value = TxtDuration.Text;
            //commandIns.Parameters.Add("@FilmAge", MySqlDbType.Int32).Value = AgeComBox.SelectedIndex + 1;
            //commandIns.Parameters.Add("@FilmProd", MySqlDbType.Int32).Value = 2;

            //db.OpenConnection();

            //if (commandIns.ExecuteNonQuery() == 1)//выполнит Sql запрос
            //    MessageBox.Show("Фильм добавлен");
            //else
            //    MessageBox.Show("Фильм не был добавлен");

            //db.CloseConnection();
        }

        private void LoadAgeData()
        {
            //AgeComBox.Items.Add();
            DB db = new DB();


            //db.OpenConnection();
            //MySqlCommand command = new MySqlCommand("SELECT `возраст`.`id`, `возраст`.`возраст` FROM возраст", db.GetConnection());

            //MySqlDataReader reader = command.ExecuteReader();
            /*
            List<AgeDTO[]> data = new AgeDTO();

            int count = 0;

            while (reader.Read())
            {
                data.Add(new AgeDTO());

                data[data.Count - 1].id = Convert.ToInt32(reader[0]);
                data[data.Count - 1].age = reader[1].ToString();
                data[data.Count - 1].number = count;

                AgeComBox.Items.Add(data[data.Count - 1][1].age);

                count++;
            }
            reader.Close();
            db.CloseConnection();
            */
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
