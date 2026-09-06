using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Equipo
    {
        private string nombre;
        private int puntos;
        public int Puntos { get; }

        private int[] partidos = new int[3];
        private int[] goles = new int[2];
        private Persona delegado; 

        public string Nombre { get { return nombre; } }

        private ArrayList listaBuenaFe = new ArrayList();

        public Equipo(string nombre, int dni, string delegado)
        {
            this.nombre = nombre;
            this.delegado = new Persona(delegado, dni);
        }

        public bool agregarJugador(Jugador unjugador)
        {
            if (unjugador != null) 
            {
            listaBuenaFe.Add(unjugador);
                return true;
            }
            return false;
        }

        public Jugador verJugadorNumero(int camiseta) 
        {
            Jugador buscado = null;
            int posicion = Buscar(camiseta);

            if (posicion != -1)
            {
                buscado = (Jugador)listaBuenaFe[posicion];
            }
            return buscado;
        }

        private int Buscar(int numero)
        {
            int encontrado = -1;

            for (int i = 0; i < listaBuenaFe.Count; i++)
            {
                if (((Jugador)listaBuenaFe[i]).nrocamiseta == numero) 
                    encontrado= i;
            }
            return encontrado;
        }

        public void resultado(int gF, int gE) //gF -> goles a favor. gE-> goles en contra
        {
            if (gF > gE)
            {
                puntos += 3;
                partidos[0] += 1; //1 partido ganado
            }
            else if (gF == gE)
            {
                puntos += 1;
                partidos[1] += 1; //1 partido empatado
            }
            else
            {
                puntos += 0;
                partidos[2]+= 1; //1 partido perdido
            }

            goles[0] += gF; //goles a favor
            goles[1] += gE; //goles en contra
        }

        /*public string[] verLista()
        {
            string[] lista = new string[10];

            for (int i = 0; i < listaBuenaFe.Count; i++)
            {
                lista[i]=listaBuenaFe[i].ToString();
            }

            return lista;
        }*/

        public string VerDatos()
        {
            return $"Nombre: {nombre}, Puntos: {puntos}, Partidos Ganados: {partidos[0]}, Partidos Empatados: {partidos[1]}, Partidos Perdidos: {partidos[2]}, Goles a Favor: {goles[0]}, Goles en Contra: {goles[1]}";
        }
    }
}
