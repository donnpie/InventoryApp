USE Inventory
GO

DROP PROC IF EXISTS SpInsertGroup;
GO 

CREATE PROC SpInsertGroup (
	@Name VARCHAR(50)
	,@Description VARCHAR(255)
	,@CategoryID INT
)
AS
BEGIN
	INSERT INTO Groups(Name, Description, CategoryID)
	VALUES 
		(@Name, @Description, @CategoryID)
END