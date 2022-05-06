USE Inventory
GO

DROP PROC IF EXISTS SpInsertCategory;
GO 

CREATE PROC SpInsertCategory (
	@Name VARCHAR(50)
	,@Description VARCHAR(255)
)
AS
BEGIN
	INSERT INTO Categories(Name, Description)
	VALUES 
		(@Name, @Description)
END
