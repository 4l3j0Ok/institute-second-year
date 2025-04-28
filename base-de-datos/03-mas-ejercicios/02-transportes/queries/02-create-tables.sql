USE Transportes;
DROP TABLE IF EXISTS Maneja;
DROP TABLE IF EXISTS Paquete;
DROP TABLE IF EXISTS Camionero;
DROP TABLE IF EXISTS Camion;
DROP TABLE IF EXISTS Provincia;
CREATE TABLE Camionero (
    DNI VARCHAR(8) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    telefono VARCHAR(15) NOT NULL,
    localidad VARCHAR(50) NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    salario INT NOT NULL,
);
CREATE TABLE Camion (
    patente VARCHAR(6) PRIMARY KEY,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    potencia INT NOT NULL,
);
CREATE TABLE Provincia (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
);
CREATE TABLE Paquete (
    codigo INT PRIMARY KEY IDENTITY(1, 1),
    direccion VARCHAR(50) NOT NULL,
    destinatario VARCHAR(50) NOT NULL,
    descripcion VARCHAR(100) NOT NULL,
    DNICamionero VARCHAR(8) NOT NULL,
    codigoProvincia INT NOT NULL,
    FOREIGN KEY (DNICamionero) REFERENCES Camionero(DNI),
    FOREIGN KEY (codigoProvincia) REFERENCES Provincia(codigo)
);
CREATE TABLE Maneja (
    patenteCamion VARCHAR(6) NOT NULL FOREIGN KEY REFERENCES Camion(patente),
    DNICamionero VARCHAR(8) NOT NULL FOREIGN KEY REFERENCES Camionero(DNI),
    fechaManejo DATE NOT NULL CONSTRAINT PKManeja PRIMARY KEY (patenteCamion, DNICamionero)
);