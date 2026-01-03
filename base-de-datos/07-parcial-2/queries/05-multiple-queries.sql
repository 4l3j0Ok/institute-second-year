USE SegundoParcialSarmiento;
-- 5. a)
CREATE VIEW Vista_Establecimientos_Sueldos AS
SELECT E.NomEstablecimiento
FROM Establecimientos E
    INNER JOIN Cargos C ON E.CodEstablecimiento = C.Establecimiento
WHERE C.Sueldo BETWEEN 2000000 AND 4000000;
SELECT *
FROM Vista_Establecimientos_Sueldos;
-- 5. b)
UPDATE Empleados
SET Nombre = 'Julia'
WHERE Legajo = '3555555';
SELECT *
FROM Empleados
WHERE Legajo = '3555555';
-- 5. c)
CREATE VIEW Vista_Empleados_Gomez_Lopez AS
SELECT Apellido,
    Nombre AS EmpleadosGomezLopez
FROM Empleados
WHERE Apellido IN ('Gomez', 'López');
SELECT *
FROM Vista_Empleados_Gomez_Lopez;
-- 5. d)
SELECT E.Nombre,
    E.Apellido
FROM Empleados E
    INNER JOIN Tareas T ON E.Legajo = T.Empleado
    INNER JOIN Cargos C ON T.Cargo = C.NumCargo
WHERE C.Sueldo > (
        SELECT AVG(Sueldo)
        FROM Cargos
    );