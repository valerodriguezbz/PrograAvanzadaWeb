CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NOT NULL, 
    [FirstLastName] VARCHAR(70) NOT NULL, 
    [City] VARCHAR(50) NOT NULL,
    [Address] VARCHAR(150) NOT NULL, 
    [PhoneNumber] INT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [created_at] DATETIME NOT NULL
)
