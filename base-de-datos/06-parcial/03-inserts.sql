USE ParcialPractico;
INSERT INTO Localidades
VALUES (1865, 'San Vicente'),
    (1866, 'San Miguel'),
    (1867, 'San Justo');
INSERT INTO Clientes
VALUES (1, 'Gomez', 1865),
    (2, 'Lopez', 1866),
    (3, 'Perez', 1867);
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