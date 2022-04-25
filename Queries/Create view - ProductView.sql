--USE Inventory
--GO

DROP VIEW IF EXISTS ProductsView
GO

CREATE VIEW ProductsView AS
(
	SELECT 
		P.ID
		,P.Barcode
		,P.ProductTradeName
		,P.GenericProductNameID
		,Gen.Name AS GenericProductName
		,P.BrandID
		,Br.Name AS BrandName
		,Gen.GroupID
		,Gr.Name AS GroupName
		,Gr.CategoryID
		,Cat.Name AS CategoryName
	FROM Products AS P
	JOIN GenericProductNames AS Gen ON P.GenericProductNameID = Gen.ID
	JOIN Brands AS Br ON P.BrandID = Br.ID
	JOIN Groups AS Gr ON Gen.GroupID = Gr.ID
	JOIN Categories AS Cat ON Gr.CategoryID = Cat.ID
);