CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdPerson] INT NOT NULL, 
    [PasswordHash] VARCHAR(255) NOT NULL, 
    CONSTRAINT [FK_Users_ToPeople] FOREIGN KEY (IdPerson) REFERENCES People(Id)
)
