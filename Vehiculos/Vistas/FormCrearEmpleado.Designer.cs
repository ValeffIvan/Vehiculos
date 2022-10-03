namespace Vehiculos.Vistas
{
    partial class FormCrearEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Apellido = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_anio = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_CrearEmpleado = new System.Windows.Forms.Button();
            this.mkbox_DNI = new System.Windows.Forms.MaskedTextBox();
            this.mkbox_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.mkbox_anio = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mkbox_Telefono);
            this.panel1.Controls.Add(this.mkbox_DNI);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_Apellido);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 288);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(30, 141);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(138, 20);
            this.txt_Email.TabIndex = 3;
            // 
            // txt_Apellido
            // 
            this.txt_Apellido.Location = new System.Drawing.Point(30, 92);
            this.txt_Apellido.Name = "txt_Apellido";
            this.txt_Apellido.Size = new System.Drawing.Size(138, 20);
            this.txt_Apellido.TabIndex = 2;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(30, 42);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(138, 20);
            this.txt_Nombre.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mkbox_anio);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txt_anio);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_patente);
            this.panel2.Controls.Add(this.txt_Modelo);
            this.panel2.Controls.Add(this.txt_Marca);
            this.panel2.Location = new System.Drawing.Point(272, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 260);
            this.panel2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Patente";
            // 
            // txt_anio
            // 
            this.txt_anio.AutoSize = true;
            this.txt_anio.Location = new System.Drawing.Point(32, 142);
            this.txt_anio.Name = "txt_anio";
            this.txt_anio.Size = new System.Drawing.Size(26, 13);
            this.txt_anio.TabIndex = 17;
            this.txt_anio.Text = "Año";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Marca";
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(35, 205);
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(138, 20);
            this.txt_patente.TabIndex = 9;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(35, 109);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(138, 20);
            this.txt_Modelo.TabIndex = 7;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(35, 59);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(138, 20);
            this.txt_Marca.TabIndex = 6;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Location = new System.Drawing.Point(55, 306);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(138, 70);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_CrearEmpleado
            // 
            this.btn_CrearEmpleado.Location = new System.Drawing.Point(298, 294);
            this.btn_CrearEmpleado.Name = "btn_CrearEmpleado";
            this.btn_CrearEmpleado.Size = new System.Drawing.Size(158, 82);
            this.btn_CrearEmpleado.TabIndex = 11;
            this.btn_CrearEmpleado.Text = "Agregar";
            this.btn_CrearEmpleado.UseVisualStyleBackColor = true;
            this.btn_CrearEmpleado.Click += new System.EventHandler(this.btn_CrearEmpleado_Click);
            // 
            // mkbox_DNI
            // 
            this.mkbox_DNI.Location = new System.Drawing.Point(30, 240);
            this.mkbox_DNI.Mask = "99999999";
            this.mkbox_DNI.Name = "mkbox_DNI";
            this.mkbox_DNI.Size = new System.Drawing.Size(138, 20);
            this.mkbox_DNI.TabIndex = 20;
            this.mkbox_DNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkbox_DNI.ValidatingType = typeof(int);
            // 
            // mkbox_Telefono
            // 
            this.mkbox_Telefono.Location = new System.Drawing.Point(30, 188);
            this.mkbox_Telefono.Mask = "(999)000-0000";
            this.mkbox_Telefono.Name = "mkbox_Telefono";
            this.mkbox_Telefono.Size = new System.Drawing.Size(138, 20);
            this.mkbox_Telefono.TabIndex = 21;
            this.mkbox_Telefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mkbox_anio
            // 
            this.mkbox_anio.Location = new System.Drawing.Point(35, 158);
            this.mkbox_anio.Mask = "00/00/0000";
            this.mkbox_anio.Name = "mkbox_anio";
            this.mkbox_anio.Size = new System.Drawing.Size(138, 20);
            this.mkbox_anio.TabIndex = 22;
            this.mkbox_anio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mkbox_anio.ValidatingType = typeof(System.DateTime);
            // 
            // FormCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 386);
            this.Controls.Add(this.btn_CrearEmpleado);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrearEmpleado";
            this.Text = "Crear Empleado";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Apellido;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_anio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_CrearEmpleado;
        private System.Windows.Forms.MaskedTextBox mkbox_Telefono;
        private System.Windows.Forms.MaskedTextBox mkbox_DNI;
        private System.Windows.Forms.MaskedTextBox mkbox_anio;
    }
}