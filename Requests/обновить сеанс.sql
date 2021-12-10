set @hallId = 0;
SELECT `ID` FROM `залы` WHERE `Название зала` = ' ' into @hallId;
UPDATE `сеансы`
SET `Дата-время сеанса` = '',
`Цена` = '',
`Залы_ID` = @hallId,
`Фильмы_ID` = ''
where ID = 3;
