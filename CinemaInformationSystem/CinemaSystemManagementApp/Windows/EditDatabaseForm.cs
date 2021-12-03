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
    public partial class EditDatabaseForm : Form
    {
        private RequestType requestType;

        public EditDatabaseForm(RequestType requestType)
        {           
            InitializeComponent();

            string title = "";

            if (requestType == RequestType.Movies)
            {
                title = "Удалить фильм";
            }
            else if (requestType == RequestType.Sessions)
            {
                title = "Сеансы";
            }
            else if (requestType == RequestType.Tickets)
            {
                title = "Билеты";
            }

            this.requestType = requestType;
        }

        

    }
}
