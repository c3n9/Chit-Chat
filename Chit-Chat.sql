USE [master]
GO
/****** Object:  Database [ChitChat]    Script Date: 09.05.2023 20:25:29 ******/
CREATE DATABASE [ChitChat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChitChat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ChitChat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChitChat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ChitChat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ChitChat] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChitChat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChitChat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChitChat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChitChat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChitChat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChitChat] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChitChat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ChitChat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChitChat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChitChat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChitChat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChitChat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChitChat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChitChat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChitChat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChitChat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChitChat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChitChat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChitChat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChitChat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChitChat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChitChat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChitChat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChitChat] SET RECOVERY FULL 
GO
ALTER DATABASE [ChitChat] SET  MULTI_USER 
GO
ALTER DATABASE [ChitChat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChitChat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChitChat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChitChat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChitChat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChitChat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ChitChat', N'ON'
GO
ALTER DATABASE [ChitChat] SET QUERY_STORE = ON
GO
ALTER DATABASE [ChitChat] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ChitChat]
GO
/****** Object:  Table [dbo].[ChatMessage]    Script Date: 09.05.2023 20:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChatMessage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Sender_Id] [int] NOT NULL,
	[Chatroom_Id] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Message] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_ChatMessage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Chatroom]    Script Date: 09.05.2023 20:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chatroom](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Topic] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Chatroom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 09.05.2023 20:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 09.05.2023 20:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[department_id] [int] NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeChatroom]    Script Date: 09.05.2023 20:25:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeChatroom](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Employee_Id] [int] NOT NULL,
	[Chatroom_Id] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeChatroom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (2, N'IT Helpdesk')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (3, N'Engineering')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (4, N'Sales')
INSERT [dbo].[Department] ([Id], [Name]) VALUES (5, N'Marketing')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (1, N'Cecilia Joyce', N'cjoyce', 1, N'cejoyce10')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (2, N'Noelle Peters', N'npeters', 1, N'noeters76')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (3, N'Aspen Tucker', N'atucker', 1, N'asucker95')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (4, N'Isadora Kirby', N'ikirby', 1, N'iskirby86')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (5, N'Jamalia Valenzuela', N'jvalenzuela', 1, N'jazuela67')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (6, N'Keely Dickson', N'kdickson', 1, N'keckson95')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (7, N'Sandra Riggs', N'sriggs', 1, N'sariggs41')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (8, N'Zachery Woodward', N'zwoodward', 1, N'zadward1')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (9, N'Emi Owen', N'eowen', 1, N'em owen9')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (10, N'Ariel Moss', N'amoss', 1, N'ar moss35')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (11, N'Phelan Mckee', N'pmckee', 1, N'phmckee27')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (12, N'Uta Cooper', N'ucooper', 2, N'utooper36')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (13, N'Iris Holden', N'iholden', 2, N'irolden2')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (14, N'Faith Cameron', N'fcameron', 2, N'fameron19')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (15, N'Renee Mosley', N'rmosley', 2, N'reosley3')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (16, N'Dana Martin', N'dmartin', 2, N'daartin89')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (17, N'Martin Larson', N'mlarson', 2, N'maarson53')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (18, N'Quinlan Mays', N'qmays', 2, N'qu mays50')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (19, N'Kelly Blackwell', N'kblackwell', 2, N'kekwell30')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (20, N'Madonna Weber', N'mweber', 2, N'maweber66')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (21, N'Jael Roberson', N'jroberson', 2, N'jaerson89')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (22, N'Anastasia Peters', N'apeters', 2, N'aneters83')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (23, N'Carol Aguilar', N'caguilar', 2, N'cauilar38')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (24, N'Alexandra Hobbs', N'ahobbs', 2, N'alhobbs32')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (25, N'Myles Golden', N'mgolden', 2, N'myolden27')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (26, N'Marny Thomas', N'mthomas', 2, N'mahomas53')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (27, N'Aline Curtis', N'acurtis', 2, N'alurtis44')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (28, N'Sade Nielsen', N'snielsen', 2, N'saelsen93')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (29, N'Halla Velez', N'hvelez', 2, N'havelez31')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (30, N'Kiara Joseph', N'kjoseph', 3, N'kioseph22')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (31, N'Stacy Wilkinson', N'swilkinson', 3, N'stinson81')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (32, N'Bevis York', N'byork', 3, N'be york64')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (33, N'Nita Santos', N'nsantos', 3, N'niantos52')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (34, N'Connor Fleming', N'cfleming', 3, N'coeming29')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (35, N'Steel Rosario', N'srosario', 3, N'stsario44')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (36, N'Mariam Mullen', N'mmullen', 3, N'maullen21')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (37, N'Blaine Patrick', N'bpatrick', 3, N'bltrick53')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (38, N'Meredith Simpson', N'msimpson', 3, N'mempson73')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (39, N'Noel Sutton', N'nsutton', 3, N'noutton25')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (40, N'Deacon Mullins', N'dmullins', 3, N'dellins57')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (41, N'Kirby England', N'kengland', 3, N'kigland62')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (42, N'Pandora Morris', N'pmorris', 3, N'paorris6')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (43, N'Magee Ayala', N'mayala', 3, N'maayala12')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (44, N'Caleb Jarvis', N'cjarvis', 3, N'caarvis9')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (45, N'Oleg Juarez', N'ojuarez', 3, N'oluarez77')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (46, N'Doris Woodward', N'dwoodward', 3, N'dodward71')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (47, N'Simon Robinson', N'srobinson', 3, N'siinson63')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (48, N'Kuame Bond', N'kbond', 3, N'ku bond52')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (49, N'Courtney Black', N'cblack', 3, N'coblack27')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (50, N'Warren Knox', N'wknox', 3, N'wa knox44')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (51, N'Macon Rodgers', N'mrodgers', 3, N'madgers90')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (52, N'Merrill Lane', N'mlane', 3, N'me lane65')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (53, N'Nero Franks', N'nfranks', 3, N'neranks41')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (54, N'Malcolm Edwards', N'medwards', 3, N'mawards33')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (55, N'Cade Rodgers', N'crodgers', 3, N'cadgers46')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (56, N'Yvonne Singleton', N'ysingleton', 3, N'yvleton70')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (57, N'Shellie Mckee', N'smckee', 3, N'shmckee15')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (58, N'Brandon Hart', N'bhart', 3, N'br hart63')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (59, N'Cullen Mack', N'cmack', 3, N'cu mack18')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (60, N'Hall Grimes', N'hgrimes', 3, N'harimes11')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (61, N'Lev Cleveland', N'lcleveland', 3, N'leeland38')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (62, N'Driscoll Klein', N'dklein', 3, N'drklein97')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (63, N'Giselle Reeves', N'greeves', 3, N'gieeves78')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (64, N'Dominique Emerson', N'demerson', 3, N'doerson18')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (65, N'Sloane Hobbs', N'shobbs', 3, N'slhobbs83')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (66, N'Yvonne Castillo', N'ycastillo', 3, N'yvtillo48')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (67, N'Iona Collins', N'icollins', 3, N'iollins36')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (68, N'Indira Wolfe', N'iwolfe', 3, N'inwolfe8')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (69, N'Chava Good', N'cgood', 3, N'ch good40')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (70, N'Calista Hodges', N'chodges', 3, N'caodges79')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (71, N'Oleg Delacruz', N'odelacruz', 3, N'olacruz98')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (72, N'Yvonne Wright', N'ywright', 3, N'yvright28')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (73, N'Kimberley Berry', N'kberry', 3, N'kiberry82')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (74, N'Jacob Mccullough', N'jmccullough', 3, N'jalough92')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (75, N'Lucian Palmer', N'lpalmer', 3, N'lualmer67')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (76, N'Bell Phillips', N'bphillips', 3, N'bellips69')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (77, N'Arthur Jordan', N'ajordan', 3, N'arordan63')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (78, N'Leonard Rich', N'lrich', 3, N'le rich1')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (79, N'Joelle Clemons', N'jclemons', 4, N'joemons27')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (80, N'Zephania Roy', N'zroy', 4, N'zea roy22')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (81, N'Nadine Hernandez', N'nhernandez', 4, N'naandez68')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (82, N'Anika Pope', N'apope', 4, N'an pope82')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (83, N'Denton Randall', N'drandall', 4, N'dendall20')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (84, N'Remedios Merritt', N'rmerritt', 4, N'rerritt34')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (85, N'Fulton Hale', N'fhale', 4, N'fu hale36')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (86, N'Christen Bryan', N'cbryan', 4, N'chbryan75')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (87, N'Gillian Castillo', N'gcastillo', 4, N'gitillo15')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (88, N'Katelyn Patel', N'kpatel', 4, N'kapatel51')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (89, N'Clare Hayden', N'chayden', 4, N'clayden21')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (90, N'Kirby Roach', N'kroach', 5, N'kiroach71')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (91, N'Tana Colon', N'tcolon', 5, N'tacolon86')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (92, N'Gretchen Hancock', N'ghancock', 5, N'grncock57')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (93, N'Judith Leonard', N'jleonard', 5, N'juonard45')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (94, N'Amaya Brady', N'abrady', 5, N'ambrady38')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (95, N'Alice Torres', N'atorres', 5, N'alorres57')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (96, N'Marny Oconnor', N'moconnor', 5, N'maonnor74')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (97, N'Sonia Cantu', N'scantu', 5, N'socantu85')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (98, N'Cathleen Wiley', N'cwiley', 5, N'cawiley44')
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (99, N'Rajah Sanchez', N'rsanchez', 5, N'ranchez32')
GO
INSERT [dbo].[Employee] ([Id], [Name], [Username], [department_id], [Password]) VALUES (100, N'Declan Arnold', N'darnold', 5, N'dernold19')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
ALTER TABLE [dbo].[ChatMessage]  WITH CHECK ADD  CONSTRAINT [FK_ChatMessage_Chatroom] FOREIGN KEY([Chatroom_Id])
REFERENCES [dbo].[Chatroom] ([Id])
GO
ALTER TABLE [dbo].[ChatMessage] CHECK CONSTRAINT [FK_ChatMessage_Chatroom]
GO
ALTER TABLE [dbo].[ChatMessage]  WITH CHECK ADD  CONSTRAINT [FK_ChatMessage_Employee] FOREIGN KEY([Sender_Id])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[ChatMessage] CHECK CONSTRAINT [FK_ChatMessage_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department1] FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department1]
GO
ALTER TABLE [dbo].[EmployeeChatroom]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeChatroom_Chatroom] FOREIGN KEY([Chatroom_Id])
REFERENCES [dbo].[Chatroom] ([Id])
GO
ALTER TABLE [dbo].[EmployeeChatroom] CHECK CONSTRAINT [FK_EmployeeChatroom_Chatroom]
GO
ALTER TABLE [dbo].[EmployeeChatroom]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeChatroom_Employee] FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[EmployeeChatroom] CHECK CONSTRAINT [FK_EmployeeChatroom_Employee]
GO
USE [master]
GO
ALTER DATABASE [ChitChat] SET  READ_WRITE 
GO
