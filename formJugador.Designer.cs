namespace WindowsFormsApp1
{
    partial class formJugador
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
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_Aceptar = new System.Windows.Forms.Button();
            this.tb_nombre_jugador = new System.Windows.Forms.TextBox();
            this.tb_dni_jugador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_jugador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(137, 143);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 0;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Aceptar
            // 
            this.bt_Aceptar.Location = new System.Drawing.Point(12, 143);
            this.bt_Aceptar.Name = "bt_Aceptar";
            this.bt_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aceptar.TabIndex = 1;
            this.bt_Aceptar.Text = "Aceptar";
            this.bt_Aceptar.UseVisualStyleBackColor = true;
            this.bt_Aceptar.Click += new System.EventHandler(this.bt_Aceptar_Click);
            // 
            // tb_nombre_jugador
            // 
            this.tb_nombre_jugador.Location = new System.Drawing.Point(93, 29);
            this.tb_nombre_jugador.Name = "tb_nombre_jugador";
            this.tb_nombre_jugador.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre_jugador.TabIndex = 2;
            this.tb_nombre_jugador.TextChanged += new System.EventHandler(this.tb_nombre_jugador_TextChanged);
            // 
            // tb_dni_jugador
            // 
            this.tb_dni_jugador.Location = new System.Drawing.Point(93, 67);
            this.tb_dni_jugador.Name = "tb_dni_jugador";
            this.tb_dni_jugador.Size = new System.Drawing.Size(100, 20);
            this.tb_dni_jugador.TabIndex = 3;
            this.tb_dni_jugador.TextChanged += new System.EventHandler(this.tb_dni_jugador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DNI";
            // 
            // cmb_jugador
            // 
            this.cmb_jugador.FormattingEnabled = true;
            this.cmb_jugador.Location = new System.Drawing.Point(93, 104);
            this.cmb_jugador.Name = "cmb_jugador";
            this.cmb_jugador.Size = new System.Drawing.Size(100, 21);
            this.cmb_jugador.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipo";
            // 
            // formJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_jugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_dni_jugador);
            this.Controls.Add(this.tb_nombre_jugador);
            this.Controls.Add(this.bt_Aceptar);
            this.Controls.Add(this.bt_cancelar);
            this.Name = "formJugador";
            this.Text = "formJugador";
            this.Load += new System.EventHandler(this.formJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_Aceptar;
        private System.Windows.Forms.TextBox tb_nombre_jugador;
        private System.Windows.Forms.TextBox tb_dni_jugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_jugador;
        private System.Windows.Forms.Label label3;
    }
}