USE Inventory
GO

DROP PROC IF EXISTS SpUpdateProduct
GO

CREATE PROC SpUpdateProduct(
	@ID INT
	,@Barcode VARCHAR(50)
	,@GenericProductNameID INT
	,@BrandID INT
	,@ProductTradeName VARCHAR(50)
	,@Comments VARCHAR(255)
	,@ImageFileName VARCHAR(255)
)
AS
BEGIN
	UPDATE Products 
	SET 
		Barcode = @Barcode
		,GenericProductNameID = @GenericProductNameID
		,BrandID = @BrandID
		,ProductTradeName = @ProductTradeName
		,Comments = @Comments
		,ImageFileName = @ImageFileName
	WHERE ID = @ID
END

EXEC SpUpdateProduct 1, '123', 1, 1, 'sdf', 'asdfs', 'asdfa'

SELECT * FROM Products WHERE ID = '121'