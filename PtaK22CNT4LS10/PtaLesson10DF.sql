USE [K22CNT4DFLESSON10]
GO
/****** Object:  Table [dbo].[PtaAccount]    Script Date: 7/3/2024 2:01:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PtaAccount](
	[PtaID] [int] NOT NULL,
	[PtaUserName] [nvarchar](50) NULL,
	[PtaPassword] [nvarchar](50) NULL,
	[PtaFullName] [nvarchar](50) NULL,
	[PtaEmail] [nvarchar](50) NULL,
	[PtaPhone] [nvarchar](50) NULL,
	[PtaActive] [bit] NULL,
 CONSTRAINT [PK_PtaAccount] PRIMARY KEY CLUSTERED 
(
	[PtaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[PtaAccount] ([PtaID], [PtaUserName], [PtaPassword], [PtaFullName], [PtaEmail], [PtaPhone], [PtaActive]) VALUES (1, N'TruongAnh', N'123456', N'Phan Trường Anh', N'anhnganh04@gmail.com', N'0333814312', 1)
GO
