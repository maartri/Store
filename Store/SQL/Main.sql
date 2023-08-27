IF NOT EXISTS(select 1 from sys.all_objects  where  name = (N'Product'))
BEGIN
	CREATE TABLE Product (
	 Id INT PRIMARY KEY IDENTITY(1,1),
	 [Name] VARCHAR(100),
	 [Price] DECIMAL(8,2)
	)
END

IF NOT EXISTS(select 1 from sys.all_objects  where  name = (N'Order'))
BEGIN
	CREATE TABLE [Order] (
	 Id INT PRIMARY KEY IDENTITY(1,1),
	 Total DECIMAL(8,2)
	)
END

IF NOT EXISTS(select 1 from sys.all_objects  where  name = (N'OrderItem'))
BEGIN
	CREATE TABLE [OrderItem] (
	 Id INT PRIMARY KEY IDENTITY(1,1),
	 ProductId INT,
	 OrderId INT,
	 Quantity INT,
	 FOREIGN KEY (ProductId) REFERENCES [Product](Id),
	 FOREIGN KEY (OrderId) REFERENCES [Order](Id)
	)
END