use filmoteka;

set @countryId = 0;
select `Страна_ID` from `страны-фильмы` where `Фильм_ID` = 3 into @countryId;
select @countryId;