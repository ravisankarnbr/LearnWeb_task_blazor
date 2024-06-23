USE [MaterialDB]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Material](
	[MaterialId] [int] IDENTITY(1,1) NOT NULL,
	[MaterialName] [varchar](50) NOT NULL,
	[MaterialUniqueName] [varchar](10) NOT NULL,
	[MaterialType] [varchar](50) NULL,
	[MaterialUse] [varchar](50) NULL,
	[Region] [varchar](50) NULL
) ON [PRIMARY]
GO
