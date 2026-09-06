using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Torneo
    {
        private string titulo;
        private Partido [] juegos;
        protected Equipo[] equipos = new Equipo[4];
        int cantidadEquipos = 0;
        int partidoActual = 0;

        public Equipo[] Equipos { get { return equipos; } }

        public Torneo(string titulo)
        {
            this.titulo = titulo;
            juegos = new Partido[6];
        }

        public bool agregarEquipo(Equipo unEquipo)
        {
            if (cantidadEquipos < 4)
            {
                equipos[cantidadEquipos] = unEquipo;
                cantidadEquipos++;

                if (cantidadEquipos == 4)
                {
                    int contadorPartidos = 0;
                    for (int i = 0; i < equipos.Length; i++)
                    {
                        for (int j = i + 1; j < equipos.Length; j++)
                        {
                                juegos[contadorPartidos] = new Partido(equipos[i], equipos[j]);
                                contadorPartidos++;     
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public bool cargarResultado(int golesL, int golesV) // golesL a favor. golesV en contra 
        {
            if (partidoActual < juegos.Length)
            {
                juegos[partidoActual].final(golesL, golesV);
                partidoActual++;
                return true;
            }
            return false;

        }

        public string[] verCuadro()
        {
            string [] descripcion = new string[4];

            for (int i = 0; i < equipos.Length; i++)
            {
                descripcion[i] = $"Equipo: {equipos[i].VerDatos()}";
            }   
            return descripcion;
        }
    }
}
