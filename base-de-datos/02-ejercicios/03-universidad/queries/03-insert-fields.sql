-- Insertar datos --
USE Universidad;
DELETE FROM Estudiante;
DELETE FROM Carrera;
DELETE FROM Facultad;
DBCC CHECKIDENT ('Facultad', RESEED, 0);
DBCC CHECKIDENT ('Carrera', RESEED, 0);
DBCC CHECKIDENT ('Estudiante', RESEED, 0);
INSERT INTO Facultad (nombre)
VALUES ('Facultad San Vicente'),
    ('Facultad Lomas de Zamora'),
    ('Facultad Temperley');
INSERT INTO Carrera (nombre, idFacultad)
VALUES ('Analista de sistemas', 1),
    ('Audiovisuales', 2),
    ('Turismo', 3);
INSERT INTO Estudiante (nombre, apellido, idCarrera)
VALUES ('Alejo', 'Sarmiento', 1),
    ('Luis', 'Díaz', 2),
    ('Marcos', 'Perez', 3);