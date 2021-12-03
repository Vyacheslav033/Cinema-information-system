using System;
using System.Data;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Класс реализующий конкретные запросы.
    /// </summary>
    public static class Requests
    {
        /// <summary>
        /// Получить все фильмы.
        /// </summary>
        /// <returns></returns>
        public static string GetFilms()
        {
            string query =
                        "SELECT `фильмы`.`id`, `фильмы`.`название`, `фильмы`.`дата выхода`, " +
                        "`фильмы`.`длительность`,`фильмы`.`тип`,`возраст`.`возраст`,`режиссер`.`фамилия` " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id`";

            return query;
        }

        /// <summary>
        /// Получить все сеансы.
        /// </summary>
        /// <returns></returns>
        public static string GetSessions()
        {
            string query =
                        "SELECT сеансы.ID, фильмы.Название as Фильм, сеансы.`дата-время сеанса`, сеансы.Цена,  залы.`название зала` as `Название зала`, " +
                        "(залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) as `Количество мест`, (залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) as `Свободные места` " +
                        "FROM Сеансы " +
                        "inner join Фильмы on Фильмы.ID = Сеансы.Фильмы_ID " +
                        "inner join Залы on Сеансы.Залы_ID = Залы.ID " +
                        "GROUP BY Сеансы.ID " +
                        "order by Сеансы.ID;";
            return query;
        }

        /// <summary>
        /// Добавить фильм.
        /// </summary>
        /// <param name="movieName"></param>
        /// <param name="movieDate"></param>
        /// <param name="duration"></param>
        /// <param name="allowedAge"></param>
        /// <param name="prodId"></param>
        /// <returns></returns>
        public static string AddMovie(string movieName, DateTime movieDate, int duration, int allowedAge, int prodId  )
        {
            string query =
                       "INSERT INTO `фильмы` " +
                       "(`Название`, `Дата выхода`, `Длительность`, `Тип`, `Возраст_ID`, `Режиссер_ID`) " +
                       "VALUES " +
                       $"(\"{movieName}\", '{movieDate.ToString("yyyy-MM-dd")}', {duration}, NULL, {allowedAge}, {prodId})";

            return query;
        }

        /// <summary>
        /// Добавить сеанс.
        /// </summary>
        /// <param name="movieData"></param>
        /// <param name="movieTime"></param>
        /// <param name="moviePrice"></param>
        /// <param name="hallId"></param>
        /// <param name="movieId"></param>
        /// <returns></returns>
        public static string AddSession(DateTime movieData, DateTime movieTime, int moviePrice, int hallId, int movieId)
        {
            string query =
                       "INSERT INTO `сеансы` " +
                       "(`Дата-время сеанса`, `Цена`, `Залы_ID`, `Фильмы_ID`) " +
                       "VALUES " +
                       $"('{movieData.ToString("yyyy-MM-dd")} {movieTime.ToLongTimeString()}', {moviePrice}, {hallId}, {movieId})";

            return query;
        }

        /// <summary>
        /// Удалить фильм по айди.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string DeleteMovieById(int id)
        {
            string query =
                       "use filmoteka; " +
                       "DELETE FROM `фильмы` " +
                       $"where `фильмы`.`id` = {id}";

            return query; 
        }

        /// <summary>
        /// Удалить сеанс по айди.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string DeleteSessionById(int id)
        {
            string query =
                       "use filmoteka; " +
                       "DELETE FROM `сеансы` " +
                       $"where `сеансы`.`id` = {id}";

            return query;
        }

        /// <summary>
        /// Удалить билет по айди.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static string DeleteTicketById(int id)
        {
            string query =
                       "use filmoteka; " +
                       "DELETE FROM `билет` " +
                       $"where `билет`.`id` = {id}";

            return query;
        }


    }
}
