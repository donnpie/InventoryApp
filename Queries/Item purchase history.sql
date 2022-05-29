USE Inventory
GO

SELECT TOP(10) * FROM InventoryIn
SELECT ID, ProductTradeName FROM Products WHERE ProductTradeName LIKE '%%' 
SELECT ProductId, ProductTradeName FROM ProductsView WHERE GroupName LIKE '%non-%' 

SELECT
	Inv.Date AS Date
	,P.ProductTradeName AS Name
	,S.Name AS Store
	--,COUNT(Inv.Date) AS QTY
	,SUM(Inv.Price) / COUNT(Inv.Date) AS AvgUnitCost
FROM InventoryIn AS Inv
INNER JOIN Products AS P ON Inv.Barcode = P.Barcode
INNER JOIN GenericProductNames AS Gen on P.GenericProductNameID = Gen.ID
INNER JOIN Stores as S on Inv.StoreID = S.ID
WHERE Gen.Name LIKE '%beer%'
GROUP BY
	Inv.Date
	,P.ProductTradeName
	,S.Name