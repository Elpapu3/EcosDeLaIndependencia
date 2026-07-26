using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//BISCAR UN COLOR MAS LLAMATIVO, Y UN TIPO DE LETRA QUE NOSEA ARIAL , QUEDA MUY PLANOdr
namespace EcosDeLaIndependencia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            this.Size = new Size(1120, 720);// tamaño de la pantalla

            EstiloBotones(button1, "Jugar");
            EstiloBotones(button2, "Multijugador");
            EstiloBotones(button3, "Configuraciones");
            EstiloBotones(button4, "Salir");
  
            CentrarPanel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void EstiloBotones(Button boton, string text) {
            boton.Text = text;
            boton.Size = new Size(250, 60);
            boton.FlatStyle = FlatStyle.Flat; //a revision, por el moemnto yo lo dejaria asi, no le da el relieve al boton 
            boton.FlatAppearance.BorderSize = 0;
            boton.BackColor = Color.Transparent;
            boton.ForeColor = Color.Gold;
            boton.Font = new Font("Arial", 20, FontStyle.Bold);
            boton.FlatAppearance.MouseOverBackColor = Color.Transparent;//
            // ESTOS DOS PORQUE NO ME GUSTA EL EFECTO AL PRECIONAR LS BOTTENES, REVISSAR SI SE PUEDE HACER EL EFECTO EN SOLO EL TEXTO Y NO EN TODO EL BOYON 
            boton.FlatAppearance.MouseDownBackColor = Color.Transparent;  // esto no andaba, si vuelve a pasar que pones una imagen y no te carga. fijarse las propiedades de la igen (copiar siempre)
        }

        private void CentrarPanel()
        {
            this.Size = new Size(1120, 720);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Menu_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }
    }
}
