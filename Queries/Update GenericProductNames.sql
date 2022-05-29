USE Inventory
GO

SELECT ID from GenericProductNames WHERE Name = 'Beer ale cyder'

UPDATE GenericProductNames 
SET Name = 'Beer ale cider' 
WHERE ID = 9 