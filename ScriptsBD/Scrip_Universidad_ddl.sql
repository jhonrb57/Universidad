USE [Universidad]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 12/04/2024 2:45:34 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[FechaInscripcion] [datetime] NULL,
 CONSTRAINT [PK_Estudiante] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materia]    Script Date: 12/04/2024 2:45:34 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[MateriaID] [int] NOT NULL,
	[Titulo] [varchar](50) NULL,
	[Creditos] [int] NULL,
 CONSTRAINT [PK_Materia] PRIMARY KEY CLUSTERED 
(
	[MateriaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaEstudiante]    Script Date: 12/04/2024 2:45:34 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaEstudiante](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MateriaID] [int] NOT NULL,
	[EstudianteID] [int] NOT NULL,
 CONSTRAINT [PK_MateriaEstudiante_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaProfesor]    Script Date: 12/04/2024 2:45:34 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaProfesor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MateriaID] [int] NOT NULL,
	[ProfesorID] [int] NOT NULL,
 CONSTRAINT [PK_MateriaProfesor_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 12/04/2024 2:45:34 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[FechaContratacion] [datetime] NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MateriaEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_MateriaEstudiante_Materia] FOREIGN KEY([MateriaID])
REFERENCES [dbo].[Materia] ([MateriaID])
GO
ALTER TABLE [dbo].[MateriaEstudiante] CHECK CONSTRAINT [FK_MateriaEstudiante_Materia]
GO
ALTER TABLE [dbo].[MateriaEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_MateriaEstudiante_Profesor] FOREIGN KEY([EstudianteID])
REFERENCES [dbo].[Estudiante] ([ID])
GO
ALTER TABLE [dbo].[MateriaEstudiante] CHECK CONSTRAINT [FK_MateriaEstudiante_Profesor]
GO
ALTER TABLE [dbo].[MateriaProfesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaProfesor_Materia] FOREIGN KEY([MateriaID])
REFERENCES [dbo].[Materia] ([MateriaID])
GO
ALTER TABLE [dbo].[MateriaProfesor] CHECK CONSTRAINT [FK_MateriaProfesor_Materia]
GO
ALTER TABLE [dbo].[MateriaProfesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaProfesor_Profesor] FOREIGN KEY([ProfesorID])
REFERENCES [dbo].[Profesor] ([ID])
GO
ALTER TABLE [dbo].[MateriaProfesor] CHECK CONSTRAINT [FK_MateriaProfesor_Profesor]
GO
