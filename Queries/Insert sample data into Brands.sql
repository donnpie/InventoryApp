-- Insert sample data
USE Inventory
GO

INSERT INTO Brands(Name, Description)
VALUES 
	('Cocacola', '')
	,('Foster''s', '')
	,('R White''s', '')
;

SELECT * FROM Brands;