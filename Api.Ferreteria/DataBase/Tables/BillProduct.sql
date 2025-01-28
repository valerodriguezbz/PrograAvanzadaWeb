CREATE TABLE [dbo].[BillProduct]
(
	[IdBill] INT NOT NULL PRIMARY KEY,
    [Name] VARCHAR(50) NOT NULL, 
    [Amount] INT NOT NULL, 
    [Price] FLOAT NOT NULL, 
    CONSTRAINT [FK_BillProduct_ToBills] FOREIGN KEY (IdBill) REFERENCES Bills(Id) 
)
