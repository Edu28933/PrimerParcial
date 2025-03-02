using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }


        public void MtdMostrarEmpleados()
        {
            cd_Empleados cd_Estudiantes = new cd_Empleados();
            DataTable dtMostrarEstudiantes = cd_Estudiantes.MtMostrarEstudiantes();
            dgvEstudiantes.DataSource = dtMostrarEstudiantes;
        }


     


        private void button1_Click(object sender, EventArgs e)
        {
            cd_Empleados cD_Estudiantes = new cd_Empleados();

            try
            {
                cD_Estudiantes.CP_mtdCrearEmpleados(txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNac.Text), DateTime.Parse(txtFechaIns.Text), int.Parse(txtCarrera.Text), txtDireccion.Text, double.Parse(txtSalario.Text), cboxEstado.Text);
                MessageBox.Show("El Estudiante se agrego con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtdCancelar();
                MtdMostrarEmpleados();




            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        







        private void Estudiantes_Load(object sender, EventArgs e)
        {
            MtdMostrarEmpleados();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            cd_Empleados cd_Estudiantes = new cd_Empleados();
            try
            {

                cd_Estudiantes.MtdActualizarEmpleados(int.Parse(txtIdEs.Text), txtNombre.Text, txtApellido.Text, DateTime.Parse(txtFechaNac.Text), DateTime.Parse(txtFechaIns.Text), int.Parse(txtCarrera.Text), txtDireccion.Text, double.Parse(txtSalario.Text), cboxEstado.Text);


                MessageBox.Show("El Estudiante se actualizo con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtdCancelar();
                MtdMostrarEmpleados();
            }


            catch (Exception ex)

            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void dgvEstudiantes_Click(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdEs.Text = dgvEstudiantes.SelectedCells[0].Value.ToString();
            txtNombre.Text = dgvEstudiantes.SelectedCells[1].Value.ToString();
            txtApellido.Text = dgvEstudiantes.SelectedCells[2].Value.ToString();
            txtFechaNac.Text = dgvEstudiantes.SelectedCells[3].Value.ToString();
            txtFechaIns.Text = dgvEstudiantes.SelectedCells[4].Value.ToString();
            txtCarrera.Text = dgvEstudiantes.SelectedCells[5].Value.ToString();
            txtDireccion.Text = dgvEstudiantes.SelectedCells[6].Value.ToString();
            txtSalario.Text = dgvEstudiantes.SelectedCells[7].Value.ToString();
            cboxEstado.Text = dgvEstudiantes.SelectedCells[8].Value.ToString();
        }

        


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                cd_Empleados cd_Estudiantes = new cd_Empleados();

                cd_Estudiantes.MtdEliminarEstudiantes(int.Parse(txtIdEs.Text));

                MessageBox.Show("El Estudiante se elimino con exito", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mtdCancelar();
                MtdMostrarEmpleados();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MtdMostrarEmpleados() ;

            }
        }

        public void mtdCancelar()
        {
            txtIdEs.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtFechaNac.Clear();
            txtFechaIns.Clear();
            txtCarrera.Clear();
            txtDireccion.Clear();
            txtSalario.Clear();
            cboxEstado.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            mtdCancelar();
        }
    }
}
