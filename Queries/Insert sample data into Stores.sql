-- Insert sample data
USE Inventory
GO

INSERT INTO Stores(Name, Description)
VALUES 
	('Aldi', '')
	,('Tesco', '')
	,('Waitrose', '')
	,('Marks & Spencer', '')
	,('Cost Cutter', '')
	,('B&M', '')
	,('B&Q', '')
	,('Sainsbury', '')
	,('Holland & Barret', '')
	,('Pets at Home', '')
	,('Amazon', '')
;

SELECT * FROM Stores;