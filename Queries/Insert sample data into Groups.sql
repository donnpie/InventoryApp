-- Insert sample data
USE Inventory
GO

--SELECT * FROM Groups;

EXEC SpInsertGroup 
	@Name = 'Meat'
	,@Description = 'Beef, pork, mutton'
	,@CategoryID = 1

EXEC SpInsertGroup  
	@Name = 'Chicken and eggs'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Dairy'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Starches'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Fish'
	,@Description = 'Including shelfish'
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Condiments'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Snacks and treats'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Herbs and spices'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Pet food and treats'
	,@Description = ''
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Non-alcoholic beverages'
	,@Description = 'Can be drunk by humans or pets, inluding powders such as coffee or hot chocolate'
	,@CategoryID = 1

EXEC SpInsertGroup
	@Name = 'Alcoholic beverages'
	,@Description = 'For consumption by humans'
	,@CategoryID = 1


