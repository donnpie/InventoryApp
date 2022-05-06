-- Insert sample data
USE Inventory
GO

--SELECT * FROM InventoryIn;

EXEC SpInsertInventoryIn 
	@Barcode = '54491472'
	,@StoreID = 1
	,@Date = '2022-04-25'
	,@Price = 1.00

EXEC SpInsertInventoryIn 
	@Barcode = '5010055100001'
	,@StoreID = 1
	,@Date = '2022-04-25'
	,@Price = 1.5

EXEC SpInsertInventoryIn 
	@Barcode = '5010018003165'
	,@StoreID = 1
	,@Date = '2022-04-25'
	,@Price = 0.90