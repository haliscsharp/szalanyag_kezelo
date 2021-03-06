USE [master]
GO
/****** Object:  Database [szalanyag_kezelo]    Script Date: 2021. 12. 02. 19:22:53 ******/
CREATE DATABASE [szalanyag_kezelo]
GO
ALTER DATABASE [szalanyag_kezelo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [szalanyag_kezelo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [szalanyag_kezelo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET ARITHABORT OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [szalanyag_kezelo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [szalanyag_kezelo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [szalanyag_kezelo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [szalanyag_kezelo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [szalanyag_kezelo] SET  MULTI_USER 
GO
ALTER DATABASE [szalanyag_kezelo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [szalanyag_kezelo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [szalanyag_kezelo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [szalanyag_kezelo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [szalanyag_kezelo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [szalanyag_kezelo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [szalanyag_kezelo] SET QUERY_STORE = OFF
GO
USE [szalanyag_kezelo]
GO
/****** Object:  Table [dbo].[anyag]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anyag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](50) NOT NULL,
	[rovid] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_anyag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[anyagminoseg]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anyagminoseg](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_anyagminoseg] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bevetelezes]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bevetelezes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[beszallito_nev] [nvarchar](50) NOT NULL,
	[datum] [datetime] NOT NULL,
	[db] [int] NOT NULL,
	[hossz] [int] NOT NULL,
	[szalanyag_id] [int] NOT NULL,
 CONSTRAINT [PK_bevetelezes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[meret]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[meret](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[szelesseg] [int] NOT NULL,
	[magassag] [int] NOT NULL,
	[vastagsag] [int] NOT NULL,
	[atmero] [int] NOT NULL,
 CONSTRAINT [PK_meret] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[raktar]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[raktar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[db] [int] NOT NULL,
	[hossz] [int] NOT NULL,
	[szalanyag_id] [int] NOT NULL,
 CONSTRAINT [PK_raktar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rendeles]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rendeles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rendelo_nev] [nvarchar](50) NOT NULL,
	[datum] [datetime] NOT NULL,
	[surgosseg] [int] NOT NULL,
	[teljesitett] [bit] NOT NULL,
 CONSTRAINT [PK_rendeles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[szalanyag]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[szalanyag](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[meret_id] [int] NOT NULL,
	[anyag_id] [int] NOT NULL,
	[anyagminoseg_id] [int] NOT NULL,
	[tipus_id] [int] NOT NULL,
 CONSTRAINT [PK_szalanyag] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipus]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipus](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](50) NOT NULL,
	[kellSzelesseg] [bit] NOT NULL,
	[kellMagassag] [bit] NOT NULL,
	[kellVastagsag] [bit] NOT NULL,
	[kellAtmero] [bit] NOT NULL,
 CONSTRAINT [PK_tipus] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vagaslista]    Script Date: 2021. 12. 02. 19:22:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vagaslista](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[db] [int] NOT NULL,
	[hossz] [int] NOT NULL,
	[feluletkezeles] [bit] NOT NULL,
	[szalanyag_id] [int] NOT NULL,
	[rendeles_id] [int] NOT NULL,
 CONSTRAINT [PK_vagaslista] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [szalanyag_kezelo] SET  READ_WRITE 
GO
