CREATE DATABASE[Minions]

USE[Minions]

CREATE TABLE[Users]
(
[Id] INT PRIMARY KEY IDENTITY,
[Username] VARCHAR(30) NOT NULL,
[Password] VARCHAR(26) NOT NULL,
[ProfilePicture] VARBINARY(MAX)
CHECK(DATALENGTH([ProfilePicture]) <= 900000),
[LastLoginTime] DATETIME,
[IsDeleted] VARCHAR(5) NOT NULL,
CHECK ([IsDeleted] = 'true' OR [IsDeleted] = 'false')
)

INSERT INTO[Users]([Username], [Password], [IsDeleted]) VALUES

('Pesho', 'pesho2789', 'true'),
('Muss', 'dsd56464', 'false'),
('Sezgo', 'sad5asd5', 'false'),
('Meto', 'sdasd6546464', 'true'),
('Lilia', 'lila54646', 'false')

SELECT * FROM [Users]

ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC0721956677

ALTER TABLE Users
ADD CONSTRAINT Pk_IdUsername PRIMARY KEY(Id, Username)


ALTER TABLE Users
ADD CONSTRAINT DF_LastLoginTime DEFAULT GETDATE() FOR LastLoginTime

ALTER TABLE Users
DROP CONSTRAINT Pk_IdUsername

ALTER TABLE Users
ADD CONSTRAINT Pk_Id PRIMARY KEY(Id)

ALTER TABLE Users
ADD CONSTRAINT CH_UsernameIsLeast3Symbol
CHECK (LEN(Username) > 3)