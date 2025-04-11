-- Crear tablas --
USE Biblioteca;
CREATE TABLE Seccion (
    ID INT NOT NULL IDENTITY(1, 1),
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);
CREATE TABLE Libro (
    ID INT NOT NULL IDENTITY(1, 1),
    IDSeccion INT NOT NULL,
    titulo VARCHAR(100) NOT NULL,
    anioPublicacion INT NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (IDSeccion) REFERENCES Seccion(ID)
);