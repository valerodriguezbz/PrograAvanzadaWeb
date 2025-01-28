CREATE TABLE [dbo].[CartService]
(
	[IdCart] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [IdService] INT NOT NULL, 
    CONSTRAINT [FK_CartService_ToCarts] FOREIGN KEY (IdCart) REFERENCES Carts(Id), 
    CONSTRAINT [FK_CartService_ToServices] FOREIGN KEY (IdService) REFERENCES Services(Id) 
)
