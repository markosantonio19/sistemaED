using Logica;
using Logica1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        private LEstudiantes estudiante = new LEstudiantes();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.addImg.CargarImagen(pictureBoxImage);
        }

        private void txtC_I_TextChanged(object sender, EventArgs e)
        {
            if(txtC_I.Text.Equals(""))
            {
                labelbtnC_i.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelbtnC_i.ForeColor = Color.Green;
            }
        }

        private void txtC_I_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
