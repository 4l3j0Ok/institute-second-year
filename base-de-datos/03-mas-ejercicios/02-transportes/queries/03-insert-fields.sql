-- Insertar datos --
USE Transportes;
DELETE FROM Maneja;
DELETE FROM Paquete;
DELETE FROM Camionero;
DELETE FROM Camion;
DELETE FROM Provincia;
INSERT INTO Provincia (codigo, nombre)
VALUES (1, 'Buenos Aires'),
    (2, 'CABA'),
    (3, 'Catamarca'),
    (4, 'Chaco');
INSERT INTO Camion (patente, marca, modelo, potencia)
VALUES ('ABC123', 'Mercedes Benz', 'Sprinter', 150),
    ('DEF456', 'Iveco', 'Daily', 180),
    ('GHI789', 'Ford', 'Transit', 160);
INSERT INTO Camionero (
        DNI,
        nombre,
        telefono,
        localidad,
        direccion,
        salario
    )
VALUES (
        '12345678',
        'Juan Perez',
        '01123456789',
        'Buenos Aires',
        'Av. Corrientes 1234',
        2000000
    ),
    (
        '87654321',
        'Roberto Gomez',
        '01198765432',
        'CABA',
        'Av. Santa Fe 5678',
        1500000
    ),
    (
        '11223344',
        'Carlos Lopez',
        '01134567890',
        'Catamarca',
        'Av. Belgrano 9101',
        3000000
    );
INSERT INTO Paquete (
        direccion,
        destinatario,
        descripcion,
        DNICamionero,
        codigoProvincia
    )
VALUES (
        'Av. Libertador 1234',
        'Maria Garcia',
        'Auriculares',
        '12345678',
        1
    ),
    (
        'Av. Rivadavia 5678',
        'Pedro Martinez',
        'Teclado',
        '87654321',
        2
    ),
    (
        'Av. San Martin 9101',
        'Ana Torres',
        'Cocina',
        '11223344',
        3
    );
INSERT INTO Maneja (patenteCamion, DNICamionero, fechaManejo)
VALUES ('ABC123', '12345678', '2025-04-12'),
    ('DEF456', '87654321', '2025-02-14'),
    ('GHI789', '11223344', '2025-04-22');