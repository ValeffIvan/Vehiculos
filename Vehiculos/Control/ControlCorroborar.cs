using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos.Modelo;

namespace Vehiculos.Control
{
    internal class ControlCorroborar
    {
        public Empleado CorroborarEmpleado(string nombre, string apellido, string DNI, string email, string telefono,
                              string marca, string modelo, string anio, string patente)
        {
            if (nombre=="" || nombre.Any(char.IsDigit) || apellido=="" || apellido.Any(char.IsDigit) || !(DNI.Any(char.IsDigit)) ||
                email=="" || !(email.Contains("@")) || telefono =="" || !(telefono.Any(char.IsDigit)) || marca=="" || modelo=="" ||
                anio=="" || !(anio.Any(char.IsDigit)) || patente=="")
            {
                return null;
            }
            else
            {
                Empleado empleado = new Empleado();
            }
        }
    }
}
