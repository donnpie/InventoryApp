USE Inventory
GO

DROP PROC IF EXISTS SpInsertInventoryIn;
GO 

CREATE PROC SpInsertInventoryIn (
	@Barcode VARCHAR(50)
	,@StoreID INT
	,@Date DATE
	,@Price FLOAT
)
AS
BEGIN
	INSERT INTO InventoryIn(Barcode, StoreID, Date, Price)
	VALUES 
		(@Barcode, @StoreID, @Date, @Price)
END