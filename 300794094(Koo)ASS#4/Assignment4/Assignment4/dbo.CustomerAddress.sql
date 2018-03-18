CREATE TABLE [dbo].[CustomerAddress]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [AddressId] INT NULL, 
    [AddressType] VARCHAR(50) NULL, 
    [rowguid] VARCHAR(50) NULL, 
    [ModifiedDate] VARCHAR(50) NULL
)
