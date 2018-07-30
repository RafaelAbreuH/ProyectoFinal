create database ProyectoFinalDb
go
use ProyectoFinalDb
go
create table Usuario(
	UsuarioId int primary key identity(1,1),
	Nombre varchar(30),
	Username varchar(50),
	Passwordd varchar(20),
	Fecha datetime,
	Telefono varchar(12),
	Direccion varchar(255)
);
go
insert into Usuario(Nombre,Username,Passwordd) values('Rafael Abreu Hernandez', 'admin', 'admin');

