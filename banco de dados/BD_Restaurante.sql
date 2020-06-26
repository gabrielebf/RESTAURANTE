USE [master]
GO
/****** Object:  Database [restaurante]    Script Date: 25/06/2020 19:27:24 ******/
CREATE DATABASE [restaurante]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'restaurante', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\restaurante.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'restaurante_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\restaurante_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [restaurante] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [restaurante].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [restaurante] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [restaurante] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [restaurante] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [restaurante] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [restaurante] SET ARITHABORT OFF 
GO
ALTER DATABASE [restaurante] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [restaurante] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [restaurante] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [restaurante] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [restaurante] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [restaurante] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [restaurante] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [restaurante] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [restaurante] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [restaurante] SET  DISABLE_BROKER 
GO
ALTER DATABASE [restaurante] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [restaurante] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [restaurante] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [restaurante] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [restaurante] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [restaurante] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [restaurante] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [restaurante] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [restaurante] SET  MULTI_USER 
GO
ALTER DATABASE [restaurante] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [restaurante] SET DB_CHAINING OFF 
GO
ALTER DATABASE [restaurante] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [restaurante] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [restaurante] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [restaurante] SET QUERY_STORE = OFF
GO
USE [restaurante]
GO
/****** Object:  Table [dbo].[RestCadastroProd]    Script Date: 25/06/2020 19:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RestCadastroProd](
	[id] [int] NOT NULL,
	[tipo] [varchar](35) NULL,
	[preco] [float] NULL,
	[desconto] [float] NOT NULL,
	[observacao] [varchar](50) NULL,
	[categoriaId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RestCadastroProd] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RestCategoria]    Script Date: 25/06/2020 19:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RestCategoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[categoria] [varchar](35) NOT NULL,
 CONSTRAINT [PK_RestCategoria] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RestClientes]    Script Date: 25/06/2020 19:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RestClientes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](35) NOT NULL,
	[telefone] [varchar](14) NOT NULL,
	[estado] [char](2) NOT NULL,
	[cidade] [varchar](35) NOT NULL,
	[endereco] [varchar](50) NOT NULL,
	[numero] [varchar](5) NOT NULL,
 CONSTRAINT [PK_RestClientes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RestPedidos]    Script Date: 25/06/2020 19:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RestPedidos](
	[id] [int] NOT NULL,
	[descricao] [varchar](35) NULL,
	[pedido] [varchar](50) NOT NULL,
	[bebida] [varchar](35) NULL,
	[endereco] [varchar](50) NOT NULL,
	[valor] [float] NOT NULL,
	[quantidade] [int] NOT NULL,
	[clienteId] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_RestPedidos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RestCadastroProd]  WITH CHECK ADD  CONSTRAINT [FK_RestCadastroProd_RestPedidos] FOREIGN KEY([id])
REFERENCES [dbo].[RestPedidos] ([id])
GO
ALTER TABLE [dbo].[RestCadastroProd] CHECK CONSTRAINT [FK_RestCadastroProd_RestPedidos]
GO
ALTER TABLE [dbo].[RestCategoria]  WITH CHECK ADD  CONSTRAINT [FK_RestCategoria_RestCadastroProd] FOREIGN KEY([id])
REFERENCES [dbo].[RestCadastroProd] ([id])
GO
ALTER TABLE [dbo].[RestCategoria] CHECK CONSTRAINT [FK_RestCategoria_RestCadastroProd]
GO
ALTER TABLE [dbo].[RestClientes]  WITH CHECK ADD  CONSTRAINT [FK_RestClientes_RestPedidos] FOREIGN KEY([id])
REFERENCES [dbo].[RestPedidos] ([id])
GO
ALTER TABLE [dbo].[RestClientes] CHECK CONSTRAINT [FK_RestClientes_RestPedidos]
GO
USE [master]
GO
ALTER DATABASE [restaurante] SET  READ_WRITE 
GO
