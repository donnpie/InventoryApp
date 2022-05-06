USE Inventory
GO

DROP PROC IF EXISTS SpInsertProduct
GO

CREATE PROC SpInsertProduct (
	@Barcode VARCHAR(50)
	,@GenericProductNameID INT
	,@BrandID INT
	,@ProductTradeName VARCHAR(50)
	,@Comments VARCHAR(255)
	,@ImageFileName VARCHAR(255)
)
AS
BEGIN
	INSERT INTO Products (Barcode, GenericProductNameID, BrandID, ProductTradeName, Comments, ImageFileName)
	VALUES 
		(@Barcode, @GenericProductNameID, @BrandID, @ProductTradeName, @Comments, @ImageFileName)
END