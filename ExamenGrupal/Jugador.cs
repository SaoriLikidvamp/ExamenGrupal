using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Jugador : Personaje
    {
        public Jugador(string nombre, int fuerza, int destreza, int vida)
        : base(nombre, fuerza, destreza, vida)
        {
        }

        public void MostrarJugador()
        {
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"--- Personaje Creado con Éxito ---");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"Este es tu personaje creado:");
            Console.WriteLine($" ");
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fuerza: {Fuerza}");
            Console.WriteLine($"Destreza: {Destreza}");
            Console.WriteLine($"Vida: {Vida}");
            Console.WriteLine($" ");
        }
    }
}
