using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Modelo
{
    internal class Empleado
    {
        public int id { get; set; }
        public DatosPersonales datosPersonales { get; set; }
        public Auto auto { get; set; }
        public Registro registro { get; set; }
    }
}
