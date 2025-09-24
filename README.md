-- Crear base de datos (el nombre tiene punto, por eso va entre corchetes)
IF DB_ID(N'AccSamseDb.1.2') IS NULL
    CREATE DATABASE [AccSamseDb.1.2];
GO

USE [AccSamseDb.1.2];

GO
-- ==========================
-- TABLA Usuarios
-- ==========================

CREATE TABLE dbo.usuarios
(
    id_person   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,   -- PK
    name        NVARCHAR(100)     NOT NULL,
    last_Name   NVARCHAR(100)     NOT NULL,
    email       NVARCHAR(150)     NOT NULL,
    document    NVARCHAR(50)      NOT NULL,
    phone       NVARCHAR(30)      NULL,

    role        NVARCHAR(50)      NOT NULL,
    [password]  NVARCHAR(256)     NOT NULL,              
    [state]     NVARCHAR(20)      NOT NULL                
);


ALTER TABLE dbo.usuarios ADD CONSTRAINT UQ_usuarios_email    UNIQUE (email);
ALTER TABLE dbo.usuarios ADD CONSTRAINT UQ_usuarios_document UNIQUE (document);


-- ==========================
-- TABLA Client
-- ==========================

CREATE TABLE Client(
	id_Client   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,   -- PK
    name        NVARCHAR(100)     NOT NULL,
    last_Name   NVARCHAR(100)     NOT NULL,
    email       NVARCHAR(150)     NOT NULL,
    document    NVARCHAR(50)      NOT NULL,
    phone       NVARCHAR(30)      NULL,
	

);

ALTER TABLE dbo.Client ADD CONSTRAINT UQ_Client_email    UNIQUE (email);
ALTER TABLE dbo.Client ADD CONSTRAINT UQ_Client_document UNIQUE (document);


-- ==========================
-- TABLA PAYMENTS
-- ==========================
CREATE TABLE dbo.Payments
(
    id_Payment      INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Amount          DECIMAL(18,2)     NOT NULL,
    Payment_Method  NVARCHAR(50)      NOT NULL,
    Payment_Date    DATETIME          NOT NULL DEFAULT(GETDATE())
);
GO


-- ==========================
-- TABLA Ventas
-- ==========================

CREATE TABLE dbo.Sales
(
    id_Sale     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,   -- PK
    id_person     INT NOT NULL,   -- FK con usuarios (el vendedor)
    id_Client   INT NOT NULL,   -- FK con client
	id_Payment INT NOT NULL,
    date        DATETIME       NOT NULL DEFAULT(GETDATE()), -- fecha de la venta
    total       DECIMAL(18,2)  NOT NULL,   -- monto total
    state      NVARCHAR(20)   NOT NULL,   -- estado de la venta

    CONSTRAINT FK_Sales_Usuarios FOREIGN KEY (id_person) 
        REFERENCES dbo.usuarios(id_person),

    CONSTRAINT FK_Sales_Client FOREIGN KEY (id_Client) 
        REFERENCES dbo.Client(id_Client),

	CONSTRAINT FK_Sales_Payments FOREIGN KEY (id_Payment) 
        REFERENCES dbo.Payments(id_Payment)
	
);

-- ==========================
-- TABLA Categories
-- ==========================

CREATE TABLE Categories (
    id_Category INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria autoincremental
    Name NVARCHAR(100) NOT NULL,                -- Nombre de la categoría
    Description NVARCHAR(255),                  -- Descripción opcional
    Status BIT NOT NULL DEFAULT 1,              -- Estado (1 = activo, 0 = inactivo)
    creation_Date DATETIME NOT NULL DEFAULT GETDATE() -- Fecha de creación automática
);



-- ==========================
-- TABLA Products
-- ==========================

CREATE TABLE Products (
    id_product INT IDENTITY(1,1) PRIMARY KEY,  -- Clave primaria autoincremental
    id_Category INT NOT NULL,                   -- Clave foránea hacia Category
    name NVARCHAR(100) NOT NULL,        -- Nombre del producto
    description NVARCHAR(255),                  -- Descripción opcional
    price DECIMAL(10,2) NOT NULL,               -- Precio con 2 decimales
    stock INT NOT NULL DEFAULT 0,               -- Stock disponible

    CONSTRAINT FK_Products_Categories FOREIGN KEY (id_Category) 
        REFERENCES Categories(id_Category)      -- Relación con la tabla Categories
);

-- ==========================
-- TABLA SaleDetails
-- ==========================

CREATE TABLE dbo.SaleDetails
(
    id_Details   INT IDENTITY(1,1) NOT NULL PRIMARY KEY, -- PK
    id_Sale      INT NOT NULL,   -- FK con Sales
    id_Product   INT NOT NULL,   -- FK con Products
    Amount       INT NOT NULL,   -- cantidad
    unit_Price   DECIMAL(18,2) NOT NULL, -- precio unitario
    subtotal     DECIMAL(18,2) NOT NULL, -- Amount * Unit_Price

    CONSTRAINT FK_SaleDetails_Sales FOREIGN KEY (id_Sale) 
        REFERENCES dbo.Sales(id_Sale),

    CONSTRAINT FK_SaleDetails_Products FOREIGN KEY (id_Product) 
        REFERENCES dbo.Products(id_Product)
);
