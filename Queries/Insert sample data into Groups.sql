-- Insert sample data
USE Inventory
GO

INSERT INTO Groups (Name, Description, CategoryID)
VALUES 
	('Meat', 'Beef, pork, mutton', 1)
	,('Chicken and eggs', '', 1)
	,('Dairy', '', 1)
	,('Starches', '', 1)
	,('Fish', 'Including shelfish', 1)
	,('Condiments', '', 1)
	,('Snacks and treats', '', 1)
	,('Herbs and spices', '', 1)
	,('Pet food and treats', '', 1)
	,('Non-alcoholic beverages', 'Can be drunk by humans or pets, inluding powders such as coffee or hot chocolat', 1)
	,('Alcoholic beverages', 'For consumption by humans', 1)
;

SELECT * FROM Groups;