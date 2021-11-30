using System.Data;

namespace CinemaResourcesLibrary
{
    /// <summary>
    /// Класс реализующий конкретные запросы.
    /// </summary>
    public static class Requestss
    {
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

        public static string GetSessions()
        {
            string query =
                        "SELECT `фильмы`.`id`, `фильмы`.`название`, `фильмы`.`дата выхода`, " +
                        "`фильмы`.`длительность`,`фильмы`.`тип`,`возраст`.`возраст`,`режиссер`.`фамилия` " +
                        "FROM фильмы " +
                        "INNER JOIN `возраст` ON `фильмы`.`возраст_id` = `возраст`.`id` " +
                        "INNER JOIN `режиссер` ON `фильмы`.`режиссер_id`=`режиссер`.`id`";

            return query;
        }


    }
}
