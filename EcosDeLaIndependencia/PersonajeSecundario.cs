using System;
using System.Drawing;
using System.Windows.Forms;

namespace EcosDeLaIndependencia
{
    internal class PersonajeSecundario
    {
        public string Nombre { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public PictureBox Img { get; set; }

        public Rectangle Area { get; set; }

        public PersonajeSecundario(string nombre, int x, int y)
        {
            Nombre = nombre;
            X = x;
            Y = y;

            Img = new PictureBox();
            Img.Size = new Size(40, 40);
            Img.BackColor = Color.Green;
            Img.Location = new Point(X, Y);

            Area = new Rectangle(x, y, 40, 40);
        }
    }
}