USE SegundoParcialSarmiento;
CREATE TABLE Establecimientos (
    CodEstablecimiento INT IDENTITY(1, 1) PRIMARY KEY,
    NomEstablecimiento VARCHAR(40) DEFAULT 'S/N',
);
CREATE TABLE Cargos (
    NumCargo INT PRIMARY KEY,
    Establecimiento INT,
    Sueldo INT NOT NULL,
    FOREIGN KEY (Establecimiento) REFERENCES Establecimientos(CodEstablecimiento)
);
CREATE TABLE Empleados (
    Legajo CHAR(8) PRIMARY KEY,
    Apellido VARCHAR(50),
    Nombre VARCHAR(50) NULL
);
CREATE TABLE Tareas (
    Empleado CHAR(8),
    Cargo INT,
    FOREIGN KEY (Empleado) REFERENCES Empleados(Legajo),
    FOREIGN KEY (Cargo) REFERENCES Cargos(NumCargo),
    PRIMARY KEY (Empleado, Cargo)
)