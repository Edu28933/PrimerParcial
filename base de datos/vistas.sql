create view vwIserie_1 as
select
    e.Nombre,
	e.Apellido,
	d.Nombre as Departamento
FROM 
    tblEmpleados e
	join
	tblDepartamentos d on e.DepartamentoID = d.DepartamentoID

WHERE 
    e.Estado = 'Activo';


	SELECT * FROM vwIserie_1;



create view vwISerie_2 as
select
	e.Nombre,
	e.Apellido,
	p.SalarioNeto
From tblEmpleados e
	join
	tblPagos p on e.EmpleadoID = p.EmpleadoID
where
	e.Estado = 'Activo' and p.CantidadHorasExtras > 0;


	select * from vwISerie_2;


create view vwISerie_3 as
select
	e.EmpleadoID,
	e.Nombre,
	sum(p.CantidadHorasExtras) as TotalHorasExtras
From tblPagos p
	join tblEmpleados e on p.EmpleadoID = e.EmpleadoID
	join tblDepartamentos d on e.DepartamentoID = d.DepartamentoID
where e.Estado = 'Activo'
group by
	e.EmpleadoID,
	e.Nombre,
	d.Nombre;

select * from tblEmpleados;
select * from tblPagos;
select * from vwISerie_3;


create view vwISerie4 as
select e.*
from tblEmpleados e
join tblDepartamentos d on e.DepartamentoID = d.DepartamentoID
where d.Nombre = 'Tecnología' and e.Salario >3000;

select* from vwISerie4;

create view vwISerie5 as
select p.*
from tblPagos p
join tblEmpleados e on p.EmpleadoID = e.EmpleadoID
where e.Estado = 'Activo';

select * from vwISerie5;

create view vwISerie6 as
select 
	d.Nombre as NombreDepartamento,
	e.Nombre as NombreEmpleado,
	p.*
from tblEmpleados e 
	join tblDepartamentos d on e.DepartamentoID = d.DepartamentoID
	join tblPagos p on e.EmpleadoID = p.EmpleadoID
where
	















