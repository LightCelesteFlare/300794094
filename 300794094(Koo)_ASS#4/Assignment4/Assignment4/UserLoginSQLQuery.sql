CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL, 
    [NameStyle] VARCHAR(200) NULL, 
    [Title] VARCHAR(200) NULL, 
    [FirstName] VARCHAR(100) NULL, 
    [MiddleName] VARCHAR(100) NOT NULL, 
    [LastName] VARCHAR(100) NULL, 
    [Suffix] VARCHAR(10) NULL, 
    [CompanyName] VARCHAR(100) NULL, 
    [SalesPerson] VARCHAR(10) NULL, 
    [EmailAddress] VARCHAR(200) NOT NULL, 
    [Phone] INT NULL, 
    [Password] VARCHAR(50) NULL
	CONSTRAINT [PK_dbo.CustomerId] PRIMARY KEY ([CustomerId])
);

CREATE TABLE dbo.[Address]
(
	[AddressId] INT NOT NULL,
	[AddressLine1] VARCHAR(100) NOT NULL, 
    [AddressLing2] VARCHAR(100) NULL,
	[City] VARCHAR(100) NOT NULL,
	[StateProvince] VARCHAR(50) NOT NULL,
	[CountryRegion] VARCHAR(50) NOT NULL,
	[PostalCode] VARCHAR(10) NOT NULL, 
    CONSTRAINT [PK_Address] PRIMARY KEY ([AddressId])
);

CREATE TABLE dbo.[CustomerAddress]
(
	[CustomerId] INT NOT NULL,
	[AddressID] INT NOT NULL,
	[AddressType] VARCHAR(10) NOT NULL, 
    [rowguid] NCHAR(10) NOT NULL, 
    [ModifiedDate] DATE NOT NULL, 
    CONSTRAINT [PK_CustomerAddress] PRIMARY KEY ([CustomerId]),
	CONSTRAINT [FK_CustomerAddress] FOREIGN KEY ([AddressID]) REFERENCES dbo.Address ON DELETE CASCADE
);