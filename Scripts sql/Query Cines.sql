/**********************************************************
 *
 * Codigo de emergencia
 *
 **********************************************************/

use master
go
drop database CINES
go


/**********************************************************
 *
 * Creación de la DB CINES
 *
 **********************************************************/
create database CINES
go
use CINES
go
create table Provincias (
id_provincia int identity(1,1) not null,
nombre varchar (100) not null 
constraint PkProvicia primary key (id_provincia)
)
go
create table Departamentos(
id_departamento int identity(1,1) not null,
id_provincia int,
nombre varchar(60),
constraint PkIdDepartamento primary key(id_departamento),
constraint FkIdProvincia foreign key(id_provincia)
references provincias(id_provincia)
)
go
create table Localidades(
id_localidad int identity(1,1) not null,
id_departamento int,
nombre varchar (100) not null,
constraint PkLocalidad primary key (id_localidad),
constraint FkIdDepartamento foreign key (id_departamento)
references Departamentos (id_departamento)
)
go
create table Barrios (
id_barrio int identity(1,1) not null,
nombre varchar (50) not null,
id_localidad int,
constraint PkBarrio primary key (id_barrio),
constraint FKLocalidad foreign key (id_localidad)
references Localidades (id_localidad)
)
go
create table Condiciones_Fiscales (
id_cond_fiscal int identity (1,1) not null,
cond_fiscal varchar (50) not null,
constraint PkCondFiscal primary key (id_cond_fiscal)
)
go
create table Beneficios (
id_beneficio int identity (1,1) not null,
tipo varchar (50) not null,
descripcion varchar(300),
fecha_inicio datetime,
fecha_finalizacion datetime,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdBeneficio primary key (id_beneficio)
)
go
create table Clientes (
id_cliente int identity(1,1) not null,
ape_cliente varchar(50) not null,
nom_cliente varchar(50) not null,
fec_nac datetime not null,
telefono bigint not null,
celular bigint not null,
mail varchar(60),
dni bigint null,
cuit bigint null,
cuil bigint null,
direccion varchar(80),
id_barrio int,
id_cond_fiscal int,
razon_social varchar(150) null,
id_beneficio int,
socio bit,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkCliente primary key (id_cliente),
constraint FkIdCondFiscal foreign key(id_cond_fiscal)
references Condiciones_Fiscales(id_cond_fiscal),
constraint FkBarrio foreign key (id_barrio)
references Barrios (id_barrio),
constraint FkBeneficio foreign key (id_beneficio)
references Beneficios (id_beneficio)
)
go
create table Tipo_Promociones(
id_tipo int identity(1,1),
nombre varchar(50),
descuento int not null,
descripcion varchar(150),
acumulable bit not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdTipo primary key(id_tipo)
)
go
create table Promociones(
id_promocion int identity(1,1),
nombre varchar(60),
caracteristicas varchar(300),
cupo int not null,
fecha_inicio datetime,
fecha_fin datetime,
tipo_promocion int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdPromo primary key(id_promocion),
constraint FkTipoPromo foreign key(tipo_promocion)
references Tipo_Promociones(id_tipo)
)
go
create table Formas_de_Pagos(
id_form_pago int identity(1,1) not null,
forma_pago varchar (70) not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkFormPago primary key (id_form_pago)
)
go
create table Cines(
id_cine int identity(1,1) not null,
nombre varchar (50) not null,
razon_social varchar(50) not null,
cuit bigint not null,
direccion varchar(150) not null,
id_cond_fiscal int,
id_barrio int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkCine primary key (id_cine),
constraint FkCondFiscalc foreign key (id_cond_fiscal)
references Condiciones_fiscales (id_cond_fiscal),
constraint FkBarrioc foreign key (id_barrio)
references Barrios (id_barrio)
)
go
create table Facturas(
id_factura bigint identity(1,1),
nro_factura bigint not null,
fecha datetime not null,
id_cine int not null,
id_cliente int null,
id_form_pago int not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdFactura primary key (id_factura),
constraint U_NroFactura unique(nro_factura),
constraint FkCinefa foreign key (id_cine)
references Cines (id_cine),
constraint FkFormPagofa foreign key (id_form_pago)
references Formas_de_pagos (id_form_pago),
constraint FkFactIdCliente foreign key(id_cliente)
references Clientes(id_cliente)
)
go
create table Calificacion (
id_calificacion int identity(1,1) not null,
descripcion varchar(10) not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkEdad primary key (id_calificacion)
)
go
create table Generos (
id_genero int identity(1,1) not null,
genero varchar (50) not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkGenero primary key (id_genero)
)
go
create table Peliculas(
id_pelicula int identity(1,1),
nombre varchar(50) not null,
descripcion varchar(250) null,
estreno bit,
duracion time(0),
id_genero int,
id_calificacion int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PKIdPelicula primary key(id_pelicula),
constraint FkIdGenero foreign key(id_genero)
references Generos(id_genero),
constraint FkIdCalificacion foreign key(id_calificacion)
references Calificacion(id_calificacion)
)
go
create table Tipos_Salas(
id_tipo_sala int identity (1,1) not null,
tipo_sala varchar (50) not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkTipoSala primary key (id_tipo_sala)
)
go
create table Salas(
id_sala int identity(1,1) not null,
nombre_sala varchar(25) not null,
cant_butacas int,
id_tipo_sala int,
id_cine int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkSala primary key (id_sala),
constraint FkTipoSalasa foreign key (id_tipo_sala)
references Tipos_Salas (id_tipo_sala),
constraint FkIdCine foreign key (id_cine)
references Cines(id_cine)
)
go
create table EstadoButacas(
id_estado int identity(1,1),
descripcion varchar(25) not null,
constraint PkIdEstado primary key(id_estado)
)
go
create table Butacas (
id_butaca int identity(1,1),
butaca int not null,
id_sala int,
id_estado int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkButaca primary key (id_butaca),
constraint FkIdNroSala foreign key(id_sala)
references Salas(id_sala),
constraint FKIdEstado foreign key (id_estado)
references EstadoButacas (id_estado)
)
go
create table Entradas(
id_entrada int identity(1,1),
nombre varchar(35) not null,
descripcion varchar(150),
precio money not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdEntrada primary key(id_entrada)
)
go
create table Funciones(
id_funcion int identity(1,1),
id_sala int,
id_pelicula int,
hs_inicio time(0),
hs_finalizacion time(0),
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdSyP primary key(id_funcion),
constraint FkIdSala foreign key(id_sala)
references Salas(id_sala),
constraint FkIdPelicula foreign key(id_pelicula)
references Peliculas(id_pelicula)
)
go
create table Detalles_Facturas(
id_detalle int identity(1,1) not null,
id_entrada int,
id_promocion int null,
id_beneficio int null,
id_funcion int,
id_butaca int,
id_factura bigint,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkDetalle primary key (id_detalle),
constraint FkIdEntrada foreign key(id_entrada)
references Entradas(id_entrada),
constraint FkIdPromo foreign key(id_promocion)
references Promociones(id_promocion),
constraint FkIdBeneficio foreign key(id_beneficio)
references Beneficios(id_beneficio),
constraint FkIdFuncion foreign key(id_funcion)
references Funciones(id_funcion),
constraint FkButacadf foreign key (id_butaca)
references Butacas (id_butaca),
constraint FkFacturadf foreign key (id_factura)
references Facturas (id_factura)
)
go
create table Reservas(
id_reserva bigint identity(1,1),
id_cliente int,
fechaYHora datetime not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdReserva primary key(id_reserva),
constraint FkIdClienteReserva foreign key(id_cliente)
references Clientes(id_cliente)
)
go
create table Detalles_Reservas(
id_detalle int identity(1,1),
id_reserva bigint,
id_butaca int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdDetalleReserva primary key(id_detalle),
constraint FkIdReserva foreign key(id_reserva)
references Reservas(id_reserva),
constraint FkIdButacaDetalleReserva foreign key(id_butaca)
references Butacas(id_butaca)
)

/******************************************************
 *
 * Tabla Usuarios para el logueo
 *
 ******************************************************/
create table user_categories(
id int identity(1,1),
categoria varchar(25) not null,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdUserCategory primary key(id)
)
go
create table users(
id int identity(1,1),
nickname varchar(30),
contrasenia varbinary(4000) not null,
id_tipo int,
created_at datetime,
updated_at datetime,
deleted_at datetime,
constraint PkIdUser primary key(id),
constraint FkIdTipo foreign key(id_tipo)
references user_categories(id)
)
go

 /******************************************************
 *
 * Procedimientos
 *
 * -- para mas información sobre ENCRYPTBYPASSPHRASE y DECRYPTBYPASSPHRASE ver:
 * -- https://msdn.microsoft.com/es-es/library/ms190357(v=sql.120).aspx y https://msdn.microsoft.com/es-es/library/ms188910(v=sql.120).aspx
 *
 ******************************************************/

-- Este procedimiento registra un usuario
create procedure registrarUsuario
	@Name nvarchar(30),
	@Pass nvarchar(300),
	@Tipo int
as
begin
    insert into users
    (
        nickname,
        contrasenia,
		id_tipo
    )
    values
    (
        @Name,
        ENCRYPTBYPASSPHRASE('CinesDzPs', @Pass),
		@Tipo
    )
end
go

-- Este procedimiento valida un usuario
create procedure validarUsuario
	@Name nvarchar(30),
	@Pass nvarchar(300),
    @Result bit output,
	@Tipo int output
as
    declare @PassCodificado as nvarchar(300)
    declare @PassDecodificado as nvarchar(50)
begin
	select @Tipo = id_tipo from users where nickname = @Name
    select @PassCodificado = contrasenia from users where nickname = @Name
    set @PassDecodificado = convert(varchar(300),DECRYPTBYPASSPHRASE('CinesDzPs', @PassCodificado))

    if @PassDecodificado = @Pass
        set @Result = 1
    else
        set @Result = 0
end
go

 /**************************************************************************************
 *
 * Las consultas mejoradas debido a la nva estructura de la base de datos 
 *
 **************************************************************************************/

-- El total recaudado por el genero en el periodo de meses pedido y hasta la fecha.
create procedure sp_recaudacionPorGenero
@Genero int = 1,
@Meses int = 1,
@Beneficio money = 0.0,
@Promocion money = 0.0
as
select g.genero as 'Genero de pelicula', sum(e.precio - @Beneficio - @Promocion) as 'Totales Generales'
from Facturas as f, Detalles_Facturas as d, Entradas as e, Funciones as fun, Peliculas as p, Generos as g
where (f.id_factura = d.id_factura) and (d.id_entrada = e.id_entrada) 
and (fun.id_funcion = d.id_funcion) and (fun.id_pelicula = p.id_pelicula)
and (g.id_genero = p.id_genero)
and (g.id_genero = @Genero) and (f.fecha between dateadd(month, -@Meses, getdate()) and getdate())
group by g.genero;
go

-- El total recaudado la película en el periodo de meses pedido y hasta la fecha.
create procedure sp_recaudacionPorPelicula
@Pelicula int = 1,
@Meses int = 1,
@Beneficio money = 0.0,
@Promocion money = 0.0
as
select p.nombre as 'Título de la Película', sum(e.precio - @Beneficio - @Promocion) as 'Totales Generales'
from Facturas as f, Detalles_Facturas as d, Entradas as e, Funciones as fun, Peliculas as p
where (f.id_factura = d.id_factura) and (d.id_entrada = e.id_entrada) 
and (fun.id_funcion = d.id_funcion) and (fun.id_pelicula = p.id_pelicula)
and (p.id_pelicula = @Pelicula) and (f.fecha between dateadd(month, -@Meses, getdate()) and getdate())
group by p.nombre;
go

-- Clientes que vieron determinada película , que sean o no socios en el periodo de tiempo especificado.
create procedure sp_clientesNoSociosPorPelicula
@Pelicula int = 1,
@Socio bit = 0,
@FechaDesde date,
@FechaHasta date
as
if @FechaDesde = NULL
	return
if @FechaHasta = NULL
	return
begin
select p.nombre as 'Título de la Pélicula', count(*) as 'Cantidad de clientes'
from Facturas as f, Detalles_Facturas as d, Clientes as c, Funciones as fun, Peliculas as p
where (f.id_factura = d.id_factura) and (d.id_funcion = fun.id_funcion) and 
(f.id_cliente = c.id_cliente) and (fun.id_pelicula = p.id_pelicula) and
(f.fecha between @FechaDesde and @FechaHasta) and (p.id_pelicula = @Pelicula) and (c.socio = @Socio)
group by p.nombre
end;
go
-- Socios que hayan visto determinada pelicula entre el determinadas fechas, y que se hayan sentado más de tres veces en la misma butaca.
create procedure sp_clientesPorPeliculaYButacaEnFecha
@Pelicula int = 1,
@socio bit = 0,
@Butaca int = 1,
@FechaDesde date,
@FechaHasta date
as
if @FechaDesde = null
	return
if @FechaHasta = null
	return
begin
select c.nom_cliente as 'NOMBRE', c.ape_cliente as 'APELLIDO', p.nombre as 'PELICULA', s.nombre_sala as 'SALA', b.butaca as 'BUTACA'
from Clientes as c join Facturas as f on c.id_cliente = f.id_cliente
	join Detalles_Facturas as d on f.id_factura = d.id_factura
	join Funciones as fun on d.id_funcion = fun.id_funcion
	join Peliculas as p on fun.id_pelicula = p.id_pelicula
	join Salas as s on fun.id_sala = s.id_sala
	join Butacas as b on s.id_sala = b.id_sala
where (p.id_pelicula = @Pelicula) and (f.fecha between @FechaDesde and @FechaHasta) and (c.socio = @socio)
and 3 < (
	select count(b2.id_butaca)
	from Clientes as c2 join Facturas as f2 on c2.id_cliente = f2.id_cliente
		join Detalles_Facturas as d2 on f2.id_factura = d2.id_factura
		join Funciones as fun2 on d2.id_funcion = fun2.id_funcion
		join Salas as s2 on fun2.id_sala = s2.id_sala
		join Butacas as b2 on s2.id_sala = b2.id_sala
	where b2.id_butaca = @Butaca and c2.id_cliente = c.id_cliente
)
end
go

 /******************************************************
 *
 * Vistas
 *
 ******************************************************/

/******************************************************
 *
 * Inserts de las Usuarios
 *
 ******************************************************/
 insert into user_categories(categoria) values('Administrador');
 go
 insert into user_categories(categoria) values('Auditor');
 go
 insert into user_categories(categoria) values('Superusuario');
 go
 insert into user_categories(categoria) values('Usuario');
 go

 insert into users(nickname, contrasenia, id_tipo) values('diegoazh',ENCRYPTBYPASSPHRASE('CinesDzPs','yusuke'),1);
 go
 insert into users(nickname, contrasenia, id_tipo) values('pablos',ENCRYPTBYPASSPHRASE('CinesDzPs','scotto'),1);
 go
 insert into users(nickname, contrasenia, id_tipo) values('emple',ENCRYPTBYPASSPHRASE('CinesDzPs','EmpleCine'),4);
 go