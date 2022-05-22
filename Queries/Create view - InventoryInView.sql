USE Inventory
GO

DROP VIEW IF EXISTS InventoryInView
GO

CREATE VIEW InventoryInView AS
(
	SELECT 
		Inv.ID AS "Inv.ID"
		,Inv.Date AS "Inv.Date"
		,Inv.Price AS "Inv.Price"

		,Prod.ID AS "Prod.ID"
		,Prod.Barcode AS "Prod.Barcode"
		,Prod.ProductTradeName AS "Prod.ProductTradeName"
		,Prod.Comments AS "Prod.Comments"
		,Prod.ImageFileName AS "Prod.ImageFileName"
		
		,Cat.ID AS "Cat.ID"
		,Cat.Name AS "Cat.CatName"
		,Cat.Description AS "Cat.CatDescription"

		,Gr.ID AS "Gr.ID"
		,Gr.Name AS "Gr.Name"
		,Gr.Description AS "Gr.Description"

		,Gen.ID AS "Gen.ID"
		,Gen.Name AS "Gen.Name"
		,Gen.Description AS "Gen.Description"

		,Br.ID AS "Br.ID"
		,Br.Name AS "Br.Name"
		,Br.Description AS "Br.Description"

		,St.ID AS "St.ID"
		,St.Name AS "St.Name"
		,St.Description AS "St.Description"
	FROM InventoryIn AS Inv
	JOIN Products AS Prod ON Inv.Barcode = Prod.Barcode
	JOIN Brands AS Br ON Prod.BrandID = Br.ID
	JOIN Stores AS St ON Inv.StoreID = St.ID
	JOIN GenericProductNames AS Gen ON Prod.GenericProductNameID = Gen.ID
	JOIN Groups AS Gr ON Gen.GroupID = Gr.ID
	JOIN Categories AS Cat ON Gr.CategoryID = Cat.ID
)
GO

SELECT * FROM InventoryInView;