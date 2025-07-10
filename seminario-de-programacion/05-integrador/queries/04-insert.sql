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
        '{ electrodomesticos_codigo }',
        '{ electrodomesticos_tipo }',
        '{ electrodomesticos_marca  }',
        '{ electrodomesticos_modelo }',
        '{ electrodomesticos_caracteristicas }',
        { electrodomesticos_cantidad_stock },
        { electrodomesticos_precio },
        '{ electrodomesticos_fecha_ingreso }'
    ),