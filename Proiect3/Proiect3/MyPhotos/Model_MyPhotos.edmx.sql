
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/07/2020 22:32:40
-- Generated from EDMX file: C:\Users\iusti\OneDrive\Documents\GitHub\TS.Net\Proiect\MyPhotos\MyPhotos\Model_MyPhotos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotosPlaces_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_PhotosPlaces_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPersons_Photo_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPersons_Photo] DROP CONSTRAINT [FK_PhotosPersons_Photo_Photos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPersons_Photo_Persons_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPersons_Photo] DROP CONSTRAINT [FK_PhotosPersons_Photo_Persons_Photo];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmsPersons_Films]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FilmsPersons] DROP CONSTRAINT [FK_FilmsPersons_Films];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmsPersons_Persons]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FilmsPersons] DROP CONSTRAINT [FK_FilmsPersons_Persons];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmsPlaces_Photo_Films]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FilmsPlaces_Photo] DROP CONSTRAINT [FK_FilmsPlaces_Photo_Films];
GO
IF OBJECT_ID(N'[dbo].[FK_FilmsPlaces_Photo_Places_Photo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FilmsPlaces_Photo] DROP CONSTRAINT [FK_FilmsPlaces_Photo_Places_Photo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Films]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Films];
GO
IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID(N'[dbo].[Places]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Places];
GO
IF OBJECT_ID(N'[dbo].[PhotosPersons_Photo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosPersons_Photo];
GO
IF OBJECT_ID(N'[dbo].[FilmsPersons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FilmsPersons];
GO
IF OBJECT_ID(N'[dbo].[FilmsPlaces_Photo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FilmsPlaces_Photo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Photo_Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Event] nvarchar(max)  NULL,
    [Landscape] nvarchar(max)  NULL,
    [Path] nvarchar(max)  NULL,
    [Places_Photo_Place_Id] int  NOT NULL
);
GO

-- Creating table 'Films'
CREATE TABLE [dbo].[Films] (
    [Film_Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NULL,
    [Event] nvarchar(max)  NULL,
    [Landscape] nvarchar(max)  NULL,
    [Path] nvarchar(max)  NULL
);
GO

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [Person_Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Places'
CREATE TABLE [dbo].[Places] (
    [Place_Id] int IDENTITY(1,1) NOT NULL,
    [Country] nvarchar(max)  NULL,
    [City] nvarchar(max)  NULL,
    [Region] nvarchar(max)  NULL
);
GO

-- Creating table 'PhotosPersons_Photo'
CREATE TABLE [dbo].[PhotosPersons_Photo] (
    [Photos_Photo_Id] int  NOT NULL,
    [Persons_Photo_Person_Id] int  NOT NULL
);
GO

-- Creating table 'FilmsPersons'
CREATE TABLE [dbo].[FilmsPersons] (
    [Films_Film_Id] int  NOT NULL,
    [Persons_Person_Id] int  NOT NULL
);
GO

-- Creating table 'FilmsPlaces_Photo'
CREATE TABLE [dbo].[FilmsPlaces_Photo] (
    [Films_Film_Id] int  NOT NULL,
    [Places_Photo_Place_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Photo_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Photo_Id] ASC);
GO

-- Creating primary key on [Film_Id] in table 'Films'
ALTER TABLE [dbo].[Films]
ADD CONSTRAINT [PK_Films]
    PRIMARY KEY CLUSTERED ([Film_Id] ASC);
GO

-- Creating primary key on [Person_Id] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([Person_Id] ASC);
GO

-- Creating primary key on [Place_Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Place_Id] ASC);
GO

-- Creating primary key on [Photos_Photo_Id], [Persons_Photo_Person_Id] in table 'PhotosPersons_Photo'
ALTER TABLE [dbo].[PhotosPersons_Photo]
ADD CONSTRAINT [PK_PhotosPersons_Photo]
    PRIMARY KEY CLUSTERED ([Photos_Photo_Id], [Persons_Photo_Person_Id] ASC);
GO

-- Creating primary key on [Films_Film_Id], [Persons_Person_Id] in table 'FilmsPersons'
ALTER TABLE [dbo].[FilmsPersons]
ADD CONSTRAINT [PK_FilmsPersons]
    PRIMARY KEY CLUSTERED ([Films_Film_Id], [Persons_Person_Id] ASC);
GO

-- Creating primary key on [Films_Film_Id], [Places_Photo_Place_Id] in table 'FilmsPlaces_Photo'
ALTER TABLE [dbo].[FilmsPlaces_Photo]
ADD CONSTRAINT [PK_FilmsPlaces_Photo]
    PRIMARY KEY CLUSTERED ([Films_Film_Id], [Places_Photo_Place_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Places_Photo_Place_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_PhotosPlaces_Photo]
    FOREIGN KEY ([Places_Photo_Place_Id])
    REFERENCES [dbo].[Places]
        ([Place_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPlaces_Photo'
CREATE INDEX [IX_FK_PhotosPlaces_Photo]
ON [dbo].[Photos]
    ([Places_Photo_Place_Id]);
GO

-- Creating foreign key on [Photos_Photo_Id] in table 'PhotosPersons_Photo'
ALTER TABLE [dbo].[PhotosPersons_Photo]
ADD CONSTRAINT [FK_PhotosPersons_Photo_Photos]
    FOREIGN KEY ([Photos_Photo_Id])
    REFERENCES [dbo].[Photos]
        ([Photo_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persons_Photo_Person_Id] in table 'PhotosPersons_Photo'
ALTER TABLE [dbo].[PhotosPersons_Photo]
ADD CONSTRAINT [FK_PhotosPersons_Photo_Persons_Photo]
    FOREIGN KEY ([Persons_Photo_Person_Id])
    REFERENCES [dbo].[Persons]
        ([Person_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPersons_Photo_Persons_Photo'
CREATE INDEX [IX_FK_PhotosPersons_Photo_Persons_Photo]
ON [dbo].[PhotosPersons_Photo]
    ([Persons_Photo_Person_Id]);
GO

-- Creating foreign key on [Films_Film_Id] in table 'FilmsPersons'
ALTER TABLE [dbo].[FilmsPersons]
ADD CONSTRAINT [FK_FilmsPersons_Films]
    FOREIGN KEY ([Films_Film_Id])
    REFERENCES [dbo].[Films]
        ([Film_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Persons_Person_Id] in table 'FilmsPersons'
ALTER TABLE [dbo].[FilmsPersons]
ADD CONSTRAINT [FK_FilmsPersons_Persons]
    FOREIGN KEY ([Persons_Person_Id])
    REFERENCES [dbo].[Persons]
        ([Person_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmsPersons_Persons'
CREATE INDEX [IX_FK_FilmsPersons_Persons]
ON [dbo].[FilmsPersons]
    ([Persons_Person_Id]);
GO

-- Creating foreign key on [Films_Film_Id] in table 'FilmsPlaces_Photo'
ALTER TABLE [dbo].[FilmsPlaces_Photo]
ADD CONSTRAINT [FK_FilmsPlaces_Photo_Films]
    FOREIGN KEY ([Films_Film_Id])
    REFERENCES [dbo].[Films]
        ([Film_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Places_Photo_Place_Id] in table 'FilmsPlaces_Photo'
ALTER TABLE [dbo].[FilmsPlaces_Photo]
ADD CONSTRAINT [FK_FilmsPlaces_Photo_Places_Photo]
    FOREIGN KEY ([Places_Photo_Place_Id])
    REFERENCES [dbo].[Places]
        ([Place_Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilmsPlaces_Photo_Places_Photo'
CREATE INDEX [IX_FK_FilmsPlaces_Photo_Places_Photo]
ON [dbo].[FilmsPlaces_Photo]
    ([Places_Photo_Place_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------