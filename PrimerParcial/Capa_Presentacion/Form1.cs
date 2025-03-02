using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 200)
            {
                panelMenu.Width = 40;
            }
            else
            {
                panelMenu.Width = 200;
            }
        }

        private void btnFrmEstudiante_Click(object sender, EventArgs e)
        {
            Empleados estudiantes = new Empleados();
            

            estudiantes.TopLevel = false;
            estudiantes.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(estudiantes);
            this.panelContenedor.Tag = estudiantes;
            estudiantes.Show();
        }
    }
}
