--Да се създадат следните таблици в T-SQL:
--1. People:
--- FirstName ( стринг 16 символа) [Not null]
--- SurName ( стринг 16 символа) [ако има има ако не, няма проблем]
--- LastName ( стринг 16 символа) [Not null]
--- Age (int) [Not null]
--- Gender (bool) (true = male) [Not null]
--- Email (string 32) [ако има има ако не, няма проблем]
--- Town [Not null]
--2. Towns:
--- Name ( стринг 16 символа) [Not null]
--- Population (int) [Not null]
--- PostCode (string 8) [optional]
--- Country
--- Region (град) [Optional]
--3. Country:
--- Name ( стринг 16 символа) [Not null]
--- PopulationMilions (int) [Not null]
--- Designation (string 2) [Not null]
--- ContinentName [Not null]
--- Languages (string 64) [Not null]
--- Description (string 1024) [може и да няма]


CREATE DATABASE UPR1DB
USE UPR1DB
CREATE TABLE People(
	Id int PRIMARY KEY IDENTITY,
	FirstName nvarchar(16) NOT NULL,
	SurName nvarchar(16),
	LastName nvarchar(16) NOT NULL,
	Age int NOT NULL,
	Gender BIT NOT NULL,
	Email nvarchar(32) UNIQUE,
	Town int, --TODO FK
)
CREATE TABLE Countries (
	Designation nvarchar(2) PRIMARY KEY,
	Name nvarchar(16) NOT NULL,
	PopulationMilions int NOT NULL,
	ContinentName nvarchar(32) NOT NULL,
	Languages nvarchar(64) NOT NULL,
	Description nvarchar(1024)
)
CREATE TABLE Towns (
	Id int PRIMARY KEY,
	Name nvarchar(16) NOT NULL,
	Population int NOT NULL,
	PostCode nvarchar(8),
	CountryId nvarchar(2)NOT NULL CONSTRAINT FK_Towns_Countries
	FOREIGN KEY REFERENCES Countries(Designation),
	Region int CONSTRAINT FK_Towns_Towns
	FOREIGN KEY REFERENCES Towns(Id)
)

INSERT INTO Countries (Name,PopulationMilions,Designation,Languages,Description) VALUES
('Bulgaria',6.5,'BG','Europe','Bulgarian','Visoki sini planini, Reki I zlatni ravnini.'),
('Uganda',45,'UG','Africa','English','For God and My Country.'),
('USA',329,'US','South America','Spanish','E pluribus unum.')

INSERT INTO Towns(Id,Name,Population,PostCode,CountryId,Region)VALUES
('Shumen',89000,'9700','BG',null),
('Plovdiv',343000,'4000', 'BG',null),
('Smiadovo',4044,'9820','BG',1),
('Richmond',229000,'V4K','US',null),
('Kampala',1500000,'759125','UG',null)

SELECT * FROM Countries
SELECT * FROM Towns

DROP TABLE Towns
DROP TABLE People
DROP TABLE Countries


