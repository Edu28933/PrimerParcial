

INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Recursos Humanos', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Contabilidad', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Tecnología', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Marketing', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Ventas', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Operaciones', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Atención al Cliente', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Desarrollo', 'Inactivo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Logística', 'Activo');
INSERT INTO tblDepartamentos (Nombre, Estado) VALUES ('Investigación y Desarrollo', 'Inactivo');
GO

INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Juan', 'Pérez', '1985-05-10', '2020-01-15', 1, 'Gerente', 3000.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('María', 'González', '1990-02-20', '2019-03-10', 2, 'Contadora', 2500.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Luis', 'Fernández', '1982-08-15', '2021-06-01', 3, 'Desarrollador', 4000.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Ana', 'Martínez', '1995-12-30', '2022-01-20', 4, 'Especialista en Marketing', 2800.00, 'Inactivo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Carlos', 'López', '1988-09-12', '2020-05-15', 5, 'Vendedor', 2200.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Laura', 'Torres', '1993-07-25', '2021-04-10', 6, 'Coordinadora', 3500.00, 'Inactivo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Pedro', 'Ramírez', '1980-11-05', '2018-09-30', 7, 'Atención al Cliente', 2000.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Sofía', 'Hernández', '1991-03-18', '2022-08-01', 8, 'Ingeniera', 4500.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Diego', 'Mendoza', '1984-10-22', '2019-07-25', 9, 'Logística', 2300.00, 'Activo');
INSERT INTO tblEmpleados (Nombre, Apellido, FechaNacimiento, FechaContratacion, DepartamentoID, PuestoTrabajo, Salario, Estado) 
VALUES ('Valeria', 'Sánchez', '1992-01-01', '2023-02-15', 10, 'Investigadora', 3800.00, 'Inactivo');
GO

INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (1, '2023-01-31', 3000.00, 5, 200.00, 300.00, 150.00, 2750.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (2, '2023-01-31', 2500.00, 2, 80.00, 250.00, 120.00, 2210.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (3, '2023-01-31', 4000.00, 4, 160.00, 400.00, 200.00, 3560.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (4, '2023-01-31', 2800.00, 3, 120.00, 280.00, 140.00, 2500.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (5, '2023-01-31', 2200.00, 1, 40.00, 220.00, 110.00, 1910.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (6, '2023-01-31', 3500.00, 6, 240.00, 350.00, 175.00, 3175.00, 'Inactivo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (7, '2023-01-31', 2000.00, 2, 80.00, 200.00, 100.00, 1820.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (8, '2023-01-31', 4500.00, 5, 200.00, 450.00, 225.00, 4025.00, 'Inactivo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (9, '2023-01-31', 2300.00, 3, 120.00, 230.00, 115.00, 2075.00, 'Activo');
INSERT INTO tblPagos (EmpleadoID, FechaPago, Monto, CantidadHorasExtras, MontoHorasExtras, DescuentoImpuesto, DescuentoIGSS, SalarioNeto, Estado) 
VALUES (10, '2023-01-31', 3800.00, 4, 160.00, 380.00, 190.00, 3430.00, 'Activo');

