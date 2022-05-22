USE [Inventory]
GO

/****** Object:  StoredProcedure [dbo].[SpSelectGenericProductNameAll]    Script Date: 2022/05/22 2:49:53 PM ******/
DROP PROCEDURE [dbo].[SpSelectGenericProductNameAll]
GO

CREATE PROC [dbo].[SpSelectGenericProductNameAll] 
AS
BEGIN
	SELECT
		Gen.ID AS ID
		,Gen.Name AS Name
		,Gen.Description AS Description
		,Groups.ID AS GroupID
		,Groups.Name AS GroupName
		,Groups.Description AS GroupDescription
		,Categories.ID AS CategoryID
		,Categories.Name AS CategoryName
		,Categories.Description AS CategoryDescription
	FROM Groups AS Groups
	JOIN Categories AS Categories ON Groups.CategoryID = Categories.ID
	JOIN GenericProductNames AS Gen ON Gen.GroupID = Groups.ID
END
GO


