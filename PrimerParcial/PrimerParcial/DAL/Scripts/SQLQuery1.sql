CREATE DATABASE Parcial1Db
GO
USE Parcial1Db
GO
CREATE TABLE Grupos
(
	GruposId int primary key identity(1,1),
	Fecha DateTime,
	Descripcion varchar(max),
	Cantidad int(40),
	Integrantes int (50),

);