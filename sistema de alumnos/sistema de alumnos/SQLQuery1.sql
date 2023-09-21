create database autenticar


use autenticar

create table usuario (

 codigo int  identity (1,1),
 nombre varchar (50),
 apellido varchar (50),
 matricula varchar (13),
 clave varchar (13)
)

select * from usuario

insert  into  usuario values('manuel','jesus','1-19-5285','12345')
insert  into  usuario values('andrea','jimenes','5-23-9415','12345')
insert  into  usuario values('juan','abru','8-16-8435','12345')
insert  into  usuario values('alexander','aquiono','3-29-7885','12345')

