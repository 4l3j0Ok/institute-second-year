USE IntegradorBanco;
-- Clear tables
DELETE FROM Impositor;
DELETE FROM Cuenta;
DELETE FROM Cliente;
DELETE FROM Sucursal;
INSERT INTO Sucursal (CodSucursal, NomSucursal)
VALUES (1, 'Adrogue'),
    (2, 'Glew'),
    (3, 'Burzaco'),
    (4, 'Guernica'),
    (5, 'Brandsen');
INSERT INTO Cuenta (NumCuenta, Sucursal, Saldo)
VALUES (2222, 3, 10000),
    (4444, 2, 20000),
    (6666, 1, 30000),
    (8888, 4, 40000),
    (1010, 5, 50000);
INSERT INTO Cliente (DNI, Apellido, Nombre)
VALUES (31111111, 'Sosa', 'Martin'),
    (32222222, 'Sosa', 'Roxana'),
    (33333333, 'Borges', 'Antonio'),
    (34444444, 'Ortiz', 'Angel'),
    (35555555, 'Molina', 'Soledad');
INSERT INTO Impositor (Cliente, Cuenta)
VALUES (31111111, 4444),
    (32222222, 8888),
    (31111111, 1010),
    (33333333, 2222),
    (34444444, 6666);