using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection AbrirConexion()
        {
            try
            {
                SqlConnection con = new SqlConnection("data source = DESKTOP-DM21I2P; initial catalog = CrudPersonas ; integrated security = true");
                con.Open();
                return con;
            }
            catch(Exception ex)
            {
                throw new Exception("No se ha podido establecer la conexion a base de datos");
            }
        }

    }
}
