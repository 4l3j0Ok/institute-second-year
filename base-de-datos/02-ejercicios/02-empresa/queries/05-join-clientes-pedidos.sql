-- Join de tablas para mostrar todos los clientes y sus pedidos
USE Empresa;
SELECT Clientes.nombre as 'Nombre del cliente',
    Pedidos.id as 'ID del pedido'
FROM Clientes
    INNER JOIN Pedidos ON Clientes.id = Pedidos.idCliente;