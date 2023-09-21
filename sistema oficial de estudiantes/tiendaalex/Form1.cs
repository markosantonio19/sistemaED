using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TiendaGATO
{
    public partial class Form1 : Form
    {   

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.Conectar();
            MessageBox.Show("La conexcion fue exitosa");
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Conectar();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM trabajadores WHERE Usuario = '" + textBox1.Text +"' AND contraseña = '"+ textBox2.Text+"'",conexion.Conectar());

            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    new Form2().Show();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                }
            }
            else
            {
                MessageBox.Show("Acceso Denegado");
            }
        }

    }
}
