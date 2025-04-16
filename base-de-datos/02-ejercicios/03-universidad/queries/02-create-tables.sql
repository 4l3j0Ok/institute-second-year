-- Crear tablas --
USE Universidad;
DROP TABLE Estudiante;
DROP TABLE Carrera;
DROP TABLE Facultad;
CREATE TABLE Facultad(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);
CREATE TABLE Carrera(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    idFacultad INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idFacultad) REFERENCES Facultad(id)
);
CREATE TABLE Estudiante(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    idCarrera INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idCarrera) REFERENCES Carrera(id)
);