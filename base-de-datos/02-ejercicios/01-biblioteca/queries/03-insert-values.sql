-- Insertar datos --
USE Biblioteca;
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
    (2, 'Star Wars', 1977);