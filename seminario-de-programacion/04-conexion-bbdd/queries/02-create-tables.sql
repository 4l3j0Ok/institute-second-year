USE SeminarioABM;
IF NOT EXISTS (
    SELECT *
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = 'Personas'
        AND TABLE_SCHEMA = 'dbo'
) BEGIN CREATE TABLE Personas(
    DNI VARCHAR(8) PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Direccion VARCHAR(60),
    Email VARCHAR(100),
    Telefono VARCHAR(15),
    Activo BIT DEFAULT 1,
)
END;