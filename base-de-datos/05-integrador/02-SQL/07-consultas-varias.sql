USE IntegradorBanco;
--- a.
SELECT Nombre,
    Apellido
FROM Cliente;
--- b.
SELECT Nombre,
    Apellido
FROM Cliente
WHERE DNI > 33000000;
--- c.
SELECT NumCuenta,
    Saldo
FROM Cuenta
WHERE Saldo < 25000;
--- d.
SELECT Apellido,
    Nombre
FROM Cliente
WHERE Apellido = 'Sosa'
    OR Apellido = 'Borges';
--- e.
SELECT NomSucursal
FROM Sucursal
    INNER JOIN Cuenta ON Cuenta.Sucursal = Sucursal.CodSucursal
WHERE Cuenta.Saldo BETWEEN 20000 AND 40000;
--- f.
SELECT *
FROM Cliente;
SELECT Apellido,
    Nombre
FROM Cliente
    INNER JOIN Impositor ON Cliente.DNI = Impositor.Cliente
    INNER JOIN Cuenta ON Impositor.Cuenta = Cuenta.NumCuenta;
--- g. Obtener el Apellido y Nombre de cada cliente en conjunto con su sucursal (NomSucursal) a la cual pertenecen (inner join en todas la tablas).
SELECT Apellido,
    Nombre,
    NomSucursal AS "Nombre de la sucursal"
FROM Cliente
    INNER JOIN Impositor ON Cliente.DNI = Impositor.Cliente
    INNER JOIN Cuenta ON Impositor.Cuenta = Cuenta.NumCuenta
    INNER JOIN Sucursal ON Cuenta.Sucursal = Sucursal.CodSucursal