USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingProduct]    Script Date: 12/6/2022 8:47:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingProduct](
	[proID] [int] IDENTITY,
	[proName] [nvarchar](50) NOT NULL,
	[proImg] [nvarchar](250) NULL,
	[proDesc] [nvarchar](max) NULL,
	[quantity] [int] NOT NULL,
	[priceDeli] [float] NOT NULL,
	[priceReceived] [float] NOT NULL,
	[dateReceive] [datetime] DEFAULT GETDATE(),
	[dateDeli] [datetime] NULL,
	PRIMARY KEY ([proID]),
    
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/* DROP */
DROP TABLE [TestingProduct];

/* FOREIGN KEY, PRIMARY KEY */
ALTER TABLE Orders
ADD CONSTRAINT FK_ProductOrder
FOREIGN KEY (proID) REFERENCES TestingProduct(proID);

/* INSERT */
USE [WebDB]
GO

INSERT INTO [dbo].[TestingProduct]
           ([proName]
           ,[proImg]
           ,[proDesc]
           ,[quantity]
           ,[priceDeli]
           ,[priceReceived]
           )
     VALUES
           ('Adrenal Stimulator'
           ,'https://cdn.shopify.com/s/files/1/0773/5985/products/AdrenalStimulator_-ADRENAL_NCFM_large.jpg?v=1589984748'
           ,'Adrenal Stabilizer is a comprehensive blend of standardized extracts of the highest-quality adaptogenic herbs plus three B vitamins.'
           ,10000
           ,300.000
           ,200.000)
GO
INSERT INTO [dbo].[TestingProduct]
           ([proName]
           ,[proImg]
           ,[proDesc]
           ,[quantity]
           ,[priceDeli]
           ,[priceReceived]
           )
     VALUES
           ('ICAPS Vision Health'
           ,'https://cdn11.bigcommerce.com/s-fe8s4uj/images/stencil/1920w/products/39245/103834/apipboe0j__43282.1606847546.jpg?c=2'
           ,'Provides a wide spectrum of important ingredients shown to support healthy eyes and vision.* With 10 mg of lutein and 2 mg of zeaxanthin, shown to help promote eye health.'
           ,10000
           ,17.000
           ,15.000)
GO

/* SELECT */
USE [WebDB]
GO

SELECT [proID]
      ,[proName]
      ,[proImg]
      ,[proDesc]
      ,[quantity]
      ,[priceDeli]
      ,[priceReceived]
      ,[dateReceive]
      ,[dateDeli]
  FROM [dbo].[TestingProduct]

GO




