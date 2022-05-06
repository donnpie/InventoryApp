-- A variety of SELECT statements for the Brands table

USE Inventory
GO

SELECT 
	* 
FROM Brands

-- Filter for Brand names
DECLARE @Brand VARCHAR(50)
SET @Brand = 'Coc'
SELECT 
	Br.ID AS "Br.ID" 
	,Br.Name AS "Br.Name"
	,Br.Description AS "Br.Description"
FROM Brands AS Br
WHERE Br.Name LIKE ('%' + @Brand + '%')