create table if not exists Блюда(
	Код integer not null key auto_increment,
	Название VARCHAR(25) UNIQUE,
	Стоимость int,
	Вес int
);

create table if not exists  Категории(
	Код integer not null key auto_increment, 
	Название VARCHAR(25) UNIQUE
);

create table if not exists  Категории_блюд(
	Код integer not null key auto_increment, 
	Код_категории int,
	Код_блюда int,
	FOREIGN KEY (Код_категории) REFERENCES Категории (Код),
	FOREIGN KEY (Код_блюда) REFERENCES Блюда (Код)
);

create table if not exists  Клиенты(
	Код integer not null key auto_increment, 
	Фамилия text,
	Имя text,
	Телефон text
);

create table if not exists  Столы(
	Код integer not null key auto_increment, 
	Название VARCHAR(25) UNIQUE
);


create table if not exists  Заказы(
	Код integer not null key auto_increment, 
	Код_клиента int,
	Код_стола int,
	Дата_заказа datetime,
	FOREIGN KEY (Код_клиента) REFERENCES Клиенты (Код),
	FOREIGN KEY (Код_стола) REFERENCES Столы (Код)
);


create table if not exists  Список_заказа(
	Код integer not null key auto_increment, 
	Код_заказа int,
	Код_блюда int,
	Количество int,
	FOREIGN KEY (Код_заказа) REFERENCES Заказы (Код),
	FOREIGN KEY (Код_блюда) REFERENCES Блюда (Код)
);