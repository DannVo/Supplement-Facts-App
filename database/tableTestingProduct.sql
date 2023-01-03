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
           ('NOW Foods, EcoGreen Multi'
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/now/now03788/l/32.jpg'
           ,'While iHerb strives to ensure the accuracy of its product images and information, some manufacturing changes to packaging and/or ingredients may be pending update on our site.'
           ,10000
           ,26.28
           ,24.18)
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
           ('California Nutrition,Men’s Multi Vitamin Gummies'
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/cgn/cgn01198/v/51.jpg'
           ,'California Gold Nutrition Men’s Multivitamin Gummies provides a convenient way to add essential nutrients into your diet, which can help support a healthy lifestyle.*'
           ,10000
           ,9.14
           ,7.16)
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
           ('Super Nutrition, SimplyOne, Men Multivitamin'
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/spn/spn00215/v/113.jpg'
           ,'Super Nutrition SimplyOne Men’s Multivitamin + Supporting Herbs makes it easy to cover the nutritional basics with one tablet a day.'
           ,10000
           ,14.69
           ,10.77)
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
           ('California Gold Nutrition, Omega-3 Premium'
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/mli/mli00952/v/218.jpg'
           ,'Omega-3 fatty acids are one type of “good fat” found in many fish sources that your body can use to support various functions. '
           ,10000
           ,7.62
           ,5.24)
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
           ('California Gold Nutrition, Vitamin D3, 125 mcg '
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/mli/mli00952/v/218.jpg'
           ,'California Gold Nutrition Vitamin D3 contains this preferred form of vitamin D. When taken daily, this supplement may help to support bone and immune health.'
           ,10000
           ,4.57
           ,3.54)
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
           ('CollagenUP, Hydrolyzed Marine Collagen Peptides'
           ,'https://cloudinary.images-iherb.com/image/upload/f_auto,q_auto:eco/images/cgn/cgn01033/l/178.jpg'
           ,'California Gold Nutrition CollagenUP contains all three of these ingredients to help support healthy hair, skin, nails, joints, and bones'
           ,10000
           ,18.50
           ,15.43)
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




