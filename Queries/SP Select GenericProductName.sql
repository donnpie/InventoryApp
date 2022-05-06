USE Inventory
GO

DROP PROC IF EXISTS SpSelectGenericProductName
GO

CREATE PROC SpSelectGenericProductName (
	@GroupId INT
)
AS
BEGIN
	SELECT
		Gen.ID AS GenericProductNameID
		,Gen.Name AS GenericProductName
		,Gen.Description AS GenericProductDescription
	FROM GenericProductNames AS Gen
	WHERE Gen.GroupID = @GroupId
END
GO


-- Test
EXEC SpSelectGenericProductName 1