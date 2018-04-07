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
;
CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [NameStyle] VARCHAR(50) NULL, 
    [Title] VARCHAR(50) NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [MiddleName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Suffix] VARCHAR(50) NULL, 
    [CompanyName] VARCHAR(50) NULL, 
    [SalesPerson] VARCHAR(50) NULL, 
    [EmailAddress] VARCHAR(100) NULL, 
    [Phone] VARCHAR(11) NULL, 
    [Password] VARCHAR(50) NULL
)
;
CREATE TABLE [dbo].[CustomerAddress]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
    [AddressId] INT NULL, 
    [AddressType] VARCHAR(50) NULL, 
    [rowguid] VARCHAR(50) NULL, 
    [ModifiedDate] VARCHAR(50) NULL
)
