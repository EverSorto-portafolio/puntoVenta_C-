Create Procedure UPS_Listado_ca '%'
@cTexto varchar(100) = ''
as
	select codigo_categoria, descripcionCategoria 
	from categoria 
	where  estado=1 and 
	upper(trim(cast(codigo_categoria as char))) + upper (trim(descripcionCategoria)) like '%'+ upper(trim(@cTexto))+'%'
go 
