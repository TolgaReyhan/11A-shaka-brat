CREATE DATABASE RelationsDemoDB
GO
USE RelationsDemoDB
GO
CREATE TABLE Purposes(
	Id int PRIMARY KEY IDENTITY,
	Name nvarchar(16) NOT NULL,
	Description nvarchar (128)
)
GO
CREATE TABLE People(
	EGN nvarchar(4) PRIMARY KEY,
	Name nvarchar(32) NOT NULL,
	Age int NOT NULL,
	Email nvarchar(32) UNIQUE,
	Proffession nvarchar(32),
)
GO
CREATE TABLE Shops(
	Id int PRIMARY KEY IDENTITY,
	StartHour int NOT NULL,
	EndHour int NOT NULL,
)
GO
CREATE TABLE Addresses(
	Id int PRIMARY KEY IDENTITY,
	TownName nvarchar(16) NOT NULL,
	StreetName nvarchar(32) NOT NULL,
	[Description] nvarchar(128),
	StreetNumber int  NOT NULL UNIQUE
)

USE HoraDurjaviGradove
GO
DROP DATABASE RelationsDemoDB