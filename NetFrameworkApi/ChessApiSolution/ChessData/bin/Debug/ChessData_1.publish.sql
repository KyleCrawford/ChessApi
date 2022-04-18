﻿/*
Deployment script for ChessData

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ChessData"
:setvar DefaultFilePrefix "ChessData"
:setvar DefaultDataPath "C:\Users\Kyle Crawford\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\Kyle Crawford\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

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
PRINT N'Creating Table [dbo].[Game]...';


GO
CREATE TABLE [dbo].[Game] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Code]        NVARCHAR (50)  NOT NULL,
    [Name]        NVARCHAR (100) NOT NULL,
    [BoardData]   NVARCHAR (MAX) NOT NULL,
    [CreatedDate] DATETIME2 (7)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating Table [dbo].[User]...';


GO
CREATE TABLE [dbo].[User] (
    [Id]          NVARCHAR (128) NOT NULL,
    [Username]    NVARCHAR (50)  NOT NULL,
    [Email]       NVARCHAR (256) NULL,
    [CreatedDate] DATETIME2 (7)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating Table [dbo].[UserGame]...';


GO
CREATE TABLE [dbo].[UserGame] (
    [GameId]    INT            NOT NULL,
    [PlayerOne] NVARCHAR (128) NOT NULL,
    [PlayerTwo] NVARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([GameId] ASC)
);


GO
PRINT N'Creating Foreign Key [dbo].[FK_UserGame_ToGame]...';


GO
ALTER TABLE [dbo].[UserGame] WITH NOCHECK
    ADD CONSTRAINT [FK_UserGame_ToGame] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Game] ([Id]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_UserGame_ToUserOne]...';


GO
ALTER TABLE [dbo].[UserGame] WITH NOCHECK
    ADD CONSTRAINT [FK_UserGame_ToUserOne] FOREIGN KEY ([PlayerOne]) REFERENCES [dbo].[User] ([Id]);


GO
PRINT N'Creating Foreign Key [dbo].[FK_UserGame_ToUserTwo]...';


GO
ALTER TABLE [dbo].[UserGame] WITH NOCHECK
    ADD CONSTRAINT [FK_UserGame_ToUserTwo] FOREIGN KEY ([PlayerTwo]) REFERENCES [dbo].[User] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[UserGame] WITH CHECK CHECK CONSTRAINT [FK_UserGame_ToGame];

ALTER TABLE [dbo].[UserGame] WITH CHECK CHECK CONSTRAINT [FK_UserGame_ToUserOne];

ALTER TABLE [dbo].[UserGame] WITH CHECK CHECK CONSTRAINT [FK_UserGame_ToUserTwo];


GO
PRINT N'Update complete.';


GO
