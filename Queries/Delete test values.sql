SELECT * FROM Categories;
DELETE FROM Categories WHERE Name LIKE 'Test%'

SELECT * FROM Groups;
DELETE FROM Groups WHERE Name LIKE 'Test%'

SELECT * FROM GenericProductNames;
DELETE FROM GenericProductNames WHERE Name LIKE 'Test%'

SELECT * FROM Stores;
DELETE FROM Stores WHERE Name LIKE 'Test%'

SELECT * FROM Brands;
DELETE FROM Brands WHERE Name LIKE 'Test%'

SELECT * FROM Products;
DELETE FROM Products WHERE ProductTradeName LIKE 'Test%'

SELECT * FROM InventoryIn;
DELETE FROM InventoryIn WHERE Barcode = '4088600427003' AND Date = '2022-05-20'