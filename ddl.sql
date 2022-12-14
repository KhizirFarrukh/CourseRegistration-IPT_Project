USE [CourseRegistration]
GO
/****** Object:  Table [dbo].[CoreCourses]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoreCourses](
	[id] [uniqueidentifier] NOT NULL,
	[prevChainID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_CoreCourses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CourseLogs]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CourseLogs](
	[id] [uniqueidentifier] NOT NULL,
	[courseID] [uniqueidentifier] NOT NULL,
	[teacherID] [uniqueidentifier] NOT NULL,
	[sectionID] [uniqueidentifier] NOT NULL,
	[year] [int] NOT NULL,
	[status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_CourseLogs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[id] [uniqueidentifier] NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[deptID] [uniqueidentifier] NOT NULL,
	[creditHours] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[id] [uniqueidentifier] NOT NULL,
	[code] [nvarchar](max) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LabCourses]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabCourses](
	[id] [uniqueidentifier] NOT NULL,
	[theoryID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_LabCourses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegisteredCourses]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegisteredCourses](
	[studentID] [nvarchar](450) NOT NULL,
	[courseLogID] [uniqueidentifier] NOT NULL,
	[status] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RegisteredCourses] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC,
	[courseLogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sections]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[id] [uniqueidentifier] NOT NULL,
	[deptID] [uniqueidentifier] NOT NULL,
	[postfixCharacter] [nvarchar](1) NOT NULL,
	[semesterNo] [int] NOT NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentLogins]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentLogins](
	[studentID] [nvarchar](450) NOT NULL,
	[password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_StudentLogins] PRIMARY KEY CLUSTERED 
(
	[studentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[id] [nvarchar](450) NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[sectionID] [uniqueidentifier] NOT NULL,
	[batchYear] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[id] [uniqueidentifier] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheoryCourses]    Script Date: 09/12/2022 7:09:13 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheoryCourses](
	[id] [uniqueidentifier] NOT NULL,
	[type] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TheoryCourses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CoreCourses]  WITH CHECK ADD  CONSTRAINT [FK_CoreCourses_CoreCourses_prevChainID] FOREIGN KEY([prevChainID])
REFERENCES [dbo].[CoreCourses] ([id])
GO
ALTER TABLE [dbo].[CoreCourses] CHECK CONSTRAINT [FK_CoreCourses_CoreCourses_prevChainID]
GO
ALTER TABLE [dbo].[CoreCourses]  WITH CHECK ADD  CONSTRAINT [FK_CoreCourses_TheoryCourses_id] FOREIGN KEY([id])
REFERENCES [dbo].[TheoryCourses] ([id])
GO
ALTER TABLE [dbo].[CoreCourses] CHECK CONSTRAINT [FK_CoreCourses_TheoryCourses_id]
GO
ALTER TABLE [dbo].[CourseLogs]  WITH CHECK ADD  CONSTRAINT [FK_CourseLogs_Courses_courseID] FOREIGN KEY([courseID])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[CourseLogs] CHECK CONSTRAINT [FK_CourseLogs_Courses_courseID]
GO
ALTER TABLE [dbo].[CourseLogs]  WITH CHECK ADD  CONSTRAINT [FK_CourseLogs_Sections_sectionID] FOREIGN KEY([sectionID])
REFERENCES [dbo].[Sections] ([id])
GO
ALTER TABLE [dbo].[CourseLogs] CHECK CONSTRAINT [FK_CourseLogs_Sections_sectionID]
GO
ALTER TABLE [dbo].[CourseLogs]  WITH CHECK ADD  CONSTRAINT [FK_CourseLogs_Teachers_teacherID] FOREIGN KEY([teacherID])
REFERENCES [dbo].[Teachers] ([id])
GO
ALTER TABLE [dbo].[CourseLogs] CHECK CONSTRAINT [FK_CourseLogs_Teachers_teacherID]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Departments_deptID] FOREIGN KEY([deptID])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Departments_deptID]
GO
ALTER TABLE [dbo].[LabCourses]  WITH CHECK ADD  CONSTRAINT [FK_LabCourses_Courses_id] FOREIGN KEY([id])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[LabCourses] CHECK CONSTRAINT [FK_LabCourses_Courses_id]
GO
ALTER TABLE [dbo].[LabCourses]  WITH CHECK ADD  CONSTRAINT [FK_LabCourses_TheoryCourses_theoryID] FOREIGN KEY([theoryID])
REFERENCES [dbo].[TheoryCourses] ([id])
GO
ALTER TABLE [dbo].[LabCourses] CHECK CONSTRAINT [FK_LabCourses_TheoryCourses_theoryID]
GO
ALTER TABLE [dbo].[RegisteredCourses]  WITH CHECK ADD  CONSTRAINT [FK_RegisteredCourses_CourseLogs_courseLogID] FOREIGN KEY([courseLogID])
REFERENCES [dbo].[CourseLogs] ([id])
GO
ALTER TABLE [dbo].[RegisteredCourses] CHECK CONSTRAINT [FK_RegisteredCourses_CourseLogs_courseLogID]
GO
ALTER TABLE [dbo].[RegisteredCourses]  WITH CHECK ADD  CONSTRAINT [FK_RegisteredCourses_Students_studentID] FOREIGN KEY([studentID])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[RegisteredCourses] CHECK CONSTRAINT [FK_RegisteredCourses_Students_studentID]
GO
ALTER TABLE [dbo].[Sections]  WITH CHECK ADD  CONSTRAINT [FK_Sections_Departments_deptID] FOREIGN KEY([deptID])
REFERENCES [dbo].[Departments] ([id])
GO
ALTER TABLE [dbo].[Sections] CHECK CONSTRAINT [FK_Sections_Departments_deptID]
GO
ALTER TABLE [dbo].[StudentLogins]  WITH CHECK ADD  CONSTRAINT [FK_StudentLogins_Students_studentID] FOREIGN KEY([studentID])
REFERENCES [dbo].[Students] ([id])
GO
ALTER TABLE [dbo].[StudentLogins] CHECK CONSTRAINT [FK_StudentLogins_Students_studentID]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Sections_sectionID] FOREIGN KEY([sectionID])
REFERENCES [dbo].[Sections] ([id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Sections_sectionID]
GO
ALTER TABLE [dbo].[TheoryCourses]  WITH CHECK ADD  CONSTRAINT [FK_TheoryCourses_Courses_id] FOREIGN KEY([id])
REFERENCES [dbo].[Courses] ([id])
GO
ALTER TABLE [dbo].[TheoryCourses] CHECK CONSTRAINT [FK_TheoryCourses_Courses_id]
GO
