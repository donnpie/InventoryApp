/*
Groups represent the second level of classification of products in the database
*/

USE Inventory
GO

--DROP TABLE IF EXISTS Groups;

CREATE TABLE Groups (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Name VARCHAR(50) NOT NULL UNIQUE
	,Description VARCHAR(255)
	,CategoryID INT FOREIGN KEY REFERENCES Categories(ID)
);