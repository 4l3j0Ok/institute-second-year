-- Creación de los SP --
USE SegundoParcialSarmiento;
CREATE PROCEDURE InsertarEstablecimiento @NomEstablecimiento VARCHAR(40) = 'S/N' AS BEGIN
INSERT INTO Establecimientos (NomEstablecimiento)
VALUES (@NomEstablecimiento);
END;
CREATE PROCEDURE InsertarCargo @NumCargo INT,
@Establecimiento INT,
@Sueldo INT AS BEGIN
INSERT INTO Cargos (NumCargo, Establecimiento, Sueldo)
VALUES (@NumCargo, @Establecimiento, @Sueldo);
END;
CREATE PROCEDURE InsertarEmpleado @Legajo CHAR(8),
@Apellido VARCHAR(50),
@Nombre VARCHAR(50) = NULL AS BEGIN
INSERT INTO Empleados (Legajo, Apellido, Nombre)
VALUES (@Legajo, @Apellido, @Nombre);
END;
CREATE PROCEDURE InsertarTarea @Empleado CHAR(8),
@Cargo INT AS BEGIN
INSERT INTO Tareas (Empleado, Cargo)
VALUES (@Empleado, @Cargo);
END;
-- Llamada de los SP --
-- Establecimientos
EXEC InsertarEstablecimiento 'Adrogué';
EXEC InsertarEstablecimiento 'Glew';
EXEC InsertarEstablecimiento 'Burzaco';
EXEC InsertarEstablecimiento;
EXEC InsertarEstablecimiento 'Brandsen';
-- Cargos
EXEC InsertarCargo 2222,
3,
1000000;
EXEC InsertarCargo 4444,
3,
2000000;
EXEC InsertarCargo 6666,
1,
3000000;
EXEC InsertarCargo 8888,
4,
4000000;
EXEC InsertarCargo 1010,
5,
5000000;
-- Empleados
EXEC InsertarEmpleado '3111111',
'Gomez',
'Martín';
EXEC InsertarEmpleado '3222222',
'Gomez',
'Roxana';
EXEC InsertarEmpleado '3333333',
'López',
'Antonio';
EXEC InsertarEmpleado '3444444',
'Ortiz';
EXEC InsertarEmpleado '3555555',
'Santillán',
'Soledad';
-- Tareas
EXEC InsertarTarea '3111111',
4444;
EXEC InsertarTarea '3222222',
8888;
EXEC InsertarTarea '3111111',
1010;
EXEC InsertarTarea '3333333',
2222;
EXEC InsertarTarea '3444444',
6666;