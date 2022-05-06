-- Insert sample data
USE Inventory
GO

EXEC SpInsertInventoryOut
	@Barcode = '54491472'
	,@Date = '2022-04-25'


EXEC SpInsertInventoryOut 
	@Barcode = '5010055100001'
	,@Date = '2022-04-25'

EXEC SpInsertInventoryOut 
	@Barcode = '5010018003165'
	,@Date = '2022-04-25'

--SELECT * FROM InventoryOut;