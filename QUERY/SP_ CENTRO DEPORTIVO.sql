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
