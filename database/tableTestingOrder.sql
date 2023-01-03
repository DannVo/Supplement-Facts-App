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
	[cusName] [nvarchar](50) NULL,
	[address] [nvarchar](250) NULL,
	[payMethod] [nvarchar](50) NULL DEFAULT 'Cash',
	[totalPay] [float] NULL,
	[createdAt] [datetime] DEFAULT GETDATE(),
	[statusText] [nvarchar](50) DEFAULT 'Waiting',
	[status] [int] DEFAULT 1,
	
	PRIMARY KEY([orderID]),
) ON [PRIMARY]
GO

/* DROP */
DROP TABLE TestingOrder;




ALTER TABLE TestingOrder
DROP COLUMN orderID;

USE [WebDB]
GO

INSERT INTO [dbo].[TestingOrder]
           ([orderName]
           ,[cusName]
           ,[address]
           ,[payMethod])
     VALUES
           ('CID001'
           ,'Le Quoc Hung'
           ,'123 Pham Ngu Lao'
           ,'Cash')
			
GO
INSERT INTO [dbo].[TestingOrder]
           ([orderName]
           ,[cusName]
           ,[address]
           ,[payMethod])
     VALUES
           ('CID002'
           ,'Le Quoc Hung'
           ,'123 Pham Ngu Lao'
           ,'Cash')
			
GO






