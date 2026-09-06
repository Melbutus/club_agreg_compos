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
    public partial class formEquipo : Form
    {
        internal formEquipo(Torneo untorneo)
        {
            InitializeComponent();
            this.torneo = untorneo;
        }
        Equipo equipo;
        Torneo torneo;

        private void tb_nombre_equipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_nombre_delegado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void formEquipo_Load(object sender, EventArgs e)
        {

        }

        private void tb_dni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_aceptar_equipo_Click(object sender, EventArgs e)
        {
            string nombre = tb_nombre_equipo.Text;
            string nombreDelegado = tb_nombre_delegado.Text;
            int dni = int.Parse(tb_dni.Text);

            equipo = new Equipo(nombre, dni, nombreDelegado);
            bool exito = torneo.agregarEquipo(equipo);

            if (exito == true) 
            {
                MessageBox.Show("Equipo agregado correctamente.");
            }
            else 
            {
                MessageBox.Show("Se han alcanzado los 4 equipos permitidos en el torneo.");
            }
        }
    }
}
