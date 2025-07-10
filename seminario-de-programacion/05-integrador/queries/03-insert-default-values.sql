USE Electrodomesticos;
INSERT INTO Electrodomestico (
        electrodomesticos_codigo,
        electrodomesticos_tipo,
        electrodomesticos_marca,
        electrodomesticos_modelo,
        electrodomesticos_caracteristicas,
        electrodomesticos_cantidad_stock,
        electrodomesticos_precio,
        electrodomesticos_fecha_ingreso
    )
VALUES (
        '0001',
        'Lavadora',
        'Samsung',
        'WF42H5200AP',
        'Carga frontal, capacidad 4.2 cu. ft.',
        10,
        499.99,
        '2023-05-10'
    ),
    (
        '0002',
        'Refrigerador',
        'LG',
        'LFCS27596S',
        'French door, capacidad 27 cu. ft.',
        5,
        1799.99,
        '2023-04-22'
    ),
    (
        '0003',
        'Licuadora',
        'Oster',
        'BLSTMG-R00-033',
        '600W, 10 velocidades',
        20,
        39.99,
        '2023-06-15'
    ),
    (
        '0004',
        'Microondas',
        'Panasonic',
        'NN-SN651B',
        '1200W, 1.2 cu. ft.',
        15,
        129.99,
        '2023-03-28'
    ),
    (
        '0005',
        'Aspiradora',
        'Dyson',
        'V11 Torque Drive',
        'Sin cable, succión potente',
        8,
        599.99,
        '2023-05-05'
    );