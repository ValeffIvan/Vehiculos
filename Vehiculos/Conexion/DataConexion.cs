using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Conexion
{
    internal class DataConexion
    {
        SqlConnection cnn = new SqlConnection("Data Source=192.168.0.29; Initial Catalog=u2;User ID=u2;Password=u2");
       
        public void Abrir() 
        {
            cnn.Open(); 
        }
        public void Cerrar() 
                             
        {
            cnn.Close(); 
        }
        public SqlConnection Conexion() 
        {
            return cnn;
        }

    }
}
