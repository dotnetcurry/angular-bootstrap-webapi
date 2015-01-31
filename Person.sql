CREATE TABLE [dbo].[PersonInformation]
(
	[PersonId] INT identity PRIMARY KEY,
	[Title] varchar(10) Not Null,
	[FirstName] varchar(50) Not Null,
	[MiddleName] varchar(50) Not Null,
	[LastName] varchar(50) Not Null,
	[Gender] varchar(10) Not Null,
	[BirthDate] date Not Null,
	[Age] int Not Null,
	[CurrentAddress] varchar(100) Not Null,
	[PermanentAddress] varchar(100) Not Null,
	[Occupation] varchar(20) Not Null,
	[Email] varchar(50),
	[MobileNo] varchar(20) Not Null 
)
