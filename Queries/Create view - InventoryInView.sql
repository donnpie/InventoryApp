USE Inventory
GO

DROP VIEW IF EXISTS InventoryInView
GO

CREATE VIEW InventoryInView AS
(
	SELECT 
		Inv.ID AS "Inv.ID"
		,Inv.Barcode AS "Inv.Barcode"
		,Inv.StoreID AS "Inv.StoreID"
		,Inv.Date AS "Inv.Date"
		,Inv.Price AS "Inv.Price"
		,Prod.GenericProductNameID AS "Prod.GenericProductNameID"
		,Prod.BrandID AS "Prod.BrandID"
		,Prod.ProductTradeName AS "Prod.ProductTradeName"
		,Gen.ID AS "Gen.ID"
		,Gen.Name AS "Gen.GenericProdName"
		,Gen.GroupID AS "Gen.GroupID"
		,Gr.ID AS "Gr.ID"
		,Gr.Name AS "Gr.GroupName"
		,Gr.Description AS "Gr.Description"
		,Gr.CategoryID AS "Gr.CategoryID"
		,Cat.Name AS "Cat.CatName"
		,Cat.Description AS "Cat.CatDescription"
	FROM InventoryIn AS Inv
	JOIN Products AS Prod ON Inv.Barcode = Prod.Barcode
	JOIN Brands AS Br ON Prod.BrandID = Br.ID
	JOIN GenericProductNames AS Gen ON Prod.GenericProductNameID = Gen.ID
	JOIN Groups AS Gr ON Gen.GroupID = Gr.ID
	JOIN Categories AS Cat ON Gr.CategoryID = Cat.ID
)
GO

SELECT * FROM InventoryInView;