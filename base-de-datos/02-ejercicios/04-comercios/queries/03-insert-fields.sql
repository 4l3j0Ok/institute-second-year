-- Insertar datos --
USE Comercio;
---
DELETE FROM Comercio;
DELETE FROM Ciudad;
DELETE FROM Provincia;
---
INSERT INTO Provincia (nombre)
VALUES ('Buenos Aires');
INSERT INTO Provincia (nombre)
VALUES ('Córdoba');
INSERT INTO Provincia (nombre)
VALUES ('Santa Fe');
INSERT INTO Provincia (nombre)
VALUES ('Mendoza');
INSERT INTO Provincia (nombre)
VALUES ('Tierra del Fuego');
INSERT INTO Ciudad (nombre, idProvincia)
VALUES ('La Plata', 1);
---
INSERT INTO Ciudad (nombre, idProvincia)
VALUES ('Mar del Plata', 1);
INSERT INTO Ciudad (nombre, idProvincia)
VALUES ('Córdoba', 2);
INSERT INTO Ciudad (nombre, idProvincia)
VALUES ('Rosario', 3);
INSERT INTO Ciudad (nombre, idProvincia)
VALUES ('Santa Fe', 3);
---
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Supermercado', 1);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Ferretería', 2);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Librería', 1);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Supermercado', 4);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Ferretería', 2);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Librería', 1);
INSERT INTO Comercio (nombre, idCiudad)
VALUES ('Supermercado', 3);