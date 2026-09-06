using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Persona
    {
        public int Dni { get; }
        public string Nombre { get; }

        public Persona(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public string VerDatos()
        {
            return $"Nombre: {Nombre}, Dni: {Dni.ToString()}";
        }
    }
}
