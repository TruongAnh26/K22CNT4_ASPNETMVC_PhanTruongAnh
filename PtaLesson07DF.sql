USE [PtaLesson07DF]
GO
/****** Object:  Table [dbo].[PtaKhoa]    Script Date: 6/12/2024 3:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaKhoa](
	[PtaMaKH] [nvarchar](50) NOT NULL,
	[PtaTenKH] [nvarchar](50) NULL,
	[PtaTrangThai] [bit] NULL,
 CONSTRAINT [PK_PtaKhoa] PRIMARY KEY CLUSTERED 
(
	[PtaMaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PtaSinhVien]    Script Date: 6/12/2024 3:29:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaSinhVien](
	[PtaMaSV] [nvarchar](50) NOT NULL,
	[PtaTenSV] [nvarchar](50) NULL,
	[PtaPhone] [nvarchar](50) NULL,
	[PtaEmail] [nvarchar](50) NULL,
	[PtaPhai] [bit] NULL,
	[PtaMaKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_PtaSinhVien] PRIMARY KEY CLUSTERED 
(
	[PtaMaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
