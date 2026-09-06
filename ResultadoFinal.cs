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
    public partial class ResultadoFinal : Form
    {
        internal ResultadoFinal(Torneo unTorneo)
        {
            InitializeComponent();
            this.torneo = unTorneo;
        }
        Torneo torneo;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ResultadoFinal_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_aceptar_resultadoFinal_Click(object sender, EventArgs e)
        {
            int localGoles = int.Parse(textBox1.Text);
            int visitanteGoles = int.Parse(textBox2.Text);
            bool resultadoCargado = torneo.cargarResultado(localGoles, visitanteGoles);

            if(resultadoCargado==true) 
            {
                MessageBox.Show("Resultado cargado correctamente.");
            }
            else
            {
                MessageBox.Show("No se pueden cargar más resultados, ya se han jugado todos los partidos.");
            }
        }

        private void bt_cancelar_resultadoFinal_Click(object sender, EventArgs e)
        {
            ResultadoFinal.ActiveForm.Close();
        }
    }
}
