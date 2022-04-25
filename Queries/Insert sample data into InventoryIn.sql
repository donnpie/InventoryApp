-- Insert sample data
USE Inventory
GO

INSERT INTO InventoryIn (Barcode, StoreID, Date, Price)
VALUES 
	('54491472', 1, '2022-04-25', 1.00)
	,('5010055100001', 1, '2022-04-25', 1.50)
	,('5010018003165', 1, '2022-04-25', 0.90)
;

SELECT * FROM InventoryIn;