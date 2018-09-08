
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/06/2018 11:09:13
-- Generated from EDMX file: C:\Users\kamel\Documents\Visual Studio 2017\Projects\TestEntityFrameworkJuly2018\TestEntityFrameworkJuly2018\Models\NorthwindEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [northwind];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [CustomerID] nchar(5)  NOT NULL,
    [CompanyName] nvarchar(40)  NOT NULL,
    [ContactName] nvarchar(30)  NULL,
    [ContactTitle] nvarchar(30)  NULL,
    [Address] nvarchar(60)  NULL,
    [City] nvarchar(15)  NULL,
    [Region] nvarchar(15)  NULL,
    [PostalCode] nvarchar(10)  NULL,
    [Country] nvarchar(15)  NULL,
    [Phone] nvarchar(24)  NULL,
    [Fax] nvarchar(24)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CustomerID] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([CustomerID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------