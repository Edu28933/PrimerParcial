
-- =============================================
-- Author:      Eduardo Solares
-- Create date: 1/3/2025
-- Description: Mostrar
-- =============================================
create PROCEDURE usp_Empleados_mostrar
AS
BEGIN
    SET NOCOUNT ON;

    Select 
        EmpleadoID as 'Empleado ID',
        Nombre,
        Apellido,
        FechaNacimiento,
        FechaContratacion,
        DepartamentoID,
		PuestoTrabajo,
		Salario,
		Estado
    from tblEmpleados;
END
