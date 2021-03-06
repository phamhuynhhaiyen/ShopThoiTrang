USE [QLshopthoitrang]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaHD] [bigint] NOT NULL,
	[MaSP] [bigint] NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_CTHD1] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CTPN]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPN](
	[MaPhieuNhap] [bigint] NOT NULL,
	[MaSP] [bigint] NOT NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [bigint] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_CT_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [bigint] IDENTITY(1,1) NOT NULL,
	[SDT] [nvarchar](10) NULL,
	[MaNV] [bigint] NULL,
	[NgayLap] [date] NULL,
	[TongTien] [bigint] NULL,
 CONSTRAINT [PK_Hoa_don] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[SDT] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khach_hang] PRIMARY KEY CLUSTERED 
(
	[SDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [bigint] NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai_mat_hang] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [bigint] NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nha_cung_cap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [bigint] NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[MaQuyen] [bigint] NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](4) NULL,
	[SDT] [char](10) NULL,
	[MatKhau] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nhan_vien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[MaPhieuNhap] [bigint] IDENTITY(1,1) NOT NULL,
	[MaNV] [bigint] NULL,
	[NgayLap] [date] NULL,
	[TongTien] [bigint] NULL,
 CONSTRAINT [PK_Phieu_nhap] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quyen]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quyen](
	[MaQuyen] [bigint] IDENTITY(1,1) NOT NULL,
	[TenQuyen] [nvarchar](50) NULL,
 CONSTRAINT [PK_Quyen] PRIMARY KEY CLUSTERED 
(
	[MaQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [bigint] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[MaLoai] [bigint] NULL,
	[MaNCC] [bigint] NULL,
	[SoLuongTon] [int] NULL,
	[GiaBan] [bigint] NULL,
 CONSTRAINT [PK_Mat_hang] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_SanPham]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_Mat_hang] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CT_PhieuNhap_Mat_hang]
GO
ALTER TABLE [dbo].[CTPN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PhieuNhap_Phieu_nhap1] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CTPN] CHECK CONSTRAINT [FK_CT_PhieuNhap_Phieu_nhap1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_Quyen] FOREIGN KEY([MaQuyen])
REFERENCES [dbo].[Quyen] ([MaQuyen])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_Quyen]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_Phieu_nhap_Nhan_vien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_Phieu_nhap_Nhan_vien]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_Mat_hang_Loai_mat_hang1] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_Mat_hang_Loai_mat_hang1]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_Mat_hang_Nha_cung_cap1] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_Mat_hang_Nha_cung_cap1]
GO
/****** Object:  StoredProcedure [dbo].[sp_getCTPN]    Script Date: 1/2/2021 5:32:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_getCTPN] @maphieunhap bigint
as
begin
SELECT CTPN.MaSP, TenSP, SoLuong, GiaNhap, ThanhTien 
FROM CTPN, SanPham 
WHERE CTPN.MaSP = SanPham.MaSP AND MaPhieuNhap IN 
(SELECT MaPhieuNhap 
FROM PhieuNhap 
WHERE MaPhieuNhap = @maphieunhap)
end
GO



USE [QLshopthoitrang]
GO
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (1, N'Sweater')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (2, N'Hoodie')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (3, N'Đầm liền')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (4, N'Quần Tây')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (5, N'Áo thun')
INSERT [dbo].[LoaiSanPham] ([MaLoai], [TenLoai]) VALUES (6, N'Chân váy')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (1, N'LV', N'Quận 9')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (2, N'Dior', N'Thủ Đức')
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi]) VALUES (3, N'HM', N'Quận 2')
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [MaNCC], [SoLuongTon], [GiaBan]) VALUES (1, N'Áo  thun dài tay trắng', 5, 1, 83, 390000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [MaNCC], [SoLuongTon], [GiaBan]) VALUES (2, N'Quần tây đen', 4, 1, 16, 260000)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MaLoai], [MaNCC], [SoLuongTon], [GiaBan]) VALUES (3, N'Áo thun unisex', 5, 1, 208, 1300000)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
SET IDENTITY_INSERT [dbo].[Quyen] ON 

INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (1, N'Admin')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (2, N'Quản lí')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (3, N'Nhân viên bán hàng')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (4, N'Nhân viên kho')
INSERT [dbo].[Quyen] ([MaQuyen], [TenQuyen]) VALUES (5, N'Kế Toán')
SET IDENTITY_INSERT [dbo].[Quyen] OFF
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071105, N'Võ Thị Diệu Thương', 2, CAST(N'2000-04-04' AS Date), N'Nữ', N'0698547458', N'202CB962AC59075B964B07152D234B70')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071112, N'Nguyễn Mai Chí Trung', 3, CAST(N'2020-12-27' AS Date), N'Nam', N'0365847895', N'202CB962AC59075B964B07152D234B70')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071114, N'Trần Quang Trường', 4, CAST(N'2020-12-27' AS Date), N'Nam', N'0365847895', N'202CB962AC59075B964B07152D234B70')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071119, N'Lê Thị Tường Vi', 1, CAST(N'2000-12-26' AS Date), N'Nữ', N'0254874596', N'202CB962AC59075B964B07152D234B70')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071122, N'Đoàn Bùi Quang Vĩnh', 5, CAST(N'2000-01-01' AS Date), N'Nam', N'0236584574', N'202CB962AC59075B964B07152D234B70')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT], [MatKhau]) VALUES (5951071125, N'Phạm Huỳnh Hải Yến', 1, CAST(N'2020-07-11' AS Date), N'Nữ', N'0776989265', N'202CB962AC59075B964B07152D234B70')
SET IDENTITY_INSERT [dbo].[PhieuNhap] ON 

INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (18, 5951071125, CAST(N'2020-10-15' AS Date), 90000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (19, 5951071125, CAST(N'2020-12-31' AS Date), 6000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (21, 5951071125, CAST(N'2020-12-31' AS Date), 4100000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (25, 5951071125, CAST(N'2021-01-01' AS Date), 20000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (26, 5951071125, CAST(N'2019-01-01' AS Date), 100000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (27, 5951071125, CAST(N'2021-01-01' AS Date), 100000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (28, 5951071125, CAST(N'2021-01-01' AS Date), 200000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (29, 5951071125, CAST(N'2021-01-01' AS Date), 200000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (30, 5951071125, CAST(N'2021-01-01' AS Date), 600000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (31, 5951071125, CAST(N'2021-01-01' AS Date), 201200000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (32, 5951071114, CAST(N'2021-01-01' AS Date), 1000000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (36, 5951071125, CAST(N'2021-01-01' AS Date), 200000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (37, 5951071114, CAST(N'2021-01-01' AS Date), 200000)
INSERT [dbo].[PhieuNhap] ([MaPhieuNhap], [MaNV], [NgayLap], [TongTien]) VALUES (10049, 5951071125, CAST(N'2021-01-02' AS Date), 300000)
SET IDENTITY_INSERT [dbo].[PhieuNhap] OFF
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (18, 1, 30, 10000, 30000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (18, 2, 1, 20000, 20000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (18, 3, 2, 20000, 40000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (19, 1, 30, 200000, 6000000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (21, 1, 20, 200000, 4000000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (21, 3, 1, 100000, 100000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (25, 3, 2, 10000, 20000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (26, 2, 1, 100000, 100000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (27, 2, 1, 100000, 100000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (28, 1, 1, 200000, 200000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (29, 1, 1, 200000, 200000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (30, 2, 2, 300000, 600000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (31, 1, 2, 600000, 1200000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (31, 3, 200, 1000000, 200000000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (32, 2, 10, 100000, 1000000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (34, 1, 1, 100000, 100000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (34, 2, 1, 10000, 10000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (36, 1, 1, 200000, 200000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (37, 2, 1, 200000, 200000)
INSERT [dbo].[CTPN] ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES (10049, 1, 1, 300000, 300000)
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (1, N'0776989265', 5951071105, CAST(N'2020-12-31' AS Date), 1040000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (8, N'0776989265', 5951071125, CAST(N'2020-01-01' AS Date), 520000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (14, N'0123456789', 5951071125, CAST(N'2020-02-01' AS Date), 130000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (15, N'0123456789', 5951071125, CAST(N'2019-01-01' AS Date), 260000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (16, N'0123456789', 5951071125, CAST(N'2021-01-01' AS Date), 26000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (19, N'0776989265', 5951071125, CAST(N'2021-01-01' AS Date), 13000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (20, N'456', 5951071125, CAST(N'2021-01-01' AS Date), 260000)
INSERT [dbo].[HoaDon] ([MaHD], [SDT], [MaNV], [NgayLap], [TongTien]) VALUES (21, N'0123456789', 5951071125, CAST(N'2021-01-01' AS Date), 260000)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (1, 1, 2, 520000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (1, 2, 1, 500000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (1, 3, 1, 20000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (8, 2, 4, 520000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (14, 2, 1, 130000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (15, 1, 1, 260000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (16, 3, 2, 26000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (19, 2, 1, 13000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (20, 1, 1, 260000)
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [ThanhTien]) VALUES (21, 2, 1, 260000)
INSERT [dbo].[KhachHang] ([SDT], [TenKH]) VALUES (N'0776989264', N'Nguyễn Mai')
INSERT [dbo].[KhachHang] ([SDT], [TenKH]) VALUES (N'0776989265', N'Nguyễn Thị My')
INSERT [dbo].[KhachHang] ([SDT], [TenKH]) VALUES (N'123456', N'Yến')
INSERT [dbo].[KhachHang] ([SDT], [TenKH]) VALUES (N'456', N'Truong')
INSERT [dbo].[KhachHang] ([SDT], [TenKH]) VALUES (N'66666', N'sdsdasd')
