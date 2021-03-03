CREATE TABLE [dbo].[Customers]
(
	[CustomerId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [UserId] INT NOT NULL,
	[CompanyName] NVARCHAR(50) NOT NULL, 
    FOREIGN KEY ([UserId]) REFERENCES Users(UserId)
)
