SELECT * FROM dbo.Customers;
SELECT DISTINCT Country from dbo.Customers;
SELECT * FROM dbo.Customers WHERE CustomerID LIKE 'Bl';
SELECT TOP 100 * FROM dbo.Customers
SELECT * FROM dbo.Customers WHERE PostalCode = '1010' AND PostalCode = '3012' AND PostalCode = '12209' AND PostalCode = '05023';
SELECT * FROM dbo.Orders WHERE NOT ShipRegion= NULL;
SELECT * FROM dbo.Customers ORDER BY Country; SELECT * FROM dbo.Customers Order BY City;
INSERT INTO dbo.Customers (CustomerName, City,Country) VALUES ('Baron VonPoopenheimer III', 'Upper Lower East Managua', 'Unterland');
UPDATE dbo.Customers SET ShipRegion = 'EuroZone' WHERE ShipRegion = 'France';
DELETE FROM dbo.OrderDetails WHERE Quantity = 1;
SELECT AVG (Quantity) FROM dbo.OrderDetails; SELECT MIN (Quantity) FROM dbo.OrderDetails; SELECT MAX (Quantity) FROM dbo.OrderDetails;
SELECT CustomerID FROM dbo.OrderDetails WHERE OrderNumber = '10290';
SELECT * FROM dbo.Orders LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID; SELECT * FROM Orders INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID; SELECT * FROM dbo.Orders RIGHT JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
