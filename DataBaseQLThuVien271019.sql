USE [master]
GO
/****** Object:  Database [DataBaseThuVien]    Script Date: 27-10-2019 11:17:49 ******/
CREATE DATABASE [DataBaseThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DataBaseThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DataBaseThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DataBaseThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DataBaseThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DataBaseThuVien] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DataBaseThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DataBaseThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DataBaseThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DataBaseThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DataBaseThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DataBaseThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DataBaseThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [DataBaseThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DataBaseThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DataBaseThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DataBaseThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DataBaseThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DataBaseThuVien] SET QUERY_STORE = OFF
GO
USE [DataBaseThuVien]
GO
/****** Object:  Table [dbo].[CTPhieuMuon]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuMuon](
	[maPhieuMuon] [nchar](10) NOT NULL,
	[maCuonSach] [nchar](10) NOT NULL,
	[ngaytra] [date] NULL,
	[maTinhTrang] [nchar](10) NULL,
	[ngayQuaHan] [int] NULL,
 CONSTRAINT [PK_CTPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[maPhieuMuon] ASC,
	[maCuonSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuNhap]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuNhap](
	[maPhieuNhap] [nchar](10) NOT NULL,
	[maDauSach] [nchar](10) NOT NULL,
	[slNhap] [int] NULL,
	[ghichu] [nvarchar](150) NULL,
 CONSTRAINT [PK_CTPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC,
	[maDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuonSach]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuonSach](
	[maCuonSach] [nchar](10) NOT NULL,
	[maDauSach] [nchar](10) NULL,
	[maTinhTrangSach] [nchar](10) NULL,
 CONSTRAINT [PK_CuonSach] PRIMARY KEY CLUSTERED 
(
	[maCuonSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[maDauSach] [nchar](10) NOT NULL,
	[tenDauSach] [nvarchar](80) NULL,
	[namXB] [int] NULL,
	[soLuong] [int] NULL,
	[maNhomSach] [nchar](10) NULL,
	[maNXB] [nchar](10) NULL,
 CONSTRAINT [PK_DauSach] PRIMARY KEY CLUSTERED 
(
	[maDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[maDG] [nchar](10) NOT NULL,
	[tenDG] [nvarchar](80) NULL,
	[ngaysinhDG] [date] NULL,
	[maCanCuocDG] [nchar](12) NULL,
	[gioitinhDG] [bit] NULL,
	[slMuon] [int] NULL,
	[sdtDG] [nchar](13) NULL,
	[diachiDG] [nvarchar](20) NULL,
	[maNhomDG] [nchar](10) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[maDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[maNV] [nchar](10) NOT NULL,
	[tenNV] [nvarchar](80) NULL,
	[ngaysinhNV] [date] NULL,
	[gioitinhNV] [bit] NULL,
	[diachiNV] [nvarchar](120) NULL,
	[sdtNV] [nchar](13) NULL,
	[maCanCuocNV] [nchar](12) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[maNXB] [nchar](10) NOT NULL,
	[tenNXB] [nvarchar](80) NULL,
	[sdtNXB] [nchar](13) NULL,
	[diachiNXB] [nvarchar](120) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomDG]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomDG](
	[maNhomDG] [nchar](10) NOT NULL,
	[tenNhomDG] [nvarchar](80) NULL,
	[slSachMuon] [int] NULL,
 CONSTRAINT [PK_NhomDG] PRIMARY KEY CLUSTERED 
(
	[maNhomDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomSach]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSach](
	[maNhomSach] [nchar](10) NOT NULL,
	[tenNhomSach] [nvarchar](80) NULL,
	[tgMuonSach] [int] NULL,
 CONSTRAINT [PK_NhomSach] PRIMARY KEY CLUSTERED 
(
	[maNhomSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[maPhieuMuon] [nchar](10) NOT NULL,
	[ngaymuon] [date] NULL,
	[ngayhentra] [date] NULL,
	[maDG] [nchar](10) NULL,
	[loaiphieu] [bit] NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[maPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPhieuNhap] [nchar](10) NOT NULL,
	[maNXB] [nchar](10) NULL,
	[ngayNhap] [date] NULL,
	[tenNVCC] [nvarchar](80) NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenNV]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenNV](
	[maquyen] [nchar](10) NOT NULL,
	[tenquyen] [nvarchar](80) NULL,
	[chuthich] [nvarchar](150) NULL,
 CONSTRAINT [PK_QuyenNV] PRIMARY KEY CLUSTERED 
(
	[maquyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanDG]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanDG](
	[maDG] [nchar](10) NOT NULL,
	[matkhauDG] [nchar](32) NULL,
	[chuThich] [nvarchar](150) NULL,
 CONSTRAINT [PK_TaiKhoanDG] PRIMARY KEY CLUSTERED 
(
	[maDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoanNV]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoanNV](
	[maNV] [nchar](10) NOT NULL,
	[matkhauNV] [nchar](32) NULL,
	[maquyen] [nchar](10) NULL,
 CONSTRAINT [PK_TaiKhoanNV] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrangSach]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangSach](
	[maTinhTrang] [nchar](10) NOT NULL,
	[tenTinhTrang] [nvarchar](80) NULL,
	[mieuta] [nvarchar](150) NULL,
 CONSTRAINT [PK_TinhTrangSach] PRIMARY KEY CLUSTERED 
(
	[maTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TuaSach]    Script Date: 27-10-2019 11:17:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuaSach](
	[maDauSach] [nchar](10) NOT NULL,
	[tenTuaSach] [nvarchar](80) NULL,
	[tacGia] [nvarchar](80) NULL,
	[tomtat] [nvarchar](500) NULL,
 CONSTRAINT [PK_TuaSach] PRIMARY KEY CLUSTERED 
(
	[maDauSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_CuonSach] FOREIGN KEY([maCuonSach])
REFERENCES [dbo].[CuonSach] ([maCuonSach])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_CuonSach]
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_PhieuMuon] FOREIGN KEY([maPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([maPhieuMuon])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_PhieuMuon]
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_TinhTrangSach] FOREIGN KEY([maTinhTrang])
REFERENCES [dbo].[TinhTrangSach] ([maTinhTrang])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_TinhTrangSach]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_DauSach] FOREIGN KEY([maDauSach])
REFERENCES [dbo].[DauSach] ([maDauSach])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_DauSach]
GO
ALTER TABLE [dbo].[CTPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuNhap_PhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[CTPhieuNhap] CHECK CONSTRAINT [FK_CTPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_DauSach] FOREIGN KEY([maDauSach])
REFERENCES [dbo].[DauSach] ([maDauSach])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_DauSach]
GO
ALTER TABLE [dbo].[CuonSach]  WITH CHECK ADD  CONSTRAINT [FK_CuonSach_TinhTrangSach] FOREIGN KEY([maTinhTrangSach])
REFERENCES [dbo].[TinhTrangSach] ([maTinhTrang])
GO
ALTER TABLE [dbo].[CuonSach] CHECK CONSTRAINT [FK_CuonSach_TinhTrangSach]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK_DauSach_NhaXuatBan] FOREIGN KEY([maNXB])
REFERENCES [dbo].[NhaXuatBan] ([maNXB])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK_DauSach_NhaXuatBan]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD  CONSTRAINT [FK_DauSach_NhomSach] FOREIGN KEY([maNhomSach])
REFERENCES [dbo].[NhomSach] ([maNhomSach])
GO
ALTER TABLE [dbo].[DauSach] CHECK CONSTRAINT [FK_DauSach_NhomSach]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_NhomDG] FOREIGN KEY([maNhomDG])
REFERENCES [dbo].[NhomDG] ([maNhomDG])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_NhomDG]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_TaiKhoanNV] FOREIGN KEY([maNV])
REFERENCES [dbo].[TaiKhoanNV] ([maNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_TaiKhoanNV]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([maDG])
REFERENCES [dbo].[DocGia] ([maDG])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaXuatBan] FOREIGN KEY([maNXB])
REFERENCES [dbo].[NhaXuatBan] ([maNXB])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaXuatBan]
GO
ALTER TABLE [dbo].[TaiKhoanDG]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanDG_DocGia] FOREIGN KEY([maDG])
REFERENCES [dbo].[DocGia] ([maDG])
GO
ALTER TABLE [dbo].[TaiKhoanDG] CHECK CONSTRAINT [FK_TaiKhoanDG_DocGia]
GO
ALTER TABLE [dbo].[TaiKhoanNV]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoanNV_QuyenNV] FOREIGN KEY([maquyen])
REFERENCES [dbo].[QuyenNV] ([maquyen])
GO
ALTER TABLE [dbo].[TaiKhoanNV] CHECK CONSTRAINT [FK_TaiKhoanNV_QuyenNV]
GO
ALTER TABLE [dbo].[TuaSach]  WITH CHECK ADD  CONSTRAINT [FK_TuaSach_DauSach] FOREIGN KEY([maDauSach])
REFERENCES [dbo].[DauSach] ([maDauSach])
GO
ALTER TABLE [dbo].[TuaSach] CHECK CONSTRAINT [FK_TuaSach_DauSach]
GO
USE [master]
GO
ALTER DATABASE [DataBaseThuVien] SET  READ_WRITE 
GO
