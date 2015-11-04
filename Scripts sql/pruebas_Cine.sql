 /******************************************************
 *
 * Pruebas
 *
 ******************************************************/


select * from users;

select convert(varchar(300),DECRYPTBYPASSPHRASE('CinesDzPs',contrasenia)) 'contraseña' from users where id = 1;

select DECRYPTBYPASSPHRASE('CinesDzPs',contrasenia) 'contraseña' from users where id = 1;

-- Estas instrucciones van juntas por lo general
delete from users
go
DBCC CHECKIDENT('users', RESEED, 0)--Reinicia la lleva primaria.
