USE Inventory
GO

DROP PROC IF EXISTS SpSelectGroup
GO

CREATE PROC SpSelectGroup (
	@CategoryId INT
)
AS
BEGIN
	SELECT
		Groups.ID AS ID
		,Groups.Name AS Name
		,Groups.Description AS Description
		,Categories.ID AS CategoryID
		,Categories.Name AS CategoryName
		,Categories.Description AS CategoryDescription
	FROM Groups AS Groups
	JOIN Categories AS Categories ON Groups.CategoryID = Categories.ID
	WHERE CategoryID = @CategoryID
END
GO

-- Test
EXEC SpSelectGroup 1