namespace Capa_Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFrmNotas = new System.Windows.Forms.Button();
            this.btnFrmCarreras = new System.Windows.Forms.Button();
            this.btnFrmEstudiante = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Blue;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 72);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer Parcial";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Blue;
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnFrmNotas);
            this.panelMenu.Controls.Add(this.btnFrmCarreras);
            this.panelMenu.Controls.Add(this.btnFrmEstudiante);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 72);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(193, 537);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Blue;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 500);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(193, 37);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnFrmNotas
            // 
            this.btnFrmNotas.BackColor = System.Drawing.Color.Blue;
            this.btnFrmNotas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmNotas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFrmNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFrmNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmNotas.ForeColor = System.Drawing.Color.White;
            this.btnFrmNotas.Location = new System.Drawing.Point(0, 74);
            this.btnFrmNotas.Name = "btnFrmNotas";
            this.btnFrmNotas.Size = new System.Drawing.Size(193, 37);
            this.btnFrmNotas.TabIndex = 2;
            this.btnFrmNotas.Text = "Pagos";
            this.btnFrmNotas.UseVisualStyleBackColor = false;
            // 
            // btnFrmCarreras
            // 
            this.btnFrmCarreras.BackColor = System.Drawing.Color.Blue;
            this.btnFrmCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmCarreras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFrmCarreras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFrmCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmCarreras.ForeColor = System.Drawing.Color.White;
            this.btnFrmCarreras.Location = new System.Drawing.Point(0, 37);
            this.btnFrmCarreras.Name = "btnFrmCarreras";
            this.btnFrmCarreras.Size = new System.Drawing.Size(193, 37);
            this.btnFrmCarreras.TabIndex = 1;
            this.btnFrmCarreras.Text = "Departamentos";
            this.btnFrmCarreras.UseVisualStyleBackColor = false;
            // 
            // btnFrmEstudiante
            // 
            this.btnFrmEstudiante.BackColor = System.Drawing.Color.Blue;
            this.btnFrmEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFrmEstudiante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnFrmEstudiante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFrmEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmEstudiante.ForeColor = System.Drawing.Color.White;
            this.btnFrmEstudiante.Location = new System.Drawing.Point(0, 0);
            this.btnFrmEstudiante.Name = "btnFrmEstudiante";
            this.btnFrmEstudiante.Size = new System.Drawing.Size(193, 37);
            this.btnFrmEstudiante.TabIndex = 0;
            this.btnFrmEstudiante.Text = "Empleados";
            this.btnFrmEstudiante.UseVisualStyleBackColor = false;
            this.btnFrmEstudiante.Click += new System.EventHandler(this.btnFrmEstudiante_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(193, 72);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(773, 537);
            this.panelContenedor.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 609);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnFrmEstudiante;
        private System.Windows.Forms.Button btnFrmNotas;
        private System.Windows.Forms.Button btnFrmCarreras;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnSalir;
    }
}

