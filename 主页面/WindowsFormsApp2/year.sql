USE [master]
GO
/****** Object:  Database [CarManagementSystem]    Script Date: 2019/6/9 20:36:57 ******/
CREATE DATABASE [CarManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarManagementSystem', FILENAME = N'D:\CarManagementSystem.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CarManagementSystem_log', FILENAME = N'D:\CarManagementSystem_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarManagementSystem] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarManagementSystem] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [CarManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [CarManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [CarManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarManagementSystem] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarManagementSystem', N'ON'
GO
USE [CarManagementSystem]
GO
/****** Object:  Table [dbo].[CarInfo]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarInfo](
	[CarNo] [int] IDENTITY(1,1) NOT NULL,
	[CarBrand] [nvarchar](20) NOT NULL,
	[CarInPrice] [decimal](9, 2) NOT NULL,
	[CarOutPrice] [decimal](9, 2) NOT NULL,
	[CarStock] [int] NOT NULL,
	[CarDisplacement] [nvarchar](10) NOT NULL,
	[CarSort] [nvarchar](10) NOT NULL,
	[ProductionID] [int] NOT NULL,
 CONSTRAINT [PK_CarInfo] PRIMARY KEY CLUSTERED 
(
	[CarNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dept]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dept](
	[DeptID] [int] IDENTITY(1,1) NOT NULL,
	[DeptName] [nvarchar](50) NOT NULL,
	[DeptPosition] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Dept] PRIMARY KEY CLUSTERED 
(
	[DeptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderInfo]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderInfo](
	[OrderNo] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [nvarchar](50) NOT NULL,
	[UserNo] [nvarchar](20) NOT NULL,
	[CarNo] [int] NOT NULL,
	[OrderNum] [int] NOT NULL,
 CONSTRAINT [PK_OrderInfo] PRIMARY KEY CLUSTERED 
(
	[OrderNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductionInfo]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductionInfo](
	[ProductionID] [int] IDENTITY(1,1) NOT NULL,
	[ProductionBrand] [nvarchar](20) NOT NULL,
	[productionPhone] [nvarchar](20) NOT NULL,
	[productionAddress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ProductionInfo] PRIMARY KEY CLUSTERED 
(
	[ProductionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PurchaseInfo]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseInfo](
	[PurchaseNo] [int] IDENTITY(1,1) NOT NULL,
	[ProductionID] [int] NOT NULL,
	[InPrice] [decimal](9, 2) NOT NULL,
	[InNum] [int] NOT NULL,
	[UserNo] [nvarchar](20) NOT NULL,
	[CarNo] [int] NOT NULL,
 CONSTRAINT [PK_PurchaseInfo] PRIMARY KEY CLUSTERED 
(
	[PurchaseNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffId] [int] NOT NULL,
	[StaffPwd] [int] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[StaffAge] [int] NOT NULL,
	[StaffSex] [nvarchar](20) NOT NULL,
	[StaffDept] [nvarchar](20) NOT NULL,
	[StafftType] [int] NOT NULL,
	[StaffAddressed] [nvarchar](50) NOT NULL,
	[StaffSalay] [int] NOT NULL,
	[StaffPhone] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stock]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[CarNo] [int] NULL,
	[ProductionID] [int] NULL,
	[Indate] [date] NOT NULL,
	[InNum] [int] NULL,
	[Storename] [nvarchar](50) NOT NULL,
	[Pay] [nvarchar](20) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[ProductionAddress] [nvarchar](50) NULL,
	[OutID] [int] NULL,
	[Stocknum] [int] NOT NULL,
	[OutNum] [nvarchar](50) NULL,
	[Prices] [int] NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserNo] [nvarchar](20) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPwd] [nvarchar](20) NOT NULL,
	[UserAge] [int] NULL,
	[UserGender] [nvarchar](10) NULL,
	[UserPhone] [nvarchar](20) NOT NULL,
	[UserState] [int] NOT NULL,
	[UserAddress] [nvarchar](50) NULL,
	[Question1] [nvarchar](50) NULL,
	[answer1] [nvarchar](50) NULL,
	[Question2] [nvarchar](50) NULL,
	[answer2] [nvarchar](50) NULL,
	[Question3] [nvarchar](50) NULL,
	[answer3] [nvarchar](50) NULL,
	[DeptID] [int] NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[year]    Script Date: 2019/6/9 20:36:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[year](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Trademark] [nvarchar](50) NOT NULL,
	[Sell] [int] NOT NULL,
 CONSTRAINT [PK_year] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CarInfo] ON 

INSERT [dbo].[CarInfo] ([CarNo], [CarBrand], [CarInPrice], [CarOutPrice], [CarStock], [CarDisplacement], [CarSort], [ProductionID]) VALUES (3, N'宝马3系', CAST(130000.00 AS Decimal(9, 2)), CAST(2300000.00 AS Decimal(9, 2)), 5, N'2.0T', N'高端豪车', 1)
SET IDENTITY_INSERT [dbo].[CarInfo] OFF
SET IDENTITY_INSERT [dbo].[OrderInfo] ON 

INSERT [dbo].[OrderInfo] ([OrderNo], [OrderDate], [UserNo], [CarNo], [OrderNum]) VALUES (1, N'2019-06-05', N'31001', 1, 2)
SET IDENTITY_INSERT [dbo].[OrderInfo] OFF
SET IDENTITY_INSERT [dbo].[ProductionInfo] ON 

INSERT [dbo].[ProductionInfo] ([ProductionID], [ProductionBrand], [productionPhone], [productionAddress]) VALUES (1, N'宝马', N'133332334313', N'上海')
SET IDENTITY_INSERT [dbo].[ProductionInfo] OFF
SET IDENTITY_INSERT [dbo].[PurchaseInfo] ON 

INSERT [dbo].[PurchaseInfo] ([PurchaseNo], [ProductionID], [InPrice], [InNum], [UserNo], [CarNo]) VALUES (1, 1, CAST(130000.00 AS Decimal(9, 2)), 4, N'31001', 1)
SET IDENTITY_INSERT [dbo].[PurchaseInfo] OFF
INSERT [dbo].[Staff] ([StaffId], [StaffPwd], [StaffName], [StaffAge], [StaffSex], [StaffDept], [StafftType], [StaffAddressed], [StaffSalay], [StaffPhone]) VALUES (31001, 123, N'刘一', 20, N'女', N'技术部', 0, N'陕西渭南', 12000, N'18729551999')
INSERT [dbo].[Staff] ([StaffId], [StaffPwd], [StaffName], [StaffAge], [StaffSex], [StaffDept], [StafftType], [StaffAddressed], [StaffSalay], [StaffPhone]) VALUES (31002, 123, N'方一', 19, N'女', N'销售部', 0, N'陕西西安', 12000, N'18729551888')
INSERT [dbo].[Staff] ([StaffId], [StaffPwd], [StaffName], [StaffAge], [StaffSex], [StaffDept], [StafftType], [StaffAddressed], [StaffSalay], [StaffPhone]) VALUES (31003, 123, N'周一', 20, N'男', N'采购部', 0, N'陕西渭南', 12000, N'18729551777')
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([SID], [CarNo], [ProductionID], [Indate], [InNum], [Storename], [Pay], [UserName], [ProductionAddress], [OutID], [Stocknum], [OutNum], [Prices]) VALUES (1, NULL, NULL, CAST(0xBA3F0B00 AS Date), NULL, N'天子仓', N'支付宝', NULL, NULL, NULL, 10, NULL, NULL)
INSERT [dbo].[Stock] ([SID], [CarNo], [ProductionID], [Indate], [InNum], [Storename], [Pay], [UserName], [ProductionAddress], [OutID], [Stocknum], [OutNum], [Prices]) VALUES (2, NULL, NULL, CAST(0xBB3F0B00 AS Date), NULL, N'地子仓', N'花呗', NULL, NULL, NULL, 23, NULL, NULL)
INSERT [dbo].[Stock] ([SID], [CarNo], [ProductionID], [Indate], [InNum], [Storename], [Pay], [UserName], [ProductionAddress], [OutID], [Stocknum], [OutNum], [Prices]) VALUES (3, NULL, NULL, CAST(0xBC3F0B00 AS Date), NULL, N'人字组', N'招财宝', NULL, NULL, NULL, 12, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Stock] OFF
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'100020', NULL, N'1234', NULL, NULL, N'18717430136', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'10034', NULL, N'123', NULL, NULL, N'12356466365', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'10043', NULL, N'123', NULL, NULL, N'12345678999', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'120003', NULL, N'234', NULL, NULL, N'15289382546', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'123000', NULL, N'789', NULL, NULL, N'12345656489', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'300001', NULL, N'341', NULL, NULL, N'12345643278', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'31001', N'张三', N'123', 20, N'女', N'131888888999', 0, N'西安', N'出生日期', N'9001', N'真实姓名', N'刘朵', N'家庭住址', N'蓝田', NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'31002', NULL, N'1', NULL, NULL, N'123', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[UserInfo] ([UserNo], [UserName], [UserPwd], [UserAge], [UserGender], [UserPhone], [UserState], [UserAddress], [Question1], [answer1], [Question2], [answer2], [Question3], [answer3], [DeptID]) VALUES (N'31004', NULL, N'1', NULL, NULL, N'123', 0, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[year] ON 

INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (1, N'马赛拉蒂', 50)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (2, N'帕加尼', 60)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (3, N'凯迪拉克', 20)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (4, N'阿尔法罗密欧', 30)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (5, N'本田', 60)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (6, N'丰田', 36)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (7, N'大众', 72)
INSERT [dbo].[year] ([ID], [Trademark], [Sell]) VALUES (8, N'雪佛兰', 25)
SET IDENTITY_INSERT [dbo].[year] OFF
ALTER TABLE [dbo].[OrderInfo] ADD  CONSTRAINT [DF_OrderInfo_OrderNum]  DEFAULT ((1)) FOR [OrderNum]
GO
ALTER TABLE [dbo].[Staff] ADD  CONSTRAINT [DF_Staff_StaffType]  DEFAULT ((0)) FOR [StafftType]
GO
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF_UserInfo_UserState]  DEFAULT ((0)) FOR [UserState]
GO
USE [master]
GO
ALTER DATABASE [CarManagementSystem] SET  READ_WRITE 
GO
