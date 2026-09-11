using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EcosDeLaIndependencia.TipoObstaculos;

namespace EcosDeLaIndependencia
{
    public partial class Juego : Form
    {
        private Jugador jugador;
        private PictureBox personaje;
        private List<Obstaculo> obstaculos;
        private PersonajeSecundario npc;
        public Juego()
        {
            InitializeComponent();
            CrearJugador();
            ConfigurarControles();
            CargarObstaculos();
            CrearNPC();
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void CrearJugador()
        {
            jugador = new Jugador();

            personaje = new PictureBox();
            personaje.Size = new Size(40, 40);
            personaje.BackColor = Color.Blue;
            personaje.Location = new Point(jugador.X, jugador.Y);

            this.Controls.Add(personaje);
        }
        private void ConfigurarControles()
        {
            this.KeyPreview = true;
            this.KeyDown += Juego_KeyDown;
            /// usar despues this.KeyUp += Juego_KeyUP;
        }
        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            int velocidad = 10; //PIXELS QUE SE MUEVEN, MAZZONE REVISA ESTO PQ NO JUEGUE POQUEMON , ASI ESTA BEIN 
            // RECORDAS, SIEMPRE LO HAGO ALREVES: 
            //X AUMENTA HACIA LA DERECHA
            // Y AUMENTA HACIA ABAJO
            // 
            int movimientoX = 0;
            int movimientoY = 0;

            if (e.KeyCode == Keys.W)
                movimientoY = -velocidad;

            if (e.KeyCode == Keys.S)
                movimientoY = velocidad;

            if (e.KeyCode == Keys.A)
                movimientoX = -velocidad;

            if (e.KeyCode == Keys.D)
                movimientoX = velocidad;
            personaje.Location = new Point(jugador.X, jugador.Y);


            Rectangle futuraPosicion = new Rectangle(
                jugador.X + movimientoX,
                jugador.Y + movimientoY,
                personaje.Width,
                personaje.Height
            );
            bool colision = false;
            foreach (Obstaculo o in obstaculos)
            {
                if (futuraPosicion.IntersectsWith(o.Area))
                {
                    colision = true;
                    break;
                }
            }
            // me equivo que aqui lo ponemos antes oporque es para que lea la colicion
            if (futuraPosicion.IntersectsWith(npc.Area))
            {
                colision = true;
            }

            if (!colision)
            {
                jugador.Mover(movimientoX, movimientoY);
                personaje.Location = new Point(jugador.X, jugador.Y);
            }


        }
        private void Juego_KeyUp(object sender, KeyEventArgs e)
        {

        }

        //cargar obstaculos, investigar si nos conviene mantener todo aqui o mejor hacerlo en otra clase 
        private void CargarObstaculos()
        {
            obstaculos = new List<Obstaculo>();

            obstaculos.Add(new Obstaculo(100, 100, 40, 40, TipoObstaculos.Casa));
            obstaculos.Add(new Obstaculo(300, 200, 80, 40, TipoObstaculos.Cerca));

            foreach (Obstaculo o in obstaculos) // recocrrer los elementos de una coleccion
            {
                this.Controls.Add(o.Img);
            }


        }
        private void CrearNPC() {
            npc = new PersonajeSecundario("Moreno", 200, 150);
            this.Controls.Add(npc.Img);
        }

    }


}
