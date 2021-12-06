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

        /// <summary>
        /// Выполнение запроса.
        /// Вывод результата запроса в виде таблицы.
        /// </summary>
        /// <param name="request"> Запрос. </param>
        /// <returns> Таблица с данными. </returns>
        public DataTable GetDataTable(string request)
        {
            return myCommand.GetDataTable(request);
        }

        /// <summary>
        /// Выполнить запрос.
        /// </summary>
        /// <param name="request"> Запрос. </param>
        /// <returns> Возвращает true если запрос был выполнен, в противном случае false. </returns>
        public bool RunRequest(string request)
        {
            return myCommand.RunRequest(request);
        }   
    }
}
