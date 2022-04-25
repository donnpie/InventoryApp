-- Insert sample data
USE Inventory
GO

INSERT INTO Categories (Name, Description)
VALUES 
	('Food and drink', 'Anything that is consumable by humans or pets')
	,('Pharmaceuticals', 'Any kind of medicine, whether ingested or not. Inludes things like supplements and first aid')
	,('Cleaning materials', 'Any kind of household cleaning material, such as washing powder or fabric softner')
	,('Hygiene and self care', 'Anything used to clean and groom oneself, eg deodorant, shampoo, toothpaste')
;