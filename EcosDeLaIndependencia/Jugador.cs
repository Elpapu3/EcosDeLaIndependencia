using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EcosDeLaIndependencia

{
    internal class Jugador
    {
        public int X { get; set; }
        public int Y { get; set; }


        public Jugador() {
            Y = 50;
            X = 50;
        }

        public void Mover(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }


    }
}
