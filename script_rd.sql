USE [master]
GO
/****** Object:  Database [RelationalDatabase]    Script Date: 4.11.2024 14:33:37 ******/
CREATE DATABASE [RelationalDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RelationalDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RelationalDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RelationalDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\RelationalDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [RelationalDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RelationalDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RelationalDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RelationalDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RelationalDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RelationalDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RelationalDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [RelationalDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RelationalDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RelationalDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RelationalDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RelationalDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RelationalDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RelationalDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RelationalDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RelationalDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RelationalDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RelationalDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RelationalDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RelationalDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RelationalDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RelationalDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RelationalDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RelationalDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RelationalDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [RelationalDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [RelationalDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RelationalDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RelationalDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RelationalDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RelationalDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RelationalDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'RelationalDatabase', N'ON'
GO
ALTER DATABASE [RelationalDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [RelationalDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [RelationalDatabase]
GO
/****** Object:  Table [dbo].[Tbl_Customer]    Script Date: 4.11.2024 14:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Customer](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[FullName] [varchar](30) NULL,
 CONSTRAINT [PK_Tbl_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Personnel]    Script Date: 4.11.2024 14:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Personnel](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
 CONSTRAINT [PK_Tbl_Personnel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Product]    Script Date: 4.11.2024 14:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Product](
	[ID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Stock] [tinyint] NULL,
	[PurchasePrice] [smallint] NULL,
	[SellingPrice] [smallint] NULL,
 CONSTRAINT [PK_Tbl_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tbl_Transaction]    Script Date: 4.11.2024 14:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_Transaction](
	[TransactionID] [tinyint] IDENTITY(1,1) NOT NULL,
	[Product] [tinyint] NULL,
	[Customer] [tinyint] NULL,
	[Personnel] [tinyint] NULL,
	[Price] [smallint] NULL,
 CONSTRAINT [PK_Tbl_Transaction] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transaction_Tbl_Customer] FOREIGN KEY([Customer])
REFERENCES [dbo].[Tbl_Customer] ([ID])
GO
ALTER TABLE [dbo].[Tbl_Transaction] CHECK CONSTRAINT [FK_Tbl_Transaction_Tbl_Customer]
GO
ALTER TABLE [dbo].[Tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transaction_Tbl_Personnel] FOREIGN KEY([Personnel])
REFERENCES [dbo].[Tbl_Personnel] ([ID])
GO
ALTER TABLE [dbo].[Tbl_Transaction] CHECK CONSTRAINT [FK_Tbl_Transaction_Tbl_Personnel]
GO
ALTER TABLE [dbo].[Tbl_Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Tbl_Transaction_Tbl_Product] FOREIGN KEY([Product])
REFERENCES [dbo].[Tbl_Product] ([ID])
GO
ALTER TABLE [dbo].[Tbl_Transaction] CHECK CONSTRAINT [FK_Tbl_Transaction_Tbl_Product]
GO
/****** Object:  StoredProcedure [dbo].[RelationalDatabase]    Script Date: 4.11.2024 14:33:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RelationalDatabase]
as
Select Tbl_Product.Name as 'Product',FullName as 'Customer',Tbl_Personnel.Name as 'Personnel',Price from Tbl_Transaction inner join Tbl_Product
on
Tbl_Transaction.Product = Tbl_Product.ID
inner join Tbl_Customer
on
Tbl_Transaction.Customer = Tbl_Customer.ID
inner join Tbl_Personnel
on
Tbl_Transaction.Personnel = Tbl_Personnel.ID
GO
USE [master]
GO
ALTER DATABASE [RelationalDatabase] SET  READ_WRITE 
GO
