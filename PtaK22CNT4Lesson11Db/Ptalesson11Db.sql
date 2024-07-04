USE [PtaK22CNT4Lessson11Db]
GO
/****** Object:  Table [dbo].[PtaCategory]    Script Date: 7/4/2024 9:50:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaCategory](
	[PtaID] [int] IDENTITY(1,1) NOT NULL,
	[PtaCateName] [nvarchar](50) NULL,
	[PtaStatus] [bit] NULL,
 CONSTRAINT [PK_PtaCategory] PRIMARY KEY CLUSTERED 
(
	[PtaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtaProduct]    Script Date: 7/4/2024 9:50:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaProduct](
	[PtaID2210900087] [nvarchar](50) NOT NULL,
	[PtaProName] [nvarchar](50) NULL,
	[PtaQty] [int] NULL,
	[PtaPrice] [float] NULL,
	[PtaCateId] [int] NULL,
	[PtaActive] [bit] NULL,
 CONSTRAINT [PK_PtaProduct] PRIMARY KEY CLUSTERED 
(
	[PtaID2210900087] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PtaCategory] ON 

INSERT [dbo].[PtaCategory] ([PtaID], [PtaCateName], [PtaStatus]) VALUES (1, N'2210900087', 1)
INSERT [dbo].[PtaCategory] ([PtaID], [PtaCateName], [PtaStatus]) VALUES (2, N'Iphone', 0)
SET IDENTITY_INSERT [dbo].[PtaCategory] OFF
GO
INSERT [dbo].[PtaProduct] ([PtaID2210900087], [PtaProName], [PtaQty], [PtaPrice], [PtaCateId], [PtaActive]) VALUES (N'2210900087', N'Phan Truong Anh', 10, 100, 1, 1)
INSERT [dbo].[PtaProduct] ([PtaID2210900087], [PtaProName], [PtaQty], [PtaPrice], [PtaCateId], [PtaActive]) VALUES (N'P001', N'Iphone 15', 2, 200, 2, 0)
GO
ALTER TABLE [dbo].[PtaProduct]  WITH CHECK ADD  CONSTRAINT [FK_PtaProduct_PtaCategory] FOREIGN KEY([PtaCateId])
REFERENCES [dbo].[PtaCategory] ([PtaID])
GO
ALTER TABLE [dbo].[PtaProduct] CHECK CONSTRAINT [FK_PtaProduct_PtaCategory]
GO
