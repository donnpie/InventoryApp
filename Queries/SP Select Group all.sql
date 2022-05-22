USE [Inventory]
GO

/****** Object:  StoredProcedure [dbo].[SpSelectGroupAll]    Script Date: 2022/05/22 2:47:25 PM ******/
DROP PROCEDURE [dbo].[SpSelectGroupAll]
GO

CREATE PROC [dbo].[SpSelectGroupAll] 
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
END
GO


