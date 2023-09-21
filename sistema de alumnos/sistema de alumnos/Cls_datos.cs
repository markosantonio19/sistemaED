using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace sistema_de_alumnos
{
    internal class Cls_datos:Cls_conexxion
    {
        string query = "";
        SqlCommand comand;
        Cls_conexxion conexxion = new Cls_conexxion();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;


        public  DataTable sql_consultas(string tabla, string campos, string condicion)
        {
            query= "SELECT "+ tabla + "FROM " + campos + "WHERE " + condicion ;
            try
            {
                adapter = new SqlDataAdapter(query, conexxion.sql_conectar());
                adapter.Fill(ds, "TDATOS");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            return ds.Tables["TDATOS"];
        }

    }
}
