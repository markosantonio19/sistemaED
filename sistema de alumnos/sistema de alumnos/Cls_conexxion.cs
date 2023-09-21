using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace sistema_de_alumnos
{
    internal class Cls_conexxion
    {
        SqlCommand command;
        SqlDataAdapter reader;
        SqlConnection sqlcom;

        public Cls_conexxion()
        {

            sqlcom = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ALUMNO\\Documents\\autenticar.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public SqlConnection sql_conectar()
        {

            try
            {
                sqlcom.Open();
            }
            catch
            {
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


        }

        public bool Validar(string user, string password)
        {
            bool valido = false;

            // Usar parámetros en lugar de concatenación de cadenas para prevenir SQL Injection
            string query = "SELECT nombre, clave FROM db.usuario WHERE nombre = @Usuario AND clave = @Clave";

            using (SqlConnection connection = sql_conectar())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros para evitar SQL Injection
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Clave", password);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            valido = true;
                        }
                    }
                }
            }

            return valido;
        }
    }
}