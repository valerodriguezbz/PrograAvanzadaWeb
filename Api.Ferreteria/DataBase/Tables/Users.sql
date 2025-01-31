CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [IdPerson] INT NOT NULL, 
    [PasswordHash] VARCHAR(255) NOT NULL, 
    [Created_at] DATETIME NULL, 
    [Updated_at] DATETIME NULL, 
    [user_created] INT NULL, 
    [user_modified] INT NULL, 
    CONSTRAINT [FK_Users_ToPeople] FOREIGN KEY (IdPerson) REFERENCES People(Id)
)
