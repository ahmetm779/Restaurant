USE [Restaurant]
GO
/****** Object:  Table [dbo].[Adisyonlar]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[HesapOdemeleri]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Kategoriler]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Masalar]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Musteriler]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[OdemeTurleri]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[PaketSiparis]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Personel]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[PersonelGorevleri]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[PersonelHareketleri]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Rezervasyonlar]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Satislar]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[ServisTuru]    Script Date: 11.09.2023 23:01:53 ******/
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
/****** Object:  Table [dbo].[Urunler]    Script Date: 11.09.2023 23:01:53 ******/
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
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (7, 1, 1, 1, CAST(N'2023-08-07T15:49:21.973' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (8, 1, 1, 2, CAST(N'2023-08-07T15:51:38.173' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (9, 1, 1, 9, CAST(N'2023-08-07T15:54:05.617' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (10, 1, 1, 5, CAST(N'2023-08-07T15:56:37.910' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (11, 1, 1, 7, CAST(N'2023-08-07T16:01:43.913' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (12, 1, 1, 4, CAST(N'2023-08-07T16:06:29.557' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (13, 1, 1, 8, CAST(N'2023-08-07T19:03:40.010' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (14, 1, 1, 5, CAST(N'2023-08-07T22:27:15.190' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (15, 1, 1, 9, CAST(N'2023-08-09T16:36:28.373' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (16, 1, 1, 4, CAST(N'2023-08-09T17:00:05.157' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (17, 2, 1, NULL, CAST(N'2023-08-13T14:04:03.103' AS DateTime), 0)
INSERT [dbo].[Adisyonlar] ([ID], [ServisTurNo], [PersonelId], [MasaId], [Tarih], [Durum]) VALUES (18, 2, 1, NULL, CAST(N'2023-08-13T14:29:39.783' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Adisyonlar] OFF
GO
SET IDENTITY_INSERT [dbo].[HesapOdemeleri] ON 

INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (1, 15, 1, 1, 24.5000, 4.4100, 1.0000, 25.5000, CAST(N'2023-08-09T16:37:46.963' AS DateTime), 0)
INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (2, 17, 1, 1, 21.0000, 3.7800, 0.0000, 21.0000, CAST(N'2023-08-15T11:11:46.350' AS DateTime), 0)
INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (3, 17, 1, 1, 21.0000, 3.7800, 0.0000, 21.0000, CAST(N'2023-08-15T11:13:23.967' AS DateTime), 0)
INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (4, 17, 1, 1, 21.0000, 3.7800, 0.0000, 21.0000, CAST(N'2023-08-15T11:15:58.960' AS DateTime), 0)
INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (5, 18, 1, 1, 9.0000, 1.6200, 0.0000, 9.0000, CAST(N'2023-08-15T11:19:51.953' AS DateTime), 0)
INSERT [dbo].[HesapOdemeleri] ([ID], [AdisyonId], [OdemeTurId], [MusteriId], [AraToplam], [KDVTutari], [Indirim], [ToplamTutar], [Tarih], [Durum]) VALUES (6, 18, 1, 1, 9.0000, 1.6200, 0.0000, 9.0000, CAST(N'2023-08-15T11:38:22.050' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[HesapOdemeleri] OFF
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

INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (1, 5, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (2, 3, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (3, 5, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (4, 4, 1, 2, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (5, 7, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (6, 3, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (7, 6, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (8, 10, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (9, 9, 1, 1, 0)
INSERT [dbo].[Masalar] ([ID], [Kapasite], [ServisTuru], [Durum], [Onay]) VALUES (10, 8, 1, 1, 0)
SET IDENTITY_INSERT [dbo].[Masalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([ID], [Ad], [Soyad], [Adres], [Telefon], [IlkSiparis], [Email], [SiparisSayisi], [Durum]) VALUES (1, N'Standart', N'Müşteri', N'Ankara', N'5552222222', NULL, NULL, NULL, 0)
INSERT [dbo].[Musteriler] ([ID], [Ad], [Soyad], [Adres], [Telefon], [IlkSiparis], [Email], [SiparisSayisi], [Durum]) VALUES (2, N'ahmet', N'şahin', N'Ankara', N'05368461364', NULL, N'ahmetm779@gmail.com', NULL, 0)
INSERT [dbo].[Musteriler] ([ID], [Ad], [Soyad], [Adres], [Telefon], [IlkSiparis], [Email], [SiparisSayisi], [Durum]) VALUES (3, N'Merve', N'Şahin', N'İstanbul', N'12345678911', NULL, N'merve@gmail.com', NULL, 0)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[OdemeTurleri] ON 

INSERT [dbo].[OdemeTurleri] ([ID], [OdemeTuru], [Aciklama], [Durum]) VALUES (1, N'Nakit', N'Nakit Ödeme', 0)
INSERT [dbo].[OdemeTurleri] ([ID], [OdemeTuru], [Aciklama], [Durum]) VALUES (2, N'Kredi Kartı', N'Kredi Kartıyla Ödeme', 0)
INSERT [dbo].[OdemeTurleri] ([ID], [OdemeTuru], [Aciklama], [Durum]) VALUES (3, N'Ticket', N'Ticket ile Ödeme', 0)
SET IDENTITY_INSERT [dbo].[OdemeTurleri] OFF
GO
SET IDENTITY_INSERT [dbo].[PaketSiparis] ON 

INSERT [dbo].[PaketSiparis] ([ID], [MusteriId], [AdisyonId], [OdemeTurId], [Aciklama], [Durum]) VALUES (1, 2, 17, 1, NULL, 0)
INSERT [dbo].[PaketSiparis] ([ID], [MusteriId], [AdisyonId], [OdemeTurId], [Aciklama], [Durum]) VALUES (2, 3, 18, 1, NULL, 1)
SET IDENTITY_INSERT [dbo].[PaketSiparis] OFF
GO
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (1, 3, N'Ahmet', N'ŞAHİN', N'0000', N'ahmetsahin', 0)
INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (2, 2, N'Merve', N'ŞAHİN', N'1111', N'mervesahin', 0)
INSERT [dbo].[Personel] ([ID], [GorevId], [Ad], [Soyad], [Parola], [KullaniciAdi], [Durum]) VALUES (3, 1, N'Melike', N'TAZRİ', N'2222', N'meliketazri', 0)
SET IDENTITY_INSERT [dbo].[Personel] OFF
GO
SET IDENTITY_INSERT [dbo].[PersonelGorevleri] ON 

INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (1, N'Müdür', N'Müdür', 0)
INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (2, N'Bulaşıkçı', N'Bulaşıkçı', 0)
INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (3, N'Şef', N'Şef', 0)
INSERT [dbo].[PersonelGorevleri] ([ID], [Gorev], [Aciklama], [Durum]) VALUES (4, N'Komi', N'Komi', 0)
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
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (28, 1, N'Giriş Yaptı', CAST(N'2023-08-07T14:59:45.353' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (29, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:00:31.643' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (30, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:06:07.117' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (31, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:08:55.960' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (32, 3, N'Giriş Yaptı', CAST(N'2023-08-07T15:32:34.383' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (33, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:36:47.450' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (34, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:48:37.057' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (35, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:50:54.103' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (36, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:52:05.290' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (37, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:53:46.680' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (38, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:56:14.630' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (39, 1, N'Giriş Yaptı', CAST(N'2023-08-07T15:59:19.370' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (40, 2, N'Giriş Yaptı', CAST(N'2023-08-07T16:01:03.627' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (41, 2, N'Giriş Yaptı', CAST(N'2023-08-07T16:03:30.923' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (42, 2, N'Giriş Yaptı', CAST(N'2023-08-07T16:04:38.580' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (43, 1, N'Giriş Yaptı', CAST(N'2023-08-07T16:06:18.707' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (44, 1, N'Giriş Yaptı', CAST(N'2023-08-07T16:06:43.183' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (45, 1, N'Giriş Yaptı', CAST(N'2023-08-07T17:45:07.500' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (46, 2, N'Giriş Yaptı', CAST(N'2023-08-07T17:47:44.700' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (47, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:42:04.377' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (48, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:47:49.427' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (49, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:48:24.987' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (50, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:54:04.013' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (51, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:54:45.157' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (52, 1, N'Giriş Yaptı', CAST(N'2023-08-07T18:59:50.030' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (53, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:03:01.290' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (54, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:04:04.743' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (55, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:04:59.243' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (56, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:05:44.187' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (57, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:09:19.930' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (58, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:19:03.040' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (59, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:19:40.250' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (60, 1, N'Giriş Yaptı', CAST(N'2023-08-07T19:27:07.317' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (61, 1, N'Giriş Yaptı', CAST(N'2023-08-07T22:26:25.387' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (62, 1, N'Giriş Yaptı', CAST(N'2023-08-07T22:27:35.393' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (63, 1, N'Giriş Yaptı', CAST(N'2023-08-07T22:41:58.040' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (64, 1, N'Giriş Yaptı', CAST(N'2023-08-07T22:43:06.257' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (65, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:09:11.720' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (66, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:10:00.990' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (67, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:10:15.623' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (68, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:13:45.763' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (69, 2, N'Giriş Yaptı', CAST(N'2023-08-09T10:15:56.617' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (70, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:24:08.747' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (71, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:26:54.977' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (72, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:29:44.140' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (73, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:33:00.880' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (74, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:34:24.913' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (75, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:36:34.713' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (76, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:40:50.923' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (77, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:42:11.553' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (78, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:44:21.890' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (79, 1, N'Giriş Yaptı', CAST(N'2023-08-09T10:48:11.703' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (80, 1, N'Giriş Yaptı', CAST(N'2023-08-09T16:35:55.500' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (81, 1, N'Giriş Yaptı', CAST(N'2023-08-09T16:36:44.383' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (82, 1, N'Giriş Yaptı', CAST(N'2023-08-09T16:36:59.623' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (83, 1, N'Giriş Yaptı', CAST(N'2023-08-09T16:59:39.133' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (84, 1, N'Giriş Yaptı', CAST(N'2023-08-09T17:00:13.090' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (85, 1, N'Giriş Yaptı', CAST(N'2023-08-10T14:50:48.177' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (86, 1, N'Giriş Yaptı', CAST(N'2023-08-10T14:52:12.880' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (87, 1, N'Giriş Yaptı', CAST(N'2023-08-11T14:35:02.113' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (88, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:09:42.817' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (89, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:10:27.987' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (90, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:11:02.647' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (91, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:11:38.110' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (92, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:38:26.957' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (93, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:54:06.287' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (94, 1, N'Giriş Yaptı', CAST(N'2023-08-11T15:55:44.640' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (95, 1, N'Giriş Yaptı', CAST(N'2023-08-11T16:09:52.247' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (96, 1, N'Giriş Yaptı', CAST(N'2023-08-11T16:12:35.450' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (97, 1, N'Giriş Yaptı', CAST(N'2023-08-11T16:17:21.883' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (98, 1, N'Giriş Yaptı', CAST(N'2023-08-11T16:25:24.393' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (99, 1, N'Giriş Yaptı', CAST(N'2023-08-11T16:35:58.010' AS DateTime), 0)
GO
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (100, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:25:29.133' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (101, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:27:20.840' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (102, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:29:05.300' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (103, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:31:10.397' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (104, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:34:23.510' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (105, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:35:20.267' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (106, 1, N'Giriş Yaptı', CAST(N'2023-08-13T14:55:35.357' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (107, 1, N'Giriş Yaptı', CAST(N'2023-08-15T09:36:57.367' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (108, 1, N'Giriş Yaptı', CAST(N'2023-08-15T10:22:17.860' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (109, 1, N'Giriş Yaptı', CAST(N'2023-08-15T10:43:22.550' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (110, 1, N'Giriş Yaptı', CAST(N'2023-08-15T10:46:27.927' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (111, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:08:29.317' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (112, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:11:27.747' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (113, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:13:10.643' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (114, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:14:55.073' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (115, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:18:38.077' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (116, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:21:09.777' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (117, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:21:50.327' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (118, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:25:29.157' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (119, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:27:30.750' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (120, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:28:18.940' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (121, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:36:58.990' AS DateTime), 0)
INSERT [dbo].[PersonelHareketleri] ([ID], [PersonelId], [Islem], [Tarih], [Durum]) VALUES (122, 1, N'Giriş Yaptı', CAST(N'2023-08-15T11:37:40.010' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[PersonelHareketleri] OFF
GO
SET IDENTITY_INSERT [dbo].[Satislar] ON 

INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (6, 6, 44, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (7, 6, 43, 7, 10, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (10, 8, 45, 2, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (11, 8, 47, 2, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (12, 8, 50, 2, 2, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (13, 9, 29, 9, 5, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (14, 10, 4, 5, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (15, 10, 26, 5, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (16, 11, 13, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (17, 11, 11, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (18, 11, 24, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (19, 11, 30, 7, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (20, 12, 44, 4, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (21, 12, 39, 4, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (23, 13, 33, 8, 2, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (25, 13, 23, 8, 5, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (27, 7, 17, 1, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (28, 7, 43, 1, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (30, 14, 44, 5, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (32, 15, 13, 9, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (33, 15, 43, 9, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (34, 15, 34, 9, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (35, 15, 30, 9, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (37, 16, 14, 4, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (38, 16, 17, 4, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (39, 16, 45, 4, 3, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (40, 17, 2, NULL, 2, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (41, 17, 10, NULL, 3, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (42, 17, 1, NULL, 1, 0)
INSERT [dbo].[Satislar] ([ID], [AdisyonId], [UrunId], [MasaId], [Adet], [Durum]) VALUES (43, 18, 25, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Satislar] OFF
GO
SET IDENTITY_INSERT [dbo].[ServisTuru] ON 

INSERT [dbo].[ServisTuru] ([ID], [ServisAdi], [Aciklama]) VALUES (1, N'Masa', N'Masa')
INSERT [dbo].[ServisTuru] ([ID], [ServisAdi], [Aciklama]) VALUES (2, N'Paket Servis', N'Paket Servis')
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
ALTER TABLE [dbo].[HesapOdemeleri] ADD  CONSTRAINT [DF_HesapOdemeleri_Tarih]  DEFAULT (getdate()) FOR [Tarih]
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
/****** Object:  StoredProcedure [dbo].[MusteriVarmi]    Script Date: 11.09.2023 23:01:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[MusteriVarmi]
	-- Add the parameters for the stored procedure here
	@Telefon varchar(11),
	@sonuc bit output
AS
	SET @sonuc=0

    -- Insert statements for procedure here
	if exists (select * from Musteriler where Telefon=@Telefon)
	begin
		set @sonuc=1
	end
GO
