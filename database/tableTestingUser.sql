USE [WebDB]
GO

/****** Object:  Table [dbo].[TestingUser]    Script Date: 12/7/2022 1:42:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestingUser](
	[id] [int] IDENTITY NOT NULL,
	[email] [nvarchar](max) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](50) NULL,
	[address] [nvarchar](250) NULL,
	[phone] [nvarchar](13) NULL,
	[createdAt] [datetime] DEFAULT GETDATE(),
	[status] [int] NULL DEFAULT 0,
	PRIMARY KEY([id])
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

USE [WebDB]
GO

DROP TABLE [dbo].[TestingUser]
      
USE [WebDB]
GO

INSERT INTO [dbo].[TestingUser]
           ([email]
           ,[password]
           ,[fullname]
           ,[address]
           ,[phone]
		   
           )
     VALUES
           ('user1@gmail.com'
           ,'user1ab'
           ,'Le Quoc Hung'
           ,'123 Pham Ngu Lao'
           ,'0914234662'
           )
GO

INSERT INTO [dbo].[TestingUser]
           ([email]
           ,[password]
           ,[fullname]
           ,[address]
           ,[phone]
		   ,[status]
           )
     VALUES
           ('admin1@gmail.com'
           ,'admin1ab'
           ,'Jonathan'
           ,'Street 16, Ward 7, District 10.'
           ,'09123116387'
		   ,1
           )
GO







