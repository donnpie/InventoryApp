USE Inventory
GO

SELECT 
	I.ID
	,ProductTradeName AS Name
	,Price
FROM InventoryIn AS I
JOIN Products AS P ON I.Barcode = P.Barcode
WHERE Date = '2022-05-24'

--Analysis of shopping on a given day
SELECT 
	ProductTradeName AS Name
	,COUNT(Price) AS Qty
	,SUM(Price) AS Amount
	,SUM(Price) / COUNT(Price) AS UnitPrice
FROM InventoryIn AS I
JOIN Products AS P ON I.Barcode = P.Barcode
WHERE Date = '2022-05-24'
GROUP BY
	ProductTradeName
ORDER BY
	Amount DESC

--Purchase history for given product
SELECT 
	I.ID
	,GPN.Name AS GenericName
	,ProductTradeName AS ProductName
	,Date
	,Price
FROM InventoryIn AS I
JOIN Products AS P ON I.Barcode = P.Barcode
JOIN GenericProductNames AS GPN ON P.GenericProductNameID = GPN.ID
WHERE P.Barcode = '5449000239662'







