USE [master]
GO
/****** Object:  Database [MyForm]    Script Date: 3/23/2016 11:03:27 PM ******/
CREATE DATABASE [MyForm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyForm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MyForm.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyForm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\MyForm_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MyForm] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyForm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyForm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyForm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyForm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyForm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyForm] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyForm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyForm] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MyForm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyForm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyForm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyForm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyForm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyForm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyForm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyForm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyForm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyForm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyForm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyForm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyForm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyForm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyForm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyForm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyForm] SET RECOVERY FULL 
GO
ALTER DATABASE [MyForm] SET  MULTI_USER 
GO
ALTER DATABASE [MyForm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyForm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyForm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyForm] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MyForm]
GO
/****** Object:  StoredProcedure [dbo].[spGetListDetailForm]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetListDetailForm]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM DetailForm
END

GO
/****** Object:  StoredProcedure [dbo].[spGetListForm]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetListForm]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT * FROM Form
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertDetailForm]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertDetailForm]
@fieldName nvarchar(100),
@coordinateX int,
@coordinateY int,
@width int,
@height int,
@location varchar(5),
@idForm varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO DetailForm 
	VALUES(@fieldName,@coordinateX,@coordinateY,@width,@height,@location,@idForm)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertForm]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertForm]
@formName nvarchar(100),
@idForm varchar(10),
@userName varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Form 
	VALUES(@idForm,@formName,@userName)
END

GO
/****** Object:  Table [dbo].[DetailForm]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetailForm](
	[idField] [int] IDENTITY(1,1) NOT NULL,
	[fieldName] [nvarchar](100) NOT NULL,
	[coordinateX] [int] NOT NULL,
	[coordinateY] [int] NOT NULL,
	[width] [int] NOT NULL,
	[height] [int] NOT NULL,
	[location] [varchar](5) NULL,
	[idForm] [varchar](10) NOT NULL,
 CONSTRAINT [PK_DetailForm] PRIMARY KEY CLUSTERED 
(
	[idField] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Form]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Form](
	[idForm] [varchar](10) NOT NULL,
	[formName] [nvarchar](100) NOT NULL,
	[UserName] [varchar](20) NULL,
	[ProcessDate] [date] NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Form] PRIMARY KEY CLUSTERED 
(
	[idForm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Image]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Image](
	[idImg] [int] IDENTITY(1,1) NOT NULL,
	[ImgName] [varchar](50) NOT NULL,
	[ImgPath] [nvarchar](100) NOT NULL,
	[Status] [int] NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[UpTime] [datetime] NOT NULL,
	[idForm] [varchar](10) NOT NULL,
 CONSTRAINT [PK_ManageImage] PRIMARY KEY CLUSTERED 
(
	[idImg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 3/23/2016 11:03:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserName] [varchar](20) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[PhoneNumber] [varchar](11) NOT NULL,
	[Role] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DetailForm] ON 

INSERT [dbo].[DetailForm] ([idField], [fieldName], [coordinateX], [coordinateY], [width], [height], [location], [idForm]) VALUES (1, N'TA', 1, 1, 1, 1, N'1', N'FA')
SET IDENTITY_INSERT [dbo].[DetailForm] OFF
INSERT [dbo].[Form] ([idForm], [formName], [UserName], [ProcessDate], [Status]) VALUES (N'FA', N'Biểu mẫu A', N'HangNT26', NULL, NULL)
INSERT [dbo].[Form] ([idForm], [formName], [UserName], [ProcessDate], [Status]) VALUES (N'FB', N'Biểu mẫu B', N'HangNT', NULL, NULL)
INSERT [dbo].[Form] ([idForm], [formName], [UserName], [ProcessDate], [Status]) VALUES (N'FC', N'CCC', N'ANh', NULL, NULL)
INSERT [dbo].[Form] ([idForm], [formName], [UserName], [ProcessDate], [Status]) VALUES (N'FD', N'D', NULL, CAST(0x8F370B00 AS Date), NULL)
INSERT [dbo].[Form] ([idForm], [formName], [UserName], [ProcessDate], [Status]) VALUES (N'FF', N'F', NULL, CAST(0x99370B00 AS Date), NULL)
ALTER TABLE [dbo].[DetailForm]  WITH CHECK ADD  CONSTRAINT [FK_DetailForm_Form] FOREIGN KEY([idForm])
REFERENCES [dbo].[Form] ([idForm])
GO
ALTER TABLE [dbo].[DetailForm] CHECK CONSTRAINT [FK_DetailForm_Form]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Form] FOREIGN KEY([idForm])
REFERENCES [dbo].[Form] ([idForm])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Form]
GO
USE [master]
GO
ALTER DATABASE [MyForm] SET  READ_WRITE 
GO
