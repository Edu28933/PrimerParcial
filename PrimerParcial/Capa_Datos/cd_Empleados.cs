using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class cd_Empleados
    {

        CD_Conexion db_conexion = new CD_Conexion();

        public DataTable MtMostrarEstudiantes()
        {
            string QryMostrarEmpleados = "usp_Empleados_mostrar";
            SqlDataAdapter adapter = new SqlDataAdapter(QryMostrarEmpleados, db_conexion.MtdAbrirConexion());
            DataTable dtMostrarEmpleados = new DataTable();
            adapter.Fill(dtMostrarEmpleados);
            db_conexion.MtdCerrarConexion();
            return dtMostrarEmpleados;
        }


        public void CP_mtdCrearEmpleados(string nombre, string apellido, DateTime FechaNacimiento, DateTime FechaContratacion, int DeptoID, string Puesto, double Salario, string Estado)
        {
            string Usp_Crear = "usp_Empleados_crear";
            SqlCommand cmd_InsertarEstudiantes = new SqlCommand(Usp_Crear, db_conexion.MtdAbrirConexion());
            cmd_InsertarEstudiantes.CommandType = CommandType.StoredProcedure;


            cmd_InsertarEstudiantes.Parameters.AddWithValue("@Nombre", nombre);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@Apellido", apellido);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@DepartamentoID", DeptoID);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@PuestoTrabajo", Puesto);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@Salario", Salario);
            cmd_InsertarEstudiantes.Parameters.AddWithValue("@Estado", Estado);
            cmd_InsertarEstudiantes.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();

        }

      

        public void MtdActualizarEmpleados(int EmpleadoId, string nombre, string apellido, DateTime FechaNacimiento, DateTime FechaContratacion, int DeptoID, string Puesto, double Salario, string Estado)
        {

            String usp_actualizar = "usp_Empleado_editar";

            SqlCommand cmduspActualizar = new SqlCommand(usp_actualizar, db_conexion.MtdAbrirConexion());

            cmduspActualizar.CommandType = CommandType.StoredProcedure;

            cmduspActualizar.Parameters.AddWithValue("@EmpleadoID", EmpleadoId);

            cmduspActualizar.Parameters.AddWithValue("@Nombre", nombre);
            cmduspActualizar.Parameters.AddWithValue("@Apellido", apellido);
            cmduspActualizar.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento);
            cmduspActualizar.Parameters.AddWithValue("@FechaContratacion", FechaContratacion);
            cmduspActualizar.Parameters.AddWithValue("DepartamentoID", DeptoID);
            cmduspActualizar.Parameters.AddWithValue("@PuestoTrabajo", Puesto);
            cmduspActualizar.Parameters.AddWithValue("@Salario", Salario);
            cmduspActualizar.Parameters.AddWithValue("@Estado", Estado);
            cmduspActualizar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }

        public void MtdEliminarEstudiantes(int EmpleadoId)
        {

            String usp_eliminar = "usp_Empleado_eliminar";

            SqlCommand cmduspeliminar = new SqlCommand(usp_eliminar, db_conexion.MtdAbrirConexion());

            cmduspeliminar.CommandType = CommandType.StoredProcedure;

            cmduspeliminar.Parameters.AddWithValue("@EmpleadoID", EmpleadoId);


            cmduspeliminar.ExecuteNonQuery();

            db_conexion.MtdCerrarConexion();


        }







    }

}
