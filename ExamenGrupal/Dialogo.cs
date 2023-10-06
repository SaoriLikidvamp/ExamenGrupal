using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Dialogo : Jugador
    {
        public Dialogo(string nombre, int fuerza, int destreza, int vida)
        : base(nombre, fuerza, destreza, vida)
        {
        }

        public void IniciarCueva()
        {
            Console.WriteLine("  ");
        }

        public void IniciarCastillo()
        {
            Console.WriteLine("  ");
              
        }

        public void IniciarAldea()
        {
            Console.WriteLine("  ");
        }
    }
}
