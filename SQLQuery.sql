
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

create table Egresos
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



alter procedure InsertarEgresos
 @Fecha date,
 @Talon int,
 @Boleta int,
 @Monto numeric(10,2),
 @Descripcion varchar(100),
 @Colegio varchar(50)
 as
 insert into Egresos (Fecha, Talon, Boleta,Monto,Descripcion, Colegio,Estado) values
 (
 @Fecha,
 @Talon,
 @Boleta,
 @Monto,
 @Descripcion,
 @Colegio,
 'Activo'
 )
 go
 alter procedure ModificarEgresos
 @Codigo int,
 @Fecha date,
 @Talon int,
 @Boleta int,
 @Monto numeric(10,2),
 @Descripcion varchar(100),
 @Colegio varchar(50)
 as
update Egresos set
Fecha=@Fecha,
Talon=@Talon,
Boleta=@Boleta,
Monto=@Monto,
Descripcion=@Descripcion,
Colegio=@Colegio
where
Codigo=@Codigo
go
alter procedure EliminarEgresos
 @Codigo int
 as
update Egresos set
Estado='Anulado'
where
Codigo=@Codigo
go
Exec ModificarIngresos 3,'10/05/2017',2,1,220,'Prueba 3','France'
select * from Ingresos where Boleta <>  1 and Talon=2
select Codigo as 'Código', Colegio as 'Nombre de Colegio', Fecha, Talon as 'Número de Talón', Boleta as 'Número de Boleta', Descripcion as 'Descripción', Monto from ingresos where Estado <> 'Anulado'
select sum (Ingresos.monto) as 'Ingresos' , sum(Egresos.monto) as'Egresos', sum (Ingresos.monto) - sum(Egresos.monto) as Balance from Ingresos, Egresos where Ingresos.Fecha='2017/7/14' and Egresos.Fecha='2017/7/14'
select Ingresos.Fecha, Ingresos.Monto, Ingresos.Descripcion, Egresos.Fecha, Egresos.Monto, Egresos.Descripcion from Ingresos, Egresos where Ingresos.Fecha=Egresos.Fecha
select Distinct(Ingresos.Monto), Distinct(Egresos.Monto) from Ingresos join Egresos on Ingresos.Fecha = Egresos.Fecha
select (Ingresos.Monto)  from Ingresos inner join Egresos on Ingresos.Fecha = Egresos.Fecha

select * from Egresos where Estado<>'Anulado' and Fecha='2017/7/14' order by Fecha
select * from Ingresos where Estado<>'Anulado' and Fecha='2017/7/16'

select * from Ingresos where Estado<>'Anulado' and Fecha between '2017/7/13' and '2017/7/16' 
select * from Ingresos where Estado<>'Anulado' and DATEPART(month,Fecha)=7 and DATEPART(year,Fecha)=2017 order by Fecha asc
select * from Egresos where Estado<>'Anulado' and DATEPART(month,Fecha)=7 and DATEPART(year,Fecha)=2017 order by Fecha
select Fecha, Monto, Descripcion from Egresos union select Fecha, Monto, Descripcion from Ingresos

guardar la tabla ingresos y egresos en datatables (dt ingresos, dt egresos)
luego iterarlos y guardarlos en otro datatable con los datos que se requieran (dt balance)
lenar el dt fila por fila, cuando una fila se agote, llenarlo con vacios
-- sacar la cantidad de filas de cada uno, luego ver quien es mayor
-- iterar hasta llegar a la cantidad del menor, luego llenar esos campos con vacios
luego mostrarlos en el gridview
luego pedir que se guarde
al guardar, se insertan los datos a la tabla
--- habrá otra tabla más como historial, como unicos campos un id y una fecha, para verificar
--- que no hayan fechas duplicadas

tambien se puede pedir crear nuevo balance
si ya existe, se dira que ya existe uno, desea reemplazarlo?
si se presiona si, se borra y se hace lo de arriba
