using System;
using System.Data;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Локальная база данных.
    /// </summary>
    public class MyDatabase
    {
        private MySQLConnector myConnection;
        private MySQLСommand myCommand;

        /// <summary>
        /// Инициаизатор класса MyDatabase.
        /// </summary>
        public MyDatabase()
        {
            myConnection = new MySQLConnector("localhost", "filmoteka", "root", "password");
            myCommand = new MySQLСommand(myConnection);
        }

        /// <summary>
        /// Комманды.
        /// </summary>
        public MySQLСommand MyСommand { get => myCommand; }

        
    }
}
