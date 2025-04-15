-- Insertar datos --
USE Universidad;
DELETE FROM Facultades;
DELETE FROM Carreras;
DELETE FROM Estudiantes;
DBCC CHECKIDENT ('Facultades', RESEED, 0);
DBCC CHECKIDENT ('Carreras', RESEED, 0);
DBCC CHECKIDENT ('Estudiantes', RESEED, 0);
INSERT INTO Facultades (nombre)
VALUES ('Facultad San Vicente'),
    ('Facultad Lomas de Zamora'),
    ('Facultad Temperley');
INSERT INTO Carreras (nombre, idFacultad)
VALUES ('Analista de sistemas', '1'),
    ('Audiovisuales', 1),
    ('Turismo', 2)