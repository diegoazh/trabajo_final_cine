 /******************************************************
 *
 * Pruebas
 *
 ******************************************************/

-- Listar usuarios
select * from users as u right join user_categories as c on u.id_tipo = c.id;

-- Prueba de Desencriptamiento y conversión
select convert(varchar(300),DECRYPTBYPASSPHRASE('CinesDzPs',contrasenia)) 'contraseña' from users where id = 1;

-- Prueba de desencriptamiento
select DECRYPTBYPASSPHRASE('CinesDzPs',contrasenia) 'contraseña' from users where id = 1;

-- Estas instrucciones van juntas por lo general
delete from users
go
DBCC CHECKIDENT('users', RESEED, 0)--Reinicia la lleva primaria.

-- Modificación de un procedimiento
alter procedure validarUsuario
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

-- Alters para corregir tablas
DELETE FROM [Condiciones_Fiscales];
GO
DBCC CHECKIDENT('Condiciones_Fiscales', RESEED, 0);
GO
DELETE FROM [Barrios];
GO
DBCC CHECKIDENT('Barrios', RESEED, 0);
GO
DELETE FROM [Beneficios];
GO
DBCC CHECKIDENT('Beneficios', RESEED, 0);
GO
DELETE FROM [Clientes];
GO
DBCC CHECKIDENT('Clientes', RESEED, 0);
GO
DELETE FROM [Formas_de_Pagos];
GO
DBCC CHECKIDENT('Formas_de_Pagos', RESEED, 0);
GO
DELETE FROM [Cines];
GO
DBCC CHECKIDENT('Cines', RESEED, 0);
GO
DELETE FROM [Calificacion];
GO
DBCC CHECKIDENT('Calificacion', RESEED, 0);
GO
DELETE FROM [Generos];
GO
DBCC CHECKIDENT('Generos', RESEED, 0);
GO
DELETE FROM [Tipos_Salas];
GO
DBCC CHECKIDENT('Tipos_Salas', RESEED, 0);
GO
DELETE FROM [Salas];
GO
DBCC CHECKIDENT('Salas', RESEED, 0);
GO
DELETE FROM [EstadoButacas];
GO
DBCC CHECKIDENT('EstadoButacas', RESEED, 0);
GO
-- OTRAS PRUEBAS
