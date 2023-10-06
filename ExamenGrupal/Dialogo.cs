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

        public void IniciarCueva(Jugador jugador)
        {
            while (true)
            {
                Console.WriteLine("  ");
                Console.WriteLine("Estás en una cueva. ¿Qué haces?");
                Console.WriteLine("  ");
                Console.WriteLine("1. Corres a la reliquia sin importar los lobos guardianes");
                Console.WriteLine("2. Peleas contra los lobos guardianes");

                string opcionCueva = Console.ReadLine();

                switch (opcionCueva)
                {
                    case "1":
                        Console.WriteLine("  ");
                        Console.WriteLine("Obtienes la reliquia, pero sufres heridas en el camino.");
                        Console.WriteLine("  ");
                        Console.WriteLine("- Pierdes 40 puntos de vida -");
                        Console.WriteLine("  ");
                        jugador.Vida -= 40;

                        if (jugador.Vida <= 0)
                        {
                            Console.WriteLine("  ");
                            Console.WriteLine("- Te quedaste sin vida. ¡Perdiste! -");
                            Console.WriteLine("  ");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Te conviertes en una estatua que protege a la aldea de cualquier ataque.");
                            Console.WriteLine("  ");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("- Eres una gran estatua protectora (Final Neutral)");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("  ");
                            return;
                        }
                        
                    case "2":

                        if (jugador.Fuerza >= 40)
                        {
                            Console.WriteLine("  ");
                            Console.WriteLine("Gracias a tu fuerza, matas a los lobos guardianes sencillamente y consigues la reliquia.");
                            Console.WriteLine(" ");
                            Console.WriteLine("- Te conviertes en una estatua que protege a la aldea de cualquier ataque -");
                            Console.WriteLine("  ");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("- Eres una gran estatua protectora (Final Neutral)");
                            Console.WriteLine("--------------------------------------------------");
                            Console.WriteLine("  ");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("  ");
                            Console.WriteLine("- No tienes suficiente fuerza para entrar a la cueva -");
                            Console.WriteLine("  ");
                            return;
                        }

                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Opción no válida. Regresando a la historia...");
                        Console.WriteLine(" ");
                        continue;
                }
            }
        }
        public void IniciarCastillo(Jugador jugador)
        {
            while (true)
            {
                Console.WriteLine("  ");
                Console.WriteLine("Estás en un castillo. ¿Qué camino eliges?");
                Console.WriteLine("1. Tomar el camino de los demonios");
                Console.WriteLine("2. Tomar el camino lleno de trampas");

                string opcionCastillo = Console.ReadLine();

                switch (opcionCastillo)
                {
                    case "1":
                        Console.WriteLine("  ");
                        Console.WriteLine("Vences a los enemigos y pierdes demasiada vida, pero igual consigues llegar al trono y convertirte en el rey.");
                        Console.WriteLine(" ");
                        Console.WriteLine("Pierdes 30 puntos de vida.");
                        jugador.Vida -= 30;

                        if (jugador.Vida <= 0)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("- Te quedaste sin vida. ¡Perdiste! -");
                            Console.WriteLine("  ");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("- ¡Ganaste! Eres un rey  (Final Bueno) -");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine(" ");
                            return;
                        }
                    case "2":
                        if (jugador.Destreza > 45)
                        {
                            Console.WriteLine("  ");
                            Console.WriteLine("Los demonios desaparecen. u~u ");
                            Console.WriteLine(" ");
                            Console.WriteLine("Cruzas fácilmente las trampas al tener una gran destreza, llegas al trono y te conviertes en rey.");
                            Console.WriteLine(" ");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("- ¡Ganaste! Eres un rey  (Final Bueno) -");
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine(" ");
                            return;
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("- No tienes suficiente destreza para entrar al castillo -");
                            Console.WriteLine(" ");
                            return;
                        }
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Opción no válida. Regresando a la historia...");
                        Console.WriteLine("  ");
                        continue;
                }
            }
        }

        public void IniciarAldea(Jugador jugador)
        {
            Console.WriteLine("  ");
            Console.WriteLine("Estás en una aldea. Este camino solo lleva a que seas espectador de cómo del castillo salen demonios a atacar la aldea.");
            Console.WriteLine("  ");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("- Verás como se destruye lo que tanto amabas (Final Malo) -");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("  ");
        }
    }
}
