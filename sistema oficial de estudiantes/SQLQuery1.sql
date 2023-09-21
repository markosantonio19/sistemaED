CREATE TABLE trabajadores (
    ID int NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) not null,
	Usuario VARCHAR(100) not null,
    contraseña VARCHAR(255)
);

CREATE TABLE Productos (
    ID int NOT NULL PRIMARY KEY,
    Nombre NVARCHAR(100) not null,
    Descripcion NVARCHAR(255) not null,
    Precio DECIMAL(10, 2) not null,
    Stock INT
);

CREATE TABLE alumnos1 (
    ID int NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) not null,
	apellido VARCHAR(100) not null,
	grado VARCHAR(100) not null,
    edad VARCHAR(255)
);

INSERT INTO trabajadores (ID, Nombre, Usuario, contraseña)
VALUES (1, 'Alex', 'Alex123', 'soygay123');

INSERT INTO Productos (ID, Nombre, Descripcion,Precio, Stock)
VALUES (1, 'Coca-Cola', 'refrescante', 3.00, 1000);

SELECT * FROM trabajadores
SELECT * FROM Productos
