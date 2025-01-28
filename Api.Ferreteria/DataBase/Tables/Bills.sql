CREATE TABLE [dbo].[Bills]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Tax] FLOAT NOT NULL, 
    [FinalPrice] FLOAT NOT NULL, 
    [PaymentAttachment] VARBINARY(MAX) NULL, 
    [PaymentConfirmation] BIT NOT NULL, 
    [created_at] DATETIME NOT NULL, 
    [updated_at] DATETIME NULL, 
    [this_id_user_updated] INT NULL, 
    CONSTRAINT [FK_Bills_ToUsers] FOREIGN KEY (this_id_user_updated) REFERENCES Users(Id)
)
