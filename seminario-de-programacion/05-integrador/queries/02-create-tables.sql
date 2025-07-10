USE Electrodomesticos;
IF NOT EXISTS (
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = 'Electrodomestico'
        AND TABLE_SCHEMA = 'dbo'
) BEGIN CREATE TABLE Electrodomestico (
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    electrodomesticos_estado BIT DEFAULT 1,
    electrodomesticos_codigo VARCHAR(10),
    electrodomesticos_tipo VARCHAR(50),
    electrodomesticos_marca VARCHAR(50),
    electrodomesticos_modelo VARCHAR(50),
    electrodomesticos_caracteristicas VARCHAR(255),
    electrodomesticos_cantidad_stock INT,
    electrodomesticos_precio DECIMAL(10, 2),
    electrodomesticos_fecha_ingreso DATETIME
);
END;