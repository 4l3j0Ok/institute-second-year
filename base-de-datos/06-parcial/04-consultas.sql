USE ParcialPractico;
SELECT Clientes.Apellido,
    Clientes.Nombre,
    Localidades.Localidad
FROM Clientes
    INNER JOIN Localidades ON Clientes.CP = Localidades.CP
ORDER BY Localidades.Localidad DESC;
UPDATE Productos
SET Precio = 50000,
    NombreP = 'Mesa armada'
WHERE IdProducto = 141;
SELECT NombreP,
    Precio
FROM Productos
WHERE IdProducto = 141;
INSERT INTO Localidades
VALUES (2323, 'Nueva localidad')
DELETE FROM Localidades
WHERE CP = 2323;
SELECT Productos.NombreP,
    Pedidos.FechaPedido
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