﻿CREATE TABLE [dbo].[Roles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Type] VARCHAR(50) NOT NULL, 
    [Created_at] DATETIME NULL, 
    [Updated_at] DATETIME NULL, 
    [User_created] INT NULL, 
    [User_updated] INT NULL
)
