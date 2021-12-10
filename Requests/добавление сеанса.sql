
set  @hallId  := 0; 
SELECT ID FROM залы WHERE `Название зала` = 'Комфорт 1' into @hallId;
INSERT INTO `сеансы` (`Дата-время сеанса`, `Цена`, `Залы_ID`, `Фильмы_ID`)
VALUES
('2021-04-29 15:40:00', 100, @hallId, 1);