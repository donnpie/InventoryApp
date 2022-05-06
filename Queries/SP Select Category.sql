USE Inventory
GO

DROP PROC IF EXISTS SpSelectCategoryAll
GO

CREATE PROC SpSelectCategoryAll
AS
BEGIN
	SELECT *
	FROM Categories AS C
END
GO

-- Test
EXEC SpSelectCategoryAll


-- Select from Categories for a given ID
DROP PROC IF EXISTS SpSelectCategory
GO

CREATE PROC SpSelectCategory (
	@ID INT
)
AS
BEGIN
	SELECT *
	FROM Categories AS C
	WHERE C.ID = @ID
END
GO

-- Test
EXEC SpSelectCategory 1
