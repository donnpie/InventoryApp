-- A variety of SELECT statements for the Groups table

USE Inventory
GO

-- Basic select
SELECT 
	* 
FROM Groups

-- Filter for groups belonging to a specific category
DECLARE @CatName VARCHAR(50)
SET @CatName = 'Food'
SELECT 
	G.ID AS "G.ID" 
	,G.Name AS "G.Name"
	,G.Description AS "G.Description"
	,G.CategoryID AS "G.CategoryID"
	,C.ID AS "C.ID"
	,C.Name AS "C.Name"
	,C.Description AS "C.Description"
FROM Groups AS G
JOIN Categories AS C on G.CategoryID = C.ID
WHERE C.Name LIKE ('%' + @CatName + '%')