CREATE TABLE [dbo].[Rentals]
(
	[RentalId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CarId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [RentDate] DATETIME NOT NULL, 
    [ReturnDate] DATETIME NULL,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)
)
