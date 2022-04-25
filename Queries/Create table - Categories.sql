/*
Categroies represent the highest level of classification of products in the database
*/

USE Inventory
GO

--DROP TABLE IF EXISTS Categories;

CREATE TABLE Categories (
	ID INT IDENTITY(1, 1) PRIMARY KEY
	,Name VARCHAR(50) NOT NULL UNIQUE
	,Description VARCHAR(255)
);