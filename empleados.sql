create database empleados
go



create table empleados(
idEmpleado INT PRIMARY KEY IDENTITY(1,1),
nombreEmpleado TEXT NOT NULL,
apellidoEmpleado TEXT NOT NULL,
edadEmpleado TEXT NOT NULL,
direccionEmpleado TEXT NOT NULL,
numeroTelefono TEXT NOT NULL,
emailEmpleado TEXT NOT NULL
);

select * from empleados