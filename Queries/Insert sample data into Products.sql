-- Insert sample data
USE Inventory
GO

EXEC SpInsertProduct 
	@Barcode = '54491472'
	,@GenericProductNameID = 8
	,@BrandID = 1
	,@ProductTradeName = 'Coke 500ml buddy'
	,@Comments = ''
	,@ImageFileName = 'Coke500mlBuddy202204291738.jpg'

EXEC SpInsertProduct 
	@Barcode = '5010055100001'
	,@GenericProductNameID = 9
	,@BrandID = 2
	,@ProductTradeName = 'Foster''s lager beer 440ml'
	,@Comments = ''
	,@ImageFileName = 'FostersLagerBeer440ml202204291739.jpg'

EXEC SpInsertProduct 
	@Barcode = '5010018003165'
	,@GenericProductNameID = 8
	,@BrandID = 3
	,@ProductTradeName = 'Premium lemonade 330ml'
	,@Comments = ''
	,@ImageFileName = 'PremiumLemonade330ml202204291740.jpg'

--SELECT * FROM Products;