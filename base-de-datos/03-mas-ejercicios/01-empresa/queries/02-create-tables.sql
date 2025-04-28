USE Empresa;
DROP TABLE IF EXISTS Producto;
DROP TABLE IF EXISTS Compra;
DROP TABLE IF EXISTS Cliente;
DROP TABLE IF EXISTS Proveedor;
CREATE TABLE Proveedor (
    codigo INT PRIMARY KEY IDENTITY(1, 1),
    nombre VARCHAR(40),
    direccion VARCHAR(30)
);
CREATE TABLE Producto (
    codigo INT PRIMARY KEY IDENTITY(1, 1),
    nombre VARCHAR(100),
    precioUnitario INT,
    codigoProveedor INT FOREIGN KEY REFERENCES Proveedor(codigo)
);
CREATE TABLE Cliente (
    id INT PRIMARY KEY IDENTITY(1, 1),
    nombre VARCHAR(20),
    apellido VARCHAR(20),
    direccion VARCHAR(30),
    fechaNacimiento DATETIME
);
CREATE TABLE Compra (
    codigoProducto INT FOREIGN KEY REFERENCES Producto(codigo),
    idCliente INT FOREIGN KEY REFERENCES Cliente(id),
    CONSTRAINT PKCompra PRIMARY KEY (codigoProducto, idCliente)
);