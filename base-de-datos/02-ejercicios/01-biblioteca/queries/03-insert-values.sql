-- Insertar datos --
USE Biblioteca;
-- Eliminar datos
-- DELETE FROM Libro;
-- DELETE FROM Seccion;
-- Resetear autoincrementos
--DBCC CHECKIDENT ('Seccion', RESEED, 0);
--DBCC CHECKIDENT ('Libro', RESEED, 0);
-- Sección
INSERT INTO Seccion (nombre)
VALUES ('Terror'),
    ('Ciencia Ficcion'),
    ('Romance'),
    ('Historia'),
    ('Aventura');
-- Libro
INSERT INTO Libro (IDSeccion, titulo, anioPublicacion)
VALUES (1, 'El Silencio de los Inocentes', 1991),
    (2, 'El Señor de los Anillos', 1954),
    (3, 'Harry Potter y la Piedra Filosofal', 1997),
    (4, 'La Odisea', 1600),
    (5, 'El Hobbit', 1937);