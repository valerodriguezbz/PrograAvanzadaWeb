CREATE TABLE [dbo].[UsersRoles]
(
	[IdUser] INT NOT NULL PRIMARY KEY, 
    [IdRole] INT NOT NULL, 
    [created_at] DATETIME NOT NULL, 
    [updated_at] DATETIME NOT NULL, 
    CONSTRAINT [FK_UsersRoles_ToUsers] FOREIGN KEY (IdUser) REFERENCES Users(Id), 
    CONSTRAINT [FK_UsersRoles_ToRoles] FOREIGN KEY (IdRole) REFERENCES Roles(Id)
)
