USE [BASEJULIJO]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Marcas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Movimientos]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Proveedores]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Talles]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Tarjetas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[TiposMovimientos]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[TiposPago]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[TiposPrenda]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  Table [dbo].[VentasTarjeta]    Script Date: 22/7/2020 12:38:42 ******/
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
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (1, N'-------------')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (2, N'BANANA DE COCO')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (3, N'CARTER''S')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
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

INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (1, N'--------')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (2, N'CABAL')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (3, N'CABAL DEBITO')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (4, N'MAESTRO')
INSERT [dbo].[Tarjetas] ([idTarjeta], [Tarjeta]) VALUES (5, N'MASTERCARD')
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
/****** Object:  StoredProcedure [dbo].[BuscarDetalleVenta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxFechas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxidMovimientoFechas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarMovimientosxidTipoMovimiento]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarVentasTarjetaFechas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[BuscarVentasxFechas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarDetalleVenta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarMovimiento]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarVenta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertarVentaTarjeta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarAnularVenta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarVentaTarjetaAnulada]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[ModificarVentaTarjetaTransferido]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarMarcas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarMovimientos]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarProveedores]    Script Date: 22/7/2020 12:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarProveedores]
as
select idProveedor as ID, Proveedor   
from Proveedores    

GO
/****** Object:  StoredProcedure [dbo].[MostrarTalles]    Script Date: 22/7/2020 12:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTalles]
as
select idTalle  as ID, Talle    
from Talles     

GO
/****** Object:  StoredProcedure [dbo].[MostrarTarjetas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarTipoPrenda]    Script Date: 22/7/2020 12:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTipoPrenda]
as
select idTipoPrenda  as ID, Tipo 
from TiposPrenda  

GO
/****** Object:  StoredProcedure [dbo].[MostrarTiposMovimiento]    Script Date: 22/7/2020 12:38:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MostrarTiposMovimiento]
as
select idTipoMovimiento as ID, Movimiento      
from TiposMovimientos 
GO
/****** Object:  StoredProcedure [dbo].[MostrarTiposMovimientoNuevos]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarVentas]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarVentasTarjeta]    Script Date: 22/7/2020 12:38:42 ******/
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
/****** Object:  StoredProcedure [dbo].[MostrarVentasTarjetaSinTransferir]    Script Date: 22/7/2020 12:38:42 ******/
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
