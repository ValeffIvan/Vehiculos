using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos.Modelo;

namespace Vehiculos.Control
{
    internal class ControlDatosPersonales
    {
        public DatosPersonales CrearDatosPersonales (string nombre, string apellido, string email, string telefono,string dni)
        {
            return new DatosPersonales(nombre, apellido, email, telefono, dni);
        }
    }
}
