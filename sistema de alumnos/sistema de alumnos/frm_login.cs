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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cls_conexxion conexxion = new Cls_conexxion();  
            if (conexxion.Validar(textBox1.Text, textBox2.Text) == true) 
            {
                this.Hide();
                Frm_menu principal = new Frm_menu();    
                principal.Show();
            }
            else
            {
                MessageBox.Show("usuario o contraseñas  incorrectos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }
    }
}
