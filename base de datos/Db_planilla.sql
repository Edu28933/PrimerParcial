-- Crear la base de datos
CREATE DATABASE db_planilla;
GO

-- Usar la base de datos creada
USE db_planilla;
GO

-- Tabla de Departamentos
CREATE TABLE tblDepartamentos (
    DepartamentoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Estado NVARCHAR(50)
);
GO

-- Tabla de Empleados
CREATE TABLE tblEmpleados (
    EmpleadoID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Apellido NVARCHAR(100) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    FechaContratacion DATE NOT NULL,
    DepartamentoID INT,
    PuestoTrabajo NVARCHAR(100) NOT NULL,
    Salario DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(50) NOT NULL,
    FOREIGN KEY (DepartamentoID) REFERENCES tblDepartamentos(DepartamentoID)
);
GO

-- Tabla de Pagos
CREATE TABLE tblPagos (
    PagoID INT PRIMARY KEY IDENTITY(1,1),
    EmpleadoID INT,
    FechaPago DATE NOT NULL,
    Monto DECIMAL(18, 2) NOT NULL,
    CantidadHorasExtras INT NOT NULL DEFAULT 0,
    MontoHorasExtras DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    DescuentoImpuesto DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    DescuentoIGSS DECIMAL(18, 2) NOT NULL DEFAULT 0.00,
    SalarioNeto DECIMAL(18, 2) NOT NULL,
    Estado NVARCHAR(50) NOT NULL,
    FOREIGN KEY (EmpleadoID) REFERENCES tblEmpleados(EmpleadoID)
);

