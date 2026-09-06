using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        Torneo torneo = new Torneo("Torneo de Futbol");
        //formEquipo Fequipo;

        
        private void formPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_cargar_jugador_Click(object sender, EventArgs e)
        {
            formJugador Fjugador = new formJugador(torneo);
            Fjugador.Show();
        }

        private void bt_resultado_partido_Click(object sender, EventArgs e)
        {
            ResultadoFinal Fresultado = new ResultadoFinal(torneo);
            Fresultado.Show();
        }

        private void bt_cuadro_posiciones_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string[] lineasCuadro = torneo.verCuadro();

            foreach (string n in lineasCuadro)
            {
                listBox1.Items.Add(n);
            }
        }

        private void bt_cargar_equipo_Click(object sender, EventArgs e)
        {
            formEquipo Fequipo = new formEquipo(torneo);
            Fequipo.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
