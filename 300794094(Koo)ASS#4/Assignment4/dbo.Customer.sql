CREATE TABLE [dbo].[Customer] (
    [CustomerId]   INT           NOT NULL,
    [NameStyle]    VARCHAR (50)  NULL,
    [Title]        VARCHAR (50)  NULL,
    [FirstName]    VARCHAR (50)  NULL,
    [MiddleName]   VARCHAR (50)  NULL,
    [LastName]     VARCHAR (50)  NULL,
    [Suffix]       VARCHAR (50)  NULL,
    [CompanyName]  VARCHAR (50)  NULL,
    [SalesPerson]  VARCHAR (50)  NULL,
    [EmailAddress] VARCHAR (100) NULL,
    [Phone]        VARCHAR (11)  NULL,
    [Password]     VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

