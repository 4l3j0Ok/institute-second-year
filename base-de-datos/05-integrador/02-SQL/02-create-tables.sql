USE IntegradorBanco;
CREATE TABLE Sucursal (
    CodSucursal INT PRIMARY KEY,
    NomSucursal VARCHAR(40)
);
CREATE TABLE Cuenta (
    NumCuenta INT PRIMARY KEY,
    Sucursal INT FOREIGN KEY REFERENCES Sucursal(CodSucursal),
    Saldo INT
);
CREATE TABLE Cliente(
    DNI INT PRIMARY KEY,
    Apellido VARCHAR(50),
    Nombre VARCHAR(50)
);
CREATE TABLE Impositor (
    Cliente INT FOREIGN KEY REFERENCES Cliente(DNI),
    Cuenta INT FOREIGN KEY REFERENCES Cuenta(NumCuenta),
    PRIMARY KEY (Cliente, Cuenta)
);
-- Verificamos que se hayan creado las tablas correctamente
-- SHOW TABLES no funciona en MSSQL, usamos:
SELECT TABLE_NAME as "Nombre de la tabla",
    TABLE_CATALOG as "Nombre de la base de datos"
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
    AND TABLE_CATALOG = 'IntegradorBanco';