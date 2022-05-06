USE Inventory
GO

CREATE PROC SpInsertBrand (
	@Name VARCHAR(50)
	,@Description VARCHAR(255)
)
AS
BEGIN
	INSERT INTO Brands(Name, Description)
	VALUES 
		(@Name, @Description)
END
