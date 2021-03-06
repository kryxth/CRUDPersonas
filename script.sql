CREATE DATABASE [CrudPersonas]
GO
USE [CrudPersonas]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 02/08/2020 20:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Sexo] [char](1) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proPersonaActualizar]    Script Date: 02/08/2020 20:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proPersonaActualizar]
	@IdPersona int,
	@Nombre varchar(100),
	@FechaNacimiento datetime,
	@Sexo char
AS
BEGIN
	SET NOCOUNT ON;

	update [dbo].[Persona] 
	set [Nombre] = @Nombre,
	FechaNacimiento = @FechaNacimiento,
	Sexo = @Sexo
	where IdPersona = @IdPersona

END
GO
/****** Object:  StoredProcedure [dbo].[proPersonaEliminar]    Script Date: 02/08/2020 20:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proPersonaEliminar]
	@IdPersona int
AS
BEGIN
	delete Persona where IdPersona = @IdPersona 
END
GO
/****** Object:  StoredProcedure [dbo].[proPersonaInsertar]    Script Date: 02/08/2020 20:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proPersonaInsertar]
	@Nombre varchar(100),
	@FechaNacimiento datetime,
	@Sexo char
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Persona]
           ([Nombre]
           ,[FechaNacimiento]
           ,[Sexo])
     VALUES
           (@Nombre
           ,@FechaNacimiento
           ,@Sexo)
END
GO
/****** Object:  StoredProcedure [dbo].[proPersonaSeleccionar]    Script Date: 02/08/2020 20:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[proPersonaSeleccionar]
	@IdPersona int = null
AS
BEGIN
	select IdPersona , Nombre , FechaNacimiento , Sexo from Persona 
	where IdPersona = ISNULL(@IdPersona , IdPersona)
END
GO
