USE Electrodomesticos;
UPDATE Electrodomestico
SET electrodomesticos_tipo = '{ electrodomesticos_tipo }',
    electrodomesticos_marca = '{ electrodomesticos_marca }',
    electrodomesticos_modelo = '{ electrodomesticos_modelo }',
    electrodomesticos_caracteristicas = '{ electrodomesticos_caracteristicas }',
    electrodomesticos_cantidad_stock = { electrodomesticos_cantidad_stock },
    electrodomesticos_precio = { electrodomesticos_precio },
    electrodomesticos_fecha_ingreso = '{ electrodomesticos_fecha_ingreso }'
WHERE Id = { Id };