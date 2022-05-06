-- Insert sample data
USE Inventory
GO

EXEC SpInsertBrand
	@Name = 'Cocacola'
	,@Description = '';

EXEC SpInsertBrand
	@Name = 'Foster''s'
	,@Description = '';

EXEC SpInsertBrand
	@Name = 'R White''s'
	,@Description = '';

--SELECT * FROM Brands;