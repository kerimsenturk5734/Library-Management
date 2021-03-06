USE [master]
GO
/****** Object:  Database [kutuphane]    Script Date: 6/24/2022 11:58:12 PM ******/
CREATE DATABASE [kutuphane]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'kutuphane', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\kutuphane.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'kutuphane_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\kutuphane_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [kutuphane] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [kutuphane].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [kutuphane] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [kutuphane] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [kutuphane] SET ARITHABORT OFF 
GO
ALTER DATABASE [kutuphane] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [kutuphane] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [kutuphane] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [kutuphane] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [kutuphane] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [kutuphane] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [kutuphane] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [kutuphane] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [kutuphane] SET  DISABLE_BROKER 
GO
ALTER DATABASE [kutuphane] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [kutuphane] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [kutuphane] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [kutuphane] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [kutuphane] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [kutuphane] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [kutuphane] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [kutuphane] SET RECOVERY FULL 
GO
ALTER DATABASE [kutuphane] SET  MULTI_USER 
GO
ALTER DATABASE [kutuphane] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [kutuphane] SET DB_CHAINING OFF 
GO
ALTER DATABASE [kutuphane] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [kutuphane] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [kutuphane] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [kutuphane] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'kutuphane', N'ON'
GO
ALTER DATABASE [kutuphane] SET QUERY_STORE = OFF
GO
USE [kutuphane]
GO
/****** Object:  Table [dbo].[tbl_istatistikler]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_istatistikler](
	[kitapsayisi] [int] NULL,
	[tarih] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kitaplar]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kitaplar](
	[kitapID] [smallint] IDENTITY(1000,1) NOT NULL,
	[kitapad] [varchar](50) NOT NULL,
	[kitapsayfa] [smallint] NOT NULL,
	[kitapyazar] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_kitaplar] PRIMARY KEY CLUSTERED 
(
	[kitapID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_kullanicilar]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_kullanicilar](
	[kadi] [varchar](30) NOT NULL,
	[ksifre] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tbl_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[kadi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_ogrenciler]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ogrenciler](
	[ogrTC] [bigint] NOT NULL,
	[ogrAd] [varchar](20) NOT NULL,
	[ogrSoyad] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tbl_ogrenciler] PRIMARY KEY CLUSTERED 
(
	[ogrTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_teslim]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_teslim](
	[teslimID] [smallint] IDENTITY(1,1) NOT NULL,
	[ogrTC] [bigint] NOT NULL,
	[kitapID] [smallint] NOT NULL,
	[kAdi] [varchar](30) NOT NULL,
	[vTarihi] [date] NULL,
	[aTarihi] [date] NULL,
	[tDurum] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_teslim] PRIMARY KEY CLUSTERED 
(
	[teslimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_teslim]  WITH CHECK ADD  CONSTRAINT [FK_tbl_teslim_tbl_kitaplar] FOREIGN KEY([kitapID])
REFERENCES [dbo].[tbl_kitaplar] ([kitapID])
GO
ALTER TABLE [dbo].[tbl_teslim] CHECK CONSTRAINT [FK_tbl_teslim_tbl_kitaplar]
GO
ALTER TABLE [dbo].[tbl_teslim]  WITH CHECK ADD  CONSTRAINT [FK_tbl_teslim_tbl_kullanicilar] FOREIGN KEY([kAdi])
REFERENCES [dbo].[tbl_kullanicilar] ([kadi])
GO
ALTER TABLE [dbo].[tbl_teslim] CHECK CONSTRAINT [FK_tbl_teslim_tbl_kullanicilar]
GO
ALTER TABLE [dbo].[tbl_teslim]  WITH CHECK ADD  CONSTRAINT [FK_tbl_teslim_tbl_ogrenciler] FOREIGN KEY([ogrTC])
REFERENCES [dbo].[tbl_ogrenciler] ([ogrTC])
GO
ALTER TABLE [dbo].[tbl_teslim] CHECK CONSTRAINT [FK_tbl_teslim_tbl_ogrenciler]
GO
/****** Object:  StoredProcedure [dbo].[GetBooks]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetBooks]
AS
BEGIN
SET NOCOUNT ON

 SELECT kitapID AS ID, kitapad AS Ad, kitapsayfa AS Sayfa, kitapyazar AS Yazar from tbl_kitaplar

END
GO
/****** Object:  StoredProcedure [dbo].[GetReceives]    Script Date: 6/24/2022 11:58:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetReceives]
AS
	
	SELECT teslimID AS [Kayıt NO],
	ogrTC AS OgrenciTC,tbl_kitaplar.kitapad AS [Kitap Adı],kAdi AS [Kayıt Yapan],
	vTarihi AS [Veriliş Tarihi],aTarihi AS [Teslim Tarihi],				
	tDurum AS Durum 
	FROM tbl_teslim
	INNER JOIN tbl_kitaplar
	ON tbl_teslim.kitapID=tbl_kitaplar.kitapID;

GO
USE [master]
GO
ALTER DATABASE [kutuphane] SET  READ_WRITE 
GO
