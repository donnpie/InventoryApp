USE [Inventory]
GO

/****** Object:  StoredProcedure [dbo].[SpSelectInventoryInBetweenDates]    Script Date: 2022/05/25 5:08:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SpSelectInventoryOutBetweenDates] (
	@StartDate DATE
	,@EndDate DATE
)
AS
BEGIN
	SELECT 
		[Inv.Date]
		,[Prod.ID]
		,[Cat.ID]
		,[Gr.ID]
		,[Gen.ID]
		,[Br.ID]
	FROM InventoryOutView 
	WHERE [Inv.Date] >= @StartDate AND [Inv.Date] <= @EndDate
END
GO


