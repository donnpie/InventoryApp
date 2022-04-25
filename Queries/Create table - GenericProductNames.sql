/*
GenericProductNames represent the third and last level of classification of products in the database.
It is intended to describe the product in concrete detail, without using brands and trademarks.
Example: Cheese (Not Clover Cheese)
*/

USE Inventory
GO

--DROP TABLE IF EXISTS GenericProductNames;

CREATE TABLE GenericProductNames (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Name VARCHAR(50) NOT NULL UNIQUE
	,Description VARCHAR(255)
	,GroupID INT FOREIGN KEY REFERENCES Groups(ID)
);