USE [Universidad]
GO
SET IDENTITY_INSERT [dbo].[Estudiante] ON 

INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (9, N'Alexander', N'Carson', CAST(N'2005-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (10, N'Alonso', N'Meredith', CAST(N'2002-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (11, N'Anand', N'Arturo', CAST(N'2003-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (12, N'Barzdukas', N'Gytis', CAST(N'2002-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (13, N'Li', N'Yan', CAST(N'2002-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (14, N'Justice', N'Peggy', CAST(N'2001-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (15, N'Norman', N'Laura', CAST(N'2003-09-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Estudiante] ([ID], [Apellido], [Nombre], [FechaInscripcion]) VALUES (16, N'Olivetto', N'Nino', CAST(N'2005-09-01T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Estudiante] OFF
GO
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (1004, N'Algebra', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (1045, N'Calculo', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (1050, N'Química', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (2021, N'Electiva', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (2042, N'Literatura', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (3124, N'Programación', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (3141, N'Trigonometría', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (3250, N'Robótica', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (4022, N'Economía', 3)
INSERT [dbo].[Materia] ([MateriaID], [Titulo], [Creditos]) VALUES (4041, N'Física', 3)
GO
SET IDENTITY_INSERT [dbo].[MateriaEstudiante] ON 

INSERT [dbo].[MateriaEstudiante] ([ID], [MateriaID], [EstudianteID]) VALUES (3, 1045, 9)
INSERT [dbo].[MateriaEstudiante] ([ID], [MateriaID], [EstudianteID]) VALUES (6, 4041, 9)
INSERT [dbo].[MateriaEstudiante] ([ID], [MateriaID], [EstudianteID]) VALUES (7, 1004, 9)
SET IDENTITY_INSERT [dbo].[MateriaEstudiante] OFF
GO
SET IDENTITY_INSERT [dbo].[Profesor] ON 

INSERT [dbo].[Profesor] ([ID], [Apellido], [Nombre], [FechaContratacion]) VALUES (1, N'Abercrombie', N'Kim', CAST(N'1995-03-11T00:00:00.000' AS DateTime))
INSERT [dbo].[Profesor] ([ID], [Apellido], [Nombre], [FechaContratacion]) VALUES (2, N'Fakhouri', N'Fadi', CAST(N'2002-07-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Profesor] ([ID], [Apellido], [Nombre], [FechaContratacion]) VALUES (3, N'Harui', N'Roger', CAST(N'1998-07-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Profesor] ([ID], [Apellido], [Nombre], [FechaContratacion]) VALUES (4, N'Kapoor', N'Candace', CAST(N'2001-01-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Profesor] ([ID], [Apellido], [Nombre], [FechaContratacion]) VALUES (5, N'Zheng', N'Roger', CAST(N'2004-02-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Profesor] OFF
GO
SET IDENTITY_INSERT [dbo].[MateriaProfesor] ON 

INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (1, 1004, 4)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (2, 1050, 3)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (3, 2042, 5)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (4, 3124, 5)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (5, 3141, 2)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (6, 2021, 3)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (7, 4022, 1)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (8, 4041, 1)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (9, 3250, 2)
INSERT [dbo].[MateriaProfesor] ([ID], [MateriaID], [ProfesorID]) VALUES (10, 1045, 4)
SET IDENTITY_INSERT [dbo].[MateriaProfesor] OFF
GO
