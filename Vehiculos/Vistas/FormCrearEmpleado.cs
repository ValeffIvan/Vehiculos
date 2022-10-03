using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vehiculos.Control;

namespace Vehiculos.Vistas
{
    public partial class FormCrearEmpleado : Form
    {
        ControlEmpleados controlEmpleados = new ControlEmpleados();
        public FormCrearEmpleado()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_CrearEmpleado_Click(object sender, EventArgs e)
        {
            controlEmpleados.AgregarEmpleado(txt_Nombre.Text, txt_Apellido.Text, mkbox_DNI.Text, txt_Email.Text,
                                             mkbox_Telefono.Text, txt_Marca.Text, txt_Modelo.Text, txt_anio.Text,
                                             txt_patente.Text);
        }
    }
}
