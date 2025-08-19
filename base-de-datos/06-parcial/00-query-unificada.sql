CREATE DATABASE ParcialPractico;

USE ParcialPractico;
CREATE TABLE Localidades (
    CP INT PRIMARY KEY,
    Localidad VARCHAR(50),
);
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    CP INT FOREIGN KEY REFERENCES Localidades(CP)
);
CREATE TABLE Pedidos (
    IdPedido INT PRIMARY KEY,
    Cliente INT FOREIGN KEY REFERENCES Clientes(IdCliente),
    FechaPedido DATE
);
CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY,
    NombreP VARCHAR(40),
    Precio INT
);
CREATE TABLE DetallePedidos (
    IdPedido INT FOREIGN KEY REFERENCES Pedidos(IdPedido),
    IdProducto INT FOREIGN KEY REFERENCES Productos(IdProducto),
    Cantidad INT,
    PRIMARY KEY (IdPedido, IdProducto)
);


--DELETE FROM DetallePedidos;
--DELETE FROM Pedidos;
--DELETE FROM Clientes;
--DELETE FROM Localidades;
--DELETE FROM Productos;

USE ParcialPractico;
INSERT INTO Localidades
VALUES (1865, 'San Vicente'),
    (1866, 'San Miguel'),
    (1867, 'San Justo');
INSERT INTO Clientes
VALUES (1, 'Juan', 'Gomez', 1865),
    (2, 'Pedro', 'Lopez', 1866),
    (3, 'Alexis', 'Perez', 1867);
INSERT INTO Pedidos
VALUES (4214, 1, '2025-07-11'),
    (4215, 2, '2025-07-12'),
    (4216, 1, '2025-07-12');
INSERT INTO Productos
VALUES (141, 'Tablas de madera', 4000),
    (1142, 'Hormigon', 20000),
    (24, 'Ladrillos', 2000);
INSERT INTO DetallePedidos
VALUES (4214, 141, 50),
    (4214, 1142, 3),
    (4215, 24, 80);
SELECT *
FROM Localidades;
SELECT *
FROM Clientes;
SELECT *
FROM Pedidos;
SELECT *
FROM Productos;
SELECT *
FROM DetallePedidos;

USE ParcialPractico;
SELECT Clientes.Apellido,
    Clientes.Nombre,
    Localidades.Localidad
FROM Clientes
    INNER JOIN Localidades ON Clientes.CP = Localidades.CP ORDER BY Localidades.Localidad DESC;

USE ParcialPractico;
UPDATE Productos SET Precio = 50000, NombreP = 'Mesa armada'
WHERE IdProducto = 141;
SELECT NombreP, Precio FROM Productos
WHERE IdProducto = 141;

INSERT INTO Localidades
VALUES (2323, 'Nueva localidad')
SELECT * FROM Localidades WHERE CP = 2323;
DELETE FROM Localidades
WHERE CP = 2323;
SELECT * FROM Localidades WHERE CP = 2323;

SELECT Productos.NombreP, Pedidos.FechaPedido
FROM Productos
    INNER JOIN DetallePedidos ON Productos.IdProducto = DetallePedidos.IdProducto
    INNER JOIN Pedidos ON DetallePedidos.IdPedido = Pedidos.IdPedido
    WHERE Productos.IdProducto BETWEEN 100 AND 200;

SELECT Clientes.Apellido,
    Clientes.Nombre,
    Productos.NombreP
    FROM Clientes
    INNER JOIN Pedidos ON Clientes.IdCliente = Pedidos.Cliente
    INNER JOIN DetallePedidos ON Pedidos.IdPedido = DetallePedidos.IdPedido
    INNER JOIN Productos ON DetallePedidos.IdProducto = Productos.IdProducto
    WHERE Clientes.Apellido LIKE 'L%'

