namespace WindowsFormsApp1
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_cargar_equipo = new System.Windows.Forms.Button();
            this.bt_cargar_jugador = new System.Windows.Forms.Button();
            this.bt_resultado_partido = new System.Windows.Forms.Button();
            this.bt_cuadro_posiciones = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_cargar_equipo
            // 
            this.bt_cargar_equipo.Location = new System.Drawing.Point(37, 34);
            this.bt_cargar_equipo.Name = "bt_cargar_equipo";
            this.bt_cargar_equipo.Size = new System.Drawing.Size(75, 43);
            this.bt_cargar_equipo.TabIndex = 0;
            this.bt_cargar_equipo.Text = "Cargar Equipo";
            this.bt_cargar_equipo.UseVisualStyleBackColor = true;
            this.bt_cargar_equipo.Click += new System.EventHandler(this.bt_cargar_equipo_Click);
            // 
            // bt_cargar_jugador
            // 
            this.bt_cargar_jugador.Location = new System.Drawing.Point(37, 104);
            this.bt_cargar_jugador.Name = "bt_cargar_jugador";
            this.bt_cargar_jugador.Size = new System.Drawing.Size(75, 47);
            this.bt_cargar_jugador.TabIndex = 1;
            this.bt_cargar_jugador.Text = "Cargar Jugadores";
            this.bt_cargar_jugador.UseVisualStyleBackColor = true;
            this.bt_cargar_jugador.Click += new System.EventHandler(this.bt_cargar_jugador_Click);
            // 
            // bt_resultado_partido
            // 
            this.bt_resultado_partido.Location = new System.Drawing.Point(37, 179);
            this.bt_resultado_partido.Name = "bt_resultado_partido";
            this.bt_resultado_partido.Size = new System.Drawing.Size(75, 50);
            this.bt_resultado_partido.TabIndex = 2;
            this.bt_resultado_partido.Text = "Resultado  partidos";
            this.bt_resultado_partido.UseVisualStyleBackColor = true;
            this.bt_resultado_partido.Click += new System.EventHandler(this.bt_resultado_partido_Click);
            // 
            // bt_cuadro_posiciones
            // 
            this.bt_cuadro_posiciones.Location = new System.Drawing.Point(37, 259);
            this.bt_cuadro_posiciones.Name = "bt_cuadro_posiciones";
            this.bt_cuadro_posiciones.Size = new System.Drawing.Size(75, 44);
            this.bt_cuadro_posiciones.TabIndex = 3;
            this.bt_cuadro_posiciones.Text = "Cuadro de posiciones";
            this.bt_cuadro_posiciones.UseVisualStyleBackColor = true;
            this.bt_cuadro_posiciones.Click += new System.EventHandler(this.bt_cuadro_posiciones_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(152, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 277);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 335);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_cuadro_posiciones);
            this.Controls.Add(this.bt_resultado_partido);
            this.Controls.Add(this.bt_cargar_jugador);
            this.Controls.Add(this.bt_cargar_equipo);
            this.Name = "formPrincipal";
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cargar_equipo;
        private System.Windows.Forms.Button bt_cargar_jugador;
        private System.Windows.Forms.Button bt_resultado_partido;
        private System.Windows.Forms.Button bt_cuadro_posiciones;
        private System.Windows.Forms.ListBox listBox1;
    }
}