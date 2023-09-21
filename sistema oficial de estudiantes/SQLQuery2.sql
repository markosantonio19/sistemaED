CREATE TABLE alumnos1 (
    ID int NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) not null,
	apellido VARCHAR(100) not null,
	grado VARCHAR(100) not null,
    edad VARCHAR(255)
);
CREATE TABLE trabajadores1 (
    ID int NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) not null,
	Usuario VARCHAR(100) not null,
    contraseña VARCHAR(255)
);

INSERT INTO alumnos1(ID, Nombre, apellido, grado, edad)
VALUES (1, 'Marco', 'Bustillos Paredes', '5° B', '17');
INSERT INTO trabajadores1 (ID, Nombre, Usuario, contraseña)
VALUES (2, 'Farid', 'Farid123', 'Hola123');
SELECT * FROM alumnos1