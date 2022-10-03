using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Control
{
    internal class ControlAutos
    {
        public Auto CrearAuto (string marca, string modelo, int anio, string patente)
        {
            return new Auto(marca, modelo, anio, patente);
        }
    }
}
