GO
/****** Object:  Table [dbo].[Asignaciones]    Script Date: 22/10/2020 13:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaciones](
	[id_asignacion] [int] NOT NULL,
	[n_asignacion] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_asignacion] PRIMARY KEY CLUSTERED 
(
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsistenciaUsuarios]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsistenciaUsuarios](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora_ingreso] [time](7) NULL,
	[hora_salida] [time](7) NULL,
	[id_estado_asistencia] [int] NULL,
	[comentario] [varchar](500) NULL,
 CONSTRAINT [pk_asistencia] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bugs]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[fecha_alta] [date] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BugsHistorico]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BugsHistorico](
	[id_bug_historico] [int] IDENTITY(1,1) NOT NULL,
	[fecha_historico] [date] NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[id_bug] [int] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_BugsHistorico] PRIMARY KEY CLUSTERED 
(
	[id_bug_historico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CasosDePrueba]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CasosDePrueba](
	[id_caso_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_plan_prueba] [int] NOT NULL,
	[titulo] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[id_responsable] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CasosDePrueba_1] PRIMARY KEY CLUSTERED 
(
	[id_caso_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPrueba]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPrueba](
	[id_ciclo_prueba] [int] NOT NULL,
	[fecha_inicio_ejecucion] [datetime] NULL,
	[fecha_fin_ejecucion] [datetime] NULL,
	[id_responsable] [int] NULL,
	[id_plan_prueba] [int] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPrueba] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPruebaDetalle]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPruebaDetalle](
	[id_ciclo_prueba_detalle] [int] NOT NULL,
	[id_ciclo_prueba] [int] NULL,
	[id_caso_prueba] [int] NULL,
	[id_usuario_tester] [int] NULL,
	[cantidad_horas] [decimal](18, 0) NULL,
	[fecha_ejecucion] [datetime] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPruebaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](50) NULL,
	[razon_social] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[calle] [varchar](500) NULL,
	[numero] [varchar](50) NULL,
	[fecha_alta] [datetime] NULL,
	[id_barrio] [int] NULL,
	[id_contacto] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criticidades]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[id_curso] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [nvarchar](50) NULL,
	[fecha_vigencia] [datetime] NULL,
	[id_categoria] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Descuentos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[id_descuento] [int] NOT NULL,
	[n_descuento] [varchar](40) NOT NULL,
	[monto] [numeric](10, 2) NULL,
 CONSTRAINT [pk_descuento] PRIMARY KEY CLUSTERED 
(
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosAsistencia]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosAsistencia](
	[id_estado_asistencia] [int] NOT NULL,
	[n_estados_asistencia] [varchar](20) NOT NULL,
 CONSTRAINT [pk_estados_asistencia] PRIMARY KEY CLUSTERED 
(
	[id_estado_asistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadosUsuarios]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadosUsuarios](
	[id_estado_usuario] [int] NOT NULL,
	[n_estado_usuario] [varchar](20) NOT NULL,
 CONSTRAINT [estado_u_pk] PRIMARY KEY CLUSTERED 
(
	[id_estado_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [varchar](50) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario_creador] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[id_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NULL,
	[numero_orden] [int] NULL,
	[id_producto] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_ciclo_prueba] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_FacturaDetalles] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objetivos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objetivos](
	[id_objetivo] [int] NOT NULL,
	[nombre_corto] [varchar](50) NULL,
	[nombre_largo] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Objetivos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjetivosCursos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjetivosCursos](
	[id_objetivo] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntos] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_ObjetivosCursos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanesDePrueba]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanesDePrueba](
	[id_plan_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[descripcion] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_PlanesDePrueba] PRIMARY KEY CLUSTERED 
(
	[id_plan_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prioridades]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos](
	[id_proyecto] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[version] [varchar](50) NULL,
	[alcance] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[borrado] [nchar](10) NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoAsignaciones]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoAsignaciones](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_asignacion] [int] NOT NULL,
	[monto] [numeric](10, 2) NULL,
	[cantidad] [int] NULL,
 CONSTRAINT [pk_sueldoasignacion] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_asignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoDescuentos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoDescuentos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[id_descuento] [int] NOT NULL,
	[cantidad] [int] NULL,
	[monto] [numeric](10, 2) NULL,
 CONSTRAINT [pk_sueldoDescuento] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC,
	[id_descuento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SueldoPerfilHistorico]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SueldoPerfilHistorico](
	[id_perfil] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldoPerfil] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sueldos]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sueldos](
	[id_usuario] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[sueldo_bruto] [numeric](10, 2) NOT NULL,
 CONSTRAINT [pk_sueldo] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](10) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCurso]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCurso](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntuacion] [int] NULL,
	[observaciones] [varchar](150) NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
 CONSTRAINT [PK_UsuariosCurso] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCursoAvance]    Script Date: 22/10/2020 13:33:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCursoAvance](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[inicio] [datetime] NOT NULL,
	[fin] [datetime] NULL,
	[porc_avance] [int] NULL,
 CONSTRAINT [PK_UsuariosCursoAvance] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC,
	[inicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (1, N'Presentismo', CAST(10000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (2, N'Hijos', CAST(3000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (3, N'Título Universitario', CAST(12000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (4, N'Título Terciario', CAST(8000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (5, N'Título Técnico', CAST(6000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (6, N'Permanencia', CAST(10800.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (7, N'Productividad', CAST(20000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[Asignaciones] ([id_asignacion], [n_asignacion], [monto]) VALUES (8, N'Horas Extras', CAST(500.00 AS Numeric(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Barrios] ON 
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (1, N'Nva Cba', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (2, N'Guemes', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (3, N'Velez Sarfields', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (4, N'Barrio Parque', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (5, N'Alberdi', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (6, N'Naranjos', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (7, N'Jardin', 0)
GO
INSERT [dbo].[Barrios] ([id_barrio], [nombre], [borrado]) VALUES (8, N'San Fernando', 0)
GO
SET IDENTITY_INSERT [dbo].[Barrios] OFF
GO
SET IDENTITY_INSERT [dbo].[Bugs] ON 
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (2, N'Validaci??n de campos', N'No valida que los campos obligatorios tengan valor', CAST(N'2019-02-02' AS Date), 1, 2, 1, 1, 1, 1, 0)
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (3, N'Carga de grilla', N'La grilla no carga valores correctos', CAST(N'2019-03-03' AS Date), 1, 2, 2, 1, 1, 2, 0)
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (5, N'Carga de combos', N'No muestra descripci??n en el combo', CAST(N'2019-03-02' AS Date), 2, 4, 3, 2, 3, 3, 0)
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (6, N'Grabado de objetos', N'No graba todos los datos del registro', CAST(N'2019-10-07' AS Date), 2, 4, 4, 2, 2, 1, 0)
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (7, N'Transacci??n', N'Graba mas de un registro sin contemplar transacci??n', CAST(N'2019-10-07' AS Date), 5, 5, 3, 3, 2, 1, 0)
GO
INSERT [dbo].[Bugs] ([id_bug], [titulo], [descripcion], [fecha_alta], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (8, N'C??lculos', N'Calcula mal el total', CAST(N'2019-10-07' AS Date), 4, 5, 4, 2, 2, 2, 0)
GO
SET IDENTITY_INSERT [dbo].[Bugs] OFF
GO
SET IDENTITY_INSERT [dbo].[BugsHistorico] ON 
GO
INSERT [dbo].[BugsHistorico] ([id_bug_historico], [fecha_historico], [titulo], [descripcion], [id_bug], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (10, CAST(N'2019-10-07' AS Date), N'probando transaccion', N'probando transaccion insert en bug e insert en historico', 6, NULL, NULL, 1, 2, 1, 1, 0)
GO
INSERT [dbo].[BugsHistorico] ([id_bug_historico], [fecha_historico], [titulo], [descripcion], [id_bug], [id_usuario_responsable], [id_usuario_asignado], [id_producto], [id_prioridad], [id_criticidad], [id_estado], [borrado]) VALUES (11, CAST(N'2019-10-07' AS Date), N'probando transaccion', N'probando transaccion', 7, NULL, NULL, 1, 1, 1, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[BugsHistorico] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (5, N'123123123', N'Farmacia jjjjj', 1, N'entre rios', N'534', NULL, 2, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (6, N'8888888888', N'Farmacia Fiovannini', 1, N'entre rios', N'5348', NULL, 2, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (7, N'4564565', N'YPF', 1, N'San Juan', N'423', NULL, 3, 3)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (9, N'55555555555', N'Shell', 1, N'Salta', N'964', NULL, 1, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (10, N'4564565', N'YPF', 1, N'San Juan', N'423', NULL, 3, 3)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1003, N'45', N'asdfghj', 1, N'rreree', N'333', CAST(N'2020-09-17T15:20:35.437' AS DateTime), 3, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1004, N'789789789', N'ertytrerty', 1, N'ertyuioyu', N'45645', CAST(N'2020-09-17T15:29:47.083' AS DateTime), 3, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1005, N'987654320987654', N'rrreere', 1, N'ewewew', N'343', CAST(N'2020-09-17T15:33:40.077' AS DateTime), 2, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1006, N'23456765432', N'SDFGHJKLKJHG', 1, N'ERTYUIUYT', N'345', CAST(N'2020-09-17T15:40:48.100' AS DateTime), 2, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1007, N'431258973', N'Microsoft', 0, N'San Martin', N'469', CAST(N'2020-09-17T16:03:59.573' AS DateTime), 1, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1008, N'14425687598', N'AXION', 1, N'Laprida', N'321', CAST(N'2020-09-17T16:10:00.703' AS DateTime), 3, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1009, N'20453698759', N'AXION', 1, N'Laprida', N'321', CAST(N'2020-09-17T16:13:29.790' AS DateTime), 2, 3)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1010, N'111111111', N'sdfghj', 1, N'san juan', N'221', CAST(N'2020-10-11T08:26:38.647' AS DateTime), 3, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1011, N'454545454', N'Apple', 0, N'Vicente Casares', N'565', CAST(N'2020-10-11T08:39:33.600' AS DateTime), 2, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1012, N'898989898', N'Globant', 1, N'Colon', N'565', CAST(N'2020-10-11T08:43:19.570' AS DateTime), 3, 3)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1013, N'979797979', N'Telecom', 0, N'Poeta Lugones', N'123', CAST(N'2020-10-11T21:31:39.897' AS DateTime), 2, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1014, N'789789789', N'cfygbhj', 1, N'rtyuio', N'556', CAST(N'2020-10-12T18:04:03.097' AS DateTime), 2, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1015, N'789789789', N'Claro', 0, N'Estrada', N'654', CAST(N'2020-10-12T18:05:25.897' AS DateTime), 3, 1)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1016, N'147147147', N'Movistar', 0, N'Buenos Aires', N'4685', CAST(N'2020-10-12T18:07:20.850' AS DateTime), 3, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1017, N'426426426', N'Personal', 0, N'JJ Paso', N'2114', CAST(N'2020-10-13T17:51:14.810' AS DateTime), 1, 2)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1018, N'2789564785', N'Mercado Libre', 0, N'Sargento Cabral', N'483', CAST(N'2020-10-22T09:11:29.463' AS DateTime), 7, 4)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1019, N'2140645945', N'Apex', 0, N'Publica E', N'123', CAST(N'2020-10-22T09:12:03.980' AS DateTime), 8, 6)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1020, N'1040645950', N'Teleprom', 0, N'Talleres', N'5000', CAST(N'2020-10-22T09:13:15.167' AS DateTime), 4, 5)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1021, N'3025318964', N'Binance', 0, N'Av Colon', N'896', CAST(N'2020-10-22T09:13:21.247' AS DateTime), 5, 6)
GO
INSERT [dbo].[Clientes] ([id_cliente], [cuit], [razon_social], [borrado], [calle], [numero], [fecha_alta], [id_barrio], [id_contacto]) VALUES (1022, N'3056847359', N'Garbarino', 0, N'Mitre', N'665', CAST(N'2020-10-22T09:14:06.260' AS DateTime), 8, 8)
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Contactos] ON 
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (1, N'Gaston', N'Roch', N'gaston.roch1998@gmail.com', N'03491504705', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (2, N'Gabriel', N'Juncos', N'gabbjuncos@gmail.com', N'22222222', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (3, N'Juan', N'Rojas', N'gJuanrojas@gmail.com', N'33333333', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (4, N'Jose', N'Fassi', N'joseFassi@hotmail.com', N'0351514462', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (5, N'Jorge', N'Gonzales', N'gonzales@gmail.com', N'3513279032', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (6, N'Camila', N'Fior', N'Fior@gmail.com', N'3514079011', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (7, N'Juan Carlos', N'Perez', N'jcarlosperez@hotmail.com', N'03491508967', 0)
GO
INSERT [dbo].[Contactos] ([id_contacto], [nombre], [apellido], [email], [telefono], [borrado]) VALUES (8, N'Florencia', N'Cejas', N'florcejas@hotmail.com', N'0351479875', 0)
GO
SET IDENTITY_INSERT [dbo].[Contactos] OFF
GO
SET IDENTITY_INSERT [dbo].[Criticidades] ON 
GO
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (1, N'LEVE', 0)
GO
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (2, N'GRAVE', 0)
GO
INSERT [dbo].[Criticidades] ([id_criticidad], [nombre], [borrado]) VALUES (3, N'INVALIDANTE', 0)
GO
SET IDENTITY_INSERT [dbo].[Criticidades] OFF
GO
SET IDENTITY_INSERT [dbo].[Estados] ON 
GO
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (1, N'Nuevo', 0)
GO
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (2, N'Asignado', 0)
GO
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (3, N'Cerrado', 0)
GO
INSERT [dbo].[Estados] ([id_estado], [nombre], [borrado]) VALUES (4, N'En testing', 0)
GO
SET IDENTITY_INSERT [dbo].[Estados] OFF
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (1, N'Presente')
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (2, N'Ausente')
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (3, N'Carpeta Médica')
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (4, N'Licencia x Estudios')
GO
INSERT [dbo].[EstadosAsistencia] ([id_estado_asistencia], [n_estados_asistencia]) VALUES (5, N'Licencia Vacaciones')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (1, N'Activo')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (2, N'A prueba')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (3, N'Inactivo')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (4, N'Baja')
GO
INSERT [dbo].[EstadosUsuarios] ([id_estado_usuario], [n_estado_usuario]) VALUES (5, N'Suspendido')
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (2, N'000000000004', 5, CAST(N'2020-09-27T10:43:24.323' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (8, N'000000000001', 5, CAST(N'2020-09-28T12:20:44.720' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (9, N'000000000005', 5, CAST(N'2020-09-28T14:36:46.803' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (10, N'000000000006', 5, CAST(N'2020-09-28T21:19:16.613' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (11, N'000000000007', 5, CAST(N'2020-09-28T23:42:33.097' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (12, N'000000000008', 5, CAST(N'2020-09-28T23:42:33.097' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (13, N'000000000009', 5, CAST(N'2020-09-28T23:45:09.373' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (14, N'000000000010', 9, CAST(N'2020-09-28T23:54:05.180' AS DateTime), 2, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (15, N'000000000011', 5, CAST(N'2020-09-29T00:05:07.213' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (16, N'000000000012', 1004, CAST(N'2020-09-29T00:07:27.430' AS DateTime), 5, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (17, N'000000000013', 1004, CAST(N'2020-09-29T00:10:04.537' AS DateTime), 5, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (18, N'000000000014', 9, CAST(N'2020-09-29T00:58:23.023' AS DateTime), 5, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (19, N'000000000015', 9, CAST(N'2020-09-29T16:21:51.157' AS DateTime), 2, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (20, N'000000000016', 1003, CAST(N'2020-09-29T18:20:35.377' AS DateTime), 5, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (21, N'000000000017', 10, CAST(N'2020-09-29T18:20:35.377' AS DateTime), 5, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (22, N'000000000018', 6, CAST(N'2020-09-29T18:42:27.380' AS DateTime), 6, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (23, N'000000000019', 9, CAST(N'2020-10-09T00:45:14.650' AS DateTime), 2, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (24, N'000000000020', 9, CAST(N'2020-10-09T17:39:09.673' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (25, N'000000000021', 6, CAST(N'2020-10-10T14:52:36.993' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (26, N'000000000022', 9, CAST(N'2020-10-10T16:24:41.670' AS DateTime), 8, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (28, N'', 9, CAST(N'2020-10-10T17:03:24.707' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (29, N'29', 10, CAST(N'2020-10-10T17:13:00.283' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (30, N'30', 1003, CAST(N'2020-10-10T17:23:32.193' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (31, N'31', 10, CAST(N'2020-10-11T12:02:49.657' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (32, N'32', 9, CAST(N'2020-10-11T15:33:05.560' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (33, N'33', 10, CAST(N'2020-10-11T16:25:00.833' AS DateTime), 1, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (34, N'34', 1006, CAST(N'2020-10-12T21:01:10.820' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (35, N'35', 1009, CAST(N'2020-10-12T21:01:10.820' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (36, N'36', 1007, CAST(N'2020-10-15T14:42:56.143' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (37, N'37', 1013, CAST(N'2020-10-13T14:42:56.000' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (38, N'38', 1015, CAST(N'2020-10-01T14:42:56.000' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (39, N'39', 1017, CAST(N'2020-10-15T15:02:33.540' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (40, N'40', 1011, CAST(N'2020-10-15T15:15:00.100' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (41, N'41', 1011, CAST(N'2020-10-15T19:51:30.323' AS DateTime), 8, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (42, N'42', 1012, CAST(N'2020-10-20T19:28:36.790' AS DateTime), 9, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (43, N'43', 1007, CAST(N'2020-10-22T13:15:25.983' AS DateTime), 11, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (44, N'44', 1020, CAST(N'2020-10-02T13:14:45.000' AS DateTime), 10, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (45, N'45', 1018, CAST(N'2020-04-08T13:15:25.000' AS DateTime), 11, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (46, N'46', 1018, CAST(N'2020-10-09T13:14:45.000' AS DateTime), 10, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (47, N'47', 1021, CAST(N'2020-07-09T13:19:21.000' AS DateTime), 13, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (48, N'48', 1017, CAST(N'2020-10-20T13:19:21.000' AS DateTime), 13, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (49, N'49', 1019, CAST(N'2020-10-22T13:21:02.940' AS DateTime), 12, 0)
GO
INSERT [dbo].[Facturas] ([id_factura], [numero_factura], [id_cliente], [fecha], [id_usuario_creador], [borrado]) VALUES (50, N'50', 1019, CAST(N'2020-10-01T13:21:02.000' AS DateTime), 12, 0)
GO
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
SET IDENTITY_INSERT [dbo].[FacturasDetalle] ON 
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (4, 8, 2, 1, 1, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (5, 9, 1, 2, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (6, 9, 2, 2, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (7, 10, 2, 1, 1, NULL, CAST(20 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (8, 10, 2, 1, 1, NULL, CAST(202 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (9, 11, 2, 1, 1, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (10, 11, 2, 1, 1, NULL, CAST(10 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (11, 12, 21, 1, 1, NULL, CAST(22 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (12, 12, 21, 1, 1, NULL, CAST(222 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (13, 13, 12, 1, 1, NULL, CAST(1221 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (14, 13, 121, 1, 1, NULL, CAST(122 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (15, 14, 22, 6, 1, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (16, 14, 222, 6, 1, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (17, 15, 11, 4, 5, NULL, CAST(5000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (18, 15, 12, 4, 5, NULL, CAST(5000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (19, 16, 1, 3, 4, NULL, CAST(111 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (20, 16, 12, 3, 5, NULL, CAST(1110 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (21, 17, 23, 4, 5, NULL, CAST(24 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (22, 17, 2, 4, 5, NULL, CAST(24 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (23, 18, 1, 4, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (24, 19, 2, 1006, 2002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (25, 19, 2, 5, 1003, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (26, 19, 3, 3, 3, NULL, CAST(50 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (27, 20, 1, 4, 2002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (28, 21, 2, 4, 4, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (29, 22, 1, 4, 4, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (30, 22, 2, 1006, 2002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (31, 23, 1, 2, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (32, 23, 2, 5, 3, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (33, 24, 1, 6, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (34, 24, 2, 1, 3, NULL, CAST(20 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (35, 25, 1, 7, 1002, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (36, 26, 1, 3, 2, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (37, 26, 2, 2, 5, NULL, CAST(66 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (38, 28, 1, 3, 2, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (39, 28, 2, 3, 4, NULL, CAST(895 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (40, 29, 1, 3, 2, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (41, 29, 2, 4, 1002, NULL, CAST(656 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (42, 30, 1, 5, 4, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (43, 30, 2, 5, 1003, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (44, 31, 1, 5, 4, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (45, 31, 2, 5, 5, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (46, 32, 1, 1006, 2005, NULL, CAST(1000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (47, 32, 2, 1007, 2003, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (48, 33, 1, 1006, 2005, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (49, 33, 2, 1007, 2004, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (50, 34, 1, 1007, 2002, NULL, CAST(522 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (51, 35, 2, 1007, 1003, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (52, 36, 1, 1007, 4, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (53, 37, 2, 1007, 2003, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (54, 38, 3, 1007, 2, NULL, CAST(1000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (55, 39, 1, 1007, 1002, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (56, 39, 2, 1007, 2002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (57, 40, 1, 1007, 4, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (58, 41, 1, 1007, 1003, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (59, 41, 2, 1, 2009, NULL, CAST(600 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (60, 41, 3, 5, 2009, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (61, 42, 1, 1007, 1, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (62, 42, 2, 7, 2009, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (63, 43, 1, 5, 2009, NULL, CAST(5000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (64, 43, 2, 1, 2009, NULL, CAST(7666 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (65, 43, 3, 1007, 2005, NULL, CAST(5896 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (66, 43, 4, 1007, 2, NULL, CAST(10000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (67, 44, 1, 1007, 2, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (68, 44, 2, 1, 2009, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (69, 44, 3, 1005, 2009, NULL, CAST(400 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (70, 44, 4, 3, 2009, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (71, 44, 5, 1007, 1002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (72, 45, 1, 1007, 1003, NULL, CAST(15000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (73, 45, 2, 4, 2009, NULL, CAST(9800 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (74, 45, 3, 1007, 1002, NULL, CAST(6000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (75, 45, 4, 1007, 2005, NULL, CAST(8600 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (76, 45, 5, 1007, 2004, NULL, CAST(600 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (77, 45, 6, 1005, 2009, NULL, CAST(13500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (78, 46, 1, 1007, 2004, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (79, 46, 2, 1007, 2, NULL, CAST(400 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (80, 46, 3, 1006, 2009, NULL, CAST(500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (81, 46, 4, 4, 2009, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (82, 47, 1, 1007, 2, NULL, CAST(18000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (83, 47, 2, 1007, 4, NULL, CAST(4700 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (84, 47, 3, 6, 2009, NULL, CAST(6500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (85, 47, 4, 1, 2009, NULL, CAST(7900 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (86, 48, 1, 1007, 1, NULL, CAST(8466 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (87, 48, 2, 1007, 5, NULL, CAST(7900 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (88, 48, 3, 2, 2009, NULL, CAST(5000 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (89, 48, 4, 2, 2009, NULL, CAST(3500 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (90, 49, 1, 1007, 1002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (91, 49, 2, 1007, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (92, 49, 3, 1007, 5, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (93, 49, 4, 7, 2009, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (94, 49, 5, 2, 2009, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (95, 49, 6, 1005, 2009, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (96, 50, 1, 1007, 3, NULL, CAST(100 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (97, 50, 2, 1007, 3, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (98, 50, 3, 1007, 4, NULL, CAST(400 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (99, 50, 4, 1007, 1002, NULL, CAST(200 AS Decimal(18, 0)), 0)
GO
INSERT [dbo].[FacturasDetalle] ([id_detalle_factura], [id_factura], [numero_orden], [id_producto], [id_proyecto], [id_ciclo_prueba], [precio], [borrado]) VALUES (100, 50, 5, 4, 2009, NULL, CAST(300 AS Decimal(18, 0)), 0)
GO
SET IDENTITY_INSERT [dbo].[FacturasDetalle] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Tester', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Desarrollador', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Responsable de Reportes', 0)
GO
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Prioridades] ON 
GO
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (1, N'BAJA', 0)
GO
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (2, N'MEDIA', 0)
GO
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (3, N'ALTA', 0)
GO
INSERT [dbo].[Prioridades] ([id_prioridad], [nombre], [borrado]) VALUES (4, N'URGENTE', 0)
GO
SET IDENTITY_INSERT [dbo].[Prioridades] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (1, N'Software de Gestion', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (2, N'Software de Gestion de Identidad', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (3, N'Software de Auditoria', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (4, N'Soft. Vulnerabilidades', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (5, N'Software de Seguridad', 1)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (6, N'Software de Notificaciones', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (7, N'Software de Facturacion', 1)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (1005, N'Software de Logistica', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (1006, N'Software de Control de Stock ', 0)
GO
INSERT [dbo].[Productos] ([id_producto], [nombre], [borrado]) VALUES (1007, N'<<Ninguno>>', 0)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proyectos] ON 
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (1, 1, N'Sistema de Facturacion', N'1.3', N'Gestionar Facturacion', 1, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2, 4, N'Sistema de Seguridad', N'2.1', N'Gestionar la Seguridad de la Emmpresa', 4, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (3, 4, N'Modulo Logistica', N'2.0', N'Gestion de Logistica', 4, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (4, 2, N'Modulo de Perfiles de Usuario', N'3.0', N'Gestionar Niveles de Acceso a Usuario', 1, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (5, 2, N'Sistema de Mensajeria Automatica', N'1.2', N'Gestionar Envio de Mensajes Automaticos', 2, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (1002, 4, N'Sistema de Alertas', N'3.1', N'Gestionar Alertas del Sistema', 7, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (1003, 6, N'Modulo de Cobro por MercadoPago', N'2.2', N'Gestionar Cobro por MercadoPago', 4, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2002, 4, N'Modulo de Perfiles de Usuario', N'3.0', N'Gestionar Niveles de Acceso a Usuario', 5, N'1         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2003, 1, N'Sistema de Facturacion', N'1.3', N'Gestionar Facturacion', 1, N'0         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2004, 1, N'Sistema de Facturacion', N'1.3', N'Gestionar Facturacion', 1, N'0         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2005, 1, N'Sistema de Facturacion', N'1.3', N'Gestionar Facturacion', 1, N'0         ')
GO
INSERT [dbo].[Proyectos] ([id_proyecto], [id_producto], [descripcion], [version], [alcance], [id_responsable], [borrado]) VALUES (2009, NULL, N'<<Ninguno>>', N'', N'', NULL, N'0         ')
GO
SET IDENTITY_INSERT [dbo].[Proyectos] OFF
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (1, CAST(N'2020-08-01' AS Date), CAST(100000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (2, CAST(N'2020-08-01' AS Date), CAST(50000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (3, CAST(N'2020-08-01' AS Date), CAST(80000.00 AS Numeric(10, 2)))
GO
INSERT [dbo].[SueldoPerfilHistorico] ([id_perfil], [fecha], [sueldo]) VALUES (4, CAST(N'2020-08-01' AS Date), CAST(49000.00 AS Numeric(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'12345', N'admin@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Tester Ariel', N'12345', N'ariel@gmail.com', N'N', 1)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 3, N'Tester Miguel', N'12345', N'miguel@gmail.com', N'S', 1)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 2, N'Tester Ana', N'12345', N'ana@gmail.com', N'N', 1)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 3, N'Tester Diego', N'12345', N'diego@gmail.com', N'N', 1)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 4, N'Tester Micaela', N'12345', N'mica@gmail.com', N'S', 1)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, 1, N'Gaston', N'41359845', N'gaston.roch1998@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (9, 1, N'Gabriel', N'12345', N'gabriel@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (10, 1, N'Maria', N'12345', N'maria@hotmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (11, 1, N'Soledad', N'12345', N'romeroma.soledad@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (12, 1, N'Agustin', N'12345', N'agustin@hotmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (13, 1, N'Mariano', N'12345', N'mariano15@gmail.com', N'S', 0)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[BugsHistorico] ADD  CONSTRAINT [DF_BugsHistorico_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Criticidades] ADD  CONSTRAINT [DF_Criticidades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Estados] ADD  CONSTRAINT [DF_Estados_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Formularios] ADD  CONSTRAINT [DF_Formularios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Prioridades] ADD  CONSTRAINT [DF_Prioridades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[AsistenciaUsuarios]  WITH CHECK ADD  CONSTRAINT [fk_id_estado_asistencia] FOREIGN KEY([id_estado_asistencia])
REFERENCES [dbo].[EstadosAsistencia] ([id_estado_asistencia])
GO
ALTER TABLE [dbo].[AsistenciaUsuarios] CHECK CONSTRAINT [fk_id_estado_asistencia]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Estados]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios1] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios1]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Bugs] FOREIGN KEY([id_bug])
REFERENCES [dbo].[Bugs] ([id_bug])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Bugs]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Criticidades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Estados]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Prioridades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Productos]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios1] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios1]
GO
ALTER TABLE [dbo].[CasosDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CasosDePrueba] CHECK CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_Usuarios]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba] FOREIGN KEY([id_caso_prueba])
REFERENCES [dbo].[CasosDePrueba] ([id_caso_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios] FOREIGN KEY([id_usuario_tester])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Contactos] FOREIGN KEY([id_contacto])
REFERENCES [dbo].[Contactos] ([id_contacto])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Contactos]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Categorias]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuarios] FOREIGN KEY([id_usuario_creador])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuarios]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id_factura])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Facturas]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Productos]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Proyectos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Cursos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Objetivos] FOREIGN KEY([id_objetivo])
REFERENCES [dbo].[Objetivos] ([id_objetivo])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Objetivos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Proyectos]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Usuarios]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Producto]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Responsable] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Responsable]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_seldoAsig_asignacion] FOREIGN KEY([id_asignacion])
REFERENCES [dbo].[Asignaciones] ([id_asignacion])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_seldoAsig_asignacion]
GO
ALTER TABLE [dbo].[SueldoAsignaciones]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_asig] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoAsignaciones] CHECK CONSTRAINT [fk_sueldo_asig]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_seldoDesc_descuento] FOREIGN KEY([id_descuento])
REFERENCES [dbo].[Descuentos] ([id_descuento])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_seldoDesc_descuento]
GO
ALTER TABLE [dbo].[SueldoDescuentos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_desc] FOREIGN KEY([id_usuario], [fecha])
REFERENCES [dbo].[Sueldos] ([id_usuario], [fecha])
GO
ALTER TABLE [dbo].[SueldoDescuentos] CHECK CONSTRAINT [fk_sueldo_desc]
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico]  WITH CHECK ADD  CONSTRAINT [fk_sueldoPerfil_permfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[SueldoPerfilHistorico] CHECK CONSTRAINT [fk_sueldoPerfil_permfiles]
GO
ALTER TABLE [dbo].[Sueldos]  WITH CHECK ADD  CONSTRAINT [fk_sueldo_usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Sueldos] CHECK CONSTRAINT [fk_sueldo_usuarios]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Cursos]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Usuarios]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso] FOREIGN KEY([id_usuario], [id_curso])
REFERENCES [dbo].[UsuariosCurso] ([id_usuario], [id_curso])
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] CHECK CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso]
GO