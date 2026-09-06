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
    public partial class formJugador : Form
    {
        internal formJugador(Torneo UnTorneo)
        {
            InitializeComponent();
            this.torneo = UnTorneo;

            for(int i=0;i<torneo.Equipos.Length; i++)
            {
                if(torneo.Equipos[i] != null)
                    cmb_jugador.Items.Add(torneo.Equipos[i].Nombre.ToString());
            }
        }

        Equipo equipo;
        Torneo torneo;

        private void button1_Click(object sender, EventArgs e)
        {
            formJugador.ActiveForm.Close();
        }

        private void tb_dni_jugador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_nombre_jugador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            try {
                int dniJugador = int.Parse(tb_dni_jugador.Text);
                string nombreJugador = tb_nombre_jugador.Text;
                string seleccionado = cmb_jugador.SelectedItem.ToString();

                for (int i=0; i<torneo.Equipos.Length; i++)
                { 
                       if(torneo.Equipos[i] != null && torneo.Equipos[i].Nombre == seleccionado)
                       {
                             equipo = torneo.Equipos[i];

                            if (equipo.agregarJugador(new Jugador(nombreJugador, dniJugador)) == true)
                            {
                                MessageBox.Show("Jugador agregado correctamente");
                                tb_nombre_jugador.Clear();
                                tb_dni_jugador.Clear();
                                cmb_jugador.SelectedIndex = -1;
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el jugador");
                            }
                       }
                }
            }
             catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message);
                 } 
                }

    
        private void formJugador_Load(object sender, EventArgs e)
        {

        }
    }
}



