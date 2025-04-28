-- Crear tablas --
USE Comercio;
DROP TABLE IF EXISTS Comercio;
DROP TABLE IF EXISTS Ciudad;
DROP TABLE IF EXISTS Provincia;
CREATE TABLE Provincia (
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);
CREATE TABLE Ciudad (
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    idProvincia INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idProvincia) REFERENCES Provincia(id)
);
CREATE TABLE Comercio (
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    idCiudad INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idCiudad) REFERENCES Ciudad(id)
);