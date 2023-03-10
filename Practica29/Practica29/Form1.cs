using System;
using System.Windows.Forms;

namespace Practica29
{
    public partial class Form1 : Form
    {
        Jugador jugador = new Jugador();
        int monedas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Practica29.Properties.Resources.picasion1;
            pictureBox2.Image = Practica29.Properties.Resources.picasion_com_8ac51153ed4afdaa0b4e64f55e8811f5;
            pictureBox3.Image = Practica29.Properties.Resources.picasion_com_6f78da5039aa52066420d1f235345e69;


        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            Random posicion = new Random();
            int primero = posicion.Next(6);
            int segundo = posicion.Next(6);
            int tercero = posicion.Next(6);

            pictureBox1.Image = imageList1.Images[primero];
            pictureBox2.Image = imageList1.Images[segundo];
            pictureBox3.Image = imageList1.Images[tercero];
            if (primero == segundo && primero == tercero && segundo == tercero)
            {
                monedas += 2000;
            }
            if (primero == segundo || primero == tercero || segundo == tercero)
            {
                monedas += 1500;

            }
            if (primero != segundo && primero != tercero && segundo!=tercero)
            {
                MessageBox.Show("Perdiste");
                monedas -= 500;
            }

            lblMonedas.Text = "Monedas: " + monedas;
            this.jugador.Monedas = monedas;
       
        }

        public void agregarJugador(Jugador jugador)
        {

            this.jugador = jugador;
            monedas = this.jugador.Monedas;

            lblMonedas.Text = "Monedas: " + monedas;
        }

    }
}
