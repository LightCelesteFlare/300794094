SELECT COUNT(*) FROM dbo.Customer WHERE CustomerId != @id 
INSERT INTO dbo.Customer (id,NameStyle,FirstName,LastName,Phone,Password,EmailAddress,CompanyName) VALUES (@id,@username,@FN,@LN,@phone,@password,@email,@Company);
