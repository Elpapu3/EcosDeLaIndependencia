using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosDeLaIndependencia
{
    internal class Obstaculo
    {
        public Rectangle Area { get; set; }
        public TipoObstaculos Tipo { get; set; }

        public PictureBox Img { get; set; }

        public Obstaculo(int x, int y, int ancho, int alto, TipoObstaculos tipo)
        {
            Area = new Rectangle(x, y, ancho, alto);
            Tipo = tipo; 


            Img = new PictureBox();
            Img.Location = new Point(x, y);
            Img.Size = new Size(ancho, alto);
            Img.BackColor = Color.Red;
        }

  
    }
}
