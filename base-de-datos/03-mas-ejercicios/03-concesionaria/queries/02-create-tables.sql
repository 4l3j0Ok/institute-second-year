USE Concesionaria;
DROP TABLE IF EXISTS Revision;
DROP TABLE IF EXISTS Automovil;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Recibe;
CREATE TABLE Cliente (
    id INT NOT NULL,
    idAlta INT NOT NULL IDENTITY(1, 1),
    nombre VARCHAR(50) NOT NULL,
    nroTelefono VARCHAR(50) NULL,
    direccion VARCHAR(50) NULL,
    ciudad VARCHAR(50) NULL,
    PRIMARY KEY (id)
);
CREATE TABLE Automovil (
    patente VARCHAR(6) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    precio INT NOT NULL,
    color VARCHAR(50) NULL,
    modelo VARCHAR(50) NULL,
    idCliente INT NOT NULL,
    PRIMARY KEY (patente),
    FOREIGN KEY (idCliente) REFERENCES Cliente (id)
);
CREATE TABLE Revision (
    codigo INT NOT NULL IDENTITY(1, 1),
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (codigo),
);
CREATE TABLE Recibe(
    patenteAutomovil VARCHAR(6) NOT NULL FOREIGN KEY REFERENCES Automovil (patente),
    codigoRevision INT NOT NULL FOREIGN KEY REFERENCES Revision (codigo),
);