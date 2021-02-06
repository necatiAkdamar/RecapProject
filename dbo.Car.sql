CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NULL, 
    [ColorId] INT NULL, 
    [ModelYear] NVARCHAR(50) NULL, 
    [DailyPrice] MONEY NULL, 
    [Description] NVARCHAR(50) NULL
)
