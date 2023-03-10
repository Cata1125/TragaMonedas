using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica29
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)

        {
            if (txtNombre.Text.Length == 0 || txtApellidos.Text.Length == 0 || txtMonedas.Text.Length == 0)
            {
                MessageBox.Show("Ingrese datos completos");
            }
            else
            {
                Jugador usuario = new Jugador();
                usuario.Monedas = int.Parse(txtMonedas.Text);
                Form1 juego = new Form1();
                juego.agregarJugador(usuario);
                juego.Visible = true;
            }
        }
                
    }
}
