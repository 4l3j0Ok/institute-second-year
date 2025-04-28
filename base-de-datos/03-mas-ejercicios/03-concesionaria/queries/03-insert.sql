USE Concesionaria;
DELETE FROM Recibe;
DELETE FROM Revision;
DELETE FROM Automovil;
DELETE FROM Cliente;
INSERT INTO Cliente (id, nombre, nroTelefono, direccion, ciudad)
VALUES (
        1,
        'Juan Perez',
        '123456789',
        'Av. Libertador 1234',
        'Buenos Aires'
    ),
    (
        2,
        'Maria Lopez',
        '987654321',
        'Calle Falsa 5678',
        'CABA'
    ),
    (
        3,
        'Carlos Garcia',
        '456789123',
        'Av. Corrientes 9101',
        'La Plata'
    ),
    (
        4,
        'Ana Martinez',
        '321654987',
        'Calle de la Paz 2345',
        'Rosario'
    ),
    (
        5,
        'Luis Fernandez',
        '654321789',
        'Av. Santa Fe 6789',
        'Mendoza'
    );
INSERT INTO Automovil (patente, marca, precio, color, modelo, idCliente)
VALUES (
        'ABC123',
        'Toyota',
        20000,
        'Rojo',
        'Corolla',
        1
    ),
    (
        'DEF456',
        'Ford',
        25000,
        'Azul',
        'Focus',
        2
    ),
    (
        'GHI789',
        'Chevrolet',
        30000,
        'Negro',
        'Corsa',
        3
    );
INSERT INTO Revision (nombre)
VALUES ('Cambio de aceite'),
    ('Cambio de frenos'),
    ('Cambio de motor'),
    ('Cambio de color'),
    ('Cambio de filtro');
INSERT INTO Recibe (patenteAutomovil, codigoRevision)
VALUES ('ABC123', 1),
    ('DEF456', 4),
    ('ABC123', 2),
    ('ABC123', 3),
    ('GHI789', 3);