using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaResourcesLibrary
{
    public static class Request
    {
        public static string Get(RequestType requestType)
        {
            switch (requestType)
            {
                case RequestType.Movies:
                {
                    string movies = "SELECT [Фильмы].[Название], [Жанры].[Жанр], [Фильмы].[Дата выхода], [Фильмы].[Длительность], [Возраст].[Возраст], [Режиссер].[Режиссер] " +
                            "FROM[Фильмы] " +
                            "INNER JOIN [Возраст] ON [Фильмы].[Возраст_ID] = [Возраст].[ID] " +
                            "INNER JOIN [Режиссер] ON [Фильмы].[Режиссер_ID] =[Режиссер].[ID] " +
                            "INNER JOIN [Фильмы-Жанры] ON [Фильмы-Жанры].[Фильмы_ID] = [Фильмы].[ID] " +
                            "INNER JOIN [Жанры] ON [Фильмы-Жанры].[Жанры_ID] = [Жанры].[ID]";
                        return movies;
                }
                case RequestType.Sessions:
                {
                        string sessions = "select [Фильмы].[Название] as [Название фильма], [Сеансы].[Цена], [Сеансы].[Дата-время сеанса], [Залы].[Название] as [Название зала] " +
                                    "from [Сеансы] " + 
                                    "inner join [Залы] on [Залы].[ID] = [Сеансы].[Залы_ID]" + 
                                    "inner join [Фильмы] on [Фильмы].[ID] = [Сеансы].[Фильм_ID]";

                                //"INNER JOIN [Фильмы] ON [Сеансы].[Фильм_ID] = [Фильмы].[ID]";
                        //"INNER JOIN [Режиссер] ON [Фильмы].[Режиссер_ID] =[Режиссер].[ID] " +
                        //"INNER JOIN [Фильмы-Жанры] ON [Фильмы-Жанры].[Фильмы_ID] = [Фильмы].[ID] " +
                        //"INNER JOIN [Жанры] ON [Фильмы-Жанры].[Жанры_ID] = [Жанры].[ID]";
                        return sessions;
                }
                default:
                    return "";              
            }

        }

    }
}
