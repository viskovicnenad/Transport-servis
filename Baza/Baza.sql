USE [master]
GO
CREATE DATABASE [TransportDB]
GO
USE [TransportDB]
GO

CREATE TABLE [dbo].[SERVIS](
	[ID] [nvarchar] (10) NOT NULL PRIMARY KEY,
	[Ime] [nvarchar] (30) NOT NULL,
	[Cena] int not null,
	[IdKorisnika] [nvarchar] (10) NOT NULL,
	[IdDrzave] [nvarchar] (10) NOT NULL
)
GO

CREATE TABLE [dbo].[DRZAVA](
	[ID] [nvarchar] (10) NOT NULL PRIMARY KEY,
	[Ime] [nvarchar] (30) NOT NULL
)
GO

CREATE TABLE [dbo].[KORISNIK](
	[ID] [nvarchar] (10) NOT NULL PRIMARY KEY,
	[Ime] [nvarchar](30) NOT NULL,
	[Prezime] [nvarchar](30) NOT NULL
)
GO

ALTER TABLE [dbo].[SERVIS] ADD CONSTRAINT
[FK_SERVIS_KORISNIK] FOREIGN KEY([IdKorisnika])
REFERENCES [dbo].[KORISNIK]([ID])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[SERVIS] ADD CONSTRAINT
[FK_SERVIS_DRZAVA] FOREIGN KEY([IdDrzave])
REFERENCES [dbo].[DRZAVA]([ID])
ON UPDATE CASCADE
GO

