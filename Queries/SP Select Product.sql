USE Inventory
GO

DROP PROC IF EXISTS SpSelectGroup
GO

CREATE PROC SpSelectGroup (
	@CatergoryId INT
)
AS
BEGIN
	SELECT *
	FROM Groups AS G
	JOIN Categories AS C ON G.CategoryID = C.ID
	WHERE C.ID = @CatergoryId
END


-- Test
EXEC SpSelectGroup 1