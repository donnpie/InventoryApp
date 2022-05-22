USE Inventory
GO

DROP PROC IF EXISTS SpSelectInventoryInBetweenDates
GO

CREATE PROC SpSelectInventoryInBetweenDates (
	@StartDate DATE
	,@EndDate DATE
)
AS
BEGIN
	SELECT 
		[Inv.Date]
		,[Inv.Price]
		,[Prod.ID]
		,[Cat.ID]
		,[Gr.ID]
		,[Gen.ID]
		,[Br.ID]
		,[St.ID]
	FROM InventoryInView 
	WHERE [Inv.Date] >= @StartDate AND [Inv.Date] <= @EndDate
END
GO


DECLARE @StartDate DATE
DECLARE @EndDate DATE

SET @StartDate = '20220501'
SET @EndDate = '20220531'

SELECT 
	[Inv.Date]
	,[Inv.Price]
	,[Prod.ID]
	,[Cat.ID]
	,[Gr.ID]
	,[Gen.ID]
	,[Br.ID]
	,[St.ID]
FROM InventoryInView 
WHERE [Inv.Date] >= @StartDate AND [Inv.Date] <= @EndDate

SELECT * FROM InventoryInView
GO








