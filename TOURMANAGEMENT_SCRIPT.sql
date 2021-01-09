USE [TOURMANAGEMENT]
GO
CREATE TABLE [dbo].[CT_DOAN_KHACHHANG](
	[IDCT] [int] IDENTITY(1,1) NOT NULL,
	[IDDOAN] [int] NULL,
	[IDKH] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_DOAN_KHACHSAN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DOAN_KHACHSAN](
	[IDCT] [int] IDENTITY(1,1) NOT NULL,
	[IDDOAN] [int] NULL,
	[IDKS] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_DOAN_PHUONGTIEN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_DOAN_PHUONGTIEN](
	[IDCT] [int] IDENTITY(1,1) NOT NULL,
	[IDDOAN] [int] NULL,
	[IDPT] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIADIEM]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIADIEM](
	[IDDIADIEM] [int] IDENTITY(1,1) NOT NULL,
	[TENDIADIEM] [nvarchar](max) NOT NULL,
	[MOTA] [nvarchar](max) NOT NULL,
	[IDTT] [int] NULL,
	[TINHTHANH] [nvarchar](max) NULL,
	[ACTIVE] [bit] NULL,
	[AVATAR] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDIADIEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOAN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOAN](
	[IDDOAN] [int] IDENTITY(1,1) NOT NULL,
	[TENDOAN] [nvarchar](max) NOT NULL,
	[IDTOUR] [int] NOT NULL,
	[SOLUONGKH] [int] NOT NULL,
	[NGAYBATDAU] [nvarchar](max) NULL,
	[NGAYKETTHUC] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[IDKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](max) NOT NULL,
	[CMND] [nvarchar](max) NULL,
	[DIACHI] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[EMAIL] [nvarchar](max) NULL,
	[NGAYSINH] [nvarchar](max) NULL,
	[ACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHSAN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHSAN](
	[IDKS] [int] IDENTITY(1,1) NOT NULL,
	[DIACHI] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[IDTT] [int] NULL,
	[ACTIVE] [bit] NULL,
	[TINHTHANH] [nvarchar](max) NULL,
	[TENKS] [nvarchar](max) NULL,
	[MOTA] [nvarchar](max) NULL,
	[AVATAR] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDKS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[IDND] [int] IDENTITY(1,1) NOT NULL,
	[IDNV] [int] NOT NULL,
	[USERNAME] [nvarchar](max) NOT NULL,
	[PASS] [nvarchar](max) NOT NULL,
	[ACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[IDNV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](max) NULL,
	[DIACHI] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[EMAIL] [nvarchar](max) NULL,
	[NGAYSINH] [nvarchar](max) NULL,
	[CHUCVU] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHUONGTIEN]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHUONGTIEN](
	[IDPT] [int] IDENTITY(1,1) NOT NULL,
	[LOAIPT] [nvarchar](max) NULL,
	[SOGHE] [int] NULL,
	[ACTIVE] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTHANH]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTHANH](
	[IDTT] [int] IDENTITY(1,1) NOT NULL,
	[TENTT] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOUR]    Script Date: 09/01/2021 11:33:09 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOUR](
	[IDTOUR] [int] IDENTITY(1,1) NOT NULL,
	[TENTOUR] [nvarchar](max) NOT NULL,
	[GIATOUR] [nvarchar](max) NOT NULL,
	[ACTIVE] [bit] NULL,
	[MOTA] [nvarchar](max) NULL,
	[LOAIHINH] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTOUR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_DIADIEM_TOUR]  WITH CHECK ADD  CONSTRAINT [FK_CT_DIADIEM_TOUR_DIADIEM] FOREIGN KEY([IDDIADIEM])
REFERENCES [dbo].[DIADIEM] ([IDDIADIEM])
GO
ALTER TABLE [dbo].[CT_DIADIEM_TOUR] CHECK CONSTRAINT [FK_CT_DIADIEM_TOUR_DIADIEM]
GO
ALTER TABLE [dbo].[CT_DIADIEM_TOUR]  WITH CHECK ADD  CONSTRAINT [FK_CT_DIADIEM_TOUR_TOUR] FOREIGN KEY([IDTOUR])
REFERENCES [dbo].[TOUR] ([IDTOUR])
GO
ALTER TABLE [dbo].[CT_DIADIEM_TOUR] CHECK CONSTRAINT [FK_CT_DIADIEM_TOUR_TOUR]
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHHANG]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_KHACHHANG] FOREIGN KEY([IDDOAN])
REFERENCES [dbo].[DOAN] ([IDDOAN])
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHHANG] CHECK CONSTRAINT [fk_CT_DOAN_KHACHHANG]
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHHANG]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_KHACHHANG_KH] FOREIGN KEY([IDKH])
REFERENCES [dbo].[KHACHHANG] ([IDKH])
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHHANG] CHECK CONSTRAINT [fk_CT_DOAN_KHACHHANG_KH]
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHSAN]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_KHACHSAN] FOREIGN KEY([IDDOAN])
REFERENCES [dbo].[DOAN] ([IDDOAN])
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHSAN] CHECK CONSTRAINT [fk_CT_DOAN_KHACHSAN]
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHSAN]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_KHACHSAN_KS] FOREIGN KEY([IDKS])
REFERENCES [dbo].[KHACHSAN] ([IDKS])
GO
ALTER TABLE [dbo].[CT_DOAN_KHACHSAN] CHECK CONSTRAINT [fk_CT_DOAN_KHACHSAN_KS]
GO
ALTER TABLE [dbo].[CT_DOAN_PHUONGTIEN]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_PHUONGTIEN] FOREIGN KEY([IDDOAN])
REFERENCES [dbo].[DOAN] ([IDDOAN])
GO
ALTER TABLE [dbo].[CT_DOAN_PHUONGTIEN] CHECK CONSTRAINT [fk_CT_DOAN_PHUONGTIEN]
GO
ALTER TABLE [dbo].[CT_DOAN_PHUONGTIEN]  WITH CHECK ADD  CONSTRAINT [fk_CT_DOAN_PHUONGTIEN_PT] FOREIGN KEY([IDPT])
REFERENCES [dbo].[PHUONGTIEN] ([IDPT])
GO
ALTER TABLE [dbo].[CT_DOAN_PHUONGTIEN] CHECK CONSTRAINT [fk_CT_DOAN_PHUONGTIEN_PT]
GO
ALTER TABLE [dbo].[DIADIEM]  WITH CHECK ADD  CONSTRAINT [fk_DIADIEM_TINHTHANH] FOREIGN KEY([IDTT])
REFERENCES [dbo].[TINHTHANH] ([IDTT])
GO
ALTER TABLE [dbo].[DIADIEM] CHECK CONSTRAINT [fk_DIADIEM_TINHTHANH]
GO
ALTER TABLE [dbo].[DOAN]  WITH CHECK ADD  CONSTRAINT [fk_DOAN_TOUR] FOREIGN KEY([IDTOUR])
REFERENCES [dbo].[TOUR] ([IDTOUR])
GO
ALTER TABLE [dbo].[DOAN] CHECK CONSTRAINT [fk_DOAN_TOUR]
GO
ALTER TABLE [dbo].[KHACHSAN]  WITH CHECK ADD  CONSTRAINT [fk_KHACHSAN_TINHTHANH] FOREIGN KEY([IDTT])
REFERENCES [dbo].[TINHTHANH] ([IDTT])
GO
ALTER TABLE [dbo].[KHACHSAN] CHECK CONSTRAINT [fk_KHACHSAN_TINHTHANH]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [fk_NGUOIDUNG_NHANVIEN] FOREIGN KEY([IDNV])
REFERENCES [dbo].[NHANVIEN] ([IDNV])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [fk_NGUOIDUNG_NHANVIEN]
GO
