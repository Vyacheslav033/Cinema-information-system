using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaResourcesLibrary;

namespace CinemaSystemManagementApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminMenuForm("efw"));
            //Application.Run(new AddMovieForm(RequestType.Add, 1));
        }
    }
}
