use filmoteka;


insert into режиссер (`Фамилия`, `Имя`) select 'Ричи', 'Гай'  FROM DUAL
WHERE NOT EXISTS (SELECT Фамилия, Имя FROM режиссер WHERE Фамилия = 'Ричи' and Имя = 'Г');
