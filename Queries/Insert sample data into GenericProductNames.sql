-- Insert sample data
USE Inventory
GO

INSERT INTO GenericProductNames(Name, Description, GroupID)
VALUES 
	('Beef', '', 1)
	,('Pork', '', 1)
	,('Mutton', '', 1)
	,('Chicken', '', 2)
	,('Eggs', '', 2)
	,('Milk', '', 3)
	,('Cheese', '', 3)
	,('Softdrink', '', 10)
	,('Beer', '', 11)
;

SELECT * FROM GenericProductNames;