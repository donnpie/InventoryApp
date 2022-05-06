USE Inventory
GO

DROP PROC IF EXISTS SpInsertGenericProductName;
GO 

CREATE PROC SpInsertGenericProductName (
	@Name VARCHAR(50)
	,@Description VARCHAR(255)
	,@GroupID INT
)
AS
BEGIN
	INSERT INTO GenericProductNames(Name, Description, GroupID)
	VALUES 
		(@Name, @Description, @GroupID)
END