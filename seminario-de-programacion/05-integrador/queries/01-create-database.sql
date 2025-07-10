IF NOT EXISTS (
    SELECT *
    FROM sys.databases
    WHERE name = 'Electrodomesticos'
) BEGIN CREATE DATABASE Electrodomesticos
END;