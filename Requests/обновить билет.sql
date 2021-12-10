use filmoteka;
set @paymentTypeId = 0;
select ID from `тип оплаты`
where Оплата = '' into @paymentTypeId;
update билет
set `Дата покупки` = '',
`Сотрудники_ID` = '',
`Тип оплаты_ID` = @paymentTypeId,
`Сеансы_ID` = '',
`Ряд` = '',
`Место`= ''
 where ID = 3