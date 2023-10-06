using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Juego
    {
        private Jugador jugador;
        public Juego(string nombre)
        {
            jugador = new Jugador(nombre, 0, 0, 0);
        }

        public void IniciarJuego()
        {
            Console.WriteLine("  ");
            Console.WriteLine($"¡Bienvenido al juego de aventura de texto, {jugador.Nombre}!");
            Console.WriteLine("  ");
            Console.WriteLine("Tienes 100 puntos para distribuir entre tus atributos (fuerza, destreza y vida).");

            while (true)
            {
                Console.WriteLine("  ");
                Console.Write("Ingresa la cantidad de puntos para Fuerza: ");
                int fuerza = Comprobando(0, 100 - jugador.Destreza - jugador.Vida);
                Console.Write("Ingresa la cantidad de puntos para Destreza: ");
                int destreza = Comprobando(0, 100 - jugador.Fuerza - jugador.Vida);
                Console.Write("Ingresa la cantidad de puntos para Vida: ");
                int vida = Comprobando(0, 100 - jugador.Fuerza - jugador.Destreza);
                Console.WriteLine("  ");

                if (fuerza + destreza + vida <= 100)
                {
                    jugador.Fuerza = fuerza;
                    jugador.Destreza = destreza;
                    jugador.Vida = vida;
                    break; // Continuar con la historia
                }
                else
                {
                    Console.WriteLine("La suma de los puntos no debe ser mayor a 100. Inténtalo nuevamente.");
                }
            }

            // Muestra el resumen del personaje creado
            jugador.MostrarJugador();
            Console.WriteLine("  ");
            Console.Write("¡Ahora empezará la real aventura :D !");
            Console.ReadLine();
        }
        public void continuardialogo()
        {
            Dialogo dialogo = new Dialogo(jugador.Nombre,jugador.Fuerza, jugador.Destreza, jugador.Vida);
            dialogo.IniciarCueva();
            dialogo.IniciarCastillo();
            dialogo.IniciarAldea();
            Console.ReadLine();
        }
        private int Comprobando(int minimo, int maximo) // validacion de ingreso de numeros, que no ingrese ni letras ni numeros negativos
        {
            int valor;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out valor) && valor >= minimo && valor <= maximo)
                {
                    return valor;
                }
                Console.Write($"Ingresa un número válido ({minimo}-{maximo}): ");
            }
        }
    }
}
