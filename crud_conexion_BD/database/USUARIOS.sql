USE [master]
GO
/****** Object:  Database [USUARIOS]    Script Date: 16/05/2023 9:26:57 p. m. ******/
CREATE DATABASE [USUARIOS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'USUARIOS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\USUARIOS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'USUARIOS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\USUARIOS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [USUARIOS] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [USUARIOS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [USUARIOS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [USUARIOS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [USUARIOS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [USUARIOS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [USUARIOS] SET ARITHABORT OFF 
GO
ALTER DATABASE [USUARIOS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [USUARIOS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [USUARIOS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [USUARIOS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [USUARIOS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [USUARIOS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [USUARIOS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [USUARIOS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [USUARIOS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [USUARIOS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [USUARIOS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [USUARIOS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [USUARIOS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [USUARIOS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [USUARIOS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [USUARIOS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [USUARIOS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [USUARIOS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [USUARIOS] SET  MULTI_USER 
GO
ALTER DATABASE [USUARIOS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [USUARIOS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [USUARIOS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [USUARIOS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [USUARIOS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [USUARIOS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [USUARIOS] SET QUERY_STORE = ON
GO
ALTER DATABASE [USUARIOS] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [USUARIOS]
GO
/****** Object:  Table [dbo].[tbl_usuarios]    Script Date: 16/05/2023 9:26:57 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_usuarios](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[Edad] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_usuarios] ON 

INSERT [dbo].[tbl_usuarios] ([ID], [Nombre], [Apellido], [Edad]) VALUES (1, N'Juliana', N'Herrera', N'19')
INSERT [dbo].[tbl_usuarios] ([ID], [Nombre], [Apellido], [Edad]) VALUES (2, N'Jeronimo', N'Santos', N'9')
INSERT [dbo].[tbl_usuarios] ([ID], [Nombre], [Apellido], [Edad]) VALUES (3, N'Sandra', N'Berrio', N'42')
INSERT [dbo].[tbl_usuarios] ([ID], [Nombre], [Apellido], [Edad]) VALUES (4, N'Susana', N'Arias', N'14')
SET IDENTITY_INSERT [dbo].[tbl_usuarios] OFF
GO
USE [master]
GO
ALTER DATABASE [USUARIOS] SET  READ_WRITE 
GO
