USE [master]
GO
/****** Object:  Database [DB_Hopital]    Script Date: 2020-04-04 23:15:36 ******/
CREATE DATABASE [DB_Hopital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Hopital', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DB_Hopital.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_Hopital_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DB_Hopital_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_Hopital] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Hopital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Hopital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Hopital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Hopital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Hopital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Hopital] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Hopital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Hopital] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Hopital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Hopital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Hopital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Hopital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Hopital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Hopital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Hopital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Hopital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Hopital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Hopital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Hopital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Hopital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Hopital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Hopital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Hopital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Hopital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Hopital] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Hopital] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Hopital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Hopital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Hopital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Hopital] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Hopital', N'ON'
GO
USE [DB_Hopital]
GO
/****** Object:  Table [dbo].[CompagnieAssurance]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompagnieAssurance](
	[idCompanie] [nvarchar](15) NOT NULL,
	[nomCompagnie] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idCompanie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departement]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departement](
	[idDepartement] [nvarchar](15) NOT NULL,
	[nomDepartement] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepartement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DossierAdmission]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DossierAdmission](
	[idAdmission] [nvarchar](15) NOT NULL,
	[chirurgieProgramme] [bit] NULL,
	[dateAdmission] [date] NULL,
	[dateChirurgie] [date] NULL,
	[dateConge] [date] NULL,
	[prixTv] [float] NULL,
	[prixTel] [float] NULL,
	[prixCh] [float] NULL,
	[numLit] [nvarchar](15) NOT NULL,
	[nss] [nvarchar](15) NOT NULL,
	[idMedecin] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK__DossierA__1057BCEFA7D2322B] PRIMARY KEY CLUSTERED 
(
	[idAdmission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lit]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lit](
	[numLit] [nvarchar](15) NOT NULL,
	[occupe] [bit] NULL,
	[numeroType] [nvarchar](15) NOT NULL,
	[idDepartement] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numLit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medecin]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medecin](
	[idMedecin] [nvarchar](15) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[idSpecialite] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedecin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parent]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parent](
	[refParent] [nvarchar](15) NOT NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[adresse] [nvarchar](50) NULL,
	[ville] [nvarchar](50) NULL,
	[province] [nvarchar](50) NULL,
	[codepostal] [nvarchar](10) NULL,
	[telephone] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[refParent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[nss] [nvarchar](15) NOT NULL,
	[dateNaissance] [date] NULL,
	[nom] [nvarchar](50) NULL,
	[prenom] [nvarchar](50) NULL,
	[adresse] [nvarchar](50) NULL,
	[ville] [nvarchar](50) NULL,
	[province] [nvarchar](50) NULL,
	[codePostal] [nvarchar](10) NULL,
	[telephone] [nvarchar](10) NULL,
	[idCompanie] [nvarchar](15) NOT NULL,
	[refParent] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK__Patient__DF90FDB02A4BED13] PRIMARY KEY CLUSTERED 
(
	[nss] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Specialite]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialite](
	[idSpecialite] [nvarchar](15) NOT NULL,
	[descSpecialite] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idSpecialite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TypeLit]    Script Date: 2020-04-04 23:15:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeLit](
	[numeroType] [nvarchar](15) NOT NULL,
	[description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[numeroType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_001', N'Allstate Assurance')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_002', N'Desjardins Assurances')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_003', N'iA Groupe financier')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_004', N'Intact Assurances')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_005', N'Promutuel Assurance')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_006', N'SSQ Assurance')
INSERT [dbo].[CompagnieAssurance] ([idCompanie], [nomCompagnie]) VALUES (N'CA_007', N'RAMQ')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_00', N'General')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_01', N'Chirurgie')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_02', N'Pédiatrie')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_03', N'Neurologie')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_04', N'Pneumologie')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_05', N'Radiologie')
INSERT [dbo].[Departement] ([idDepartement], [nomDepartement]) VALUES (N'DEP_06', N'Cardiologie ')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_1', 0, CAST(N'2020-02-29' AS Date), NULL, CAST(N'2020-04-04' AS Date), 42.5, 0, 571, N'L015', N'NSS_1', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_10', 0, CAST(N'2020-01-08' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L015', N'NSS_1', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_11', 1, CAST(N'2020-01-30' AS Date), CAST(N'2020-04-22' AS Date), CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L003', N'NSS_2', N'MED_001')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_12', 1, CAST(N'2020-01-23' AS Date), CAST(N'2020-04-22' AS Date), CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L001', N'NSS_10', N'MED_001')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_13', 0, CAST(N'2020-02-09' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L006', N'NSS_3', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_14', 1, CAST(N'2020-03-23' AS Date), CAST(N'2020-04-15' AS Date), CAST(N'2020-04-04' AS Date), 42.5, 7.5, 0, N'L004', N'NSS_4', N'MED_001')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_15', 0, CAST(N'2020-03-05' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L007', N'NSS_5', N'MED_006')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_16', 0, CAST(N'2020-01-02' AS Date), NULL, NULL, 42.5, 0, 267, N'L024', N'NSS_4', N'MED_012')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_17', 0, CAST(N'2020-03-04' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L011', N'NSS_3', N'MED_012')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_18', 1, CAST(N'2020-01-23' AS Date), CAST(N'2020-04-29' AS Date), NULL, 42.5, 0, 0, N'L046', N'NSS_1', N'MED_003')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_19', 0, CAST(N'2020-02-12' AS Date), NULL, NULL, 0, 0, 0, N'L033', N'NSS_3', N'MED_015')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_2', 0, CAST(N'2020-03-22' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 571, N'L015', N'NSS_2', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_3', 1, CAST(N'2020-01-08' AS Date), CAST(N'2020-04-29' AS Date), CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L004', N'NSS_3', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_4', 0, CAST(N'2020-02-14' AS Date), NULL, CAST(N'2020-04-04' AS Date), 42.5, 7.5, 267, N'L011', N'NSS_4', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_5', 0, CAST(N'2020-02-08' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L007', N'NSS_5', N'MED_001')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_6', 1, CAST(N'2020-02-22' AS Date), CAST(N'2020-04-23' AS Date), NULL, 42.5, 0, 0, N'L002', N'NSS_6', N'MED_001')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_7', 0, CAST(N'2020-01-02' AS Date), NULL, CAST(N'2020-04-04' AS Date), 42.5, 0, 0, N'L005', N'NSS_7', N'MED_006')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_8', 0, CAST(N'2020-01-08' AS Date), NULL, CAST(N'2020-04-04' AS Date), 0, 0, 0, N'L016', N'NSS_8', N'MED_010')
INSERT [dbo].[DossierAdmission] ([idAdmission], [chirurgieProgramme], [dateAdmission], [dateChirurgie], [dateConge], [prixTv], [prixTel], [prixCh], [numLit], [nss], [idMedecin]) VALUES (N'ADMI_9', 0, CAST(N'2020-02-15' AS Date), NULL, NULL, 0, 0, 0, N'L008', N'NSS_9', N'MED_010')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L001', 0, N'1', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L002', 1, N'1', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L003', 0, N'2', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L004', 0, N'3', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L005', 0, N'1', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L006', 0, N'2', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L007', 0, N'3', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L008', 1, N'1', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L009', 0, N'1', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L010', 0, N'1', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L011', 0, N'2', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L012', 0, N'3', N'DEP_04')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L013', 0, N'1', N'DEP_04')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L014', 0, N'2', N'DEP_04')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L015', 0, N'3', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L016', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L017', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L018', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L019', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L020', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L021', 0, N'2', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L022', 0, N'3', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L023', 0, N'1', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L024', 1, N'2', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L025', 0, N'1', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L026', 0, N'1', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L027', 0, N'3', N'DEP_03')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L028', 0, N'1', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L029', 0, N'1', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L030', 0, N'2', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L031', 0, N'1', N'DEP_05')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L032', 0, N'1', N'DEP_05')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L033', 1, N'2', N'DEP_05')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L034', 0, N'3', N'DEP_05')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L035', 0, N'1', N'DEP_06')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L036', 0, N'1', N'DEP_06')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L037', 0, N'2', N'DEP_06')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L038', 0, N'3', N'DEP_06')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L039', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L040', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L041', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L042', 0, N'2', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L043', 0, N'1', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L044', 0, N'2', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L045', 0, N'3', N'DEP_00')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L046', 1, N'1', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L047', 0, N'1', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L048', 0, N'2', N'DEP_01')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L049', 0, N'1', N'DEP_02')
INSERT [dbo].[Lit] ([numLit], [occupe], [numeroType], [idDepartement]) VALUES (N'L050', 0, N'1', N'DEP_02')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_001', N'Charles', N'Bell', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_002', N'Claude ', N'Bernard', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_003', N'Alfred ', N'Blalock', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_004', N'Albert ', N'Calmette', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_005', N'Harvey ', N'Cushing', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_006', N'Jean ', N'Cruveilhier', N'SPE_02')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_007', N'Gabriel ', N'Fallope', N'SPE_02')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_008', N'Arthur ', N'Guedel', N'SPE_02')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_009', N'Robert ', N'Koch', N'SPE_02')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_010', N'Bob', N'Marly', N'SPE_03')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_011', N'Emilie', N'Lara', N'SPE_03')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_012', N'Claude ', N'Bernard', N'SPE_04')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_013', N'Jules ', N'Bordet', N'SPE_04')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_014', N'Jean ', N'Cruveilhier', N'SPE_01')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_015', N'Henri ', N'Laborit', N'SPE_04')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_016', N'Luc ', N'Montagnier', N'SPE_05')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_017', N'William ', N'Osler', N'SPE_05')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_018', N'Peter ', N'Safar', N'SPE_05')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_019', N'Armand ', N'Trousseau', N'SPE_06')
INSERT [dbo].[Medecin] ([idMedecin], [nom], [prenom], [idSpecialite]) VALUES (N'MED_020', N'Alexandre ', N'Yersin', N'SPE_06')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_1', N'nait said', N'hamid', N'2121  jary', N'Montréal', N'Québec', N'h1h5b7', N'4389273030')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_2', N'arab', N'said', N'3569  jary', N'Montréal', N'Québec', N'j1h5b7', N'4389003030')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_3', N'BELAIR ', N'maria', N'1425 RUE JAMES', N'Laval', N'Québec', N'k5j6i9', N'5143659999')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_4', N'JOHN', N'MARIA', N'1425 RUE JAMES CP 4001 SUCC A', N'VICTORIA', N'Colombie-Britannique', N'V8X 3X4', N'5148889393')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_5', N'FANTINI ', N'ARON', N'275, rue Notre-Dame Est, bur. R.134', N'Montréal', N'Québec', N'k5h 6y9', N'4389998888')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_6', N'GARCIA ', N'LUIS', N'1673 Saint Christophe ', N'Montréal', N'Québec', N'H2L 3W7', N'4381215544')
INSERT [dbo].[Parent] ([refParent], [nom], [prenom], [adresse], [ville], [province], [codepostal], [telephone]) VALUES (N'PAR_7', N'LOESER ', N'Pool', N'2000, rue Sherbrooke Ouest', N'Montréal', N'Quebec', N'H3H 1G4', N'5149992323')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_1', CAST(N'1974-06-01' AS Date), N'nait said', N'makhlouf', N'11215 boulvard pix ix', N'Montréal', N'Québec', N'h1h4b6', N'4389263535', N'CA_007', N'PAR_1')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_10', CAST(N'2004-06-01' AS Date), N'LOESER ', N'FRANCOIS', N'2000, rue Sherbrooke Ouest', N'Montréal', N'Québec', N'H3H 1G4', N'4382221010', N'CA_001', N'PAR_7')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_2', CAST(N'1986-07-01' AS Date), N'arabe', N'toufik', N'11215 boul pie ix', N'Montréal', N'Québec', N'h5k3k3', N'4381113322', N'CA_001', N'PAR_2')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_3', CAST(N'1985-07-01' AS Date), N'JOHN', N'JONES', N'1425 RUE JAMES CP 4001 SUCC A', N'VICTORIA', N'Colombie-Britannique', N'V8X 3X4', N'5141213333', N'CA_002', N'PAR_4')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_4', CAST(N'2002-06-01' AS Date), N'FANTINI ', N'LORENZO', N'275, rue Notre-Dame Est, bur. R.134', N'Montréal', N'Québec', N'H2Y 1C6', N'4382229595', N'CA_007', N'PAR_5')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_5', CAST(N'2015-07-01' AS Date), N'GARCIA ', N'ALBERT', N'1673 Saint Christophe ', N'Montréal', N'Québec', N'H2L 3W7', N'5148889693', N'CA_004', N'PAR_6')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_6', CAST(N'2010-08-01' AS Date), N'nait said', N'yacine', N'11215 boul pie ix', N'Montréal', N'Québec', N'h1h 4b6', N'4389273535', N'CA_007', N'PAR_1')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_7', CAST(N'2013-07-01' AS Date), N'arabe', N'hocine', N'555 rue Jary', N'Montréal', N'Québec', N'r9r 9h9', N'5142223636', N'CA_007', N'PAR_2')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_8', CAST(N'1990-09-01' AS Date), N'BELAIR ', N'JOE', N'1896 JEAN TALON', N'Montréal', N'Québec', N'G5G H8N', N'4389517755', N'CA_005', N'PAR_3')
INSERT [dbo].[Patient] ([nss], [dateNaissance], [nom], [prenom], [adresse], [ville], [province], [codePostal], [telephone], [idCompanie], [refParent]) VALUES (N'NSS_9', CAST(N'1993-05-01' AS Date), N'arabe', N'omar', N'159 Jean Talon', N'Montréal', N'Québec', N'G5H 6J5', N'5148889494', N'CA_005', N'PAR_2')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_01', N'Chirurgien')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_02', N'Pediatre')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_03', N'Pneumologue')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_04', N'Cardiologue')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_05', N'Radiologue')
INSERT [dbo].[Specialite] ([idSpecialite], [descSpecialite]) VALUES (N'SPE_06', N'Neurologue')
INSERT [dbo].[TypeLit] ([numeroType], [description]) VALUES (N'1', N'standard')
INSERT [dbo].[TypeLit] ([numeroType], [description]) VALUES (N'2', N'semi-privée')
INSERT [dbo].[TypeLit] ([numeroType], [description]) VALUES (N'3', N'privée')
ALTER TABLE [dbo].[DossierAdmission]  WITH CHECK ADD  CONSTRAINT [fk_lit] FOREIGN KEY([numLit])
REFERENCES [dbo].[Lit] ([numLit])
GO
ALTER TABLE [dbo].[DossierAdmission] CHECK CONSTRAINT [fk_lit]
GO
ALTER TABLE [dbo].[DossierAdmission]  WITH CHECK ADD  CONSTRAINT [fk_medecin_doss] FOREIGN KEY([idMedecin])
REFERENCES [dbo].[Medecin] ([idMedecin])
GO
ALTER TABLE [dbo].[DossierAdmission] CHECK CONSTRAINT [fk_medecin_doss]
GO
ALTER TABLE [dbo].[DossierAdmission]  WITH CHECK ADD  CONSTRAINT [fk_patient_doss] FOREIGN KEY([nss])
REFERENCES [dbo].[Patient] ([nss])
GO
ALTER TABLE [dbo].[DossierAdmission] CHECK CONSTRAINT [fk_patient_doss]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [fk_lit_dep] FOREIGN KEY([idDepartement])
REFERENCES [dbo].[Departement] ([idDepartement])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [fk_lit_dep]
GO
ALTER TABLE [dbo].[Lit]  WITH CHECK ADD  CONSTRAINT [fk_lit_type] FOREIGN KEY([numeroType])
REFERENCES [dbo].[TypeLit] ([numeroType])
GO
ALTER TABLE [dbo].[Lit] CHECK CONSTRAINT [fk_lit_type]
GO
ALTER TABLE [dbo].[Medecin]  WITH CHECK ADD  CONSTRAINT [FK_Medecin_Specialite] FOREIGN KEY([idSpecialite])
REFERENCES [dbo].[Specialite] ([idSpecialite])
GO
ALTER TABLE [dbo].[Medecin] CHECK CONSTRAINT [FK_Medecin_Specialite]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [fk_patient_ass] FOREIGN KEY([idCompanie])
REFERENCES [dbo].[CompagnieAssurance] ([idCompanie])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [fk_patient_ass]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [fk_patient_parent] FOREIGN KEY([refParent])
REFERENCES [dbo].[Parent] ([refParent])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [fk_patient_parent]
GO
USE [master]
GO
ALTER DATABASE [DB_Hopital] SET  READ_WRITE 
GO
