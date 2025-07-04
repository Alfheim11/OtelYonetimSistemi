USE [master]
GO
/****** Object:  Database [OtelYP]    Script Date: 3.06.2025 11:02:30 ******/
CREATE DATABASE [OtelYP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtelYP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\OtelYP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtelYP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\OtelYP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [OtelYP] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtelYP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtelYP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtelYP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtelYP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtelYP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtelYP] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtelYP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtelYP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtelYP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtelYP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtelYP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtelYP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtelYP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtelYP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtelYP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtelYP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtelYP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtelYP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtelYP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtelYP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtelYP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtelYP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtelYP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtelYP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OtelYP] SET  MULTI_USER 
GO
ALTER DATABASE [OtelYP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtelYP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtelYP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtelYP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtelYP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OtelYP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [OtelYP] SET QUERY_STORE = ON
GO
ALTER DATABASE [OtelYP] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [OtelYP]
GO
/****** Object:  Table [dbo].[Kalir]    Script Date: 3.06.2025 11:02:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kalir](
	[MusteriID] [int] NOT NULL,
	[OdaID] [int] NOT NULL,
 CONSTRAINT [PK_Kalir_1] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC,
	[OdaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 3.06.2025 11:02:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](50) NOT NULL,
	[MusteriSoyad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 3.06.2025 11:02:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[OdaID] [int] IDENTITY(1,1) NOT NULL,
	[OdaNo] [nvarchar](50) NOT NULL,
	[GecelikFiyat] [decimal](10, 2) NOT NULL,
	[Durum] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Odalar] PRIMARY KEY CLUSTERED 
(
	[OdaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 3.06.2025 11:02:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAd] [nvarchar](50) NULL,
	[PersonelSoyad] [nvarchar](50) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervasyon]    Script Date: 3.06.2025 11:02:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyon](
	[RezervasyonID] [int] IDENTITY(1,1) NOT NULL,
	[GirisTarihi] [date] NOT NULL,
	[CikisTarihi] [date] NOT NULL,
	[MusteriID] [int] NOT NULL,
	[OdaID] [int] NOT NULL,
	[PersonelID] [int] NOT NULL,
 CONSTRAINT [PK_Rezervasyon_1] PRIMARY KEY CLUSTERED 
(
	[RezervasyonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (1, N'Ahmet', N'Çakmak')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (3, N'Ayşe', N'Güler')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (4, N'Hatice', N'Buz')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (5, N'Kamil', N'Yıldırım')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (6, N'Kadir', N'Hatay')
INSERT [dbo].[Musteri] ([MusteriID], [MusteriAd], [MusteriSoyad]) VALUES (7, N'Türker', N'Şahin')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
GO
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (1, N'101', CAST(5000.00 AS Decimal(10, 2)), N'Boş')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (3, N'102', CAST(1500.00 AS Decimal(10, 2)), N'Boş')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (4, N'103', CAST(1000.00 AS Decimal(10, 2)), N'Boş')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (5, N'104', CAST(2000.00 AS Decimal(10, 2)), N'Dolu')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (6, N'105', CAST(2500.00 AS Decimal(10, 2)), N'Boş')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (7, N'106', CAST(6000.00 AS Decimal(10, 2)), N'Boş')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (8, N'107', CAST(3500.00 AS Decimal(10, 2)), N'Dolu')
INSERT [dbo].[Odalar] ([OdaID], [OdaNo], [GecelikFiyat], [Durum]) VALUES (9, N'108', CAST(8000.00 AS Decimal(10, 2)), N'Boş')
SET IDENTITY_INSERT [dbo].[Odalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelID], [PersonelAd], [PersonelSoyad]) VALUES (1, N'Ahmet', N'Kılıç')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAd], [PersonelSoyad]) VALUES (2, N'Nuriye', N'Şentop')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAd], [PersonelSoyad]) VALUES (3, N'Lale', N'Fırlatır')
INSERT [dbo].[Personel] ([PersonelID], [PersonelAd], [PersonelSoyad]) VALUES (4, N'Kadir', N'Hatay')
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[Rezervasyon] ON 

INSERT [dbo].[Rezervasyon] ([RezervasyonID], [GirisTarihi], [CikisTarihi], [MusteriID], [OdaID], [PersonelID]) VALUES (3, CAST(N'2025-06-03' AS Date), CAST(N'2025-06-07' AS Date), 5, 8, 1)
INSERT [dbo].[Rezervasyon] ([RezervasyonID], [GirisTarihi], [CikisTarihi], [MusteriID], [OdaID], [PersonelID]) VALUES (4, CAST(N'2025-06-03' AS Date), CAST(N'2025-06-14' AS Date), 7, 5, 3)
SET IDENTITY_INSERT [dbo].[Rezervasyon] OFF
GO
ALTER TABLE [dbo].[Kalir]  WITH CHECK ADD  CONSTRAINT [FK_Kalir_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([MusteriID])
GO
ALTER TABLE [dbo].[Kalir] CHECK CONSTRAINT [FK_Kalir_Musteri]
GO
ALTER TABLE [dbo].[Kalir]  WITH CHECK ADD  CONSTRAINT [FK_Kalir_Odalar] FOREIGN KEY([OdaID])
REFERENCES [dbo].[Odalar] ([OdaID])
GO
ALTER TABLE [dbo].[Kalir] CHECK CONSTRAINT [FK_Kalir_Odalar]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([MusteriID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Musteri]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Odalar] FOREIGN KEY([OdaID])
REFERENCES [dbo].[Odalar] ([OdaID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Odalar]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_Personel] FOREIGN KEY([RezervasyonID])
REFERENCES [dbo].[Personel] ([PersonelID])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_Personel]
GO
USE [master]
GO
ALTER DATABASE [OtelYP] SET  READ_WRITE 
GO
