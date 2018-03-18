CREATE TABLE [dbo].[Address]
(
	[AddressId] INT NOT NULL PRIMARY KEY, 
    [AddressLine1] NCHAR(10) NOT NULL, 
    [AddressLine2] NCHAR(10) NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [StateProvince] VARCHAR(50) NOT NULL, 
    [CountryRegion] NCHAR(10) NOT NULL, 
    [PostalCode] NCHAR(10) NOT NULL
)
