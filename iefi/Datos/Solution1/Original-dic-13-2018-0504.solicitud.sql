Create database Suministros
use
Suministros

--traer la info de la solicitud 18575 
 select* from municipalidad
 where solicitud '18575'


--Importe total

select Detalle servicio,sum(total)as suma


