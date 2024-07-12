USE [PhanTruongAnh_2210900087]
GO
/****** Object:  Table [dbo].[Pta_Sach]    Script Date: 7/12/2024 1:48:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pta_Sach](
	[Pta_MaSach] [char](10) NOT NULL,
	[Pta_TenSach] [nvarchar](50) NULL,
	[Pta_SoTrang] [int] NULL,
	[Pta_NamXB] [int] NULL,
	[Pta_MaTG] [char](10) NULL,
	[Pta_TrangThai] [bit] NULL,
 CONSTRAINT [PK_Pta_Sach] PRIMARY KEY CLUSTERED 
(
	[Pta_MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtaTacGia]    Script Date: 7/12/2024 1:48:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaTacGia](
	[Pta_MaTG] [char](10) NOT NULL,
	[Pta_TenTG] [nvarchar](50) NULL,
 CONSTRAINT [PK_PtaTacGia] PRIMARY KEY CLUSTERED 
(
	[Pta_MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Pta_Sach] ([Pta_MaSach], [Pta_TenSach], [Pta_SoTrang], [Pta_NamXB], [Pta_MaTG], [Pta_TrangThai]) VALUES (N'S1        ', N'HEHE', 22, 2004, N'2210900087', 1)
GO
INSERT [dbo].[PtaTacGia] ([Pta_MaTG], [Pta_TenTG]) VALUES (N'2210900087', N'PhanTruongAnh')
GO
ALTER TABLE [dbo].[Pta_Sach]  WITH CHECK ADD  CONSTRAINT [FK_Pta_Sach_PtaTacGia] FOREIGN KEY([Pta_MaTG])
REFERENCES [dbo].[PtaTacGia] ([Pta_MaTG])
GO
ALTER TABLE [dbo].[Pta_Sach] CHECK CONSTRAINT [FK_Pta_Sach_PtaTacGia]
GO
