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

-- Filter for barcode
DECLARE @Barcode VARCHAR(50)
SET @Barcode = '54491472'
SELECT 
	Pr.ID AS "Pr.ID"
	,Pr.Barcode AS "Pr.Barcode"
	,Pr.ProductTradeName AS "Pr.Name"
FROM Products AS Pr
WHERE Pr.Barcode = @Barcode