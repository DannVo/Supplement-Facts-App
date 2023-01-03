USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingOrderDetail]    Script Date: 12/6/2022 8:26:49 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingOrderDetail](
	[orderID] [int] NOT NULL,
	[proID] [int] NOT NULL,
	[quantity] [int] NULL,
	[totalPrice] [float] NULL,
	
    CONSTRAINT FK_Detail_Order FOREIGN KEY ([orderID])
    REFERENCES TestingOrder([orderID]),
	CONSTRAINT FK_Product_Order FOREIGN KEY ([proID])
    REFERENCES TestingProduct([proID]),
) ON [PRIMARY]
GO

/* DROP */
DROP TABLE TestingOrderDetail;

/* DROP CONSTRAINT */
ALTER TABLE TestingOrderDetail
DROP CONSTRAINT FK_Detail_Order;

/* FOREIGN KEY, PRIMARY KEY */
ALTER TABLE [TestingOrderDetail]
ADD CONSTRAINT FK_Detail_Order
FOREIGN KEY ([orderID]) REFERENCES TestingOrder(orderID);

USE [WebDB]
GO

INSERT INTO [dbo].[TestingOrderDetail]
           ([orderID]
           ,[proID]
           ,[quantity])
     VALUES
           (1
           ,1
           ,14
           )
GO
INSERT INTO [dbo].[TestingOrderDetail]
           ([orderID]
           ,[proID]
           ,[quantity])
     VALUES
           (2
           ,5
           ,22
           )
GO
