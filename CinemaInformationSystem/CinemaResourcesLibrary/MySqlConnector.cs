﻿using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Класс отвечающий за подключение к базе данных.
    /// </summary>
    public class MySqlConnector
    {
        private string connectingLine;
        private MySqlConnection myConnection;

        /// <summary>
        /// Инициализатор класса MySqlConnector.
        /// </summary>
        /// <param name="server"> Сервер. </param>
        /// <param name="database"> Имя база данных. </param>
        /// <param name="uid"> Идентификатор пользователя. </param>
        /// <param name="password"> Пароль. </param>
        public MySqlConnector(string server, string database, string uid, string password)
        {
            if (String.IsNullOrEmpty(server))
            {
                throw new ArgumentNullException("Не был передан сервер!");
            }

            if (String.IsNullOrEmpty(database))
            {
                throw new ArgumentNullException("Не была передана база данных!");
            }

            if (String.IsNullOrEmpty(uid))
            {
                throw new ArgumentNullException("Не был передан идентификатор пользователя!");
            }

            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Не был передан пароль!");
            }

            this.connectingLine = $"Server={server};Database={database};Uid={uid};pwd={password};";
            myConnection = new MySqlConnection(connectingLine);
        }

        /// <summary>
        /// Соодинение с бд.
        /// </summary>
        public void Connect()
        {
            if (myConnection.State == ConnectionState.Closed)
            {
                myConnection.Open();
            }     
        }

        /// <summary>
        /// Разъединение с бд.
        /// </summary>
        public void Disconnect()
        {
            if (myConnection.State == ConnectionState.Open)
            {
                myConnection.Close();
            }
        }

        /// <summary>
        /// Статус подключения.
        /// </summary>
        public ConnectionState State
        {
            get { return myConnection.State; }
        }

        /// <summary>
        /// Соединение.
        /// </summary>
        public MySqlConnection Connection
        {
            get {return myConnection;}
        }
    }
}