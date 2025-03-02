-- ============================================
-- Author:		eDUARDO sOLARES
-- Create date: 2025/03/01 
-- Description:	EDITAR
-- =============================================
create procedure usp_Empleados_editar 
( 			 
	@EmpleadoID int, 
	@Nombre varchar (50),  
	@Apellido varchar (50),  
	@FechaNacimiento DATETIME,   
	@FechaContratacion DATETIME,
	@DepartamentoID Int,
	@PuestoTrabajo varchar (100),
	@Salario decimal (10,2),
	@Estado varchar (50)
	)  
	AS
BEGIN
	SET NOCOUNT ON; 

	update tblEmpleados
	set Nombre = @Nombre, 
	Apellido = @Apellido, 
	FechaNacimiento = @FechaNacimiento,
	FechaContratacion = @FechaContratacion, 
	DepartamentoID = @DepartamentoID,
	PuestoTrabajo = @PuestoTrabajo,
	Salario = @Salario,
	Estado = @Estado 
	where EmpleadoID = @EmpleadoID 

	select @@ROWCOUNT
END
