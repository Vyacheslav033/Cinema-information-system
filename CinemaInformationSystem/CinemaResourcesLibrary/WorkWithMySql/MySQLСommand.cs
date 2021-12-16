using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Класс отвечающий за выполнеия запросов.
    /// </summary>
    public class MySQLСommand
    {
        private MySQLConnector connector;

        /// <summary>
        /// Инициализатор класса MySqlСommands.
        /// </summary>
        /// <param name="connector"> Подключение к бд. </param>
        public MySQLСommand(MySQLConnector connector)
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
        /// <param name="request"> Запрос. </param>
        /// <returns> Таблица с данными. </returns>
        public DataTable GetDataTable(string request)
        {
            IsEmptyRequest(request);

            var dataTable = new DataTable();
            var msc = new MySqlCommand()
            {
                Connection = connector.Connection,
                CommandText = request
            };

            connector.Connect();

            using (DbDataReader reader = msc.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }
            }

            connector.Disconnect();

            return dataTable;
        }

        /// <summary>
        /// Выполнить запрос.
        /// </summary>
        /// <param name="request"> Запрос. </param>
        /// <returns> Возвращает true если запрос был выполнен, в противном случае false. </returns>
        public bool RunRequest(string request)
        {
            IsEmptyRequest(request);

            connector.Connect();

            var commandIns = new MySqlCommand(request, connector.Connection);

            bool isPerform = (commandIns.ExecuteNonQuery() > 0) ? true : false;

            connector.Disconnect();

            return isPerform;
        }

        /// <summary>
        /// Получить считанные данные.
        /// </summary>
        /// <param name="request"> Запрос. </param>
        /// <returns> Возвращает лист с читаными данными запроса в строковом представлении. </returns>
        public List<string> GetReadData(string request)
        {
            IsEmptyRequest(request);

            var data = new List<string>();
            
            connector.Connect();
            var commandIns = new MySqlCommand(request, connector.Connection);
            MySqlDataReader reader = commandIns.ExecuteReader();

            while (reader.Read())
            {
                for (var j = 0; j < reader.FieldCount; j++)
                {
                    data.Add(reader.GetValue(j).ToString());
                }
            }

            reader.Close();
            connector.Disconnect();

            return data;
        }

        /// <summary>
        /// Проверка на пустой запрос.
        /// </summary>
        /// <param name="request"> Запрос. </param>
        private void IsEmptyRequest(string request)
        {
            if (string.IsNullOrWhiteSpace(request))
            {
                throw new ArgumentException("Запрос не был передан.");
            }
        }
    }
}
