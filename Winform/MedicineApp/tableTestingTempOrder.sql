USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingTempOrder]    Script Date: 12/9/2022 11:21:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingTempOrder](
	[tempID] [int] IDENTITY NOT NULL,
	[cusID] [int] NULL,
	[proID] [int] NULL,
	[quantity] [int] NULL,
	PRIMARY KEY([tempID]),


) ON [PRIMARY]
GO

/* DROP */
DROP TABLE TestingTempOrder;

/* FOREIGN KEY, PRIMARY KEY */
/* NOT ADDED */
ALTER TABLE [TestingTempOrder]
ADD CONSTRAINT FK_TempOrder_User
FOREIGN KEY ([cusID]) REFERENCES TestingUser(id);
