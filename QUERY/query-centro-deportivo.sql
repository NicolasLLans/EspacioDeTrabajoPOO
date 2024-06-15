CREATE DATABASE centrodeportivo1e;

USE centrodeportivo1e;

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

# creo SP para buscar usuario y contraseña de un empleado 
DELIMITER //

CREATE PROCEDURE BuscarUsuarioInicioSesion (
    IN p_usuario VARCHAR(100),
    IN p_contrasena VARCHAR(100)
)
BEGIN
    SELECT e.*, p.*
    FROM Empleado AS e
    INNER JOIN Persona AS p ON p.IdPersona = e.FkPersona
    WHERE e.Usuario = p_usuario AND e.Contrasena = p_contrasena;
END //

DELIMITER ;


# creo SP para insertar un nuevo empleado
DELIMITER //

CREATE PROCEDURE InsertarEmpleado (
    IN p_usuario VARCHAR(100),
    IN p_contrasena VARCHAR(100),
    IN p_nombre VARCHAR(100),
    IN p_apellido VARCHAR(100),
    IN p_dni BIGINT,
    IN p_direccion VARCHAR(255),
    IN p_telefono BIGINT,
    IN p_email VARCHAR(100),    
    IN p_fechaAlta DATETIME,
    IN p_puesto VARCHAR(100)
)
BEGIN
    DECLARE lastId INT;

    -- Insertar en Persona
    INSERT INTO Persona (Dni, Nombre, Apellido, Direccion, Telefono, Email, AptoFisico, FechaAlta, FechaBaja, Baja)
    VALUES (p_dni, p_nombre, p_apellido, p_direccion, p_telefono, p_email, FALSE, p_fechaAlta, NULL, FALSE);

    -- Obtener el ID insertado en Persona
    SET lastId = LAST_INSERT_ID();

    -- Insertar en Empleado
    INSERT INTO Empleado (FkPersona, Usuario, Contrasena, Puesto)
    VALUES (lastId, p_usuario, p_contrasena, p_puesto);
       
END //

DELIMITER ;

# creo SP para ver si existe un usuario 
DELIMITER //

CREATE PROCEDURE BuscarUsuario (
    IN p_usuario VARCHAR(255)
)
BEGIN
    SELECT * FROM Empleado
    WHERE Usuario = p_usuario;
END //


# creo SP para insertar un nuevo Socio
DELIMITER //

CREATE PROCEDURE InsertarSocio (
    IN p_nombre VARCHAR(100),
    IN p_apellido VARCHAR(100),
    IN p_dni BIGINT,
    IN p_direccion VARCHAR(255),
    IN p_telefono BIGINT,
    IN p_email VARCHAR(100),
    IN p_aptoFisico BOOLEAN,
    IN p_fechaAlta DATETIME
   
)
BEGIN
    DECLARE lastId INT;

    -- Insertar en Persona
    INSERT INTO Persona (Dni, Nombre, Apellido, Direccion, Telefono, Email, AptoFisico, FechaAlta, FechaBaja, Baja)
    VALUES (p_dni, p_nombre, p_apellido, p_direccion, p_telefono, p_email, p_aptoFisico, p_fechaAlta, NULL, FALSE);

    -- Obtener el ID insertado en Persona
    SET lastId = LAST_INSERT_ID();

    -- Insertar en Empleado
    INSERT INTO socio (FkPersona)
    VALUES (lastId);
       
END //

DELIMITER ;


#buscar SI EXISTE SOCIO  por DNI


DELIMITER //

CREATE PROCEDURE ExisteSocio (
    IN p_dni BIGINT
)
BEGIN
    DECLARE socioExiste INT DEFAULT 0;

    SELECT 
        COUNT(*) INTO socioExiste
    FROM Socio s
    INNER JOIN Persona p ON s.FkPersona = p.IdPersona
    WHERE p.Dni = p_dni AND p.Baja = FALSE;
    
    SELECT socioExiste;
END //

DELIMITER ;

#insertar NO SOCIO

# creo SP para insertar un nuevo Socio
DELIMITER //

CREATE PROCEDURE InsertarNoSocio (
    IN p_nombre VARCHAR(100),
    IN p_apellido VARCHAR(100),
    IN p_dni BIGINT,
    IN p_direccion VARCHAR(255),
    IN p_telefono BIGINT,
    IN p_email VARCHAR(100),
    IN p_aptoFisico BOOLEAN,
    IN p_fechaAlta DATETIME
   
)
BEGIN
    DECLARE ultimoIdPersona INT;

    -- Insertar en Persona
    INSERT INTO Persona (Dni, Nombre, Apellido, Direccion, Telefono, Email, AptoFisico, FechaAlta, FechaBaja, Baja)
    VALUES (p_dni, p_nombre, p_apellido, p_direccion, p_telefono, p_email, p_aptoFisico, p_fechaAlta, NULL, FALSE);

    -- Obtener el ID insertado en Persona
    SET ultimoIdPersona = LAST_INSERT_ID();

    -- Insertar en Empleado
    INSERT INTO nosocio (FkPersona)
    VALUES (ultimoIdPersona);
       
END //

DELIMITER ;

#buscar SI EXISTE NO SOCIO  por DNI

DELIMITER //

CREATE PROCEDURE ExisteNoSocio (
    IN p_dni BIGINT
)
BEGIN
    DECLARE noSocioExiste INT DEFAULT 0;

    SELECT 
        COUNT(*) INTO noSocioExiste
    FROM nosocio s
    INNER JOIN Persona p ON s.FkPersona = p.IdPersona
    WHERE p.Dni = p_dni AND p.Baja = FALSE;
    
    SELECT noSocioExiste;
END //

DELIMITER ;


# SP PARA INSERTAR UNA NUEVA ACTIVIDAD
DELIMITER //

CREATE PROCEDURE InsertarActividad (
    IN p_nombre VARCHAR(100),
    IN p_precio DECIMAL(10, 2)
)
BEGIN
    INSERT INTO Actividad (Nombre, Precio)
    VALUES (p_nombre, p_precio);
END //

DELIMITER ;


# SP PARA TRAER ACTICIDADES ACTIVAS
DELIMITER //

CREATE PROCEDURE TraerActividadesActivas ()
BEGIN
    SELECT * FROM Actividad WHERE baja =0;
END //

DELIMITER ;


# SP PARA TRAER SOCIOS ACTIVAS
DELIMITER //

CREATE PROCEDURE TraerSociosActivos ()
BEGIN
SELECT  s.NumeroSocio,
CONCAT(p.Nombre, ' ', p.Apellido) AS 'Nombre'
FROM socio s
INNER JOIN persona p ON p.IdPersona = s.FkPersona
WHERE p.baja = 0;

END //

DELIMITER ;

# SP PARA Cargar tabla intermedia  SOCIOS ACTIVAS

DELIMITER //

CREATE PROCEDURE InsertarSocioActividad(
    IN p_IdSocio INT,
    IN p_IdActividad INT
)
BEGIN         
        INSERT INTO Socio_Actividad (IdSocio, IdActividad)
        VALUES (p_IdSocio, p_IdActividad);
   
END //

DELIMITER ;

# verificar  cuantas actividades lleva inscripto
DELIMITER //

CREATE PROCEDURE VerificarLimiteActividades(
    IN p_IdSocio INT,
    OUT p_NumeroActividades INT
)
BEGIN    
    DECLARE actividad_count INT;
    
    -- Contar cantidad actividades 
    SELECT COUNT(*)
    INTO actividad_count
    FROM Socio_Actividad
    WHERE IdSocio = p_IdSocio;
    
    SET p_NumeroActividades = actividad_count;
END //

DELIMITER ;

#sp para verificar que no se repita la inscripcion a una misma actividad
DELIMITER //

CREATE PROCEDURE VerificarActividadSocio(
    IN p_IdSocio INT,
    IN p_IdActividad INT,
    OUT p_ExisteInscripcion BOOL
)
BEGIN
    -- Verificar si el socio ya está inscrito en la actividad
    IF EXISTS (
        SELECT 1
        FROM Socio_Actividad
        WHERE IdSocio = p_IdSocio AND IdActividad = p_IdActividad
    ) THEN
        SET p_ExisteInscripcion = TRUE;
    ELSE
        SET p_ExisteInscripcion = FALSE;
    END IF;
END //

DELIMITER ;

#traer actividad por numero socio
DELIMITER //

CREATE PROCEDURE TraerActividadesPorNumeroSocio(
    IN p_NumeroSocio INT
)
BEGIN

    SELECT a.*
    FROM Actividad a
    INNER JOIN Socio_Actividad sa ON a.IdActividad = sa.IdActividad
    INNER JOIN Socio s ON sa.IdSocio = s.NumeroSocio
    WHERE s.NumeroSocio = p_NumeroSocio;
END //

DELIMITER ;