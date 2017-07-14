create table Usuarios
(
Usuario varchar (15) not null primary key,
Clave varchar (15) not null,
Tipo varchar (15) not null,
Nombre varchar (15) not null,
Apellido varchar (15) not null,
Estado varchar(1) not null
)

create table Ingresos
(
Codigo int identity (1,1) primary key,
Fecha date not null,
Talon int not null,
Boleta int not null,
Monto numeric(10,2) not null,
Descripcion varchar (100),
Colegio varchar (50) not null,
Estado varchar(7) not null
)

alter procedure InsertarIngresos
 @Fecha date,
 @Talon int,
 @Boleta int,
 @Monto numeric(10,2),
 @Descripcion varchar(100),
 @Colegio varchar(50)
 as
 insert into Ingresos (Fecha, Talon, Boleta,Monto,Descripcion, Colegio,Estado) values
 (
 @Fecha,
 @Talon,
 @Boleta,
 @Monto,
 @Descripcion,
 @Colegio,
 'Activo'
 )
 alter procedure ModificarIngresos
 @Codigo int,
 @Fecha date,
 @Talon int,
 @Boleta int,
 @Monto numeric(10,2),
 @Descripcion varchar(100),
 @Colegio varchar(50)
 as
update Ingresos set
Fecha=@Fecha,
Talon=@Talon,
Boleta=@Boleta,
Monto=@Monto,
Descripcion=@Descripcion,
Colegio=@Colegio
where
Codigo=@Codigo
go
create procedure EliminarIngresos
 @Codigo int
 as
update Ingresos set
Estado='Anulado'
where
Codigo=@Codigo
go

Exec ModificarIngresos 3,'10/05/2017',2,1,220,'Prueba 3','France'
select * from Ingresos where Boleta <>  1 and Talon=2