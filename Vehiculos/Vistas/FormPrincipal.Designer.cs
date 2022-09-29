namespace Vehiculos
{
    partial class FormPrincipal
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
            this.btn_CrearCliente = new System.Windows.Forms.Button();
            this.btn_CrearEmpleado = new System.Windows.Forms.Button();
            this.btn_ListarCliente = new System.Windows.Forms.Button();
            this.btn_ListarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CrearCliente
            // 
            this.btn_CrearCliente.Location = new System.Drawing.Point(46, 26);
            this.btn_CrearCliente.Name = "btn_CrearCliente";
            this.btn_CrearCliente.Size = new System.Drawing.Size(216, 75);
            this.btn_CrearCliente.TabIndex = 1;
            this.btn_CrearCliente.Text = "Crear Cliente";
            this.btn_CrearCliente.UseVisualStyleBackColor = true;
            // 
            // btn_CrearEmpleado
            // 
            this.btn_CrearEmpleado.Location = new System.Drawing.Point(46, 136);
            this.btn_CrearEmpleado.Name = "btn_CrearEmpleado";
            this.btn_CrearEmpleado.Size = new System.Drawing.Size(216, 75);
            this.btn_CrearEmpleado.TabIndex = 2;
            this.btn_CrearEmpleado.Text = "Crear Empleado";
            this.btn_CrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // btn_ListarCliente
            // 
            this.btn_ListarCliente.Location = new System.Drawing.Point(46, 246);
            this.btn_ListarCliente.Name = "btn_ListarCliente";
            this.btn_ListarCliente.Size = new System.Drawing.Size(216, 75);
            this.btn_ListarCliente.TabIndex = 3;
            this.btn_ListarCliente.Text = "Listar Cliente";
            this.btn_ListarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_ListarEmpleado
            // 
            this.btn_ListarEmpleado.Location = new System.Drawing.Point(46, 345);
            this.btn_ListarEmpleado.Name = "btn_ListarEmpleado";
            this.btn_ListarEmpleado.Size = new System.Drawing.Size(216, 75);
            this.btn_ListarEmpleado.TabIndex = 4;
            this.btn_ListarEmpleado.Text = "Listar  Empleado";
            this.btn_ListarEmpleado.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 445);
            this.Controls.Add(this.btn_ListarEmpleado);
            this.Controls.Add(this.btn_ListarCliente);
            this.Controls.Add(this.btn_CrearEmpleado);
            this.Controls.Add(this.btn_CrearCliente);
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_CrearCliente;
        private System.Windows.Forms.Button btn_CrearEmpleado;
        private System.Windows.Forms.Button btn_ListarCliente;
        private System.Windows.Forms.Button btn_ListarEmpleado;
    }
}

