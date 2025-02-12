USE [master]
GO
/****** Object:  Database [MarketProject]    Script Date: 24.12.2020 20:36:55 ******/
CREATE DATABASE [MarketProject]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MarketProject', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MarketProject.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MarketProject_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\MarketProject_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MarketProject] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MarketProject].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MarketProject] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MarketProject] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MarketProject] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MarketProject] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MarketProject] SET ARITHABORT OFF 
GO
ALTER DATABASE [MarketProject] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MarketProject] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MarketProject] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MarketProject] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MarketProject] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MarketProject] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MarketProject] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MarketProject] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MarketProject] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MarketProject] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MarketProject] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MarketProject] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MarketProject] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MarketProject] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MarketProject] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MarketProject] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MarketProject] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MarketProject] SET RECOVERY FULL 
GO
ALTER DATABASE [MarketProject] SET  MULTI_USER 
GO
ALTER DATABASE [MarketProject] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MarketProject] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MarketProject] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MarketProject] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MarketProject] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MarketProject] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MarketProject', N'ON'
GO
ALTER DATABASE [MarketProject] SET QUERY_STORE = OFF
GO
USE [MarketProject]
GO
/****** Object:  Table [dbo].[Cashier]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cashier](
	[cashierID] [int] IDENTITY(1,1) NOT NULL,
	[employeeID] [int] NULL,
 CONSTRAINT [PK_Cashier] PRIMARY KEY CLUSTERED 
(
	[cashierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Director]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Director](
	[directorID] [int] IDENTITY(1,1) NOT NULL,
	[employeeID] [int] NOT NULL,
 CONSTRAINT [PK_Director] PRIMARY KEY CLUSTERED 
(
	[directorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [int] IDENTITY(1,1) NOT NULL,
	[employeeName] [varchar](50) NULL,
	[employeeAdres] [varchar](50) NULL,
	[marketID] [int] NULL,
	[dailyHoliday] [varchar](50) NULL,
	[yearlyHoliday] [int] NOT NULL,
	[employeePrice] [float] NULL,
	[employeeTime] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HalfDirector]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HalfDirector](
	[halfDirectorID] [int] IDENTITY(1,1) NOT NULL,
	[employeeID] [int] NULL,
 CONSTRAINT [PK_HalfDirector] PRIMARY KEY CLUSTERED 
(
	[halfDirectorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Market]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Market](
	[marketID] [int] IDENTITY(1,1) NOT NULL,
	[marketName] [varchar](50) NULL,
	[marketAdres] [varchar](50) NULL,
 CONSTRAINT [PK_Market] PRIMARY KEY CLUSTERED 
(
	[marketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[productID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](50) NOT NULL,
	[marketID] [int] NULL,
	[supplierID] [int] NULL,
	[productPrice] [float] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[productID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[supplierID] [int] IDENTITY(1,1) NOT NULL,
	[supplierName] [varchar](50) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[supplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserTable]    Script Date: 24.12.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserTable](
	[userID] [int] NULL,
	[userName] [varchar](50) NULL,
	[userPassword] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Director] ON 

INSERT [dbo].[Director] ([directorID], [employeeID]) VALUES (1, 4)
INSERT [dbo].[Director] ([directorID], [employeeID]) VALUES (2, 5)
INSERT [dbo].[Director] ([directorID], [employeeID]) VALUES (3, 8)
SET IDENTITY_INSERT [dbo].[Director] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([employeeID], [employeeName], [employeeAdres], [marketID], [dailyHoliday], [yearlyHoliday], [employeePrice], [employeeTime]) VALUES (3, N'Hasan Ali', N'Gaziantep', 2, N'Pazartesi', 2, 12, NULL)
INSERT [dbo].[Employee] ([employeeID], [employeeName], [employeeAdres], [marketID], [dailyHoliday], [yearlyHoliday], [employeePrice], [employeeTime]) VALUES (4, N'Muhammed ALi', N'Sinop', 2, N'Salı', 4, 12, NULL)
INSERT [dbo].[Employee] ([employeeID], [employeeName], [employeeAdres], [marketID], [dailyHoliday], [yearlyHoliday], [employeePrice], [employeeTime]) VALUES (5, N'Beyza', N'Burdur', 2, N'Çarşamba', 32, 23, NULL)
INSERT [dbo].[Employee] ([employeeID], [employeeName], [employeeAdres], [marketID], [dailyHoliday], [yearlyHoliday], [employeePrice], [employeeTime]) VALUES (7, N'asdas', N'asdad', 2, N'sdadas', 14, 24, NULL)
INSERT [dbo].[Employee] ([employeeID], [employeeName], [employeeAdres], [marketID], [dailyHoliday], [yearlyHoliday], [employeePrice], [employeeTime]) VALUES (8, N'Merve', N'İzmir', 2, N'Salı', 14, 23, NULL)
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Market] ON 

INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (2, N'Güldür Market', N'Manisa')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (3, N'Osman Gültekin', N'İzmir')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (4, N'Deneme', N'Ankara')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (5, N'dfgdfg', N'İstanbul')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (6, N'sdfsf', N'Sinop')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (7, N'Databasee', N'Burdur')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (8, N'dede', N'sdfdsfsd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (9, N'sfsddds', N'sdfdsfds')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (10, N'London', N'Merve')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (11, N'Merve', N'London')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (12, N'sdfds', N'dsdfs')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (13, N'sdfsff', N'sfdssdfds')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (14, N'denemeürün', N'ürün')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (15, N'sdfsffds', N'sdffsdfdfss')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (16, N'dgfg', N'fddg')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (17, N'deneme', N'sdfsd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (18, N'asdsadas', N'dasdasdas')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (19, N'dgdfg', N'gfgdgdf')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (20, N'dfgdfgd', N'dfgdfgfdgd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (21, N'sfdfdsf', N'sfdsfdss')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (22, N'fdsfds', N'fdsfsfdf')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (23, N'sdasadad', N'asdasdasasd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (24, N'sdfdfs', N'sfsfsd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (25, N'dfdsfsdf', N'sddsfsdfsd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (26, N'dfdgfdgdfg', N'dfgdfgdfgfd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (27, N'dgfdgd', N'dfgdgdfgfd')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (28, N'efsdfsfs', N'sdffsddsfs')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (29, N'sonuncu', N'bu')
INSERT [dbo].[Market] ([marketID], [marketName], [marketAdres]) VALUES (30, N'Bir Deneme Daha', N'Yapalım Mı')
SET IDENTITY_INSERT [dbo].[Market] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (1, N'deneme', 7, 1, 45)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (2, N'YeniÜrün', 3, 1, 23)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (3, N'ss', 18, NULL, 21)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (4, N'YeniÜrün', 25, NULL, 23)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (5, N'ss', 26, NULL, 21)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (6, N'YeniÜrün', 27, NULL, 23)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (7, N'ss', 27, NULL, 21)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (8, N'deneme', 28, NULL, 45)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (9, N'deneme', 29, NULL, 45)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (10, N'deneme', 30, NULL, 45)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (11, N'YeniÜrün', 30, NULL, 23)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (12, N'ss', 30, NULL, 21)
INSERT [dbo].[Product] ([productID], [productName], [marketID], [supplierID], [productPrice]) VALUES (13, N'ss', 30, NULL, 21)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([supplierID], [supplierName]) VALUES (1, N'Tuzcu')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
INSERT [dbo].[UserTable] ([userID], [userName], [userPassword]) VALUES (1, N'admin', N'123456')
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_yearlyHoliday]  DEFAULT ((14)) FOR [yearlyHoliday]
GO
ALTER TABLE [dbo].[Cashier]  WITH CHECK ADD  CONSTRAINT [FK_Cashier_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cashier] CHECK CONSTRAINT [FK_Cashier_Employee]
GO
ALTER TABLE [dbo].[Director]  WITH CHECK ADD  CONSTRAINT [FK_Director_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Director] CHECK CONSTRAINT [FK_Director_Employee]
GO
ALTER TABLE [dbo].[HalfDirector]  WITH CHECK ADD  CONSTRAINT [FK_HalfDirector_Employee] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Employee] ([employeeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HalfDirector] CHECK CONSTRAINT [FK_HalfDirector_Employee]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Market] FOREIGN KEY([marketID])
REFERENCES [dbo].[Market] ([marketID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Market]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier1] FOREIGN KEY([supplierID])
REFERENCES [dbo].[Supplier] ([supplierID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier1]
GO
USE [master]
GO
ALTER DATABASE [MarketProject] SET  READ_WRITE 
GO
