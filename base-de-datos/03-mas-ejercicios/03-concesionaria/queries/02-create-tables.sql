CREATE TABLE Cliente (
    id INT NOT NULL,
    idAlta INT NOT NULL,
    nombre VARCHAR NOT NULL,
    nroTelefono VARCHAR NULL,
    direccion VARCHAR NULL,
    ciudad DATETIME NULL,
    PRIMARY KEY (id)
);
CREATE TABLE Automovil (
    patente INT NOT NULL,
    marca VARCHAR NOT NULL,
    precio INT NOT NULL,
    color VARCHAR NULL,
    modelo VARCHAR NULL,
    idCliente INT NOT NULL,
    PRIMARY KEY (patente),
    FOREIGN KEY (idCliente) REFERENCES Cliente (id)
);
CREATE TABLE Revision (
    codigo INT NOT NULL,
    nombre VARCHAR NOT NULL,
    patenteAutomovil INT NOT NULL,
    PRIMARY KEY (codigo),
    FOREIGN KEY (patenteAutomovil) REFERENCES Automovil (patente)
);