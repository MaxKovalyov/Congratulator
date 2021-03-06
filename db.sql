USE [master]
GO
/****** Object:  Database [Person]    Script Date: 15.07.2021 11:48:05 ******/
CREATE DATABASE [Person]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Person', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Person.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Person_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Person_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Person] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Person].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Person] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Person] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Person] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Person] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Person] SET ARITHABORT OFF 
GO
ALTER DATABASE [Person] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Person] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Person] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Person] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Person] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Person] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Person] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Person] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Person] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Person] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Person] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Person] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Person] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Person] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Person] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Person] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Person] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Person] SET RECOVERY FULL 
GO
ALTER DATABASE [Person] SET  MULTI_USER 
GO
ALTER DATABASE [Person] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Person] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Person] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Person] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Person] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Person] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Person', N'ON'
GO
ALTER DATABASE [Person] SET QUERY_STORE = OFF
GO
USE [Person]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15.07.2021 11:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 15.07.2021 11:48:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[dayBirth] [int] NOT NULL,
	[monthBirth] [int] NOT NULL,
	[category] [nvarchar](max) NULL,
	[urlImg] [nvarchar](max) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210714094759_Initial', N'5.0.8')
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (1, N'Yuki Asuna', 19, 7, N'Friends', N'/img/asuna.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (2, N'Geralt iz Rivii', 29, 11, N'Professors', N'/img/geralt.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (3, N'Viktor Pushkin', 15, 7, N'Collega', N'/img/1.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (4, N'Levy Leonhart', 16, 7, N'Professors', N'/img/levy.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (5, N'Pokemon Pikachu', 17, 7, N'Familiars', N'/img/pikachu.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (6, N'Kristiano Ronaldo', 14, 7, N'Friends', N'/img/ronaldo.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (8, N'Ciri Swallow', 15, 7, N'Family', N'/img/ciri.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (9, N'Remuru Tempest', 16, 7, N'Family', N'/img/sliz.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (26, N'God Thor', 14, 7, N'Friends', N'/img/thor.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (27, N'Dominic Torreto', 15, 7, N'Collega', N'/img/forsag.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (28, N'My dog Roxi', 18, 7, N'Friends', N'/img/dog.jpg')
INSERT [dbo].[Person] ([Id], [name], [dayBirth], [monthBirth], [category], [urlImg]) VALUES (29, N'Some girl', 20, 10, N'Familiar', N'/img/nogame.png')
SET IDENTITY_INSERT [dbo].[Person] OFF
GO
USE [master]
GO
ALTER DATABASE [Person] SET  READ_WRITE 
GO
