using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Partido
    {
        private Equipo local;
        private Equipo visitante;
        private int[] participantes = new int[2];

        public Partido(Equipo local, Equipo visitante)
        {
            this.local = local;
            this.visitante = visitante;
        }

        public void final(int golesLocal, int golesVisita)
        {
            local.resultado(golesLocal, golesVisita);
            visitante.resultado(golesVisita, golesLocal);
        }

        public string Resumen()
        {
            return $"Local: {local}, Visitante: {visitante}";
        }
    }
}
