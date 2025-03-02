-- =============================================
-- Author:		Eduardo Solares
-- Create date: 01/03/2025
-- Description:	stored porcedure Eliminar
-- =============================================
create procedure usp_Empleados_Eliminar
( 
@EmpleadoID int 

)
AS
BEGIN
	SET NOCOUNT ON; 

	Delete tblEmpleados 
	where EmpleadoID = @EmpleadoID

	select @@ROWCOUNT
END

select * from tblEmpleados;