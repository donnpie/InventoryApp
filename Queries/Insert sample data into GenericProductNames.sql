-- Insert sample data
USE Inventory
GO

--SELECT * FROM GenericProductNames;

EXEC SpInsertGenericProductName 
	@Name = 'Beef'
	,@Description = ''
	,@GroupID = 1

EXEC SpInsertGenericProductName 
	@Name = 'Pork'
	,@Description = ''
	,@GroupID = 1

EXEC SpInsertGenericProductName 
	@Name = 'Mutton'
	,@Description = ''
	,@GroupID = 1

EXEC SpInsertGenericProductName 
	@Name = 'Chicken'
	,@Description = ''
	,@GroupID = 2

EXEC SpInsertGenericProductName 
	@Name = 'Eggs'
	,@Description = ''
	,@GroupID = 2

EXEC SpInsertGenericProductName 
	@Name = 'Milk'
	,@Description = ''
	,@GroupID = 3

EXEC SpInsertGenericProductName 
	@Name = 'Cheese'
	,@Description = ''
	,@GroupID = 3

EXEC SpInsertGenericProductName 
	@Name = 'Softdrink'
	,@Description = ''
	,@GroupID = 10

EXEC SpInsertGenericProductName 
	@Name = 'Beer'
	,@Description = ''
	,@GroupID = 11
