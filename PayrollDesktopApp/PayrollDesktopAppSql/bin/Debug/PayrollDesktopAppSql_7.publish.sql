﻿/*
Deployment script for PayrollSystemDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "PayrollSystemDB"
:setvar DefaultFilePrefix "PayrollSystemDB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Starting rebuilding table [dbo].[tblUsers]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_tblUsers] (
    [UserId]      INT            IDENTITY (1, 1) NOT NULL,
    [UserName]    NVARCHAR (50)  NOT NULL,
    [Password]    NVARCHAR (50)  NOT NULL,
    [Roles]       NVARCHAR (50)  NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([UserName] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[tblUsers])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_tblUsers] ON;
        INSERT INTO [dbo].[tmp_ms_xx_tblUsers] ([UserName], [UserId], [Password], [Roles], [Description])
        SELECT   [UserName],
                 [UserId],
                 [Password],
                 [Roles],
                 [Description]
        FROM     [dbo].[tblUsers]
        ORDER BY [UserName] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_tblUsers] OFF;
    END

DROP TABLE [dbo].[tblUsers];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_tblUsers]', N'tblUsers';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Refreshing [dbo].[spInsertUser]...';


GO
EXECUTE sp_refreshsqlmodule N'[dbo].[spInsertUser]';


GO
PRINT N'Update complete.';


GO