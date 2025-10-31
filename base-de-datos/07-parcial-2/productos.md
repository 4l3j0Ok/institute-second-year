## CREAR BASE DE DATOS Y TABLAS

```sql
-- Crear base de datos de pruebas
CREATE DATABASE PruebasDB;
GO

USE PruebasDB;
GO

-- Tabla de usuarios
CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

-- Tabla de productos
CREATE TABLE Productos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL CHECK (Stock >= 0)
);
GO

-- Tabla de pedidos
CREATE TABLE Pedidos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    UsuarioId INT NOT NULL,
    FechaPedido DATETIME DEFAULT GETDATE(),
    Total DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (UsuarioId) REFERENCES Usuarios(Id)
);
GO

-- Tabla detalle de pedidos
CREATE TABLE DetallePedidos (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PedidoId INT NOT NULL,
    ProductoId INT NOT NULL,
    Cantidad INT NOT NULL CHECK (Cantidad > 0),
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (PedidoId) REFERENCES Pedidos(Id),
    FOREIGN KEY (ProductoId) REFERENCES Productos(Id)
);
GO
```

## INSERTAR DATOS DE PRUEBA

```sql
USE PruebasDB;
GO

-- Usuarios
INSERT INTO Usuarios (Nombre, Email)
VALUES 
('Alejo Sarmiento', 'alejo@example.com'),
('Nico Rolón', 'nico@example.com'),
('Camila Torres', 'camila@example.com'),
('Eliana Dev', 'eliana@example.com');
GO

-- Productos
INSERT INTO Productos (Nombre, Precio, Stock)
VALUES
('Café Montivero', 5500.00, 25),
('Mate Cocido Taragüi', 1500.00, 60),
('Taza térmica Leafnoise', 8000.00, 10),
('SSD Kingston 500GB', 45000.00, 5),
('Raspberry Pi 5', 120000.00, 3);
GO

-- Pedidos
INSERT INTO Pedidos (UsuarioId, Total)
VALUES 
(1, 15500.00),
(2, 9600.00),
(3, 120000.00);
GO

-- Detalles de pedidos
INSERT INTO DetallePedidos (PedidoId, ProductoId, Cantidad, PrecioUnitario)
VALUES
(1, 1, 2, 5500.00),
(1, 2, 1, 1500.00),
(2, 2, 4, 1500.00),
(2, 3, 1, 8000.00),
(3, 5, 1, 120000.00);
GO

-- Verificar datos
SELECT * FROM Usuarios;
SELECT * FROM Productos;
SELECT * FROM Pedidos;
SELECT * FROM DetallePedidos;
```

Esto crea un escenario completo para pruebas: usuarios, productos, pedidos y sus detalles. ¿Querés que agregue un `VIEW` o `JOIN` para mostrar los pedidos con sus productos y totales?
