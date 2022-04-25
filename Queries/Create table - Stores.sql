/*
Stores represent the shops where consumer items are bought
*/

USE Inventory
GO

--DROP TABLE IF EXISTS Stores;

CREATE TABLE Stores (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Name VARCHAR(50) NOT NULL UNIQUE
	,Description VARCHAR(255)
);