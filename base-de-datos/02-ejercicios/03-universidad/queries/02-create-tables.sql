-- Crear tablas --
USE Universidad;
CREATE TABLE Estudiantes(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    idCarrera INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idCarrera) REFERENCES Carreras(id)
);
CREATE TABLE Carreras(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    idFacultad INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idFacultad) REFERENCES Facultades(id)
) CREATE TABLE Facultades(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
)