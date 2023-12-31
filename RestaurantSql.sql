USE [Restaurant]
GO
/****** Object:  Table [dbo].[Adisyonlar]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adisyonlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServisTurNo] [int] NULL,
	[PersonelId] [int] NULL,
	[MasaId] [int] NULL,
	[Tarih] [datetime] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Adisyonlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HesapOdemeleri]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HesapOdemeleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdisyonId] [int] NULL,
	[OdemeTurId] [int] NULL,
	[MusteriId] [int] NULL,
	[AraToplam] [money] NULL,
	[KDVTutari] [money] NULL,
	[Indirim] [money] NULL,
	[ToplamTutar] [money] NULL,
	[Tarih] [datetime] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_HesapOdemeleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kategoriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](100) NULL,
	[Aciklama] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Kategoriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masalar]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kapasite] [int] NULL,
	[ServisTuru] [int] NULL,
	[Durum] [int] NULL,
	[Onay] [bit] NULL,
 CONSTRAINT [PK_Masalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Adres] [text] NULL,
	[Telefon] [nvarchar](50) NULL,
	[IlkSiparis] [date] NULL,
	[Email] [nvarchar](50) NULL,
	[SiparisSayisi] [int] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OdemeTurleri]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdemeTurleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OdemeTuru] [nvarchar](50) NULL,
	[Aciklama] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_OdemeTurleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaketSiparis]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaketSiparis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NULL,
	[AdisyonId] [int] NULL,
	[OdemeTurId] [int] NULL,
	[Aciklama] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_PaketSiparis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GorevId] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Parola] [nvarchar](50) NULL,
	[KullaniciAdi] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelGorevleri]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelGorevleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Gorev] [nvarchar](100) NULL,
	[Aciklama] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_PersonelGorevleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelHareketleri]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelHareketleri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelId] [int] NULL,
	[Islem] [nvarchar](50) NULL,
	[Tarih] [datetime] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_PersonelHareketleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervasyonlar]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyonlar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriId] [int] NULL,
	[MasaId] [int] NULL,
	[AdisyonId] [int] NULL,
	[KisiSayisi] [int] NULL,
	[Tarih] [datetime] NULL,
	[Aciklama] [text] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Rezervasyonlar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Satislar]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Satislar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdisyonId] [int] NULL,
	[UrunId] [int] NULL,
	[MasaId] [int] NULL,
	[Adet] [int] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Satislar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServisTuru]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServisTuru](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServisAdi] [nvarchar](50) NULL,
	[Aciklama] [text] NULL,
 CONSTRAINT [PK_ServisTuru] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 4.08.2023 16:34:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KategoriId] [int] NULL,
	[UrunAd] [nvarchar](100) NULL,
	[Aciklama] [text] NULL,
	[Fiyat] [money] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Adisyonlar] ON 

INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (4, 1, 1, 2, CAST(N'2023-08-03T17:09:01.160' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (5, 1, 1, 3, CAST(N'2023-08-03T17:09:18.080' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (6, 1, 1, 7, CAST(N'2023-08-04T16:27:57.367' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Adisyonlar] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategoriler] ON 

INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (1, N'Çorbalar', N'Çorbalar', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (2, N'Ara Sıcaklar', N'Ara Sıcaklar', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (3, N'Ana Yemek', N'Ana Yemek', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (4, N'Makarnalar', N'Makarnalar', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (5, N'Fast Food', N'Fast Food', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (6, N'Salatalar', N'Salatalar', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (7, N'Tatlılar', N'Tatlılar', 0)
INSERT [dbo].[Kategoriler] ([ID], [KategoriAdi], [Aciklama], [Durum]) VALUES (8, N'İçecekler', N'İçecekler', 0)
SET IDENTITY_INSERT [dbo].[Kategoriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Masalar] ON 

INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (1, 5, 1, 2, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (2, 3, 1, 2, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (3, 5, 1, 3, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (4, 4, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (5, 7, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (6, 3, 1, 2, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (7, 6, 1, 2, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (8, 10, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (9, 9, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (10, 8, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Masalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (1, 3, N'Ahmet', N'ŞAHİN', N'0000', N'ahmetsahin', 0)
INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (2, 2, N'Merve', N'ŞAHİN', N'1111', N'mervesahin', 0)
INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (3, 1, N'Melike', N'TAZRİ', N'2222', N'meliketazri', 0)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonelGorevleri] ON 

INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (1, N'Komi', N'Komi', 0)
INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (2, N'Bulaşıkçı', N'Baş Bulaşıkçı', 0)
INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (3, N'Şef', N'Şef', 0)
SET IDENTITY_INSERT [dbo].[PersonelGorevleri] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonelHareketleri] ON 

INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (1, 2, N'Giriş Yaptı', CAST(N'2023-08-03T13:46:41.273' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (2, 1, N'Giriş Yaptı', CAST(N'2023-08-03T13:47:14.473' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (3, 1, N'Giriş Yaptı', CAST(N'2023-08-03T14:16:26.873' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (4, 1, N'Giriş Yaptı', CAST(N'2023-08-03T16:01:10.537' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (5, 3, N'Giriş Yaptı', CAST(N'2023-08-03T16:17:35.087' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (6, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:03:00.680' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (7, 2, N'Giriş Yaptı', CAST(N'2023-08-03T17:04:30.407' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (8, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:05:16.207' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (9, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:12:12.450' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (10, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:13:11.413' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (11, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:13:58.317' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (12, 1, N'Giriş Yaptı', CAST(N'2023-08-03T17:15:03.307' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (13, 1, N'Giriş Yaptı', CAST(N'2023-08-04T07:49:59.703' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (14, 1, N'Giriş Yaptı', CAST(N'2023-08-04T08:00:10.900' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (15, 1, N'Giriş Yaptı', CAST(N'2023-08-04T08:08:46.563' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (16, 1, N'Giriş Yaptı', CAST(N'2023-08-04T11:41:27.557' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (17, 1, N'Giriş Yaptı', CAST(N'2023-08-04T14:30:33.040' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (18, 1, N'Giriş Yaptı', CAST(N'2023-08-04T14:59:19.963' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (19, 2, N'Giriş Yaptı', CAST(N'2023-08-04T15:28:55.037' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (20, 1, N'Giriş Yaptı', CAST(N'2023-08-04T15:30:35.397' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (21, 1, N'Giriş Yaptı', CAST(N'2023-08-04T15:32:38.500' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (22, 1, N'Giriş Yaptı', CAST(N'2023-08-04T15:35:28.373' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (23, 1, N'Giriş Yaptı', CAST(N'2023-08-04T16:12:15.013' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (24, 1, N'Giriş Yaptı', CAST(N'2023-08-04T16:14:02.703' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (25, 1, N'Giriş Yaptı', CAST(N'2023-08-04T16:17:45.433' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (26, 3, N'Giriş Yaptı', CAST(N'2023-08-04T16:24:43.163' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (27, 1, N'Giriş Yaptı', CAST(N'2023-08-04T16:27:29.443' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[PersonelHareketleri] OFF
GO
SET IDENTITY_INSERT [dbo].[Satislar] ON 

INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (1, 0, 44, 1, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (2, 0, 46, 1, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (3, 0, 45, 1, 2, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (4, 0, 30, 6, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (5, 0, 1, 6, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (6, 6, 44, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (7, 6, 43, 7, 10, 0)
SET IDENTITY_INSERT [dbo].[Satislar] OFF
GO
SET IDENTITY_INSERT [dbo].[ServisTuru] ON 

INSERT [dbo].[ServisTuru] ([ID], [ServisAdi], [Aciklama]) VALUES (1, N'Komi', N'Komi')
INSERT [dbo].[ServisTuru] ([ID], [ServisAdi], [Aciklama]) VALUES (2, N'Garson', N'Garson')
INSERT [dbo].[ServisTuru] ([ID], [ServisAdi], [Aciklama]) VALUES (3, N'Aşçı', N'Aşçı')
SET IDENTITY_INSERT [dbo].[ServisTuru] OFF
GO
SET IDENTITY_INSERT [dbo].[Urunler] ON 

INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (1, 1, N'Tarhana', N'Güzel Yemek', 2.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (2, 1, N'Domates', N'Güzel Yemek', 2.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (3, 1, N'Mercimek Çorbası', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (4, 1, N'Ezogelin', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (5, 1, N'Yayla', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (6, 1, N'İşkembe', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (7, 2, N'Patates Kızartması', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (8, 2, N'Fırında Patates', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (9, 2, N'Sosis-Patates Tava', N'Güzel Yemek', 6.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (10, 2, N'Patates Kroket', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (11, 2, N'Sigara Böreği', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (12, 2, N'Paçanga Böreği', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (13, 3, N'Tavuk Izgara', N'Güzel Yemek', 10.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (14, 3, N'Kremalı Mantar', N'Güzel Yemek', 11.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (15, 3, N'Schnitzel', N'Güzel Yemek', 10.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (16, 3, N'Kanat Izgara', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (17, 3, N'Bonfile', N'Güzel Yemek', 11.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (18, 3, N'Köfte Tabağı', N'Güzel Yemek', 12.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (19, 3, N'Kaşarlı Pide', N'Güzel Yemek', 8.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (20, 3, N'Kıymalı Pide', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (21, 3, N'Kaşarlı Sucuklu', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (22, 3, N'Kuşbaşılı Pide', N'Güzel Yemek', 10.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (23, 3, N'Lahmacun', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (24, 4, N'Spagetti Bolonez', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (25, 4, N'Spagetti Napoli', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (26, 4, N'Penne Arabiatta', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (27, 4, N'Penne Bologne', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (28, 5, N'Tavuk Şiş Dürüm', N'Güzel Yemek', 7.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (29, 5, N'Çöp Şiş Dürüm', N'Güzel Yemek', 8.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (30, 5, N'Adana Dürüm', N'Güzel Yemek', 8.5000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (31, 5, N'Köfte Dürüm', N'Güzel Yemek', 9.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (32, 6, N'Çoban Salata', N'Güzel Yemek', 4.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (33, 6, N'Mevsim Salata', N'Güzel Yemek', 4.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (34, 6, N'Peynir Salatası', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (35, 6, N'Tonbalıklı Salata', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (36, 7, N'Baklava', N'Güzel Yemek', 7.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (37, 7, N'Künefe', N'Güzel Yemek', 6.5000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (38, 7, N'Fırın Sütlaç', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (39, 7, N'Kazandibi', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (40, 7, N'Tavuk Göğsü', N'Güzel Yemek', 5.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (41, 7, N'Profiterol', N'Güzel Yemek', 6.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (42, 7, N'Sufle', N'Güzel Yemek', 6.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (43, 8, N'Ayran', N'Güzel Yemek', 2.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (44, 8, N'Şalgam', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (45, 8, N'Soda', N'Güzel Yemek', 2.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (46, 8, N'Meyveli Soda', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (47, 8, N'Kola', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (48, 8, N'Fanta', N'Güzel Yemek', 3.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (49, 8, N'Çay', N'Güzel Yemek', 2.0000, 0)
INSERT [dbo].[Urunler] ([ID], [KategoriId], [UrunAd], [Aciklama], [Fiyat], [Durum]) VALUES (50, 8, N'Türk Kahvesi', N'Güzel Yemek', 5.0000, 0)
SET IDENTITY_INSERT [dbo].[Urunler] OFF
GO
ALTER TABLE [dbo].[Adisyonlar] ADD  CONSTRAINT [DF_Adisyonlar_Tarih]  DEFAULT (getdate()) FOR [Tarih]
GO
ALTER TABLE [dbo].[Adisyonlar] ADD  CONSTRAINT [DF_Adisyonlar_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[HesapOdemeleri] ADD  CONSTRAINT [DF_HesapOdemeleri_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Kategoriler] ADD  CONSTRAINT [DF_Kategoriler_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Masalar] ADD  CONSTRAINT [DF_Masalar_Durum]  DEFAULT ((1)) FOR [Durum]
GO
ALTER TABLE [dbo].[Masalar] ADD  CONSTRAINT [DF_Masalar_Onay]  DEFAULT ((0)) FOR [Onay]
GO
ALTER TABLE [dbo].[Musteriler] ADD  CONSTRAINT [DF_Musteriler_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[OdemeTurleri] ADD  CONSTRAINT [DF_OdemeTurleri_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[PaketSiparis] ADD  CONSTRAINT [DF_PaketSiparis_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Personel] ADD  CONSTRAINT [DF_Personel_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[PersonelGorevleri] ADD  CONSTRAINT [DF_PersonelGorevleri_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[PersonelHareketleri] ADD  CONSTRAINT [DF_PersonelHareketleri_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Rezervasyonlar] ADD  CONSTRAINT [DF_Rezervasyonlar_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Satislar] ADD  CONSTRAINT [DF_Satislar_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Urunler] ADD  CONSTRAINT [DF_Urunler_Durum]  DEFAULT ((0)) FOR [Durum]
GO
ALTER TABLE [dbo].[Adisyonlar]  WITH CHECK ADD  CONSTRAINT [FK_Adisyonlar_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([ID])
GO
ALTER TABLE [dbo].[Adisyonlar] CHECK CONSTRAINT [FK_Adisyonlar_Personel]
GO
ALTER TABLE [dbo].[Adisyonlar]  WITH CHECK ADD  CONSTRAINT [FK_Adisyonlar_ServisTuru] FOREIGN KEY([ServisTurNo])
REFERENCES [dbo].[ServisTuru] ([ID])
GO
ALTER TABLE [dbo].[Adisyonlar] CHECK CONSTRAINT [FK_Adisyonlar_ServisTuru]
GO
ALTER TABLE [dbo].[HesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_HesapOdemeleri_Adisyonlar] FOREIGN KEY([AdisyonId])
REFERENCES [dbo].[Adisyonlar] ([ID])
GO
ALTER TABLE [dbo].[HesapOdemeleri] CHECK CONSTRAINT [FK_HesapOdemeleri_Adisyonlar]
GO
ALTER TABLE [dbo].[HesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_HesapOdemeleri_Musteriler] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteriler] ([ID])
GO
ALTER TABLE [dbo].[HesapOdemeleri] CHECK CONSTRAINT [FK_HesapOdemeleri_Musteriler]
GO
ALTER TABLE [dbo].[HesapOdemeleri]  WITH CHECK ADD  CONSTRAINT [FK_HesapOdemeleri_OdemeTurleri] FOREIGN KEY([OdemeTurId])
REFERENCES [dbo].[OdemeTurleri] ([ID])
GO
ALTER TABLE [dbo].[HesapOdemeleri] CHECK CONSTRAINT [FK_HesapOdemeleri_OdemeTurleri]
GO
ALTER TABLE [dbo].[PaketSiparis]  WITH CHECK ADD  CONSTRAINT [FK_PaketSiparis_Musteriler] FOREIGN KEY([MusteriId])
REFERENCES [dbo].[Musteriler] ([ID])
GO
ALTER TABLE [dbo].[PaketSiparis] CHECK CONSTRAINT [FK_PaketSiparis_Musteriler]
GO
ALTER TABLE [dbo].[PaketSiparis]  WITH CHECK ADD  CONSTRAINT [FK_PaketSiparis_OdemeTurleri] FOREIGN KEY([OdemeTurId])
REFERENCES [dbo].[OdemeTurleri] ([ID])
GO
ALTER TABLE [dbo].[PaketSiparis] CHECK CONSTRAINT [FK_PaketSiparis_OdemeTurleri]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_PersonelGorevleri] FOREIGN KEY([GorevId])
REFERENCES [dbo].[PersonelGorevleri] ([ID])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_PersonelGorevleri]
GO
ALTER TABLE [dbo].[Rezervasyonlar]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyonlar_Adisyonlar] FOREIGN KEY([AdisyonId])
REFERENCES [dbo].[Adisyonlar] ([ID])
GO
ALTER TABLE [dbo].[Rezervasyonlar] CHECK CONSTRAINT [FK_Rezervasyonlar_Adisyonlar]
GO
ALTER TABLE [dbo].[Rezervasyonlar]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyonlar_Masalar] FOREIGN KEY([MasaId])
REFERENCES [dbo].[Masalar] ([ID])
GO
ALTER TABLE [dbo].[Rezervasyonlar] CHECK CONSTRAINT [FK_Rezervasyonlar_Masalar]
GO
ALTER TABLE [dbo].[Satislar]  WITH CHECK ADD  CONSTRAINT [FK_Satislar_Urunler] FOREIGN KEY([UrunId])
REFERENCES [dbo].[Urunler] ([ID])
GO
ALTER TABLE [dbo].[Satislar] CHECK CONSTRAINT [FK_Satislar_Urunler]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Kategoriler] FOREIGN KEY([KategoriId])
REFERENCES [dbo].[Kategoriler] ([ID])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Kategoriler]
GO
