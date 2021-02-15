use BD_CONTACTABILIDAD 
go 
CREATE PROCEDURE SP_ROL_list
AS
SELECT idRol, nombreRol from tb_Rol 

CREATE PROCEDURE SP_PRODUCTO_list
AS
select idProducto, nombreProducto, descripcionProducto, estadoProducto from tb_Producto where estadoProducto = 1;

CREATE PROCEDUre SP_CLIENTE_ListaPorDNI
( @NumDoc varchar(20)
)
AS
select cli.idCliente, cli.nombreCliente, cli.apellidosCliente, cli.numeroDocumentoCliente, 
cli.generoCliente, cli.idCategoria, cat.nombreCategoria

from tb_Cliente cli inner join tb_Categoria cat
on cli.idCategoria = cat.idCategoria
where cli.numeroDocumentoCliente = '44476373'

CREATE PROCEDURE SP_ROL_Insert
(@nombreRol varchar(20) )
AS
insert into tb_rol (nombreRol)
values(@nombreRol)



select