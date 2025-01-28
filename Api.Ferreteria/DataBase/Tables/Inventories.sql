﻿CREATE TABLE [dbo].[Inventories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [IdProduct] UNIQUEIDENTIFIER NOT NULL, 
    [IdSupplier] UNIQUEIDENTIFIER NOT NULL, 
    [Stock] INT NOT NULL, 
    [created_at] DATETIME NOT NULL, 
    [updated_at] DATETIME NULL, 
    [this_id_user_create] INT NOT NULL, 
    CONSTRAINT [FK_Inventories_ToUsers] FOREIGN KEY (this_id_user_create) REFERENCES Users(Id)
)
