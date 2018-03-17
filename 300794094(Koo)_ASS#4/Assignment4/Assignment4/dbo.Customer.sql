CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL PRIMARY KEY, 
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
	CONSTRAINT [PK_dbo.CustomerAddress] PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);
