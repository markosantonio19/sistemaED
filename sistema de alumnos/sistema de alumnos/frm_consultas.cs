using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sistema_de_alumnos
{
    public partial class frm_consultas : Form
    {
        public frm_consultas()
        {
            InitializeComponent();
        }
        Cls_datos datos = new Cls_datos();


        public string TxtBuscar { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            

            dataGridView1   .DataSource = datos.sql_consultas("usuario", "codigo as Codigo,nombre as Nombre ,apellido as Apellido, matricula as Matricula", "nombre" + TxtBuscar + "'or apellidos" + TxtBuscar + "");

        }
    }
}