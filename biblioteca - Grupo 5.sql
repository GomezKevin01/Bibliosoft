--***********************************************************************************************
--*																								*
--* CREAR LAS TABLAS UNA POR UNA e insertar los datos o bien crearlos todos desde la aplicación *
--*																								*
--***********************************************************************************************

create database  biblioteca1;
--drop database biblioteca1

go
use biblioteca1;
go

create table socioss (
	idSocio int identity primary key not null,
	dni int not null,
	tipoSocio int not null,
	apellido varchar(50) not null,
	nombre varchar(50) not null,
	fechaNacimiento date,
	direccion varchar(50) not null,
	telefono varchar(30) not null
	);

alter table socioss
add constraint UQ_socioss_dni
unique (dni);

create table autores (
	idAutor int identity primary key not null,
	dni int not null,
	apellido varchar(50) not null,
	nombre varchar(50) not null,
	fechaNacimiento date,
	pais varchar(40) not null
	);

create table proveedores (
	idProveedor int identity primary key not null,
	nombre varchar(50) not null,
	direccion varchar(50) not null,
	telefono varchar(30) not null
	);

create table libross (
	idLibro int identity primary key not null,
	titulo varchar(50) not null,
	año int,
	editorial varchar(50) not null,
	idAutor inT not null,
	idProveedor int not null,
	constraint FK_libros_autores foreign key (idAutor) references autores (idAutor),
	constraint FK_libros_proveedores foreign key (idProveedor) references proveedores (idProveedor)
	);
alter table libross
add estado int;

create table prestamos (
	idPrestamo int identity primary key not null,
	fechaPrestamo date,
	fechaVencimiento date,
	idSocio int ,
	constraint FK_prestamos_socios foreign key (idSocio) references socioss (idSocio),
	);
--drop table prestamos;
create table prestamosPersistente (
	idPrestamo int identity primary key not null,
	fechaPrestamo date/*,
	fechaVencimiento date,
	idSocio int ,
	constraint FK_prestamosPersistente_socios foreign key (idSocio) references socioss (idSocio),*/
	);
	select * from prestamosPersistente;
--drop table prestamosPersistente;

create table detallePrestamo(
	idDetalle int identity primary key not null,
	idPrestamo int,
	idLibro int,
	constraint Fk_detallePrestamo_libross foreign key (idLibro) references libross (idLibro),
	constraint FK_detallePrestamo_prestamos foreign key (idPrestamo) references prestamos (idPrestamo)
);
--drop table detallePrestamo

create table empleados (
	idEmpleado int identity primary key not null,
	tipoEmpleado int not null,
	usuario varchar(50) unique not null,
	contraseña varchar(100) not null,
	apeYnombre varchar(100) not null,
	dni int unique not null,
	fechaNacimiento date not null,
	telefono varchar(50) not null,
	direccion varchar(50) not null
	);
--drop table empleados

create table configuracion(
	idFantasma int identity primary key not null,
	claveRigistroEmpleado varchar(100) not null,
	diasProxVencimiento int not null
	);

--drop table configuracion;

-- ingreso de datos para prueba

insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (5896321,1, 'Profesor','Jirafales','19500815','Av. Siempre viva 2234','3794001075');
insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (15268748,1, 'Alfonzo','Pedro','19700715','Junin 634','3795101077');
insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (14201598,1, 'La Red','David','19700819','Av. Gral. Paz 410','3794001170');
insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (42061916,2, 'Gomez','Kevin','19990805','Av. Teniente Ibañez 2234','3794007710');
insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (40697120,2, 'Kryvenki','Nicolas','19890815','Av. Presidente Nicolas Kryvenki 666','3794001078');
insert into socioss(dni,tipoSocio,apellido,nombre,fechaNacimiento,direccion,telefono) values (42698741,2, 'Casafu','Gabriel','19891218','Juan de Dios Gomez 412','3794771078');
select * from socioss;

insert into autores(dni,apellido,nombre,fechaNacimiento,pais) values (4012365,'Tanenbaum','Andrew','19440316','USA');
insert into autores(dni,apellido,nombre,fechaNacimiento,pais) values (22674012,'Toriyama','Akira','19780405','Japón');
insert into autores(dni,apellido,nombre,fechaNacimiento,pais) values (21555396,'García','Gabriel','19470306','Colombia');
insert into autores(dni,apellido,nombre,fechaNacimiento,pais) values (8796123,'Borges','Jorge','18990614','Argentina');


select * from autores;
--drop table autores

--Consulta
select au.nombre, COUNT(li.idLibro)
from autores au
inner join libross li
on au.idAutor = li.idAutor
group by au.nombre
order by au.nombre desc;

insert into proveedores(nombre,direccion,telefono) values ('Panini','Calle Corrientes 412','3794771054');
insert into proveedores(nombre,direccion,telefono) values ('Piamonte','Av. el Libertador 1263','3796771854');
insert into proveedores(nombre,direccion,telefono) values ('Lomas','Av. Centenario 613','3794111954');
select * from proveedores;
--drop table proveedores

insert into libross(titulo,año,editorial,idAutor,idProveedor,estado) values ('Aprendiendo con Martina 2','2018','Kapeluz',5,1,0);
select * from libross
where idLibro != 1
--drop table libross

insert into empleados(tipoEmpleado,usuario,contraseña,apeYnombre,dni,fechaNacimiento,telefono,direccion) values (3,'admin','admin','Gomez Kevin David',42061916,'19990805','3794007710','Teniente Ibañez 1578');
insert into empleados(tipoEmpleado,usuario,contraseña,apeYnombre,dni,fechaNacimiento,telefono,direccion) values (1,'Jose','1234','Romero Jose',410618745,'19980815','3794877711','Las Heras 258');
insert into empleados(tipoEmpleado,usuario,contraseña,apeYnombre,dni,fechaNacimiento,telefono,direccion) values (2,'Juan','1234','Veron Juan',370818745,'19850915','3794887725','San Martín 1560');
select * from empleados;


select * from configuracion;
--delete from configuracion;

-- vistas

alter view prestamosPorSocio
as 
select pres.idPrestamo,so.dni,concat(so.apellido,' ',so.nombre)as Socio,
CASE
    WHEN pres.fechaVencimiento < CONVERT(CHAR(8), GETDATE(), 112) THEN 'SI'    
    ELSE 'NO'
END AS Vencido
from socioss so
inner join prestamos pres
on so.idSocio = pres.idSocio;

select * from prestamosPorSocio;


create view verPrestamos 
as
select detalle.idPrestamo as 'ID del prestamo',li.idLibro as 'ID del libro', li.titulo as Título
from detallePrestamo detalle
inner join libross li
on detalle.idLibro = li.idLibro
inner join prestamos p
on detalle.idPrestamo = p.idPrestamo;

select * from verPrestamos;


create view vistaLibros
as
select li.idLibro as 'ID del libro', li.titulo as Título, li.año as Año, li.editorial as Editorial, CONCAT(au.apellido,' ', au.nombre) as Autor, prov.nombre as Proveedor,
CASE
    WHEN li.estado = 1  THEN 'SI'    
    ELSE 'NO'
END AS Prestado
from libross li
inner join autores au
on li.idAutor = au.idAutor
inner join proveedores prov
on li.idProveedor = prov.idProveedor;

select * from vistaLibros;


create view vistaEmpleados
as 
select e.idEmpleado as 'ID del Empleado',
case e.tipoEmpleado
	when 1 then 'Bibliotecario'
	when 2 then 'Gestor de Stock'
	when 3 then  'Administrador'
end as 'Tipo de Empleado',
e.dni as DNI, e.apeYnombre as 'Apellido y nombre', e.usuario as Usuario,e.fechaNacimiento as 'Fecha de nacimiento',e.direccion as Dirección,e.telefono as Telefono
from empleados e

select * from vistaEmpleados;


create view vistaSocios
as 
select s.idSocio, 
case s.tipoSocio
	when 1 then 'Profesor'
	else 'Alumno'
end as tipoDeSocio, s.dni as DNI, S.apellido AS Apellido, s.nombre as Nombre, s.fechaNacimiento, s.direccion as Dirección, s.telefono as Telefono
from socioss s

select * from vistaSocios;




--Vistas descartadas

/*create view librosView
as
select li.idLibro, li.titulo, li.año, li.editorial, CONCAT(au.apellido,' ', au.nombre) as Autor, prov.nombre as Proveedor,
CASE
    WHEN li.estado = 1  THEN 'SI'    
    ELSE 'NO'
END AS Prestado
from libross li
inner join autores au
on li.idAutor = au.idAutor
inner join proveedores prov
on li.idProveedor = prov.idProveedor

select * from librosView


create view prestamosLibros 
as
select detalle.idPrestamo,li.idLibro, li.titulo
from detallePrestamo detalle
inner join libross li
on detalle.idLibro = li.idLibro;

select * from prestamosLibros;

create view prestamosPorMes
as
SELECT 
case MONTH(fechaPrestamo)
	when 1 then 'Enero'
	when 2 then 'Febrero'
	when 3 then 'Marzo'
	when 4 then 'Abril'
	when 5 then 'Mayo'
	when 6 then 'Junio'
	when 7 then 'Julio'
	when 8 then 'Agosto'
	when 9 then 'Septiembre'
	when 10 then 'Octubre'
	when 11 then 'Noviembre'
	when 12 then 'Diciembre'
	end as Meses,
SUM(1) AS Prestamos
FROM prestamos
GROUP BY  MONTH(fechaPrestamo)

select * from prestamosPorMes;

drop view prestamosPorMes;

*/