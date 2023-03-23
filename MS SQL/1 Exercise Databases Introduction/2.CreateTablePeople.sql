CREATE DATABASE[Minions]

USE[Minions]

CREATE TABLE [People](
[Id] INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(200) NOT NULL,
CHECK ([Gender] = 'm' OR [Gender] = 'f'),
[Picture] VARBINARY(MAX)
CHECK(DATALENGTH([Picture]) <= 2000000),
[Height] DECIMAL(3, 2),
[Weight] DECIMAL(5, 2),
[Gender] CHAR(1) NOT NULL,
[Birthdate] DATE NOT NULL,
[Biography] NVARCHAR(MAX))


INSERT INTO[People](
[Name], [Height], [Weight]
, [Gender], [Birthdate])

VALUES
('Mus', 1.68, 75.2, 'm', '1986.07.25'),
('Kris', 1.78, 78.2, 'm', '1995.07.20'),
('Silvia', 1.65, 56.3, 'f', '1999.12.03'),
('Eva', 1.72, 49.2, 'f', '2001.04.14'),
('Delcho', 1.80, 90, 'm', '1977.08.04')

SELECT * FROM[People]


