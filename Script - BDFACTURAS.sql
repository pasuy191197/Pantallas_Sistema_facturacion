USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = 'DBFACTURAS')
    DROP DATABASE DBFACTURAS;
GO

CREATE DATABASE DBFACTURAS;
GO

USE DBFACTURAS;
GO

-- Creando las tablas...

CREATE TABLE TBLROLES (
    IdRolEmpleado  INT IDENTITY(1,1) PRIMARY KEY,
    StrDescripcion VARCHAR(50) NOT NULL
);
GO

CREATE TABLE TBLEMPLEADO (
    IdEmpleado          INT IDENTITY(1,1) PRIMARY KEY,
    strNombre           VARCHAR(50)   NOT NULL,
    NumDocumento        BIGINT        NOT NULL,
    StrDireccion        VARCHAR(100)  NOT NULL,
    StrTelefono         VARCHAR(50)   NOT NULL,
    StrEmail            VARCHAR(50)   NOT NULL,
    IdRolEmpleado       INT           NOT NULL REFERENCES TBLROLES(IdRolEmpleado),
    DtmIngreso          DATETIME      NOT NULL,
    DtmRetiro           DATETIME      NULL,
    strDatosAdicionales VARCHAR(250)  NULL,
    DtmFechaModifica    DATETIME      NOT NULL,
    StrUsuarioModifico  VARCHAR(30)   NOT NULL
);
GO

CREATE TABLE TBLSEGURIDAD (
    IdSeguridad        INT IDENTITY(1,1) PRIMARY KEY,
    IdEmpleado         INT         NOT NULL REFERENCES TBLEMPLEADO(IdEmpleado),
    StrUsuario         VARCHAR(20) NOT NULL,
    StrClave           VARCHAR(20) NOT NULL,
    DtmFechaModifica   DATETIME    NOT NULL,
    StrUsuarioModifico VARCHAR(30) NOT NULL
);
GO

CREATE TABLE TBLCLIENTES (
    IdCliente          INT IDENTITY(1,1) PRIMARY KEY,
    StrNombre          VARCHAR(50) NOT NULL,
    NumDocumento       BIGINT      NOT NULL,
    StrDireccion       VARCHAR(70) NOT NULL,
    StrTelefono        VARCHAR(30) NOT NULL,
    StrEmail           VARCHAR(50) NOT NULL,
    DtmFechaModifica   DATETIME    NOT NULL,
    StrUsuarioModifico VARCHAR(30) NOT NULL
);
GO

CREATE TABLE TBLCATEGORIA_PROD (
    idCategoria        INT IDENTITY(1,1) PRIMARY KEY,
    StrDescripcion     VARCHAR(60) NOT NULL,
    DtmFechaModifica   DATETIME    NOT NULL,
    StrUsuarioModifico VARCHAR(40) NOT NULL
);
GO

CREATE TABLE TBLPRODUCTO (
    IdProducto         INT IDENTITY(1,1) PRIMARY KEY,
    StrNombre          VARCHAR(70)  NOT NULL,
    StrCodigo          VARCHAR(30)  NOT NULL,
    NumPrecioCompra    FLOAT        NOT NULL,
    NumPrecioVenta     FLOAT        NOT NULL,
    idCategoria        INT          NOT NULL REFERENCES TBLCATEGORIA_PROD(idCategoria),
    StrDetalle         VARCHAR(250) NULL,
    strFoto            VARCHAR(50)  NULL,
    NumStock           INT          NOT NULL DEFAULT 0,
    DtmFechaModifica   DATETIME     NOT NULL,
    StrUsuarioModifico VARCHAR(30)  NOT NULL
);
GO

CREATE TABLE TBLESTADO_FACTURA (
    IdEstadoFactura INT IDENTITY(1,1) PRIMARY KEY,
    StrDescripcion  VARCHAR(30) NOT NULL
);
GO

CREATE TABLE TBLFACTURA (
    IdFactura          INT IDENTITY(1,1) PRIMARY KEY,
    DtmFecha           DATETIME    NOT NULL,
    IdCliente          INT         NOT NULL REFERENCES TBLCLIENTES(IdCliente),
    IdEmpleado         INT         NOT NULL REFERENCES TBLEMPLEADO(IdEmpleado),
    NumDescuento       FLOAT       NOT NULL DEFAULT 0,
    NumImpuesto        FLOAT       NOT NULL DEFAULT 0,
    NumValorTotal      FLOAT       NOT NULL DEFAULT 0,
    IdEstado           INT         NOT NULL REFERENCES TBLESTADO_FACTURA(IdEstadoFactura),
    DtmFechaModifica   DATETIME    NOT NULL,
    StrUsuarioModifico VARCHAR(30) NOT NULL
);
GO

CREATE TABLE TBLDETALLE_FACTURA (
    idDetalle   INT IDENTITY(1,1) PRIMARY KEY,
    IdFactura   INT   NOT NULL REFERENCES TBLFACTURA(IdFactura),
    NumCantidad INT   NOT NULL,
    IdProducto  INT   NOT NULL REFERENCES TBLPRODUCTO(IdProducto),
    NumPrecio   FLOAT NOT NULL
);
GO

-- Datos para corroborar...

INSERT INTO TBLESTADO_FACTURA (StrDescripcion) VALUES ('Pendiente'),('Pagada'),('Cancelada');
INSERT INTO TBLROLES (StrDescripcion) VALUES ('Administrador'),('Vendedor'),('Bodeguero');
INSERT INTO TBLCATEGORIA_PROD (StrDescripcion, DtmFechaModifica, StrUsuarioModifico)
    VALUES ('Electrónica', GETDATE(), 'admin'),('Ropa', GETDATE(), 'admin'),('Alimentos', GETDATE(), 'admin');

INSERT INTO TBLEMPLEADO (strNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail,
    IdRolEmpleado, DtmIngreso, strDatosAdicionales, DtmFechaModifica, StrUsuarioModifico)
VALUES ('Administrador', 1000000000, 'Medellín', '3001234567', 'admin@sistema.com',
    1, GETDATE(), 'Usuario administrador', GETDATE(), 'sistema');

INSERT INTO TBLSEGURIDAD (IdEmpleado, StrUsuario, StrClave, DtmFechaModifica, StrUsuarioModifico)
VALUES (1, 'admin', '123', GETDATE(), 'sistema');
GO

-- Para los procedimientos almacenados.

-- LOGIN
CREATE PROCEDURE [dbo].[validar_Login]
    @StrUsuario VARCHAR(50), @StrClave VARCHAR(50)
AS
    SELECT s.IdEmpleado, s.StrUsuario, e.strNombre, r.StrDescripcion AS Rol
    FROM TBLSEGURIDAD s
    INNER JOIN TBLEMPLEADO e ON s.IdEmpleado = e.IdEmpleado
    INNER JOIN TBLROLES r    ON e.IdRolEmpleado = r.IdRolEmpleado
    WHERE s.StrUsuario = @StrUsuario AND s.StrClave = @StrClave;
GO

-- CLIENTES
CREATE PROCEDURE [dbo].[listar_Clientes]
AS
    SELECT IdCliente, StrNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail
    FROM TBLCLIENTES ORDER BY StrNombre;
GO

CREATE PROCEDURE [dbo].[actualizar_Cliente]
    @IdCliente INT, @StrNombre VARCHAR(50), @NumDocumento BIGINT,
    @StrDireccion VARCHAR(70), @StrTelefono VARCHAR(30), @StrEmail VARCHAR(50),
    @DtmFechaModifica DATETIME, @StrUsuarioModifico VARCHAR(30)
AS
    IF NOT EXISTS (SELECT IdCliente FROM TBLCLIENTES WHERE IdCliente = @IdCliente)
        INSERT INTO TBLCLIENTES (StrNombre, NumDocumento, StrDireccion, StrTelefono,
            StrEmail, DtmFechaModifica, StrUsuarioModifico)
        VALUES (@StrNombre, @NumDocumento, @StrDireccion, @StrTelefono,
            @StrEmail, @DtmFechaModifica, @StrUsuarioModifico)
    ELSE
        UPDATE TBLCLIENTES SET StrNombre=@StrNombre, NumDocumento=@NumDocumento,
            StrDireccion=@StrDireccion, StrTelefono=@StrTelefono, StrEmail=@StrEmail,
            DtmFechaModifica=@DtmFechaModifica, StrUsuarioModifico=@StrUsuarioModifico
        WHERE IdCliente = @IdCliente;
GO

CREATE PROCEDURE [dbo].[eliminar_Cliente] @IdCliente INT
AS  DELETE FROM TBLCLIENTES WHERE IdCliente = @IdCliente;
GO

-- PRODUCTOS
CREATE PROCEDURE [dbo].[listar_Productos]
AS
    SELECT p.IdProducto, p.StrNombre, p.StrCodigo, p.NumPrecioCompra, p.NumPrecioVenta,
           p.idCategoria, c.StrDescripcion AS Categoria, p.StrDetalle, p.NumStock
    FROM TBLPRODUCTO p
    INNER JOIN TBLCATEGORIA_PROD c ON p.idCategoria = c.idCategoria
    ORDER BY p.StrNombre;
GO

CREATE PROCEDURE [dbo].[actualizar_Producto]
    @IdProducto INT, @StrNombre VARCHAR(70), @StrCodigo VARCHAR(30),
    @NumPrecioCompra FLOAT, @NumPrecioVenta FLOAT, @idCategoria INT,
    @StrDetalle VARCHAR(250), @NumStock INT,
    @DtmFechaModifica DATETIME, @StrUsuarioModifico VARCHAR(30)
AS
    IF NOT EXISTS (SELECT IdProducto FROM TBLPRODUCTO WHERE IdProducto = @IdProducto)
        INSERT INTO TBLPRODUCTO (StrNombre, StrCodigo, NumPrecioCompra, NumPrecioVenta,
            idCategoria, StrDetalle, NumStock, DtmFechaModifica, StrUsuarioModifico)
        VALUES (@StrNombre, @StrCodigo, @NumPrecioCompra, @NumPrecioVenta,
            @idCategoria, @StrDetalle, @NumStock, @DtmFechaModifica, @StrUsuarioModifico)
    ELSE
        UPDATE TBLPRODUCTO SET StrNombre=@StrNombre, StrCodigo=@StrCodigo,
            NumPrecioCompra=@NumPrecioCompra, NumPrecioVenta=@NumPrecioVenta,
            idCategoria=@idCategoria, StrDetalle=@StrDetalle, NumStock=@NumStock,
            DtmFechaModifica=@DtmFechaModifica, StrUsuarioModifico=@StrUsuarioModifico
        WHERE IdProducto = @IdProducto;
GO

CREATE PROCEDURE [dbo].[eliminar_Producto] @IdProducto INT
AS  DELETE FROM TBLPRODUCTO WHERE IdProducto = @IdProducto;
GO

-- CATEGORÍAS Y ROLES (para ComboBoxes)
CREATE PROCEDURE [dbo].[listar_Categorias]
AS  SELECT idCategoria, StrDescripcion FROM TBLCATEGORIA_PROD ORDER BY StrDescripcion;
GO

CREATE PROCEDURE [dbo].[listar_Roles]
AS  SELECT IdRolEmpleado, StrDescripcion FROM TBLROLES ORDER BY StrDescripcion;
GO

CREATE PROCEDURE [dbo].[listar_Empleados]
AS
    SELECT e.IdEmpleado, e.strNombre, e.NumDocumento, e.StrTelefono, e.StrEmail,
           r.StrDescripcion AS Rol
    FROM TBLEMPLEADO e
    INNER JOIN TBLROLES r ON e.IdRolEmpleado = r.IdRolEmpleado
    ORDER BY e.strNombre;
GO

-- EMPLEADOS
CREATE PROCEDURE [dbo].[actualizar_Empleado]
    @IdEmpleado INT, @strNombre VARCHAR(50), @NumDocumento BIGINT,
    @StrDireccion VARCHAR(50), @StrTelefono VARCHAR(20), @StrEmail VARCHAR(50),
    @IdRolEmpleado INT, @DtmIngreso DATETIME, @DtmRetiro DATETIME,
    @strDatosAdicionales NVARCHAR(250), @DtmFechaModifica DATETIME, @StrUsuarioModifico VARCHAR(20)
AS
    IF NOT EXISTS (SELECT IdEmpleado FROM TBLEMPLEADO WHERE IdEmpleado = @IdEmpleado)
        INSERT INTO TBLEMPLEADO (strNombre, NumDocumento, StrDireccion, StrTelefono, StrEmail,
            IdRolEmpleado, DtmIngreso, DtmRetiro, strDatosAdicionales, DtmFechaModifica, StrUsuarioModifico)
        VALUES (@strNombre, @NumDocumento, @StrDireccion, @StrTelefono, @StrEmail,
            @IdRolEmpleado, @DtmIngreso, @DtmRetiro, @strDatosAdicionales, @DtmFechaModifica, @StrUsuarioModifico)
    ELSE
        UPDATE TBLEMPLEADO SET strNombre=@strNombre, NumDocumento=@NumDocumento,
            StrDireccion=@StrDireccion, StrTelefono=@StrTelefono, StrEmail=@StrEmail,
            IdRolEmpleado=@IdRolEmpleado, DtmIngreso=@DtmIngreso, DtmRetiro=@DtmRetiro,
            strDatosAdicionales=@strDatosAdicionales, DtmFechaModifica=@DtmFechaModifica,
            StrUsuarioModifico=@StrUsuarioModifico
        WHERE NumDocumento = @NumDocumento;
GO

-- SEGURIDAD
CREATE PROCEDURE [dbo].[actualizar_Seguridad]
    @IdEmpleado INT, @StrUsuario VARCHAR(50), @StrClave VARCHAR(50),
    @DtmFechaModifica DATETIME, @StrUsuarioModifico VARCHAR(10)
AS
    IF NOT EXISTS (SELECT IdEmpleado FROM TBLSEGURIDAD WHERE IdEmpleado = @IdEmpleado)
        INSERT INTO TBLSEGURIDAD (IdEmpleado, StrUsuario, StrClave, DtmFechaModifica, StrUsuarioModifico)
        VALUES (@IdEmpleado, @StrUsuario, @StrClave, @DtmFechaModifica, @StrUsuarioModifico)
    ELSE
        UPDATE TBLSEGURIDAD SET StrUsuario=@StrUsuario, StrClave=@StrClave,
            DtmFechaModifica=@DtmFechaModifica, StrUsuarioModifico=@StrUsuarioModifico
        WHERE IdEmpleado = @IdEmpleado;
GO

CREATE PROCEDURE [dbo].[Eliminar_Empleado] @IdEmpleado INT
AS  DELETE FROM TBLEMPLEADO WHERE IdEmpleado = @IdEmpleado;
GO

CREATE PROCEDURE [dbo].[Eliminar_Seguridad] @IdEmpleado INT
AS  DELETE FROM TBLSEGURIDAD WHERE IdEmpleado = @IdEmpleado;
GO

-- Adicionalmente ... Procedimientos para la categoría de productos

CREATE PROCEDURE [dbo].[actualizar_Categoria]
    @idCategoria INT,
    @StrDescripcion VARCHAR(60),
    @DtmFechaModifica DATETIME,
    @StrUsuarioModifico VARCHAR(40)
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM TBLCATEGORIA_PROD WHERE idCategoria = @idCategoria
    )
        INSERT INTO TBLCATEGORIA_PROD
        (
            StrDescripcion,
            DtmFechaModifica,
            StrUsuarioModifico
        )
        VALUES
        (
            @StrDescripcion,
            @DtmFechaModifica,
            @StrUsuarioModifico
        )
    ELSE
        UPDATE TBLCATEGORIA_PROD
        SET
            StrDescripcion = @StrDescripcion,
            DtmFechaModifica = @DtmFechaModifica,
            StrUsuarioModifico = @StrUsuarioModifico
        WHERE idCategoria = @idCategoria;
END
GO

CREATE PROCEDURE [dbo].[eliminar_Categoria]
    @idCategoria INT
AS
BEGIN
    DELETE FROM TBLCATEGORIA_PROD
    WHERE idCategoria = @idCategoria;
END
GO