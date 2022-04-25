-- Insert sample data
USE Inventory
GO

INSERT INTO Products (Barcode, GenericProductNameID, BrandID, ProductTradeName)
VALUES 
	('54491472', 8, 1, 'Coke 500ml buddy')
	,('5010055100001', 9, 2, 'Foster''s lager beer 440ml')
	,('5010018003165', 8, 3, 'Premium lemonade 330ml')
;

SELECT * FROM Products;