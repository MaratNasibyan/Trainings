USE Fund
GO

CREATE TABLE dbo.Fundraiser
(
	[FundraiserId] BIGINT NOT NULL IDENTITY(1, 1),
	[FirstName]  NVARCHAR(MAX) NULL,
	[LastName] NVARCHAR(MAX) NULL,
	[Email] NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[CreateDate] DATETIME ,
	[ModifyDate] DATETIME NULL,
	[IsActive] BIT,

	CONSTRAINT PK_Fundraiser PRIMARY KEY ([FundraiserId])
)

GO
