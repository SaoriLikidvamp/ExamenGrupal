using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Personaje
    {
        public string Nombre;
        public int Fuerza;
        public int Destreza;
        public int Vida;


        public Personaje(string nombre, int fuerza, int destreza, int vida)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
           this.Destreza = destreza;
            this.Vida = vida;
        }
    }
}

