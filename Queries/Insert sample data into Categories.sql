-- Insert sample data
USE Inventory
GO

EXEC SpInsertCategory (
	@Name = 'Food and drink'
	,@Description = 'Anything that is consumable by humans or pets'
)

EXEC SpInsertCategory (
	@Name = 'Pharmaceuticals'
	,@Description = 'Any kind of medicine, whether ingested or not. Inludes things like supplements and first aid'
)

EXEC SpInsertCategory (
	@Name = 'Cleaning materials'
	,@Description = 'Any kind of household cleaning material, such as washing powder or fabric softner'
)

EXEC SpInsertCategory (
	@Name = 'Hygiene and self care'
	,@Description = 'Anything used to clean and groom oneself, eg deodorant, shampoo, toothpaste'
)