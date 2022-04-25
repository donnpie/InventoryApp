-- Insert sample data
USE Inventory
GO

INSERT INTO InventoryOut (Barcode, Date)
VALUES 
	('54491472', '2022-04-25')
	,('5010055100001', '2022-04-25')
	,('5010018003165', '2022-04-25')
;

SELECT * FROM InventoryOut;