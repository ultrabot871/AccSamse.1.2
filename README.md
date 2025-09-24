-- ==========================
-- CREACIÓN DE BASE DE DATOS
-- ==========================
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
    id_person   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name        NVARCHAR(100)     NOT NULL,
    last_Name   NVARCHAR(100)     NOT NULL,
    email       NVARCHAR(150)     NOT NULL,
    document    NVARCHAR(50)      NOT NULL,
    phone       NVARCHAR(30)      NULL,
    role        NVARCHAR(50)      NOT NULL,
    [password]  NVARCHAR(256)     NOT NULL,
    [state]     NVARCHAR(20)      NOT NULL
);

ALTER TABLE dbo.usuarios 
ADD CONSTRAINT UQ_usuarios_email UNIQUE (email),
    CONSTRAINT UQ_usuarios_document UNIQUE (document);

-- ==========================
-- TABLA Clientes
-- ==========================
CREATE TABLE dbo.Client
(
    id_Client   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name        NVARCHAR(100)     NOT NULL,
    last_Name   NVARCHAR(100)     NOT NULL,
    email       NVARCHAR(150)     NOT NULL,
    document    NVARCHAR(50)      NOT NULL,
    phone       NVARCHAR(30)      NULL
);

ALTER TABLE dbo.Client
ADD CONSTRAINT UQ_Client_email UNIQUE (email),
    CONSTRAINT UQ_Client_document UNIQUE (document);

-- ==========================
-- TABLA Pagos
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
    id_Sale     INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    id_person   INT NOT NULL,
    id_Client   INT NOT NULL,
    id_Payment  INT NOT NULL,
    date        DATETIME       NOT NULL DEFAULT(GETDATE()),
    total       DECIMAL(18,2)  NOT NULL,
    state       NVARCHAR(20)   NOT NULL,

    CONSTRAINT FK_Sales_Usuarios FOREIGN KEY (id_person)
        REFERENCES dbo.usuarios(id_person),

    CONSTRAINT FK_Sales_Client FOREIGN KEY (id_Client)
        REFERENCES dbo.Client(id_Client),

    CONSTRAINT FK_Sales_Payments FOREIGN KEY (id_Payment)
        REFERENCES dbo.Payments(id_Payment)
);

-- ==========================
-- TABLA Categorías
-- ==========================
CREATE TABLE dbo.Categories
(
    id_Category   INT IDENTITY(1,1) PRIMARY KEY,
    Name          NVARCHAR(100) NOT NULL,
    Description   NVARCHAR(255) NULL,
    Status        BIT NOT NULL DEFAULT 1,
    creation_Date DATETIME NOT NULL DEFAULT GETDATE()
);

-- ==========================
-- TABLA Productos
-- ==========================
CREATE TABLE dbo.Products
(
    id_product   INT IDENTITY(1,1) PRIMARY KEY,
    id_Category  INT NOT NULL,
    name         NVARCHAR(100) NOT NULL,
    description  NVARCHAR(255) NULL,
    price        DECIMAL(10,2) NOT NULL,
    stock        INT NOT NULL DEFAULT 0,

    CONSTRAINT FK_Products_Categories FOREIGN KEY (id_Category)
        REFERENCES dbo.Categories(id_Category)
);

-- ==========================
-- TABLA Detalles de Ventas
-- ==========================
CREATE TABLE dbo.SaleDetails
(
    id_Details  INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    id_Sale     INT NOT NULL,
    id_Product  INT NOT NULL,
    Amount      INT NOT NULL,
    unit_Price  DECIMAL(18,2) NOT NULL,
    subtotal    DECIMAL(18,2) NOT NULL,

    CONSTRAINT FK_SaleDetails_Sales FOREIGN KEY (id_Sale)
        REFERENCES dbo.Sales(id_Sale),

    CONSTRAINT FK_SaleDetails_Products FOREIGN KEY (id_Product)
        REFERENCES dbo.Products(id_product)
);

