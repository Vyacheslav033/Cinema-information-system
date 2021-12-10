use filmoteka;
create table администраторы
(
    ID INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Логин VARCHAR(20) NOT NULL UNIQUE,
    Пароль VARCHAR(20) NOT NULL,
	`Сотрудник_ID` INT NOT NULL,
    FOREIGN KEY (`Сотрудник_ID`) REFERENCES filmoteka.сотрудники (ID)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);