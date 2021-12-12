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
        public static string GetMovies()
        {
            string query =
                        "SELECT `фильмы`.`id`, `фильмы`.`название`, `фильмы`.`дата выхода`, " +
                        "`фильмы`.`длительность`,`фильмы`.`тип`,`возраст`.`возраст`, `режиссер`.`имя`, `режиссер`.`фамилия` " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id` " +
                        "order by фильмы.id; ";
            return query;
        }

        /// <summary>
        /// Получить фильм по айди.
        /// </summary>
        /// <returns></returns>
        public static string GetMovieById(int id)
        {
            string query =
                        "select * " +
                        "from фильмы " +
                        $"where ID = {id}";
                        
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
                        "(залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) as `Количество мест`, " +
                        "((залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) - (SELECT count(Место) FROM билет where `Сеансы_ID` = Сеансы.ID)) as `Свободные места` " +
                        "FROM Сеансы " +
                        "inner join Фильмы on Фильмы.ID = Сеансы.Фильмы_ID " +
                        "inner join Залы on Сеансы.Залы_ID = Залы.ID " +
                        "GROUP BY Сеансы.ID " +
                        "order by Сеансы.ID;";
            return query;
        }

        /// <summary>
        /// Получить сеанс по айди.
        /// </summary>
        /// <returns></returns>
        public static string GetSessionById(int id)
        {
            string query =
                        "select * " +
                        "from сеансы " +
                        $"where ID = {id}";

            return query;
        }

        /// <summary>
        /// Получить все билеты.
        /// </summary>
        /// <returns></returns>
        public static string GetTickets()
        {
            string query =
                        "SELECT билет.ID, билет.`Дата покупки`, сеансы.`Дата-время сеанса`,сеансы.ID as 'ID сеанса', билет.Ряд, билет.Место, " +
                        "concat(сотрудники.Фамилия , ' ', сотрудники.Имя, ' ', сотрудники.Отчество) as 'ФИО сотрудника', `тип оплаты`.Оплата " +
                        "FROM билет " +
                        "inner join сотрудники on билет.Сотрудники_ID = сотрудники.ID " +
                        "inner join `тип оплаты` on билет.`Тип оплаты_ID` = `тип оплаты`.ID " +
                        "inner join сеансы on билет.Сеансы_ID = сеансы.ID " +
                        "order by билет.ID ";

            return query;
        }

        /// <summary>
        /// Получить билет по айди.
        /// </summary>
        /// <returns></returns>
        public static string GetTicketById(int id)
        {
            string query =
                        "select * " +
                        "from билет " +
                        $"where ID = {id}";

            return query;
        }

        /// <summary>
        /// Получить информацию о занытых местах по номеру сеанса.
        /// </summary>
        /// <returns></returns>
        public static string GetReservedSeatsBySessionId(int sessionId)
        {         
            string query =
                        "select Ряд, Место " +
                        "from билет " +
                        $"where `Сеансы_ID` = {sessionId}";

            return query;
        }

        /// <summary>
        /// Добавить фильм.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static string AddMovie(Movie movie)
        {
            string query =
                        $"insert into режиссер (`Фамилия`, `Имя`) select \"{movie.ProducerSurname}\", \"{movie.ProducerName}\" FROM DUAL " +
                        $"WHERE NOT EXISTS (SELECT Фамилия, Имя FROM режиссер WHERE Фамилия = \"{movie.ProducerSurname}\" and Имя = \"{movie.ProducerName}\");" +
                        "set  @allowedAgeId = 0; " +
                        "set  @producerId = 0; " +
                        $"SELECT ID FROM возраст WHERE Возраст = \"{movie.AllowedAge}\" into @allowedAgeId;" +
                        $"SELECT ID FROM режиссер WHERE Фамилия = \"{movie.ProducerSurname}\" and Имя = \"{movie.ProducerName}\" into @producerId;" +
                        "INSERT INTO `фильмы` " +
                        "(`Название`, `Дата выхода`, `Длительность`, `Тип`, `Возраст_ID`, `Режиссер_ID`) " +
                        "VALUES " +
                        $"(\"{movie.Name}\", '{movie.ReleaseDate.ToString("yyyy-MM-dd")}', {movie.Duration}, NULL, @allowedAgeId, @producerId)";

            return query;
        }

        /// <summary>
        /// Изменить фильм по id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        public static string UpdateMovieById(int id, Movie movie)
        {
            string query =
                        $"insert into режиссер (`Фамилия`, `Имя`) select \"{movie.ProducerSurname}\", \"{movie.ProducerName}\" FROM DUAL " +
                        $"WHERE NOT EXISTS (SELECT Фамилия, Имя FROM режиссер WHERE Фамилия = \"{movie.ProducerSurname}\" and Имя = \"{movie.ProducerName}\");" +
                        "set @allowedAgeId = 0; " +
                        "set @producerId = 0; " +
                        $"SELECT ID FROM возраст WHERE Возраст = \"{movie.AllowedAge}\" into @allowedAgeId;" +
                        $"SELECT ID FROM режиссер WHERE Фамилия = \"{movie.ProducerSurname}\" and Имя = \"{movie.ProducerName}\" into @producerId;" +
                        "UPDATE `фильмы` " +
                        $"SET `Название` = \"{movie.Name}\", " +
                        $"`Дата выхода` = \"{movie.ReleaseDate.ToString("yyyy-MM-dd")}\", " +
                        $"`Длительность` = {movie.Duration}, " +
                        $"`Тип` = NULL, " +
                        $"`Возраст_ID` = @allowedAgeId," +
                        $"`Режиссер_ID` = @producerId " +
                        $"where ID = {id};";                      

            return query;
        }

        /// <summary>
        /// Добавить сеанс.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        public static string AddSession(Session session)
        {
            string query =          
                       "set @hallId = 0;" +
                       $"SELECT `ID` FROM `залы` WHERE `Название зала` = \"{session.HallName}\" into @hallId;" + 
                       "INSERT INTO `сеансы` " +
                       "(`Дата-время сеанса`, `Цена`, `Залы_ID`, `Фильмы_ID`) " +
                       "VALUES " +
                       $"(\"{session.MovieData.ToString("yyyy-MM-dd")} {session.MovieTime.ToLongTimeString()}\", {session.MoviePrice}, @hallId, {session.MovieId})";

            return query;
        }

        /// <summary>
        /// Изменить сеанс по id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="session"></param>
        /// <returns></returns>
        public static string UpdateSessionById(int id, Session session)
        {
            string query =
                        "set @hallId = 0;" +
                        $"SELECT `ID` FROM `залы` WHERE `Название зала` = \"{session.HallName}\" into @hallId;" +
                        "UPDATE `сеансы`" +
                        $"SET `Дата-время сеанса` = \"{session.MovieData.ToString("yyyy-MM-dd")} {session.MovieTime.ToLongTimeString()}\", " +
                        $"`Цена` = {session.MoviePrice}, " +
                        $"`Залы_ID` = @hallId, " +
                        $"`Фильмы_ID` = {session.MovieId} " +
                        $"where ID = {id};";

            return query;
        }

        /// <summary>
        /// Добавить билет.
        /// </summary>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public static string AddTicket(Ticket ticket)
        {
            string query =
                       "set @paymentTypeId = 0;" +
                       $"select ID from `тип оплаты` where Оплата = \"{ticket.PaymentType}\" into @paymentTypeId;" +
                       "INSERT INTO `билет` " +
                       "(`Дата покупки`, `Сотрудники_ID`, `Тип оплаты_ID`, `Сеансы_ID`, `Ряд`, `Место`) " +
                       "VALUES " +
                       $"(\"{ticket.PaymentData.ToString("yyyy-MM-dd")} {ticket.PaymentTime.ToLongTimeString()}\", " +
                       $"{ticket.EmployeeId}, @paymentTypeId, {ticket.SessionId}, {ticket.Seat.RowNumber}, {ticket.Seat.SeatNumber})";

            return query;
        }

        /// <summary>
        /// Получить информацию о зале по номеру сеанса.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <returns></returns>
        public static string GetInfoAboutHall(int sessionId)
        {
            string query =
                        "set @hallId = 0;" +
                        $"select `Залы_ID` from сеансы where ID = {sessionId} into @hallId;" +
                        $"select `Кол-во рядов`, `Кол-во мест в ряду` from залы where ID = @hallId;";

            return query;
        }

        /// <summary>
        /// Изменить билет по id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public static string UpdateTicketById(int id, Ticket ticket)
        {
            string query =
                        "set @paymentTypeId = 0;" +
                        $"select ID from `тип оплаты` where Оплата = \"{ticket.PaymentType}\" into @paymentTypeId;" + $" " +
                        "update билет " +
                        $"set `Дата покупки` = \"{ticket.PaymentData.ToString("yyyy-MM-dd")} {ticket.PaymentTime.ToLongTimeString()}\", " +
                        $"`Сотрудники_ID` = {ticket.EmployeeId}, " +
                        $"`Тип оплаты_ID` = @paymentTypeId, " +
                        $"`Сеансы_ID` = {ticket.SessionId}, " +
                        $"`Ряд` = {ticket.Seat.RowNumber}, " +
                        $"`Место`= {ticket.Seat.SeatNumber} " +
                        $" where ID = {id}";
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

        /// <summary>
        /// Проверка на администратора.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string IsAdministrator(string login, string password)
        {
            string query =
                       $"SELECT * FROM администраторы WHERE Логин = \"{login}\" AND Пароль = \"{password}\";";

            return query;
        }


    }
}
