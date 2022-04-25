/*
Brands represent the companies that supply products, although it is not strictly the same as the legal entity that constitutes a company.
It is intended to describe where a product comes from.
For no-name products, use the name of the store if possible, else use "No name"
*/

USE Inventory
GO

--DROP TABLE IF EXISTS Brands;

CREATE TABLE Brands (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Name VARCHAR(50) NOT NULL UNIQUE
	,Description VARCHAR(255)
);