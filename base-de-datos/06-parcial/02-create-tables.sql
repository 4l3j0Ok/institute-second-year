USE ParcialPractico;
CREATE TABLE Localidades (
    CP INT PRIMARY KEY,
    Localidad VARCHAR(50),
);
CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    CP INT FOREIGN KEY REFERENCES Localidades(CP)
);
CREATE TABLE Pedidos (
    IdPedido INT PRIMARY KEY,
    Cliente INT FOREIGN KEY REFERENCES Clientes(IdCliente),
    FechaPedido DATE
);
CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY,
    NombreP VARCHAR(40),
    Precio INT
);
CREATE TABLE DetallePedidos (
    IdPedido INT FOREIGN KEY REFERENCES Pedidos(IdPedido),
    IdProducto INT FOREIGN KEY REFERENCES Productos(IdProducto),
    Cantidad INT,
    PRIMARY KEY (IdPedido, IdProducto)
);