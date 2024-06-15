CREATE DATABASE centrodeportivo1e;

CREATE TABLE Persona (
    IdPersona INT PRIMARY KEY AUTO_INCREMENT,
    Dni BIGINT ,
    Nombre VARCHAR(100),
    Apellido VARCHAR(100),
    Direccion VARCHAR(255),
    Telefono BIGINT,
    Email VARCHAR(100),
    AptoFisico BOOLEAN,
    FechaAlta DATETIME ,
    FechaBaja DATETIME,
    Baja BOOLEAN DEFAULT 0
);

INSERT INTO Persona (Dni, Nombre, Apellido, Direccion, Telefono, Email, AptoFisico, FechaAlta, FechaBaja, Baja)
VALUES (00000001, 'ADMINISTRADOR', 'CENTRO DEPORTIVO', 'GRUPO 1 E', '08001112222', 'centrodeportivoe1@centrodeportivo.com', 0, '2024-05-19', NULL, 0);


CREATE TABLE Empleado (
    IdEmpleado INT PRIMARY KEY AUTO_INCREMENT,
    FkPersona INT,
    Usuario VARCHAR(100),
    Contrasena VARCHAR(100),
    Puesto VARCHAR(100),
    FOREIGN KEY (FkPersona) REFERENCES Persona(IdPersona)
);

INSERT INTO Empleado (FkPersona, Usuario, Contrasena, Puesto)
VALUES (1, 'ADMIN', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'ADMINISTRACION');


CREATE TABLE Socio (
    NumeroSocio INT PRIMARY KEY AUTO_INCREMENT,
    FkPersona INT,     
    FOREIGN KEY (FkPersona) REFERENCES Persona(IdPersona)
);

CREATE TABLE NoSocio (
    NumeroNoSocio INT PRIMARY KEY AUTO_INCREMENT,
    FkPersona INT,    
    FOREIGN KEY (FkPersona) REFERENCES Persona(IdPersona)
);


CREATE TABLE Carnet (
    CarnetID BIGINT PRIMARY KEY AUTO_INCREMENT,
    Fk_NumeroSocio INT,
    Vencimiento DATETIME,
    FOREIGN KEY (Fk_NumeroSocio) REFERENCES Socio(NumeroSocio)
);
CREATE TABLE Actividad (
    IdActividad INT PRIMARY KEY AUTO_INCREMENT,
    Nombre VARCHAR(100),
    Precio DECIMAL(10, 2),
    baja BOOL DEFAULT 0
);

CREATE TABLE Cuota (
    IdCuota BIGINT PRIMARY KEY AUTO_INCREMENT,
    fkPersona INT ,     
    FechaVencimiento DATETIME,
    FOREIGN KEY (fkPersona) REFERENCES Persona(IdPersona)
);

CREATE TABLE Pago (
    IdPago BIGINT PRIMARY KEY AUTO_INCREMENT,
    fkCuota BIGINT,  -- Asegúrate de que los tipos de datos coincidan
    FechaPago DATETIME,    
    FOREIGN KEY (fkCuota) REFERENCES Cuota(IdCuota)
);


CREATE TABLE Socio_Actividad (
    IdSocio INT,
    IdActividad INT,
    PRIMARY KEY (IdSocio, IdActividad),
    FOREIGN KEY (IdSocio) REFERENCES Socio(NumeroSocio),
    FOREIGN KEY (IdActividad) REFERENCES Actividad(IdActividad)
);



