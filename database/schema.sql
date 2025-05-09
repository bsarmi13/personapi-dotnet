-- SQL Server Script
-- -----------------------------------------------------
-- Database: persona_db
-- -----------------------------------------------------

-- Create the database if it doesn't exist
IF NOT EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = 'persona_db')
BEGIN
    CREATE DATABASE persona_db;
    ALTER AUTHORIZATION ON DATABASE::persona_db TO sa;
END
GO

USE persona_db;
GO

-- -----------------------------------------------------
-- Table persona_db.persona
-- -----------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'persona') AND type in (N'U'))
BEGIN
    CREATE TABLE persona (
        cc INT NOT NULL,
        nombre VARCHAR(45) NOT NULL,
        apellido VARCHAR(45) NOT NULL,
        genero CHAR(1) NOT NULL,
        edad INT NULL,
        PRIMARY KEY (cc),
        CONSTRAINT CK_persona_genero CHECK (genero IN ('M', 'F'))
    );
END
GO

-- -----------------------------------------------------
-- Table persona_db.profesion
-- -----------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'profesion') AND type in (N'U'))
BEGIN
    CREATE TABLE profesion (
        id INT NOT NULL,
        nom VARCHAR(90) NOT NULL,
        des NVARCHAR(MAX) NULL,
        PRIMARY KEY (id)
    );
END
GO

-- -----------------------------------------------------
-- Table persona_db.estudios
-- -----------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'estudios') AND type in (N'U'))
BEGIN
    CREATE TABLE estudios (
        id_prof INT NOT NULL,
        cc_per INT NOT NULL,
        fecha DATE NULL,
        univer VARCHAR(50) NULL,
        PRIMARY KEY (id_prof, cc_per)
    );

    ALTER TABLE estudios
    ADD CONSTRAINT FK_estudios_persona FOREIGN KEY (cc_per)
        REFERENCES persona (cc);

    ALTER TABLE estudios
    ADD CONSTRAINT FK_estudios_profesion FOREIGN KEY (id_prof)
        REFERENCES profesion (id);
END
GO

-- -----------------------------------------------------
-- Table persona_db.telefono
-- -----------------------------------------------------
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'telefono') AND type in (N'U'))
BEGIN
    CREATE TABLE telefono (
        num VARCHAR(15) NOT NULL,
        oper VARCHAR(45) NOT NULL,
        duenio INT NOT NULL,
        PRIMARY KEY (num)
    );

    ALTER TABLE telefono
    ADD CONSTRAINT FK_telefono_persona FOREIGN KEY (duenio)
        REFERENCES persona (cc);
END
GO