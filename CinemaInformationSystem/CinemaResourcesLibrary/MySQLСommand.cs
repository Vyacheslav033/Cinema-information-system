using System;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Класс отвечающий за выполнеия запросов.
    /// </summary>
    public class MySQLСommand
    {
        private MySqlConnector connector;

        /// <summary>
        /// Инициализатор класса MySqlСommands.
        /// </summary>
        /// <param name="connector"> Подключение к бд. </param>
        public MySQLСommand(MySqlConnector connector)
        {
            if (connector == null)
            {
                throw new ArgumentNullException("Было  передано пустое соединение!");
            }

            this.connector = connector;
        }

        /// <summary>
        /// Выполнение запроса.
        /// Вывод результата запроса в виде таблицы.
        /// </summary>
        /// <param name="query"> Запрос. </param>
        /// <returns> Таблица с данными. </returns>
        public DataTable RunRequest(string query)
        {
            var dataTable = new DataTable();
            var cmd = new MySqlCommand();

            connector.Connect();

            cmd.Connection = connector.Connection;
            cmd.CommandText = query;

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            connector.Disconnect();

            return dataTable;
        }

        
    }
}
