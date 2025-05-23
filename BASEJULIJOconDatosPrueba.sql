USE [BASEJULIJO]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idTipoPrenda] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[idTalle] [int] NULL,
	[idMarca] [int] NULL,
	[idProveedor] [int] NULL,
	[Cantidad] [int] NULL,
	[Precio] [int] NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Marcas](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[idMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[idTipoMovimiento] [int] NULL,
	[Total] [int] NULL,
	[Fecha] [date] NULL,
 CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED 
(
	[idMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedores](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Proveedor] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Talles]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Talles](
	[idTalle] [int] IDENTITY(1,1) NOT NULL,
	[Talle] [varchar](50) NULL,
 CONSTRAINT [PK_Talles] PRIMARY KEY CLUSTERED 
(
	[idTalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tarjetas](
	[idTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[Tarjeta] [varchar](50) NULL,
 CONSTRAINT [PK_Tarjetas] PRIMARY KEY CLUSTERED 
(
	[idTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposMovimientos]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposMovimientos](
	[idTipoMovimiento] [int] IDENTITY(1,1) NOT NULL,
	[Movimiento] [varchar](50) NULL,
	[Signo] [bit] NULL,
 CONSTRAINT [PK_TiposMovimientos] PRIMARY KEY CLUSTERED 
(
	[idTipoMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposPago]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposPago](
	[idTipoPago] [int] IDENTITY(1,1) NOT NULL,
	[TipoPago] [varchar](50) NULL,
 CONSTRAINT [PK_TiposPago] PRIMARY KEY CLUSTERED 
(
	[idTipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposPrenda]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposPrenda](
	[idTipoPrenda] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NULL,
 CONSTRAINT [PK_TiposPrenda] PRIMARY KEY CLUSTERED 
(
	[idTipoPrenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ventas](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[Cliente] [varchar](50) NULL,
	[Fecha] [date] NULL,
	[idTipoPago] [int] NULL,
	[idTarjeta] [int] NULL,
	[Monto] [int] NULL,
	[Anulada] [bit] NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentasTarjeta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentasTarjeta](
	[idVentaTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NULL,
	[idTipoPago] [int] NULL,
	[idTarjeta] [int] NULL,
	[FechaVenta] [date] NULL,
	[Total] [int] NULL,
	[FechaTranferido] [date] NULL,
	[Transferido] [bit] NULL,
	[Anulada] [bit] NULL,
 CONSTRAINT [PK_VentasTarjeta] PRIMARY KEY CLUSTERED 
(
	[idVentaTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON 

INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (1, 2, 6, N'', 15, 1, 2, 1, 1500)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (2, 3, 4, N'', 15, 1, 3, 1, 700)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (4, 5, 4, N'', 16, 1, 3, 1, 250)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (5, 5, 8, N'', 19, 1, 1, 1, 560)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (6, 7, 4, N'', 16, 1, 3, 1, 300)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (7, 8, 7, N'', 17, 1, 4, 1, 280)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (8, 9, 3, N'', 16, 1, 4, 1, 600)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (9, 10, 4, N'Roja', 16, 1, 4, 1, 560)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (10, 10, 7, N'negro', 18, 1, 2, 1, 250)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (11, 11, 9, N'rojo', 15, 1, 3, 1, 1)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (12, 11, 2, N'verde', 9, 1, 2, 2, 600)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (13, 12, 7, N'rosa', 17, 1, 4, 1, 800)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (14, 12, 8, N'verde', 18, 1, 2, 1, 900)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (15, 15, 3, N'', 16, 1, 3, 1, 800)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (16, 17, 7, N'', 18, 1, 4, 1, 800)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (17, 18, 3, N'', 4, 1, 4, 1, 600)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (18, 19, 3, N'', 4, 3, 3, 1, 100)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (19, 20, 3, N'', 4, 1, 3, 1, 5200)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (20, 21, 3, N'AZUL CON RAYAS', 18, 2, 2, 1, 500)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (21, 21, 5, N'NEGRO', 19, 1, 1, 1, 1000)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (22, 22, 3, N'VERDE', 8, 1, 3, 1, 700)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (23, 23, 2, N'VERDE', 3, 2, 2, 1, 1500)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (24, 24, 3, N'', 2, 3, 3, 1, 100)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [idVenta], [idTipoPrenda], [Descripcion], [idTalle], [idMarca], [idProveedor], [Cantidad], [Precio]) VALUES (25, 25, 3, N'VERDE', 15, 2, 2, 1, 600)
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (1, N'-------------')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (2, N'BANANA DE COCO')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (3, N'CARTER''S')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
SET IDENTITY_INSERT [dbo].[Movimientos] ON 

INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (1, 1, 1000, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (2, 1, 1500, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (3, 1, 700, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (4, 1, 120, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (5, 1, 810, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (6, 3, 300, CAST(N'2020-07-19' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (7, 3, 300, CAST(N'2020-07-18' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (8, 3, 280, CAST(N'2020-07-17' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (9, 1, 600, CAST(N'2020-07-16' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (10, 9, 300, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (11, 9, 600, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (12, 7, 1500, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (13, 5, 7500, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (14, 3, 810, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (15, 2, 1201, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (16, 2, 1700, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (17, 3, 800, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (18, 2, 0, CAST(N'2020-07-20' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (19, 3, 900, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (20, 2, 1600, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (21, 2, 800, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (22, 3, 800, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (23, 2, 1100, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (24, 2, 100, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (25, 3, 5200, CAST(N'2020-07-21' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (26, 9, 810, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (27, 3, 1500, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (28, 2, 700, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (29, 9, 700, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (30, 3, 1500, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (31, 9, 1500, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (32, 3, 100, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (33, 9, 100, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (34, 1, 600, CAST(N'2020-07-22' AS Date))
INSERT [dbo].[Movimientos] ([idMovimiento], [idTipoMovimiento], [Total], [Fecha]) VALUES (35, 5, 7500, CAST(N'2020-07-22' AS Date))
SET IDENTITY_INSERT [dbo].[Movimientos] OFF
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([idProveedor], [Proveedor]) VALUES (1, N'PARRANDA')
INSERT [dbo].[Proveedores] ([idProveedor], [Proveedor]) VALUES (2, N'BANANA DE COCO')
INSERT [dbo].[Proveedores] ([idProveedor], [Proveedor]) VALUES (3, N'MUNDO INFANTIL')
INSERT [dbo].[Proveedores] ([idProveedor], [Proveedor]) VALUES (4, N'MIRIAN CHAMBI DIAZ')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
SET IDENTITY_INSERT [dbo].[Talles] ON 

INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (1, N'RN')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (2, N'1 - 0 A 3 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (3, N'2 - 3 A 6 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (4, N'3 - 6 A 9 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (5, N'4 - 9 A 12 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (6, N'5 - 12 A 18 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (7, N'6 - 18 A 24 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (8, N'1 - 6 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (9, N'2 - 9 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (10, N'3 - 12 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (11, N'4 - 18 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (12, N'5  - 24 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (13, N'6 - 30 MESES')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (14, N'4 AÑOS')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (15, N'6 AÑOS')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (16, N'8 AÑOS')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (17, N'10 AÑOS')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (18, N'12 AÑOS')
INSERT [dbo].[Talles] ([idTalle], [Talle]) VALUES (19, N'14 AÑOS')
SET IDENTITY_INSERT [dbo].[Talles] OFF
SET IDENTITY_INSERT [dbo].[Tarjetas] ON 

INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (1, N'---------------')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (2, N'CABAL')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (3, N'CABAL DEBITO')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (4, N'MAESTRO')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (5, N'MASTERCARD ')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (6, N'MASTERCARD DEBITO')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (7, N'SERVTEC')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (8, N'UNION PAY')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (9, N'VISA')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (10, N'VISA DEBITO')
SET IDENTITY_INSERT [dbo].[Tarjetas] OFF
SET IDENTITY_INSERT [dbo].[TiposMovimientos] ON 

INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (1, N'EFECTIVO', 1)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (2, N'DEBITO', 1)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (3, N'CREDITO', 1)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (4, N'COMPRA DE ROPAS', 0)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (5, N'ALQUILER', 0)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (6, N'EXPENSAS', 0)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (7, N'SECHEEP', 0)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (8, N'GASTOS VARIOS', 0)
INSERT [dbo].[TiposMovimientos] ([idTipoMovimiento], [Movimiento], [Signo]) VALUES (9, N'ANULACION DE VENTA', 0)
SET IDENTITY_INSERT [dbo].[TiposMovimientos] OFF
SET IDENTITY_INSERT [dbo].[TiposPago] ON 

INSERT [dbo].[TiposPago] ([idTipoPago], [TipoPago]) VALUES (1, N'EFECTIVO')
INSERT [dbo].[TiposPago] ([idTipoPago], [TipoPago]) VALUES (2, N'DEBITO')
INSERT [dbo].[TiposPago] ([idTipoPago], [TipoPago]) VALUES (3, N'CREDITO')
SET IDENTITY_INSERT [dbo].[TiposPago] OFF
SET IDENTITY_INSERT [dbo].[TiposPrenda] ON 

INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (1, N'BODY')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (2, N'CONJUNTO')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (3, N'REMERA')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (4, N'CAMISETA')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (5, N'BUZO')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (6, N'CAMPERA')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (7, N'PANTALON')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (8, N'SHORT')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (9, N'JEAN')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (10, N'MEDIAS')
INSERT [dbo].[TiposPrenda] ([idTipoPrenda], [Tipo]) VALUES (11, N'ACCESORIO')
SET IDENTITY_INSERT [dbo].[TiposPrenda] OFF
SET IDENTITY_INSERT [dbo].[Ventas] ON 

INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (1, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 1, NULL, 1000, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (2, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 1, NULL, 1500, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (3, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 1, NULL, 700, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (4, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 1, NULL, 120, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (5, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 1, 1, 810, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (6, N'Consumidor Final', CAST(N'2020-07-19' AS Date), 3, 4, 300, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (7, N'Consumidor Final', CAST(N'2020-07-18' AS Date), 3, 4, 300, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (8, N'Consumidor Final', CAST(N'2020-07-17' AS Date), 2, 4, 280, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (9, N'Consumidor Final', CAST(N'2020-07-16' AS Date), 1, 1, 600, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (10, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 2, 4, 810, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (11, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 2, 3, 1201, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (12, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 9, 1700, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (13, N'Consumidor Final', CAST(N'2020-07-20' AS Date), 3, 8, 800, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (14, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 8, 900, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (15, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 9, 1600, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (16, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 9, 800, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (17, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 8, 800, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (18, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 9, 1100, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (19, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 9, 100, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (20, N'Consumidor Final', CAST(N'2020-07-21' AS Date), 3, 8, 5200, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (21, N'NOE BUENO', CAST(N'2020-07-22' AS Date), 2, 4, 1500, 0)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (22, N'LARA', CAST(N'2020-07-22' AS Date), 2, 4, 700, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (23, N'GERARDO', CAST(N'2020-07-22' AS Date), 3, 9, 1500, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (24, N'CONSUMIDOR FINAL', CAST(N'2020-07-22' AS Date), 3, 8, 100, 1)
INSERT [dbo].[Ventas] ([idVenta], [Cliente], [Fecha], [idTipoPago], [idTarjeta], [Monto], [Anulada]) VALUES (25, N'CONSUMIDOR FINAL', CAST(N'2020-07-22' AS Date), 1, 1, 600, 0)
SET IDENTITY_INSERT [dbo].[Ventas] OFF
SET IDENTITY_INSERT [dbo].[VentasTarjeta] ON 

INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (1, 5, 3, NULL, CAST(N'2020-07-20' AS Date), 810, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (2, 6, 3, NULL, CAST(N'2020-07-19' AS Date), 300, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (3, 7, 3, NULL, CAST(N'2020-07-18' AS Date), 300, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (4, 8, 2, NULL, CAST(N'2020-07-17' AS Date), 280, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (5, 9, 3, NULL, CAST(N'2020-07-16' AS Date), 600, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (6, 10, 2, 4, CAST(N'2020-07-21' AS Date), 810, CAST(N'2020-07-22' AS Date), 1, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (7, 11, 2, 3, CAST(N'2020-07-21' AS Date), 1201, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (8, 12, 3, 9, CAST(N'2020-07-21' AS Date), 1700, CAST(N'2020-07-22' AS Date), 1, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (9, 13, 3, 8, CAST(N'2020-07-20' AS Date), 800, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (10, 14, 3, 8, CAST(N'2020-07-21' AS Date), 900, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (11, 15, 3, 9, CAST(N'2020-07-21' AS Date), 1600, CAST(N'2020-07-21' AS Date), 1, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (12, 16, 3, 9, CAST(N'2020-07-21' AS Date), 800, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (13, 17, 3, 8, CAST(N'2020-07-21' AS Date), 800, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (14, 18, 3, 9, CAST(N'2020-07-21' AS Date), 1100, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (15, 19, 3, 9, CAST(N'2020-07-21' AS Date), 100, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (16, 20, 3, 8, CAST(N'2020-07-21' AS Date), 5200, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (17, 21, 2, 4, CAST(N'2020-07-22' AS Date), 1500, NULL, 0, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (18, 22, 2, 4, CAST(N'2020-07-22' AS Date), 700, CAST(N'2020-07-22' AS Date), 1, 0)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (19, 23, 3, 9, CAST(N'2020-07-22' AS Date), 1500, NULL, 0, 1)
INSERT [dbo].[VentasTarjeta] ([idVentaTarjeta], [idVenta], [idTipoPago], [idTarjeta], [FechaVenta], [Total], [FechaTranferido], [Transferido], [Anulada]) VALUES (20, 24, 3, 8, CAST(N'2020-07-22' AS Date), 100, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[VentasTarjeta] OFF
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Marcas] FOREIGN KEY([idMarca])
REFERENCES [dbo].[Marcas] ([idMarca])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Marcas]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Proveedores] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[Proveedores] ([idProveedor])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Proveedores]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Talles] FOREIGN KEY([idTalle])
REFERENCES [dbo].[Talles] ([idTalle])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Talles]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_TiposPrenda] FOREIGN KEY([idTipoPrenda])
REFERENCES [dbo].[TiposPrenda] ([idTipoPrenda])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_TiposPrenda]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Ventas]
GO
ALTER TABLE [dbo].[Movimientos]  WITH CHECK ADD  CONSTRAINT [FK_Movimientos_TiposMovimientos] FOREIGN KEY([idTipoMovimiento])
REFERENCES [dbo].[TiposMovimientos] ([idTipoMovimiento])
GO
ALTER TABLE [dbo].[Movimientos] CHECK CONSTRAINT [FK_Movimientos_TiposMovimientos]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_Tarjetas] FOREIGN KEY([idTarjeta])
REFERENCES [dbo].[Tarjetas] ([idTarjeta])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_Tarjetas]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Ventas_TiposPago] FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TiposPago] ([idTipoPago])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [FK_Ventas_TiposPago]
GO
ALTER TABLE [dbo].[VentasTarjeta]  WITH CHECK ADD  CONSTRAINT [FK_VentasTarjeta_Tarjetas] FOREIGN KEY([idTarjeta])
REFERENCES [dbo].[Tarjetas] ([idTarjeta])
GO
ALTER TABLE [dbo].[VentasTarjeta] CHECK CONSTRAINT [FK_VentasTarjeta_Tarjetas]
GO
ALTER TABLE [dbo].[VentasTarjeta]  WITH CHECK ADD  CONSTRAINT [FK_VentasTarjeta_TiposPago] FOREIGN KEY([idTipoPago])
REFERENCES [dbo].[TiposPago] ([idTipoPago])
GO
ALTER TABLE [dbo].[VentasTarjeta] CHECK CONSTRAINT [FK_VentasTarjeta_TiposPago]
GO
ALTER TABLE [dbo].[VentasTarjeta]  WITH CHECK ADD  CONSTRAINT [FK_VentasTarjeta_Ventas] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Ventas] ([idVenta])
GO
ALTER TABLE [dbo].[VentasTarjeta] CHECK CONSTRAINT [FK_VentasTarjeta_Ventas]
GO
/****** Object:  StoredProcedure [dbo].[BuscarDetalleVenta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarDetalleVenta]
@idVenta as int
as
select Tipo, Descripcion ,Talle, Marca, Proveedor , Cantidad , Precio      
from DetalleVenta,TiposPrenda , Talles, Marcas, Proveedores 
where DetalleVenta .idTipoPrenda  = TiposPrenda .idTipoPrenda  and DetalleVenta .idTalle = Talles .idTalle 
and DetalleVenta .idMarca = Marcas .idMarca and DetalleVenta .idProveedor = Proveedores .idProveedor and DetalleVenta .idVenta =@idVenta  
GO
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxFechas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarMovimientosxFechas]
@Fecha1 date,
@Fecha2 date
as
select idMovimiento  as ID, Movimiento , Total , Fecha, Signo 
from Movimientos , TiposMovimientos 
where Movimientos .idTipoMovimiento  = TiposMovimientos .idTipoMovimiento and Movimientos .Fecha >= @Fecha1  and Movimientos.Fecha <= @Fecha2     
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxidMovimientoFechas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarMovimientosxidMovimientoFechas]
@idTipoMovimiento int,
@Fecha1 date,
@Fecha2 date
as
select idMovimiento  as ID, Movimiento , Total , Fecha, Signo      
from Movimientos , TiposMovimientos 
where Movimientos .idTipoMovimiento  = TiposMovimientos .idTipoMovimiento and Movimientos .Fecha >= @Fecha1  and Movimientos.Fecha <= @Fecha2     
and Movimientos .idTipoMovimiento = @idTipoMovimiento 
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxidTipoMovimiento]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarMovimientosxidTipoMovimiento]
@idTipoMovimiento int
as
select idMovimiento  as ID, Movimiento , Total , Fecha, Signo 
from Movimientos , TiposMovimientos 
where Movimientos .idTipoMovimiento  = TiposMovimientos .idTipoMovimiento and Movimientos .idTipoMovimiento = @idTipoMovimiento    
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[BuscarVentasTarjetaFechas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarVentasTarjetaFechas]
@Fecha1 date,
@Fecha2 date
as
select idVentaTarjeta  as ID, idVenta as Venta, TipoPago as Tipo , Tarjeta , FechaVenta as Fecha , Total , Transferido as Marcado, FechaTranferido as Transferido    
from VentasTarjeta , TiposPago , Tarjetas
where VentasTarjeta .idTipoPago  = TiposPago .idTipoPago   and VentasTarjeta.idTarjeta  = Tarjetas .idTarjeta   
and VentasTarjeta .FechaVenta >= @Fecha1 and VentasTarjeta .FechaVenta <= @Fecha2 and Anulada = 0
order by FechaVenta  desc
GO
/****** Object:  StoredProcedure [dbo].[BuscarVentasxFechas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarVentasxFechas]
@Fecha1 date,
@Fecha2 date
as
select idVenta  as ID, Cliente , Fecha , TipoPago , Tarjeta, Monto , Anulada    
from Ventas, TiposPago , Tarjetas
where ventas.idTarjeta = Tarjetas .idTarjeta  and Ventas .idTipoPago = TiposPago .idTipoPago  
and Fecha >= @Fecha1  and Fecha <= @Fecha2 
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[InsertarDetalleVenta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarDetalleVenta]
@idVenta int,
@idTipoPrenda int,
@Descripcion varchar(50),
@idTalle int,
@idMarca int,
@idProveedor int,
@Cantidad int,
@Precio int
as
insert into DetalleVenta   values (@idVenta , @idTipoPrenda , @Descripcion , @idTalle , @idMarca , @idProveedor , @Cantidad ,@Precio )
GO
/****** Object:  StoredProcedure [dbo].[InsertarMovimiento]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarMovimiento]
@idTipoMovimiento int,
@Total int,
@Fecha date
as
insert into Movimientos    values (@idTipoMovimiento , @Total , @Fecha  )
GO
/****** Object:  StoredProcedure [dbo].[InsertarVenta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertarVenta]
@Cliente varchar(50),
@Fecha date,
@idTipoPago int,
@idTarjeta int,
@Monto int,
@Anulada bit
as
insert into Ventas  values (@Cliente , @Fecha , @idTipoPago , @idTarjeta , @Monto ,@Anulada)
GO
/****** Object:  StoredProcedure [dbo].[InsertarVentaTarjeta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarVentaTarjeta]
@idVenta int,
@idTipoPago int,
@idTarjeta int,
@FechaVenta date,
@Total int,
@Transferido bit,
@Anulada bit
as
insert into VentasTarjeta  values (@idVenta  , @idTipoPago  ,@idTarjeta , @FechaVenta , @Total,null,@Transferido,@Anulada   )
GO
/****** Object:  StoredProcedure [dbo].[ModificarAnularVenta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarAnularVenta]
@idVenta int,
@Anulada bit
as
update Ventas  set Anulada  = @Anulada  
where idVenta  = @idVenta  
GO
/****** Object:  StoredProcedure [dbo].[ModificarVentaTarjetaAnulada]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarVentaTarjetaAnulada]
@idVenta int,
@Anulada bit
as
update VentasTarjeta set Anulada   = @Anulada  
where idVenta  = @idVenta  
GO
/****** Object:  StoredProcedure [dbo].[ModificarVentaTarjetaTransferido]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ModificarVentaTarjetaTransferido]
@idVenta int,
@Fecha date,
@Transferido bit
as
update VentasTarjeta   set FechaTranferido = @Fecha, Transferido = @Transferido 
where idVenta  = @idVenta  
GO
/****** Object:  StoredProcedure [dbo].[MostrarMarcas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarMarcas]
as
select idMarca   as ID, Marca  
from Marcas   
where idMarca <> 1
GO
/****** Object:  StoredProcedure [dbo].[MostrarMovimientos]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarMovimientos]
as
select idMovimiento  as ID, Movimiento , Total , Fecha, Signo      
from Movimientos , TiposMovimientos 
where Movimientos .idTipoMovimiento  = TiposMovimientos .idTipoMovimiento   
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[MostrarProveedores]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarProveedores]
as
select idProveedor as ID, Proveedor   
from Proveedores    

GO
/****** Object:  StoredProcedure [dbo].[MostrarTalles]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTalles]
as
select idTalle  as ID, Talle    
from Talles     

GO
/****** Object:  StoredProcedure [dbo].[MostrarTarjetas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarTarjetas]
as
select idTarjeta   as ID, Tarjeta     
from Tarjetas  
where idTarjeta <>1
GO
/****** Object:  StoredProcedure [dbo].[MostrarTipoPrenda]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTipoPrenda]
as
select idTipoPrenda  as ID, Tipo 
from TiposPrenda  

GO
/****** Object:  StoredProcedure [dbo].[MostrarTiposMovimiento]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTiposMovimiento]
as
select idTipoMovimiento as ID, Movimiento      
from TiposMovimientos 
GO
/****** Object:  StoredProcedure [dbo].[MostrarTiposMovimientoNuevos]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTiposMovimientoNuevos]
as
select idTipoMovimiento as ID, Movimiento      
from TiposMovimientos 
where idTipoMovimiento <> 1 and idTipoMovimiento <> 2 and idTipoMovimiento <> 3 and idTipoMovimiento <> 9
GO
/****** Object:  StoredProcedure [dbo].[MostrarVentas]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarVentas]
as
select idVenta  as ID, Cliente , Fecha , TipoPago , Tarjeta, Monto , Anulada    
from Ventas, TiposPago , Tarjetas
where ventas.idTarjeta = Tarjetas .idTarjeta  and Ventas .idTipoPago = TiposPago .idTipoPago  
order by Fecha desc
GO
/****** Object:  StoredProcedure [dbo].[MostrarVentasTarjeta]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarVentasTarjeta]
as
select idVentaTarjeta  as ID, idVenta as Venta, TipoPago as Tipo , Tarjeta , FechaVenta as Fecha , Total , Transferido as Marcardo, FechaTranferido as Transferido     
from VentasTarjeta , TiposPago , Tarjetas
where VentasTarjeta .idTipoPago  = TiposPago .idTipoPago   and VentasTarjeta.idTarjeta  = Tarjetas .idTarjeta   
and VentasTarjeta .Anulada = 0
order by FechaVenta  desc
GO
/****** Object:  StoredProcedure [dbo].[MostrarVentasTarjetaSinTransferir]    Script Date: 22/7/2020 11:42:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MostrarVentasTarjetaSinTransferir]
as
select idVentaTarjeta  as ID, idVenta as Venta, TipoPago as Tipo , Tarjeta , FechaVenta as Fecha , Total , Transferido as Marcado, FechaTranferido as Transferido     
from VentasTarjeta , TiposPago , Tarjetas
where VentasTarjeta .idTipoPago  = TiposPago .idTipoPago   and VentasTarjeta.idTarjeta  = Tarjetas .idTarjeta 
and Transferido = 0  and Anulada = 0
order by FechaVenta  desc
GO
