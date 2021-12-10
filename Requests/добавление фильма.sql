set  @genreId = 0; 
set  @allowedAgeId = 0; 
SELECT ID FROM жанры WHERE Жанр = "Драма" into @genreId;
SELECT ID FROM возраст WHERE Возраст = "12+" into @allowedAgeId;
SELECT @genreId;
SELECT @allowedAgeId;
-- INSERT INTO `фильмы` (`Название`,`Дата выхода`,`Длительность`, `Тип`, `Возраст_ID`,`Режиссер_ID`) VALUES
-- ("Лига Справедливости Зака Снайдера",'2021-03-18', 242, NULL, 6, 8);