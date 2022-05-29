USE Inventory
GO

SELECT TOP(10) * FROM ProductsView

SELECT ID, ProductTradeName, Barcode FROM Products WHERE ProductTradeName LIKE '%ice%' 
SELECT ID, ProductTradeName, Barcode FROM Products WHERE ProductTradeName LIKE '%brown%' 
SELECT ProductId, ProductTradeName FROM ProductsView WHERE GroupName LIKE '%alc%' 
SELECT BrandId, BrandName FROM ProductsView WHERE BrandName LIKE '%tesco%' 

SELECT
	Inv.ID AS [Inv.ID]
	,P.ProductTradeName AS [P.Name]
	,S.ID AS [S.ID]
	,S.Name AS [S.Name]
FROM InventoryIn AS Inv
INNER JOIN Products AS P ON Inv.Barcode = P.Barcode
INNER JOIN GenericProductNames AS Gen on P.GenericProductNameID = Gen.ID
INNER JOIN Stores as S on Inv.StoreID = S.ID
WHERE Gen.Name LIKE '%ice%'

SELECT * FROM Stores WHERE Name IN ('ALDI', 'Tesco')

DECLARE @ID INT
DECLARE @Barcode VARCHAR(50)
DECLARE @GenericProductNameID INT
DECLARE @BrandID INT
DECLARE @ProductTradeName VARCHAR(50)
DECLARE @Comments VARCHAR(255)
DECLARE @ImageFileName VARCHAR(255)

UPDATE Products 
SET Barcode = @Barcode
,GenericProductNameID = @GenericProductNameID
,BrandID = @BrandID
,ProductTradeName = @ProductTradeName
,Comments = @Comments
,ImageFileName = @ImageFileName
WHERE ID = @ID

UPDATE Products 
SET ProductTradeName = 'Madagascan vanilla & brownies ice cream' 
WHERE ID = 97

UPDATE Products 
SET BrandID = 11 
WHERE ID = 100

UPDATE InventoryIn 
SET StoreID = 2
WHERE ID = 62

UPDATE InventoryIn 
SET Price = 3.75
WHERE ID = 88 --InventoryIn ID!!!