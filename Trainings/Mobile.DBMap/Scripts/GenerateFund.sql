USE Fund
GO

CREATE TABLE dbo.Fundraiser
(
	[FundraiserId] BIGINT NOT NULL IDENTITY(1, 1),
	[FirstName]  NVARCHAR(MAX) NULL,
	[LastName] NVARCHAR(MAX) NULL,
	[Email] NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[CreateDate] DATETIME NOT NULL,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT,

	CONSTRAINT PK_Fundraiser_FundraiserId PRIMARY KEY ([FundraiserId])
)

GO

CREATE TABLE dbo.Donate
(
	[DonateId] BIGINT NOT NULL IDENTITY(1, 1),
	[Money] MONEY NOT NULL,
	[FundraiserId] BIGINT NOT NULL,
	[CreateDate] DATETIME NOT NULL,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT

	CONSTRAINT PK_Donate_DonateId PRIMARY KEY ([DonateId])
	CONSTRAINT FK_Fundraiser_Donate FOREIGN KEY ([FundraiserId]) REFERENCES Fundraiser([FundraiserId])
)

GO

CREATE TABLE dbo.People
(
	[PeopleId] BIGINT NOT NULL IDENTITY(1, 1),
	[CreateDate] DATETIME NOT NULL,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT

	CONSTRAINT PK_People_PeopleId PRIMARY KEY ([PeopleId])
)

GO	

CREATE TABLE dbo.FundraiserPeople
(
	[FundraiserPeopleId] BIGINT NOT NULL IDENTITY(1, 1),
	[FundraiserId] BIGINT NOT NULL,
	[PeopleId] BIGINT NOT NULL,
	[CreateDate] DATETIME NOT NULL,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT

	CONSTRAINT PK_FundraiserPeople_FundraiserPeopleId PRIMARY KEY ([FundraiserPeopleId]),
	CONSTRAINT FK_Fundraiser_People FOREIGN KEY ([FundraiserId]) REFERENCES Fundraiser(FundraiserId),
	CONSTRAINT FK_People_Fundraiser FOREIGN KEY ([PeopleId]) REFERENCES People([PeopleId])
)

GO

CREATE TABLE dbo.Pictures
(
	[PictureId] BIGINT NOT NULL IDENTITY(1, 1),
	[PicturePath] NVARCHAR(MAX) NOT NULL,
	[CreateDate] DATETIME NOT NULL,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT

	CONSTRAINT PK_Pictures_PictureId PRIMARY KEY ([PictureId])
)