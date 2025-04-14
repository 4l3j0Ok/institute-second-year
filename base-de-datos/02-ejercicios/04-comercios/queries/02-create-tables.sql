-- Crear tablas --
USE Empresa;
CREATE TABLE Clientes(
    id INT IDENTITY(1, 1) NOT NULL,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    correo VARCHAR(80) NOT NULL,
    PRIMARY KEY(id)
);
CREATE TABLE Pedidos(
    id INT IDENTITY(1, 1) NOT NULL,
    monto INT NOT NULL,
    idCliente INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (idCliente) REFERENCES Clientes(id)
);