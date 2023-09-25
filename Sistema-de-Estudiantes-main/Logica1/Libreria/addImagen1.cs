using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica1.Libreria
{
    public class addImagen1
    {
        private OpenFileDialog df = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnload a true significa que la imagen se carga de forma sincronica
            pictureBox.WaitOnLoad = true;
            df.Filter = "Imagenes|*.jpg;*.gif;*.bmp"; //tipos de archivos en la que vamos a filtrar
            df.ShowDialog();
            if (df.FileName != string.Empty)
            {
                pictureBox.ImageLocation = df.FileName;
            }
        }
    }
}
