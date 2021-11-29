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
    public partial class EditDatabaseForm : Form
    {
        public EditDatabaseForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addMovieForm = new AddMovieForm();
            addMovieForm.Show();
        }
    }
}
