
-- =============================================
-- Author:		Eduardo Solares
-- Create date: 1/32025
-- Description:	crear 
-- =============================================
CREATE PROCEDURE usp_Empleados_crear 
	
	( 
	@Nombre varchar (50),  
	@Apellido varchar (50),  
	@FechaNacimiento DATETIME,   
	@FechaContratacion DATETIME,
	@DepartamentoID Int,
	@PuestoTrabajo varchar (100),
	@Salario decimal(10,2),
	@Estado varchar (50)
	) 
AS
BEGIN
	SET NOCOUNT ON; 
	Insert into tblEmpleados
	(  
		Nombre,
        Apellido,
        FechaNacimiento,
        FechaContratacion,
        DepartamentoID,
		PuestoTrabajo,
		Salario,
		Estado
	) 
	values 
	( 
		@Nombre,
        @Apellido,
        @FechaNacimiento,
        @FechaContratacion,
        @DepartamentoID,
		@PuestoTrabajo,
		@Salario,
		@Estado
	)  

	select @@ROWCOUNT
END
GO

select * from tblEmpleados;