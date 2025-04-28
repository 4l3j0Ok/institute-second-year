USE Empresa;
DELETE FROM Compra;
DELETE FROM Producto;
DELETE FROM Cliente;
DELETE FROM Proveedor;
DBCC CHECKIDENT ('Proveedor', RESEED, 0);
DBCC CHECKIDENT ('Producto', RESEED, 0);
DBCC CHECKIDENT ('Cliente', RESEED, 0);
INSERT INTO Proveedor (nombre)
VALUES ('Proveedor 1'),
    ('Proveedor 2'),
    ('Proveedor 3'),
    ('Proveedor 4');
INSERT INTO Producto (nombre, precioUnitario, codigoProveedor)
VALUES ('Arroz', 700, 1),
    ('Fideos', 800, 2),
    ('Lentejas', 600, 4),
    ('Pack de condimentos', 1000, 1),
    ('Salsa de tomate', 400, 1),
    ('Ñoquis', 2200, 3);
INSERT INTO Cliente (
        nombre,
        apellido,
        direccion,
        fechaNacimiento
    )
VALUES (
        'Alejandro',
        'Ruiz',
        'Av. Sarmiento 123',
        '1997-02-02'
    ),
    (
        'Roberto',
        'Gomez',
        'Av. Sarmiento 123',
        '1997-12-10'
    ),
    (
        'Pedro',
        'Gimenez',
        'Av. Pueyrredon',
        '1992-01-05'
    );
INSERT INTO Compra (codigoProducto, idCliente)
VALUES (1, 1),
    (2, 2),
    (2, 3),
    (3, 1),
    (3, 3);