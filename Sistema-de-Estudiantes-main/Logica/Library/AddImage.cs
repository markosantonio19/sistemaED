using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class AddImage
    {

        private OpenFileDialog fd = new OpenFileDialog();

        public void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnload a true significa que la imagen se carga de forma sincronica
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"; //tipos de archivos con la que vamos a filtrar
            fd.ShowDialog();
            if(fd.FileName != string.Empty)     // preguntamos si la imagen seleccionada es distinto a vacio 
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
    }
}
