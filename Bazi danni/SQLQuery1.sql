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


CREATE TABLE Countries(
Designation nvarchar(2) PRIMARY KEY,
Name nvarchar(16) NOT NULL,
PopulationMilions int NOT NULL ,
ContinentName nvarchar(32) NOT NULL,
Languages nvarchar(64) NOT NULL,
Description nvarchar(1024) 
)

GO

CREATE TABLE Towns(
Id int PRIMARY KEY,
Name nvarchar(16) NOT NULL,
Population int NOT NULL ,
PostCode nvarchar(8) NOT NULL,
CountryId nvarchar(2) NOT NULL CONSTRAINT FK_Towns_Countries
FOREIGN KEY REFERENCES Countries(Designation),
Region int CONSTRAINT FK_Towns_Towns
FOREIGN KEY REFERENCES Towns(Id),
)

GO

CREATE TABLE People(
Id int PRIMARY KEY,
FirstName nvarchar(16) NOT NULL ,
SurName nvarchar(16) ,
LastName nvarchar(16) NOT NULL ,
Age int NOT NULL,
Gender bit, 
Email nvarchar(32) UNIQUE,
TownId int NOT NULL CONSTRAINT FK_People_Towns
FOREIGN KEY REFERENCES Towns(Id) 
)

INSERT INTO Countries(Name, PopulationMilions, Designation, ContinentName, Languages,Description) VALUES
('Bulgaria',6.5,'BG','Europe','Bulgarian','Visoki sini planini, Reki I zlatni ravnini.'),
('Uganda',45,'UG','Africa','English','For God and My Country'),
('USA',329,'US','South America','English, Spanish','E pluribus unum')

INSERT INTO Towns(Id,Name,Population,PostCode,CountryId,Region ) VALUES
(1,'Shumen',89000,'9700','BG',1),
(22,'Plovdiv',343000,'4000', 'BG',22),
(3,'Smiadovo',4044,'9820', 'BG',1),
(5,'Kampala',1500000,'759125','UG',5),
(6,'Kaolinovo',1000,'9701','BG',1)

INSERT INTO Towns(Name,Population, PostCode, CountryId, Region ) VALUES
 ('Varna',350000,'1700','BG', 6	)
 
INSERT INTO People(Id,FirstName,SurName,LastName,Age,Gender,Email,TownId) VALUES
(1,'Kosta','Ivanov','Mladenov',35,1,'kom@abv.bg',3),
(2,'Malinka','Kalinova','Ivanova',25,0,'malimali@yahoo.com',22),
(3,'Kamelia','Amelieva','Preslavova',21,0,'kamali@gmail.com',1),
(4,'Marin','Tomislavov','Goleminov',40,1,'marin_g@gmail.com',1),
(5,'Sambo','Viktor','Dontworry',58,1,'sambomambo@ugabuga.com',5),
(6,'John','Bob','Marley',17,1,'johnybegood@yahoo.com.',4),
(7,'Jessica', 'Jehna', 'Jahmeson', 27,0,'jehna27@gmail.com.', 4)

SELECT * FROM Countries
SELECT * FROM Towns
SELECT * FROM People

DROP TABLE Towns
DROP TABLE Countries
DROP TABLE People

