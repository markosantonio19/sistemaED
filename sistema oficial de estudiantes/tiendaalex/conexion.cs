using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TiendaGATO
{
    internal class conexion
    {
        public static SqlConnection Conectar()
        { 
            SqlConnection cn = new SqlConnection("SERVER=DESKTOP-7LDGQBD;DATABASE=Tienda;integrated security=true;");

            cn.Open();
            return cn;
        }
    }
}
