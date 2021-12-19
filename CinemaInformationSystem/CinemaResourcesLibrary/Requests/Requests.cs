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
        /// <returns> Запрос. </returns>
        public static string GetMovies()
        {
            string query =
                        "SELECT `фильмы`.`id` as 'ID', `фильмы`.`название` as 'Название',`фильмы`.`длительность` as 'Длительность, мин.', " +
                        "`фильмы`.`дата выхода` as 'Дата выхода', `режиссер`.`имя` as 'Имя режиссёра', `режиссер`.`фамилия` as 'Фамилия режиссёра', " +
                        "`фильмы`.`тип` as 'Тип',`возраст`.`возраст` as 'Возрастное ограничение' " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id` " +
                        "order by фильмы.id; ";
            return query;
        }

        /// <summary>
        /// Получить фильм по айди.
        /// </summary>
        /// <param name="id"> Номер фильма. </param>
        /// <returns> Запрос. </returns>
        public static string GetMovieById(int id)
        {
            string query =
                        "SELECT `фильмы`.`id` as 'ID', `фильмы`.`название` as 'Название',`фильмы`.`длительность` as 'Длительность, мин.', " +
                        "`фильмы`.`дата выхода` as 'Дата выхода', `режиссер`.`имя` as 'Имя режиссёра', `режиссер`.`фамилия` as 'Фамилия режиссёра', " +
                        "`фильмы`.`тип` as 'Тип',`возраст`.`возраст` as 'Возрастное ограничение' " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id` " +
                        $"where `фильмы`.`id` = {id}";
            return query;
        }

        /// <summary>
        /// Получить фильм по названию.
        /// </summary>
        /// <param name="name"> Название фильма. </param>
        /// <returns> Запрос. </returns>
        public static string GetMovieByName(string name)
        {
            string query =
                        "SELECT `фильмы`.`id` as 'ID', `фильмы`.`название` as 'Название',`фильмы`.`длительность` as 'Длительность, мин.', " +
                        "`фильмы`.`дата выхода` as 'Дата выхода', `режиссер`.`имя` as 'Имя режиссёра', `режиссер`.`фамилия` as 'Фамилия режиссёра', " +
                        "`фильмы`.`тип` as 'Тип',`возраст`.`возраст` as 'Возрастное ограничение' " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id` " +
                        $"where `фильмы`.`название` = \"{name}\"";
            return query;
        }

        /// <summary>
        /// Получить все сеансы.
        /// </summary>
        /// <returns> Запрос. </returns>
        public static string GetSessions()
        {
            string query =
                        "SELECT сеансы.ID as 'ID', фильмы.Название as 'Фильм', сеансы.`дата-время сеанса` as 'Дата и время сеанса', сеансы.Цена as 'Стоимость', " +
                        "залы.`название зала` as `Зал`, (залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) as `Количество мест`, " +
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
        /// <param name="id"> Номер сеанса. </param>
        /// <returns> Запрос. </returns>
        public static string GetSessionById(int id)
        {
            string query =
                        "select сеансы.ID, сеансы.`дата-время сеанса`, сеансы.Цена,  " +
                        "залы.`название зала`, сеансы.`Фильмы_ID` " +
                        "from Сеансы " +
                        "inner join Залы on Сеансы.Залы_ID = Залы.ID " +
                        $"where сеансы.ID = {id}";

            return query;
        }

        /// <summary>
        /// Получить сеанс по названию фильма
        /// </summary>
        /// <param name="movieName"> Название фильма. </param>
        /// <returns> Запрос. </returns>
        public static string GetSessionsByMovieName(string movieName)
        {
            string query =
                        "SELECT сеансы.ID as 'ID', фильмы.Название as 'Фильм', сеансы.`дата-время сеанса` as 'Дата и время сеанса', сеансы.Цена as 'Стоимость', " +
                        "залы.`название зала` as `Зал`, (залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) as `Количество мест`, " +
                        "((залы.`Кол-во рядов` * залы.`Кол-во мест в ряду`) - (SELECT count(Место) FROM билет where `Сеансы_ID` = Сеансы.ID)) as `Свободные места` " +
                        "FROM Сеансы " +
                        "inner join Фильмы on Фильмы.ID = Сеансы.Фильмы_ID " +
                        "inner join Залы on Сеансы.Залы_ID = Залы.ID " +
                        $"where `фильмы`.`название` = \"{movieName}\"";
            return query;
        }

        /// <summary>
        /// Получить все билеты.
        /// </summary>
        /// <returns> Запрос. </returns>
        public static string GetTickets()
        {
            string query =
                        "SELECT билет.ID, билет.`Дата покупки`, сеансы.`Дата-время сеанса`, сеансы.ID as 'Номер сеанса',  " +
                        "(select фильмы.`Название` from фильмы inner join сеансы on сеансы.Фильмы_ID = фильмы.ID where сеансы.ID = `Номер сеанса` limit 1 ) as 'Название фильма', " +
                        "билет.Ряд, билет.Место, concat(сотрудники.Фамилия , ' ', сотрудники.Имя, ' ', сотрудники.Отчество) as 'ФИО сотрудника', `тип оплаты`.Оплата " +
                        "FROM билет " +
                        "inner join сотрудники on билет.Сотрудники_ID = сотрудники.ID " +
                        "inner join `тип оплаты` on билет.`Тип оплаты_ID` = `тип оплаты`.ID " +
                        "inner join сеансы on билет.Сеансы_ID = сеансы.ID " +
                        "order by билет.ID ";

            return query;
        }

        /// <summary>
        /// Получить билеты по названию фильма.
        /// </summary>
        /// <param name="movieName"> Название фильма. </param>
        /// <returns> Запрос. </returns>
        public static string GetTicketsByMovieName(string movieName)
        {
            string query =
                        "SELECT билет.ID, билет.`Дата покупки`, сеансы.`Дата-время сеанса`, сеансы.ID as 'Номер сеанса',  " +
                        "(select фильмы.`Название` from фильмы inner join сеансы on сеансы.Фильмы_ID = фильмы.ID where сеансы.ID = `Номер сеанса` limit 1 ) as 'Название фильма', " +
                        "билет.Ряд, билет.Место, concat(сотрудники.Фамилия , ' ', сотрудники.Имя, ' ', сотрудники.Отчество) as 'ФИО сотрудника', `тип оплаты`.Оплата " +
                        "FROM билет " +
                        "inner join сотрудники on билет.`Сотрудники_ID` = сотрудники.ID " +
                        "inner join `тип оплаты` on билет.`Тип оплаты_ID` = `тип оплаты`.ID " +
                        $"join сеансы on билет.`Сеансы_ID` = сеансы.ID inner join фильмы on сеансы.`Фильмы_ID` = фильмы.ID and фильмы.Название = \"{movieName}\" " +
                        "order by билет.ID ";

            return query;
        }

        /// <summary>
        /// Получить билет по айди.
        /// </summary>
        /// <returns> Запрос. </returns>
        public static string GetTicketById(int id)
        {
            string query =
                        "select билет.ID, билет.`Дата покупки`, билет.`Сотрудники_ID`, " +
                        "`тип оплаты`.Оплата, билет.`Сеансы_ID`, билет.`Ряд`, билет.`Место` " +
                        "from билет " +
                        "inner join `тип оплаты` on билет.`Тип оплаты_ID` = `тип оплаты`.ID " +
                        $"where билет.ID = {id}";

            return query;
        }

        /// <summary>
        /// Получить информацию о занытых местах по номеру сеанса.
        /// </summary>
        /// <returns> Запрос. </returns>
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
        /// <param name="movie"> Фильм. </param>
        /// <returns> Запрос. </returns>
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
                        $"(\"{movie.Name}\", \"{movie.ReleaseDate.ToString("yyyy-MM-dd")}\", {movie.Duration}, \"{movie.Type}\", @allowedAgeId, @producerId)";

            return query;
        }

        /// <summary>
        /// Изменить фильм по id.
        /// </summary>
        /// <param name="id"> Номер фильма. </param>
        /// <param name="movie"> Фильм. </param>
        /// <returns> Запрос. </returns>
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
                        $"`Тип` = \"{movie.Type}\", " +
                        $"`Возраст_ID` = @allowedAgeId," +
                        $"`Режиссер_ID` = @producerId " +
                        $"where ID = {id};";                      

            return query;
        }

        /// <summary>
        /// Добавить сеанс.
        /// </summary>
        /// <param name="session"> Сеанс. </param>
        /// <returns> Запрос. </returns>
        public static string AddSession(Session session)
        {
            string query =          
                       "set @hallId = 0;" +
                       $"SELECT `ID` FROM `залы` WHERE `Название зала` = \"{session.HallName}\" into @hallId;" + 
                       "INSERT INTO `сеансы` " +
                       "(`Дата-время сеанса`, `Цена`, `Залы_ID`, `Фильмы_ID`) " +
                       "VALUES " +
                       $"(\"{session.Data.ToString("yyyy-MM-dd")} {session.Time.ToLongTimeString()}\", {session.Price}, @hallId, {session.MovieId})";

            return query;
        }

        /// <summary>
        /// Изменить сеанс по id.
        /// </summary>
        /// <param name="id"> Номер сеанса. </param>
        /// <param name="session"> Сеанс. </param>
        /// <returns> Запрос. </returns>
        public static string UpdateSessionById(int id, Session session)
        {
            string query =
                        "set @hallId = 0;" +
                        $"SELECT `ID` FROM `залы` WHERE `Название зала` = \"{session.HallName}\" into @hallId;" +
                        "UPDATE `сеансы`" +
                        $"SET `Дата-время сеанса` = \"{session.Data.ToString("yyyy-MM-dd")} {session.Time.ToLongTimeString()}\", " +
                        $"`Цена` = {session.Price}, " +
                        $"`Залы_ID` = @hallId, " +
                        $"`Фильмы_ID` = {session.MovieId} " +
                        $"where ID = {id};";

            return query;
        }

        /// <summary>
        /// Добавить билет.
        /// </summary>
        /// <param name="ticket"> Билет. </param>
        /// <returns> Запрос. </returns>
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
        /// <param name="sessionId"> Номер сеанса. </param>
        /// <returns> Запрос. </returns>
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
        /// <param name="id"> Номер билета. </param>
        /// <param name="ticket"> Билет. </param>
        /// <returns> Запрос. </returns>
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
        /// <param name="id"> Номер фильма. </param>
        /// <returns> Запрос. </returns>
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
        /// <param name="id"> Номер сеанса. </param>
        /// <returns> Запрос. </returns>
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
        /// <param name="id"> Номер билета. </param>
        /// <returns>  Запрос.  </returns>
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
        /// <param name="login"> Логин. </param>
        /// <param name="password"> Пароль. </param>
        /// <returns> Запрос. </returns>
        public static string IsAdministrator(string login, string password)
        {
            string query =
                       $"SELECT * FROM администраторы WHERE Логин = \"{login}\" AND Пароль = \"{password}\";";

            return query;
        }
    }
}
