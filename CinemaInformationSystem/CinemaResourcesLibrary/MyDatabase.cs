using System;
using System.Data;

namespace CinemaResourcesLibrary
{
    public class MyDatabase
    {
        private MySQLConnector myConnection;
        private MySQLСommand myCommand;


        public MyDatabase()
        {
            myConnection = new MySQLConnector("localhost", "filmoteka", "root", "password");
            myCommand = new MySQLСommand(myConnection);
        }

        public MySQLСommand MyСommand { get => myCommand; }

        
    }
}
