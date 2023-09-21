using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace sistema_de_alumnos
{
    internal class Cls_conexxion
    {
        SqlCommand command;
        SqlDataAdapter reader;
        SqlConnection sqlcom;

        public Cls_conexxion() {

            sqlcom = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ALUMNO\\Documents\\autenticar.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public SqlConnection sql_conectar()
        {

        try{
            sqlcom.Open();   
        }
            catch { 
        }
            return sqlcom;
    }
        public void sql_desconectar()
        {
            try
            {
                sqlcom.Close();
            } 
            catch { }

            public bool validar(string user , string password)
            {

                bool valido = false;    
                string query =@"SELECT nombre, clave from db.usuario"
            }
        }   

}
