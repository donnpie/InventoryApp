/*
Products represents consumer products.
Each product must have a barcode
*/

USE Inventory
GO

--DROP TABLE IF EXISTS Products;

CREATE TABLE Products (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Barcode VARCHAR(50) NOT NULL UNIQUE
	,GenericProductNameID INT FOREIGN KEY REFERENCES GenericProductNames(ID)
	,BrandID INT FOREIGN KEY REFERENCES Brands(ID)
	,ProductTradeName VARCHAR(50) NOT NULL UNIQUE
	,Image BINARY
	,Comments VARCHAR(255)
);