USE Empresa;
-- Una empresa vende productos destinados a la gastronomía a sus clientes, se necesita conocer los datos personales de 
-- los clientes  (identificación nombre,  apellido, dirección y fecha de  nacimiento)  cada producto tiene un nombre y un 
-- código, así como un precio unitario.  Un cliente puede comprar varios productos a la empresa y un mismo producto puede ser comprado por varios clientes, 
-- los productos son suministrados por diferentes proveedores.  Se debe tener en cuenta que un producto solo puede ser suministrado por un proveedor y que un proveedor puede 
-- suministrar diferentes productos, de cada proveedor se desea conocer el código de proveedor, nombre y dirección.
SELECT Cliente.nombre AS "Nombre de cliente",
    Cliente.apellido AS "Apellido del cliente",
    Cliente.direccion AS "Dirección del cliente",
    Cliente.fechaNacimiento AS "Fecha de nacimiento del cliente",
    Producto.nombre AS "Nombre de producto",
    Proveedor.codigo AS "Código del proveedor",
    Proveedor.nombre AS "Nombre del proveedor"
FROM Cliente
    INNER JOIN Compra ON Cliente.id = Compra.idCliente
    INNER JOIN Producto ON Compra.codigoProducto = Producto.codigo
    INNER JOIN Proveedor ON Proveedor.codigo = Producto.codigoProveedor;