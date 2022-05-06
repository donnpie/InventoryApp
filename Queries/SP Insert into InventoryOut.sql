USE Inventory
GO

DROP PROC IF EXISTS SpInsertInventoryOut;
GO 

CREATE PROC SpInsertInventoryOut (
	@Barcode VARCHAR(50)
	,@Date DATE
)
AS
BEGIN
	INSERT INTO InventoryOut(Barcode, Date)
	VALUES 
		(@Barcode, @Date)
END
