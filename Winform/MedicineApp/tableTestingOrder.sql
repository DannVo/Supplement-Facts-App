USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingOrder]    Script Date: 12/6/2022 7:41:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingOrder](
	[orderID] [int] IDENTITY NOT NULL,
	[orderName] [nvarchar](50) NULL DEFAULT 'ORDER NO NAME',
	[statusText] [nvarchar](50) DEFAULT 'Waiting',
	[status] [int] DEFAULT 1,
	[payMethod] [nvarchar](50) NULL,
	[totalPay] [float] NULL,
	[createdAt] [datetime] DEFAULT GETDATE(),
	[cusName] [nvarchar](50) NULL,
	[address] [nvarchar](250) NULL,
	
	PRIMARY KEY([orderID]),
) ON [PRIMARY]
GO

/* DROP */
DROP TABLE TestingOrder;




ALTER TABLE TestingOrder
DROP COLUMN orderID;






