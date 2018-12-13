Create database Suministros
use
Suministros

--traer la info de la solicitud 18575 
 select* from municipalidad
 where solicitud '18575'
 


--Importe total

select Count(*)cantidad
 from detalle servicio 
 
select Detalle servicio,sum(preciounitario)as suma


