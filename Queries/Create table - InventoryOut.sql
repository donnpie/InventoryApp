/*
InventoryOut represents transactions where new stock is removed from the database
*/

USE Inventory
GO

--DROP TABLE IF EXISTS InventoryOut;

CREATE TABLE InventoryOut (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Barcode VARCHAR(50) FOREIGN KEY REFERENCES Products(Barcode)
	,Date DATE
);