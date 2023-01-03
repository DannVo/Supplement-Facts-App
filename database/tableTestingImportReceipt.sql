USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingImportReceipt]    Script Date: 12/6/2022 8:47:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingImportReceipt](
	[receiptID] [int] IDENTITY,
	[receiptCode] [varchar](50) NOT NULL,
	[nameDeli] [nvarchar](250) NOT NULL,
	[codeCompanyDeli] [varchar](50) NOT NULL,
	[managerName] [nvarchar](250) NOT NULL,
	[quantityReceipt] [int] NOT NULL,
	[dateReceive] [datetime] DEFAULT GETDATE(),
	[paymethod] [nvarchar](250) NOT NULL DEFAULT 'Cash',
	[totalPrice] [float] NOT NULL,
	PRIMARY KEY ([receiptCode]),
    
) ON [PRIMARY] 
GO

/* DROP */
DROP TABLE [TestingImportReceipt];

/* FOREIGN KEY, PRIMARY KEY */
ALTER TABLE TestingImportReceipt
ADD CONSTRAINT FK_Product_ImpReceipt
FOREIGN KEY (proID) REFERENCES TestingProduct(proID);