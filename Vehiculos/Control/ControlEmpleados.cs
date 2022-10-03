using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Control
{
    internal class ControlEmpleados
    {
        public string AgregarEmpleado(string nombre, string apellido, string DNI, string email, string telefono,
                                      string marca, string modelo, string anio, string patente)
        {
            if (CorroborarEmpleado(nombre,  apellido,  DNI,  email, telefono, marca, modelo, anio,  patente))
            {

            }
            return "";
        }

        public bool CorroborarEmpleado(string nombre, string apellido, string DNI, string email, string telefono,
                                      string marca, string modelo, string anio, string patente)
        {

        }

    }
}
