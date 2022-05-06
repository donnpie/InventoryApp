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
		ID AS ID
		,Name AS Name
		,Description AS Description
	FROM Groups
	WHERE CategoryID = @CategoryID
END
GO

-- Test
EXEC SpSelectGroup 1