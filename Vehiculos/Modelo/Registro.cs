using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Modelo
{
    internal class Registro
    {
        public int id { get; set; }
        public TipoRegistro tipoRegistro { get; set; }
        public DateTime fechaVencimiento { get; set; }
    }
}
