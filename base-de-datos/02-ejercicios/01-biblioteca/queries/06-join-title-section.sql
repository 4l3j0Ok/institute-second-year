-- Join de tablas para mostrar el título del libro y la sección a la que pertenece
USE Biblioteca;
SELECT Libro.titulo as 'Título del libro',
    Seccion.nombre as 'Sección'
FROM Libro
    INNER JOIN Seccion ON Seccion.ID = Libro.IDSeccion;