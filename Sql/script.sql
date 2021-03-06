USE [Questionnaire]
GO
/****** Object:  Table [dbo].[Opition]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opition](
	[OpitionId] [bigint] IDENTITY(1,1) NOT NULL,
	[QuestionId] [bigint] NULL,
	[OpitionName] [nvarchar](100) NULL,
	[IsCorrect] [bit] NULL,
 CONSTRAINT [PK_Opition] PRIMARY KEY CLUSTERED 
(
	[OpitionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[QuestionId] [bigint] IDENTITY(1,1) NOT NULL,
	[QuestionName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestId] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NULL,
	[CreateBy] [datetime] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Test] PRIMARY KEY CLUSTERED 
(
	[TestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test_Question_Mapping]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test_Question_Mapping](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TestId] [bigint] NOT NULL,
	[QuestionId] [bigint] NOT NULL,
 CONSTRAINT [PK_Test_Question_Mapping] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Test_Mapping]    Script Date: 5/18/2022 7:11:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Test_Mapping](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[TestId] [bigint] NOT NULL,
	[TestHour] [int] NULL,
	[Score] [decimal](18, 2) NULL,
 CONSTRAINT [PK_User_Test_Mapping] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Opition] ON 

INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (1, 1, N'Yes', 1)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (2, 1, N'No', 0)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (3, 2, N'Yes', 1)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (4, 2, N'No', 0)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (5, 3, N'Yes', 1)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (6, 3, N'No', 0)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (7, 4, N'Yes', 1)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (8, 4, N'No', 0)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (9, 5, N'Yes', 1)
INSERT [dbo].[Opition] ([OpitionId], [QuestionId], [OpitionName], [IsCorrect]) VALUES (13, 5, N'No', 0)
SET IDENTITY_INSERT [dbo].[Opition] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([QuestionId], [QuestionName]) VALUES (1, N'What do you like angular?')
INSERT [dbo].[Question] ([QuestionId], [QuestionName]) VALUES (2, N'What do you like ASP.NET Core?')
INSERT [dbo].[Question] ([QuestionId], [QuestionName]) VALUES (3, N'Are you readlly learn the Angular?')
INSERT [dbo].[Question] ([QuestionId], [QuestionName]) VALUES (4, N'Are you readlly learn the ASP.Net Core?')
INSERT [dbo].[Question] ([QuestionId], [QuestionName]) VALUES (5, N'Why is choice Angular and ASP.NET Core?')
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET IDENTITY_INSERT [dbo].[Test] ON 

INSERT [dbo].[Test] ([TestId], [Name], [CreateBy], [CreateDate]) VALUES (1, N'Test 01', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Test] OFF
GO
SET IDENTITY_INSERT [dbo].[Test_Question_Mapping] ON 

INSERT [dbo].[Test_Question_Mapping] ([Id], [TestId], [QuestionId]) VALUES (1, 1, 1)
SET IDENTITY_INSERT [dbo].[Test_Question_Mapping] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [Firstname], [LastName]) VALUES (1, N'David', N'Cao')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[User_Test_Mapping] ON 

INSERT [dbo].[User_Test_Mapping] ([Id], [UserId], [TestId], [TestHour], [Score]) VALUES (1, 1, 1, 0, CAST(0.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[User_Test_Mapping] OFF
GO
ALTER TABLE [dbo].[Opition]  WITH CHECK ADD  CONSTRAINT [FK_Opition_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
GO
ALTER TABLE [dbo].[Opition] CHECK CONSTRAINT [FK_Opition_Question]
GO
ALTER TABLE [dbo].[Test_Question_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_Test_Question_Mapping_Question] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[Question] ([QuestionId])
GO
ALTER TABLE [dbo].[Test_Question_Mapping] CHECK CONSTRAINT [FK_Test_Question_Mapping_Question]
GO
ALTER TABLE [dbo].[Test_Question_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_Test_Question_Mapping_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([TestId])
GO
ALTER TABLE [dbo].[Test_Question_Mapping] CHECK CONSTRAINT [FK_Test_Question_Mapping_Test]
GO
ALTER TABLE [dbo].[User_Test_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_User_Test_Mapping_Test] FOREIGN KEY([TestId])
REFERENCES [dbo].[Test] ([TestId])
GO
ALTER TABLE [dbo].[User_Test_Mapping] CHECK CONSTRAINT [FK_User_Test_Mapping_Test]
GO
ALTER TABLE [dbo].[User_Test_Mapping]  WITH CHECK ADD  CONSTRAINT [FK_User_Test_Mapping_User1] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[User_Test_Mapping] CHECK CONSTRAINT [FK_User_Test_Mapping_User1]
GO
