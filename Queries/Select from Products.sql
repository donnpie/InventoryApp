-- A variety of SELECT statements for the Products table

USE Inventory
GO

SELECT 
	* 
FROM Products;

SELECT 
	* 
FROM Products
WHERE ProductTradeName LIKE '%coke%'; -- % is a wildcard that matches any character

