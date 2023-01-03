USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingImportDetailProd]]   Script Date: 12/6/2022 8:47:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingImportDetailProd](
	[receiptCode] [varchar](50) NOT NULL,
	[proID] [int] NOT NULL,
	[proName] [nvarchar](50) NOT NULL,
	[proImg] [nvarchar](250) NULL,
	[proDesc] [nvarchar](max) NULL,
	[quantity] [int] NOT NULL,
	[priceReceive] [float] NOT NULL,
    
) ON [PRIMARY] 
GO

/* DROP */
DROP TABLE [TestingImportDetailProd];

/* FOREIGN KEY, PRIMARY KEY */
ALTER TABLE [TestingImportDetailProd]
ADD CONSTRAINT FK_ImpReceipt_ImpDetail
FOREIGN KEY ([receiptCode]) REFERENCES TestingImportReceipt([receiptCode]);