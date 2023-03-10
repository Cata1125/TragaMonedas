using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica29
{
    public  class Jugador: Persona
    {
        private int monedas;
        private int ganancias;

        public int Monedas { get => monedas; set => monedas = value; }
        public int Ganancias { get => ganancias; set => ganancias = value; }
    }
}
