USE Inventory
GO

SELECT
	P.GenericProductName AS Name
	,COUNT(InvIn.Barcode) AS QtyIn
	,COUNT(InvOut.Barcode) AS QtyOut
	,COUNT(InvIn.Barcode) - COUNT(InvOut.Barcode) AS Qty
FROM InventoryIn AS InvIn
LEFT JOIN ProductsView AS P ON InvIn.Barcode = P.Barcode
LEFT JOIN InventoryOut AS InvOut ON InvOut.Barcode = P.Barcode
GROUP BY 
	P.GenericProductName
ORDER BY
	Qty DESC

SELECT
	P.GenericProductName AS Name
FROM InventoryIn AS InvIn
JOIN ProductsView AS P ON InvIn.Barcode = P.Barcode
WHERE P.GenericProductName = 'Beer ale cyder'