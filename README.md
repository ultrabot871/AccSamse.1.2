# 📌 Base de Datos `AccSamseDb.1.2`

Este proyecto contiene la definición de la base de datos **AccSamseDb.1.2** y la tabla principal de usuarios.

---

## ⚙️ Creación de la Base de Datos

```sql
-- Crear base de datos (el nombre tiene punto, por eso va entre corchetes)
IF DB_ID(N'AccSamseDb.1.2') IS NULL
    CREATE DATABASE [AccSamseDb.1.2];
GO

USE [AccSamseDb.1.2];
GO

IF OBJECT_ID(N'dbo.usuarios', N'U') IS NOT NULL
    DROP TABLE dbo.usuarios;
GO

CREATE TABLE dbo.usuarios
(
    id_person   INT IDENTITY(1,1) NOT NULL PRIMARY KEY,   -- PK
    name        NVARCHAR(100)     NOT NULL,
    last_Name   NVARCHAR(100)     NOT NULL,
    email       NVARCHAR(150)     NOT NULL,
    document    NVARCHAR(50)      NOT NULL,
    phone       NVARCHAR(30)      NULL,

    role        NVARCHAR(50)      NOT NULL,
    [password]  NVARCHAR(256)     NOT NULL,               -- sugerido para hash
    [state]     NVARCHAR(20)      NOT NULL                -- ej. 'Activo'/'Inactivo'
);
GO


ALTER TABLE dbo.usuarios ADD CONSTRAINT UQ_usuarios_email    UNIQUE (email);
ALTER TABLE dbo.usuarios ADD CONSTRAINT UQ_usuarios_document UNIQUE (document);
GO
