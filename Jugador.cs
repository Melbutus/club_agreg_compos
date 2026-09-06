using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Jugador:Persona
    {
        public static int idNumCamiseta = 1;
        public int nrocamiseta=0;
        public Jugador(string nombre, int dni):base(nombre,dni) 
        {
            nrocamiseta = idNumCamiseta;
            idNumCamiseta += 1;
        }

        public string VerDatos() 
        {
            return base.VerDatos() + $"Num Camiseta: {idNumCamiseta}";
        }
    }
}
