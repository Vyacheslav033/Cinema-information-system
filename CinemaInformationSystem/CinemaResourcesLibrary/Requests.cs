using System;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Назвагние запросов.
    /// </summary>
    public enum Requests : int
    {
        /// <summary>
        /// Запрос на получение главной таблицы бд.
        /// </summary>
        GetMainTable,

        /// <summary>
        /// Запрос на удаление конкретной строки главное таблицы.
        /// </summary>
        DeleteRow,

        /// <summary>
        /// Запрос на получение доролнительной таблицы.
        /// </summary>
        GetAdditionalTable
    }
}
