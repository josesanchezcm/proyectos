USE [VentasLeon]
GO
/****** SP de Mantenimiento de Distritos ******/
--Insertar
Create PROCEDURE [dbo].[usp_InsertarDistrito]
@nom_dis varchar(30),
@cod_ven char(3)
AS
declare @vcod char(3)
declare @vcont int
set @vcont=(Select count(*) from tb_distrito)
if @vcont=0 
       set @vcod ='D01'
else
        set @vcod=(Select 'D' +Right(Max (Right(Cod_dis,2)+ 101 ),2) 
    From Tb_Distrito)
insert into Tb_Distrito values(@vcod,@nom_dis,@cod_ven)

go
--Actualizar
Create PROCEDURE [dbo].[usp_ActualizarDistrito]
@cod_dis char(3),
@nom_dis varchar(30),
@cod_ven char(3)
AS
update Tb_Distrito set Nom_dis=@nom_dis,Cod_ven=@cod_ven
where Cod_dis=@cod_dis
go

--Eliminar
Create PROCEDURE [dbo].[usp_EliminarDistrito]
@cod_dis char(3)
AS
Delete from Tb_Distrito
where Cod_dis=@cod_dis
go

--Consultar
Create PROCEDURE [dbo].[usp_ConsultarDistrito]
@cod_dis char(3)
AS
Select cod_dis,nom_dis,cod_ven from Tb_Distrito
where cod_dis=@cod_dis
go

--Listar 
Create PROCEDURE [dbo].[usp_ListarDistrito]
@cod_dis char(3)
AS
Select cod_dis,nom_dis,cod_ven from Tb_Distrito
go
