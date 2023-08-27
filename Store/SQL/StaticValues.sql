IF NOT EXISTS (SELECT TOP 1 Id FROM Roles where Roles.Rolename = 'Administrator')
BEGIN
	INSERT INTO Roles(Id,Rolename) VALUES (100, 'Administrator')
END
GO

IF NOT EXISTS (SELECT TOP 1 Id FROM Roles where Roles.Rolename = 'Cashier')
BEGIN
	INSERT INTO Roles(Id,Rolename) VALUES (200,'Cashier')
END
GO

