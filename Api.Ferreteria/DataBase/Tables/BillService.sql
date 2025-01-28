CREATE TABLE [dbo].[BillService]
(
	[IdBill] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(50) NULL, 
    [Schedule] VARCHAR(50) NOT NULL, 
    [Price] FLOAT NOT NULL, 
    CONSTRAINT [FK_BillService_ToBills] FOREIGN KEY (IdBill) REFERENCES Bills(Id)
)
