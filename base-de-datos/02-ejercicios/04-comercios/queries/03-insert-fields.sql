-- Insertar datos --
USE Empresa;
DELETE FROM Pedidos;
DELETE FROM Clientes;
DBCC CHECKIDENT ('Clientes', RESEED, 0);
DBCC CHECKIDENT ('Pedidos', RESEED, 0);
INSERT INTO Clientes (nombre, apellido, correo)
VALUES ('Pedro', 'Gomez', 'pgomez@argentina.gob.ar'),
    ('Juan', 'Díaz', 'jdiaz@leafnoise.io'),
    ('Julián', 'Weich', 'jweich@telefe.com.ar');
INSERT INTO Pedidos (monto, idCliente)
VALUES (100, 1),
    (200, 2),
    (300, 3),
    (400, 1),
    (500, 2);