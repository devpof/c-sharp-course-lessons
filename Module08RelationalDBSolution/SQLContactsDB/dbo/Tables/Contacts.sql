CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, --adding the keyword IDENTITY will make it auto-increment 
    [FirstName] NVARCHAR(50) NOT NULL, --NVARCHAR is so it can accept Unicode characters or like arabic characters
    [LastName] NVARCHAR(50) NOT NULL
)
