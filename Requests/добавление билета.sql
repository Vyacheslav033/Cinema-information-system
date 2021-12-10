set @employeeId = 0;
set @paymentTypeId = 0;
select ID from `тип оплаты` where Оплата = "Наличная" into @paymentTypeId;
select @paymentTypeId;

-- INSERT INTO `билет` (`Дата покупки`, `Сотрудники_ID`, `Тип оплаты_ID`, `Сеансы_ID`, `Ряд`, `Место`) VALUES
-- ('2021-05-02 12:53:25', 3, 1, 4, 1, 3) 