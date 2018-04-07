CREATE TABLE [dbo].[Address] (
    [AddressId]     INT  IDENTITY(1,1)        NOT NULL,
    [AddressLine1]  NCHAR (10)   NOT NULL,
    [AddressLine2]  NCHAR (10)   NULL,
    [City]          VARCHAR (50) NOT NULL,
    [StateProvince] VARCHAR (50) NOT NULL,
    [CountryRegion] NCHAR (10)   NOT NULL,
    [PostalCode]    NCHAR (10)   NOT NULL,
    PRIMARY KEY CLUSTERED ([AddressId] ASC)
);

