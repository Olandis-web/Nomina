USE [master]
GO
/****** Object:  Database [SysNom2024]    Script Date: 8/4/2024 3:24:31 PM ******/
CREATE DATABASE [SysNom2024]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SysNom2024', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SysNom2024.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SysNom2024_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\SysNom2024_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SysNom2024] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SysNom2024].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SysNom2024] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SysNom2024] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SysNom2024] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SysNom2024] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SysNom2024] SET ARITHABORT OFF 
GO
ALTER DATABASE [SysNom2024] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SysNom2024] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SysNom2024] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SysNom2024] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SysNom2024] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SysNom2024] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SysNom2024] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SysNom2024] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SysNom2024] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SysNom2024] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SysNom2024] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SysNom2024] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SysNom2024] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SysNom2024] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SysNom2024] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SysNom2024] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SysNom2024] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SysNom2024] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SysNom2024] SET  MULTI_USER 
GO
ALTER DATABASE [SysNom2024] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SysNom2024] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SysNom2024] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SysNom2024] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SysNom2024] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SysNom2024] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SysNom2024] SET QUERY_STORE = ON
GO
ALTER DATABASE [SysNom2024] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SysNom2024]
GO
/****** Object:  Table [dbo].[Comision]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comision](
	[IDComision] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](50) NOT NULL,
	[MontoComision] [decimal](10, 2) NOT NULL,
	[EstadoPago] [varchar](150) NOT NULL,
	[MetodoPago] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Comision] PRIMARY KEY CLUSTERED 
(
	[IDComision] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[IDDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[NombreDepartamento] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Descuentos]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[IDDescuento] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](50) NULL,
	[NombreDescuento] [varchar](170) NOT NULL,
 CONSTRAINT [PK_Descuentos] PRIMARY KEY CLUSTERED 
(
	[IDDescuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[IDEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Telefono] [varchar](11) NOT NULL,
	[Departamento] [varchar](100) NOT NULL,
	[Sueldo] [decimal](10, 2) NOT NULL,
	[Posicion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IDEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoAprobacion]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoAprobacion](
	[IDEstadoAprobacion] [int] IDENTITY(1,1) NOT NULL,
	[EstadoAprobacion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoAprobacion] PRIMARY KEY CLUSTERED 
(
	[IDEstadoAprobacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPago]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPago](
	[IDEstadoPago] [int] IDENTITY(1,1) NOT NULL,
	[EstadoPago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoPago] PRIMARY KEY CLUSTERED 
(
	[IDEstadoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gestión de empresa]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gestión de empresa](
	[IDEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[RNC] [varchar](20) NOT NULL,
	[Propietario] [varchar](150) NOT NULL,
	[SitioWeb] [varchar](150) NOT NULL,
	[Telefono] [varchar](11) NOT NULL,
	[Direccion] [varchar](250) NOT NULL,
 CONSTRAINT [PK_Gestión de empresa] PRIMARY KEY CLUSTERED 
(
	[IDEmpresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gestión de usuario]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gestión de usuario](
	[IDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Clave] [varchar](150) NOT NULL,
	[Rol] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Gestión de usuario] PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horas extras]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horas extras](
	[IDHoraExtra] [int] IDENTITY(1,1) NOT NULL,
	[NombreEmpleado] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[TotalHorasextras] [decimal](6, 2) NOT NULL,
	[TarifaPago] [decimal](8, 2) NOT NULL,
	[EstadoAprobacion] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Horas extras] PRIMARY KEY CLUSTERED 
(
	[IDHoraExtra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodoPago](
	[IDMetodoPago] [int] IDENTITY(1,1) NOT NULL,
	[MetodoPago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MetodoPago] PRIMARY KEY CLUSTERED 
(
	[IDMetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posiciones]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posiciones](
	[IDPosicion] [int] IDENTITY(1,1) NOT NULL,
	[Nombreposicion] [varchar](100) NOT NULL,
	[Sueldoposicion] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Posiciones] PRIMARY KEY CLUSTERED 
(
	[IDPosicion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IDRol] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[IDRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sueldo]    Script Date: 8/4/2024 3:24:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldo](
	[IDEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Fechapago] [datetime] NOT NULL,
	[Salariobase] [decimal](10, 2) NOT NULL,
	[Tarifahoraria] [decimal](8, 2) NOT NULL,
	[Sueldoneto] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Comision] ON 

INSERT [dbo].[Comision] ([IDComision], [NombreEmpleado], [MontoComision], [EstadoPago], [MetodoPago]) VALUES (2, N'JUAN PEREZ', CAST(8000.00 AS Decimal(10, 2)), N'PENDIENTE', N'CHEQUE')
INSERT [dbo].[Comision] ([IDComision], [NombreEmpleado], [MontoComision], [EstadoPago], [MetodoPago]) VALUES (3, N'JUANA PEREZ', CAST(5000.00 AS Decimal(10, 2)), N'APROBADO', N'TRANSFERENCIA')
INSERT [dbo].[Comision] ([IDComision], [NombreEmpleado], [MontoComision], [EstadoPago], [MetodoPago]) VALUES (4, N'HUGO MENA', CAST(8265.00 AS Decimal(10, 2)), N'PENDIENTE', N'TRANSFERENCIA')
INSERT [dbo].[Comision] ([IDComision], [NombreEmpleado], [MontoComision], [EstadoPago], [MetodoPago]) VALUES (5, N'RAFAELA MARTINEZ', CAST(86320.00 AS Decimal(10, 2)), N'APROBADO', N'TRANSFERENCIA')
SET IDENTITY_INSERT [dbo].[Comision] OFF
GO
SET IDENTITY_INSERT [dbo].[Departamentos] ON 

INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (1, N'RRHH')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (2, N'AUDITORIA INTERNA')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (3, N'CONTABILIDAD')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (4, N'VENTAS')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (5, N'GERENCIA ADMINISTRATIVA')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (6, N'MANTENIMIENTO')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (7, N'COMPRA')
INSERT [dbo].[Departamentos] ([IDDepartamento], [NombreDepartamento]) VALUES (8, N'GERENCIA FINANCIERA')
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Descuentos] ON 

INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (1, N'OSCAR MARTINEZ', N'TSS (Tesorería de Seguridad Social)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (2, N'ARMANDO MENDOZA', N'ISR (Impuesto Sobre la Renta)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (6, N'JULIAN ALVAREZ', N'AFP (Administradora de fondos de Pensiones)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (7, N'JUANA DEL CARMEN', N'AFP (Administradora de fondos de Pensiones)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (8, N'MARIA GUZMAN', N'SFS (Seguro Familiar Salud)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (9, N'CARLOS GONZALES', N'SRL (Seguro de Riesgo Laboral)')
INSERT [dbo].[Descuentos] ([IDDescuento], [NombreEmpleado], [NombreDescuento]) VALUES (10, N'ANTONIETA DE LA CRUZ', N'TSS (Tesorería de Seguridad Social)')
SET IDENTITY_INSERT [dbo].[Descuentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([IDEmpleado], [Nombre], [Telefono], [Departamento], [Sueldo], [Posicion]) VALUES (1, N'JUAN PEREZ', N'8096652531', N'GERENCIA ADMINISTRATIVA', CAST(25000.00 AS Decimal(10, 2)), N'ENCARGADO')
INSERT [dbo].[Empleados] ([IDEmpleado], [Nombre], [Telefono], [Departamento], [Sueldo], [Posicion]) VALUES (2, N'MARIA TORRES', N'8297756420', N'CONTABILIDAD', CAST(65000.00 AS Decimal(10, 2)), N'GERENTE')
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoAprobacion] ON 

INSERT [dbo].[EstadoAprobacion] ([IDEstadoAprobacion], [EstadoAprobacion]) VALUES (1, N'PENDIENTE')
INSERT [dbo].[EstadoAprobacion] ([IDEstadoAprobacion], [EstadoAprobacion]) VALUES (2, N'APROBADO')
SET IDENTITY_INSERT [dbo].[EstadoAprobacion] OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoPago] ON 

INSERT [dbo].[EstadoPago] ([IDEstadoPago], [EstadoPago]) VALUES (1, N'PENDIENTE')
INSERT [dbo].[EstadoPago] ([IDEstadoPago], [EstadoPago]) VALUES (2, N'APROBADO')
SET IDENTITY_INSERT [dbo].[EstadoPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Gestión de empresa] ON 

INSERT [dbo].[Gestión de empresa] ([IDEmpresa], [Nombre], [RNC], [Propietario], [SitioWeb], [Telefono], [Direccion]) VALUES (2, N'D''OLANDIS PELUQUERIA', N'123456789', N'OLANDIS BATISTA', N'OLANDISPELU@GMAIL.COM', N'8096654231', N'CALLE A, LA MONEDA, AUT. SAN ISIDRO')
SET IDENTITY_INSERT [dbo].[Gestión de empresa] OFF
GO
SET IDENTITY_INSERT [dbo].[Gestión de usuario] ON 

INSERT [dbo].[Gestión de usuario] ([IDUsuario], [Nombre], [Usuario], [Clave], [Rol]) VALUES (1, N'OLANDIS BATISTA', N'OLANDIS777', N'123456', N'CREACION')
INSERT [dbo].[Gestión de usuario] ([IDUsuario], [Nombre], [Usuario], [Clave], [Rol]) VALUES (2, N'MATIRELYS ALCANTARA', N'MATI888', N'1234', N'REVISION')
INSERT [dbo].[Gestión de usuario] ([IDUsuario], [Nombre], [Usuario], [Clave], [Rol]) VALUES (3, N'JUSTIN SANZHEZ', N'AZUANO115', N'12345', N'APROBACION')
SET IDENTITY_INSERT [dbo].[Gestión de usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Horas extras] ON 

INSERT [dbo].[Horas extras] ([IDHoraExtra], [NombreEmpleado], [Fecha], [TotalHorasextras], [TarifaPago], [EstadoAprobacion]) VALUES (2, N'MIGUEL VARGAS', CAST(N'2024-07-24T11:40:51.970' AS DateTime), CAST(5.00 AS Decimal(6, 2)), CAST(2000.00 AS Decimal(8, 2)), N'APROBADO')
INSERT [dbo].[Horas extras] ([IDHoraExtra], [NombreEmpleado], [Fecha], [TotalHorasextras], [TarifaPago], [EstadoAprobacion]) VALUES (3, N'MARIA DEL CARMEN', CAST(N'2024-07-24T11:41:21.103' AS DateTime), CAST(2.00 AS Decimal(6, 2)), CAST(550.00 AS Decimal(8, 2)), N'PENDIENTE')
INSERT [dbo].[Horas extras] ([IDHoraExtra], [NombreEmpleado], [Fecha], [TotalHorasextras], [TarifaPago], [EstadoAprobacion]) VALUES (4, N'JULIAN ALVAREZ', CAST(N'2024-08-03T12:40:54.000' AS DateTime), CAST(8.00 AS Decimal(6, 2)), CAST(5000.00 AS Decimal(8, 2)), N'APROBADO')
INSERT [dbo].[Horas extras] ([IDHoraExtra], [NombreEmpleado], [Fecha], [TotalHorasextras], [TarifaPago], [EstadoAprobacion]) VALUES (5, N'OLANDIS BATISTA', CAST(N'2024-06-07T12:40:54.000' AS DateTime), CAST(1.00 AS Decimal(6, 2)), CAST(500000.00 AS Decimal(8, 2)), N'APROBADO')
SET IDENTITY_INSERT [dbo].[Horas extras] OFF
GO
SET IDENTITY_INSERT [dbo].[MetodoPago] ON 

INSERT [dbo].[MetodoPago] ([IDMetodoPago], [MetodoPago]) VALUES (1, N'TRANSFERENCIA')
INSERT [dbo].[MetodoPago] ([IDMetodoPago], [MetodoPago]) VALUES (2, N'CHEQUE')
SET IDENTITY_INSERT [dbo].[MetodoPago] OFF
GO
SET IDENTITY_INSERT [dbo].[Posiciones] ON 

INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (2, N'GERENTE', CAST(1235.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (4, N'ENCARGADO', CAST(4465.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (6, N'ANALISTA', CAST(4564.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (9, N'MENSAJERO', CAST(879.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (10, N'SECRETARIO/A', CAST(51321.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (12, N'AUXILIAR', CAST(4546.00 AS Decimal(18, 2)))
INSERT [dbo].[Posiciones] ([IDPosicion], [Nombreposicion], [Sueldoposicion]) VALUES (13, N'CONTADOR', CAST(123456.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Posiciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([IDRol], [Rol]) VALUES (1, N'REVISION')
INSERT [dbo].[Rol] ([IDRol], [Rol]) VALUES (2, N'APROBACION')
INSERT [dbo].[Rol] ([IDRol], [Rol]) VALUES (3, N'CREACION')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
ALTER TABLE [dbo].[Gestión de usuario] ADD  CONSTRAINT [DF_Gestión de usuario_Usuario]  DEFAULT ('UNIQUE') FOR [Usuario]
GO
ALTER TABLE [dbo].[Horas extras] ADD  CONSTRAINT [DF_Horas extras_Fecha]  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Sueldo] ADD  CONSTRAINT [DF_Sueldo_Fechapago]  DEFAULT (getdate()) FOR [Fechapago]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizacionGestiondeusuario]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_ActualizacionGestiondeusuario]
@codigo int,
@nom varchar(150),
@usr varchar(50),
@clave varchar(150),
@rol varchar(150)
AS
BEGIN
   UPDATE [dbo].[Gestión de usuario]
   SET

        [Nombre] = @nom
	   ,[Usuario] = @usr
	   ,[Clave] = @clave 
	   ,[Rol] = @rol
   
    WHERE
  IDUsuario  = @codigo
   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaComision]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaComision]
 @Codigo int,
 @nom varchar(50),
@monto decimal(10,2),
@estadopago varchar(150),
@metodo varchar(150)
AS
BEGIN
   UPDATE [dbo].[Comision]
   SET
   
        [NombreEmpleado] = @nom
       ,[MontoComision] =  @monto 
	   ,[EstadoPago] = @estadopago 
	   ,[MetodoPago] = @metodo
  
   WHERE
   IDComision = @codigo
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaDepartamento]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaDepartamento]
@Codigo int,
@nom varchar(150)

AS
BEGIN
   UPDATE [dbo].[Departamentos]
   SET
  [NombreDepartamento]   =  @nom
  
   WHERE
   [IDDepartamento] = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaDescuentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaDescuentos]
@Codigo int,
@Nomempleado varchar(50),
@nom varchar(170)

AS
BEGIN
   UPDATE [dbo].[Descuentos]
   SET
        [NombreEmpleado] = @Nomempleado
       ,[NombreDescuento]= @nom
		WHERE
   IDDescuento = @codigo
	
   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaEmpleado]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_ActualizaEmpleado]
@Codigo int,
@nom varchar(150),
@tel varchar(11),
@dep varchar(100),
@sd decimal(10,2),
@psc varchar(50)

AS
BEGIN
   UPDATE [dbo].[Empleados]
   SET
        [Nombre] =  @nom
	   ,[Telefono] = @tel
	   ,[Departamento] = @dep
	   ,[Sueldo] = @sd
	   ,[Posicion]= @psc
  
   WHERE
   IDEmpleado = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaGestiondeempresa]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaGestiondeempresa]
@Codigo int,
@nom varchar(150),
@RNC varchar(20),
@prt varchar(150),
@sw varchar(150),
@tel varchar(11),
@dir varchar(250)
AS
BEGIN
   UPDATE [dbo].[Gestión de empresa]
   SET
   
   
        [Nombre] =  @nom
		,[RNC] = @RNC
		,[Propietario] = @prt
		,[SitioWeb] = @sw 
		,[Telefono] = @tel
		,[Direccion] = @dir
	   
	   WHERE
  IDEmpresa = @codigo
  
    
	
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaHoraExtras]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_ActualizaHoraExtras]
@Codigo int,
@Nomempleado varchar(50),
@fecha datetime,
@total decimal(6,2),
@tarifa decimal(8,2),
@estado varchar(20)
AS
BEGIN
   UPDATE [dbo].[Horas extras]
   SET
   
         [NombreEmpleado] = @Nomempleado
		,[Fecha] = @fecha
        ,[TotalHorasextras] = @total 
		,[TarifaPago] = @tarifa 
		,[EstadoAprobacion] = @estado 
  
     where
	 IDHoraExtra = @codigo
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaPosiciones]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaPosiciones]
@Codigo int,
@nom varchar(100),
@sd decimal(18,2)
AS
BEGIN
   UPDATE[dbo].[Posiciones]
   SET
   
   
        [Nombreposicion] = @nom
	   ,[Sueldoposicion] = @sd
   
    
     WHERE
   IDPosicion = @codigo
	
   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaRol]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_ActualizaRol]
@Codigo int,
@rol varchar(50)

AS
BEGIN
   UPDATE [dbo].[Rol]
   SET
   [Rol]  =  @rol
  
   WHERE
   [IDRol] = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizaSueldo]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActualizaSueldo]
@Codigo int,
@salario decimal(10,2),
@Tarifahoraria decimal(8,2),
@sueldoneto decimal(10,2)
AS
BEGIN
   UPDATE [dbo].[Sueldo]
   SET
   
      
	   [Salariobase] = @salario 
	  ,[Tarifahoraria] = @Tarifahoraria 
	  ,[Sueldoneto] = @sueldoneto
     
   
    WHERE
  IDEmpleado  = @codigo
 

   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_CBDepartamentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBDepartamentos]
as
Select IDDepartamento, NombreDepartamento from [dbo].[Departamentos]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBDescuento]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[SP_CBDescuento]
as
Select NombreDescuento from [dbo].[Descuentos]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBEstadoAprobacion]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBEstadoAprobacion]
as
Select IDEstadoAprobacion, EstadoAprobacion from [dbo].[EstadoAprobacion]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBEstadoPago]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBEstadoPago]
as
Select IDEstadoPago, EstadoPago from [dbo].[EstadoPago]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBMetodoPago]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBMetodoPago]
as
Select IDMetodoPago, MetodoPago from [dbo].[MetodoPago]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBPosicion]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBPosicion]
as
Select IDPosicion, Nombreposicion from [dbo].[Posiciones]
GO
/****** Object:  StoredProcedure [dbo].[SP_CBRol]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SP_CBRol]
as
Select IDRol, Rol from [dbo].[Rol]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVComision]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DGVComision]
as
Select * from [dbo].[Comision]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVDepartamentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVDepartamentos]
as
Select * from [dbo].[Departamentos]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVDescuentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVDescuentos]
as
Select * from [dbo].[Descuentos]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVEmpleados]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVEmpleados]
as
Select * from [dbo].[Empleados]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVEmpresa]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVEmpresa]
as
Select * from [dbo].[Gestión de empresa]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVHoraExtra]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_DGVHoraExtra]
as
Select * from [dbo].[Horas extras]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVPosiciones]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVPosiciones]
as
Select * from [dbo].[Posiciones]
GO
/****** Object:  StoredProcedure [dbo].[SP_DGVUsuario]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DGVUsuario]
as
Select * from [dbo].[Gestión de usuario]
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaComision]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminaComision]
 @Codigo int
AS
BEGIN
   DELETE FROM [dbo].[Comision] WHERE IDComision = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaDepartamento]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminaDepartamento]
@codigo INT
AS
BEGIN
   DELETE FROM [dbo].[Departamentos] WHERE [IDDepartamento] = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaDescuentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_EliminaDescuentos]
@codigo INT
AS
BEGIN
   DELETE FROM [dbo].[Descuentos] WHERE IDDescuento = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaEmpleado]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_EliminaEmpleado]
@codigo INT
AS
BEGIN
   DELETE FROM [dbo].[Empleados] WHERE IDEmpleado = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaGestiondeempresa]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminaGestiondeempresa]
@Codigo int

AS
BEGIN
   DELETE FROM [dbo].[Gestión de empresa]
 
   
   
       
	   
	   WHERE
  IDEmpresa = @codigo
  
    
	END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaGestiondeusuario]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_EliminaGestiondeusuario]
@codigo int
AS
BEGIN
   DELETE FROM [dbo].[Gestión de usuario] WHERE IDUsuario = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaHoraExtras]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminaHoraExtras]
@Codigo int
AS
BEGIN
   DELETE FROM [dbo].[Horas extras]
   
  
     where
	 IDHoraExtra = @codigo
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaPosiciones]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_EliminaPosiciones]
@codigo INT
AS
BEGIN
   DELETE FROM [dbo].[Posiciones] WHERE IDPosicion = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaRol]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_EliminaRol]
@codigo INT
AS
BEGIN
   DELETE FROM [dbo].[Rol] WHERE [IDRol] = @codigo
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EliminaSueldo]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminaSueldo]
@Codigo int

AS
BEGIN
  DELETE FROM [dbo].[Sueldo]
     
   
    WHERE
  IDEmpleado  = @codigo
 

   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaComision]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaComision]
@nom varchar(50),
@monto decimal(10,2),
@estadopago varchar(150),
@metodo varchar(150)
AS
BEGIN
   INSERT INTO [dbo].[Comision]
   (
        [NombreEmpleado]
       ,[MontoComision]
	   ,[EstadoPago]
	   ,[MetodoPago]
   )
    VALUES
   (
     @nom
    ,@monto 
    ,@estadopago 
    ,@metodo
	
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaDepartamento]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_InsertaDepartamento]
@nom varchar(150)
AS
BEGIN
   INSERT INTO [dbo].[Departamentos]
   (
        [NombreDepartamento]
   )
   VALUES
   (
     @nom
	 
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaDescuentos]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaDescuentos]
@Nomempleado varchar(50),
@nom varchar(170)

AS
BEGIN
   INSERT INTO [dbo].[Descuentos]
   (
         [NombreEmpleado]
        ,[NombreDescuento]
	   
   )
   VALUES
   (
      @Nomempleado
     ,@nom
	
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaEmpleado]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_InsertaEmpleado]
@nom varchar(150),
@tel varchar(11),
@dep varchar(100),
@sd decimal(10,2),
@psc varchar(50)
AS
BEGIN
   INSERT INTO [dbo].[Empleados]
   (
        [Nombre]
	   ,[Telefono]
	   ,[Departamento]
	   ,[Sueldo]
	   ,[Posicion]
   )
   VALUES
   (
     @nom
	 ,@tel
	 ,@dep
	 ,@sd
	 ,@psc
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaGestiondeempresa]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaGestiondeempresa]
@nom varchar(150),
@RNC varchar(20),
@prt varchar(150),
@sw varchar(150),
@tel varchar(11),
@dir varchar(250)
AS
BEGIN
   INSERT INTO [dbo].[Gestión de empresa]
   (
   
        [Nombre]
		,[RNC]
		,[Propietario]
		,[SitioWeb]
		,[Telefono]
		,[Direccion]
	   
   )
    VALUES
   (
     @nom
	 ,@RNC
	 ,@prt
	 ,@sw 
	 ,@tel
	 ,@dir
	
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaGestiondeusuario]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[SP_InsertaGestiondeusuario]
@nom varchar(150),
@usr varchar(50),
@clave varchar(150),
@rol varchar(150)
AS
BEGIN
   INSERT INTO [dbo].[Gestión de usuario]
   (
        [Nombre]
	   ,[Usuario]
	   ,[Clave]
	   ,[Rol]
   )
   VALUES
   (
     @nom
	 ,@usr 
     ,@clave 
     ,@rol
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaHoraExtras]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_InsertaHoraExtras]
@NomEmpleado varchar(50),
@fecha datetime,
@total decimal(6,2),
@tarifa decimal(8,2),
@estado varchar(20)
AS
BEGIN
   INSERT INTO [dbo].[Horas extras]
   (
         [NombreEmpleado]
		,[Fecha]
        ,[TotalHorasextras]
		,[TarifaPago]
		,[EstadoAprobacion]
   )
    VALUES
   (
     @NomEmpleado
	,@fecha
	,@total 
    ,@tarifa 
    ,@estado 
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaPosiciones]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaPosiciones]
@nom varchar(100),
@sd decimal(18,2)
AS
BEGIN
   INSERT INTO [dbo].[Posiciones]
   (
   
        [Nombreposicion]
	   ,[Sueldoposicion]
   )
    VALUES
   (
     @nom
	 ,@sd
	
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaRol]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaRol]
@rol varchar(150)
AS
BEGIN
   INSERT INTO [dbo].[Rol]
   (
        [Rol]
   )
   VALUES
   (
     @rol
	 
   )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertaSueldo]    Script Date: 8/4/2024 3:24:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertaSueldo]
@salario decimal(10,2),
@Tarifahoraria decimal(8,2),
@sueldoneto decimal(10,2)
AS
BEGIN
   INSERT INTO [dbo].[Sueldo]
   (
      
	   [Salariobase]
	  ,[Tarifahoraria]
	  ,[Sueldoneto]
     
   )
    VALUES
   (
     @salario 
    ,@Tarifahoraria 
    ,@sueldoneto

   )
END
GO
USE [master]
GO
ALTER DATABASE [SysNom2024] SET  READ_WRITE 
GO
