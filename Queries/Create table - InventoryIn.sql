/*
InventoryIn represents transactions where new stock is added to the database
*/

USE Inventory
GO

--DROP TABLE IF EXISTS InventoryIn;

CREATE TABLE InventoryIn (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Barcode VARCHAR(50) FOREIGN KEY REFERENCES Products(Barcode)
	,StoreID INT FOREIGN KEY REFERENCES Stores(ID)
	,Date DATE
	,Price FLOAT
);