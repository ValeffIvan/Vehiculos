using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehiculos.Data;
using Vehiculos.Modelo;

namespace Vehiculos.Control
{
    internal class ControlEmpleados
    {
        DataEmpleados dataEmpleado = new DataEmpleados();
        ControlCorroborar controlCorroborar = new ControlCorroborar();
        public string AgregarEmpleado(string nombre, string apellido, string DNI, string email, string telefono,
                                      string marca, string modelo, string anio, string patente)
        {
            Empleado empleadoAux= controlCorroborar.CorroborarEmpleado(nombre, apellido, DNI, email, 
                                                                       telefono, marca, modelo, anio, patente);
            if (empleadoAux == null)
            {
                return "Datos erroneos";
            }
            else
            {
                dataEmpleado.Agregar(empleadoAux);
                return "Empleado cargado con exito";
            }
        }

    }
}
