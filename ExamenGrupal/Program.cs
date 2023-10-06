using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Bienvenido a una aventura extraordinaria -- ");
            Console.WriteLine("  ");
            Console.Write("Ingresa el nombre de tu personaje: ");
            string nombre = Console.ReadLine();

            Juego juego = new Juego(nombre);
            juego.IniciarJuego();
        }
    }
}
