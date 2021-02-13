CREATE TABLE [dbo].[Cars]
(
	[CarId] INT NOT NULL PRIMARY KEY, 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] INT NOT NULL, 
    [DailyPrice] INT NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL
)
