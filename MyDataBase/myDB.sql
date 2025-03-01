USE [master]
GO
/****** Object:  Database [starshopdb]    Script Date: 20.02.2025 18:30:06 ******/
CREATE DATABASE [starshopdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'starshopdb', FILENAME = N'/var/opt/mssql/data/starshopdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'starshopdb_log', FILENAME = N'/var/opt/mssql/data/starshopdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [starshopdb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [starshopdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [starshopdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [starshopdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [starshopdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [starshopdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [starshopdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [starshopdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [starshopdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [starshopdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [starshopdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [starshopdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [starshopdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [starshopdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [starshopdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [starshopdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [starshopdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [starshopdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [starshopdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [starshopdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [starshopdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [starshopdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [starshopdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [starshopdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [starshopdb] SET RECOVERY FULL 
GO
ALTER DATABASE [starshopdb] SET  MULTI_USER 
GO
ALTER DATABASE [starshopdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [starshopdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [starshopdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [starshopdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [starshopdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [starshopdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'starshopdb', N'ON'
GO
ALTER DATABASE [starshopdb] SET QUERY_STORE = ON
GO
ALTER DATABASE [starshopdb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [starshopdb]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[categoryID] [bigint] IDENTITY(1,1) NOT NULL,
	[categoryName] [nchar](20) NOT NULL,
	[description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[categoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer.Status]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer.Status](
	[statusID] [tinyint] NOT NULL,
	[statusName] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Customer.Status] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customerID] [bigint] IDENTITY(1,1) NOT NULL,
	[firstName] [nchar](20) NOT NULL,
	[lastName] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomersDetails]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomersDetails](
	[customerID] [bigint] NOT NULL,
	[birthDay] [datetime] NULL,
	[memberDate] [datetime] NULL,
	[statusID] [tinyint] NULL,
 CONSTRAINT [PK_CustomersDetails] PRIMARY KEY CLUSTERED 
(
	[customerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[orderID] [bigint] NOT NULL,
	[productID] [bigint] NOT NULL,
	[customerID] [bigint] NOT NULL,
	[amount] [int] NOT NULL,
	[address] [nvarchar](255) NULL,
	[deliveryDate] [datetime] NULL,
	[status] [nchar](15) NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderID] [bigint] IDENTITY(1,1) NOT NULL,
	[orderDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[orderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductDetails]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductDetails](
	[productID] [bigint] NOT NULL,
	[description] [nvarchar](50) NULL,
	[unitPrice] [float] NOT NULL,
	[stock] [int] NOT NULL,
 CONSTRAINT [PK_ProductDetails] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 20.02.2025 18:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[productID] [bigint] IDENTITY(1,1) NOT NULL,
	[categoryID] [bigint] NOT NULL,
	[productName] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CustomersDetails]  WITH CHECK ADD  CONSTRAINT [FK_CustomersDetails_Customers] FOREIGN KEY([statusID])
REFERENCES [dbo].[Customer.Status] ([statusID])
GO
ALTER TABLE [dbo].[CustomersDetails] CHECK CONSTRAINT [FK_CustomersDetails_Customers]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Customers] FOREIGN KEY([customerID])
REFERENCES [dbo].[Customers] ([customerID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Customers]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([orderID])
REFERENCES [dbo].[Orders] ([orderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([productID])
REFERENCES [dbo].[Products] ([productID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[ProductDetails]  WITH NOCHECK ADD  CONSTRAINT [FK_ProductDetails_Products] FOREIGN KEY([productID])
REFERENCES [dbo].[Products] ([productID])
GO
ALTER TABLE [dbo].[ProductDetails] CHECK CONSTRAINT [FK_ProductDetails_Products]
GO
ALTER TABLE [dbo].[Products]  WITH NOCHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([categoryID])
REFERENCES [dbo].[Categories] ([categoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [starshopdb] SET  READ_WRITE 
GO
