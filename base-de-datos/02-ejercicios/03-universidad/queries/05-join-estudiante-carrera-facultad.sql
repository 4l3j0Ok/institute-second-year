-- Join de tablas para mostrar todos los clientes y sus pedidos
USE Universidad;
SELECT Estudiante.nombre as 'Nombre del estudiante',
    Carrera.nombre as 'Carrera que cursa',
    Facultad.nombre as 'Facultad perteneciente'
FROM Estudiante
    INNER JOIN Carrera ON Estudiante.idCarrera = Carrera.id
    INNER JOIN Facultad ON Carrera.idFacultad = Facultad.id;