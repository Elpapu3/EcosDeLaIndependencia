using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosDeLaIndependencia
{
    public partial class Juego : Form
    {
        private Jugador jugador;
        private PictureBox personaje;

        public Juego()
        {
            InitializeComponent();
            CrearJugador();
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void CrearJugador() {
            jugador = new Jugador();

            personaje = new PictureBox();
            personaje.Size = new Size(40, 40);
            personaje.BackColor = Color.Blue;
            personaje.Location = new Point(jugador.X, jugador.Y);

            this.Controls.Add(personaje);
        }
          
    }
}
