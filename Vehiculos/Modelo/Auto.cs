using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    internal class Auto
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int anio { get; set; }
        public string patente { get; set; }

        public Auto (string marca, string modelo, int anio, string patente)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
            this.patente = patente;
        }
    }
}
