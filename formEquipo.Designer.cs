namespace WindowsFormsApp1
{
    partial class formEquipo
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
            this.tb_nombre_equipo = new System.Windows.Forms.TextBox();
            this.tb_nombre_delegado = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_dni = new System.Windows.Forms.TextBox();
            this.bt_aceptar_equipo = new System.Windows.Forms.Button();
            this.bt_cancelar_equipo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nombre_equipo
            // 
            this.tb_nombre_equipo.Location = new System.Drawing.Point(140, 23);
            this.tb_nombre_equipo.Name = "tb_nombre_equipo";
            this.tb_nombre_equipo.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre_equipo.TabIndex = 0;
            this.tb_nombre_equipo.TextChanged += new System.EventHandler(this.tb_nombre_equipo_TextChanged);
            // 
            // tb_nombre_delegado
            // 
            this.tb_nombre_delegado.Location = new System.Drawing.Point(140, 65);
            this.tb_nombre_delegado.Name = "tb_nombre_delegado";
            this.tb_nombre_delegado.Size = new System.Drawing.Size(100, 20);
            this.tb_nombre_delegado.TabIndex = 1;
            this.tb_nombre_delegado.TextChanged += new System.EventHandler(this.tb_nombre_delegado_TextChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(28, 23);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(80, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre Equipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Delegado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // tb_dni
            // 
            this.tb_dni.Location = new System.Drawing.Point(140, 102);
            this.tb_dni.Name = "tb_dni";
            this.tb_dni.Size = new System.Drawing.Size(100, 20);
            this.tb_dni.TabIndex = 5;
            this.tb_dni.TextChanged += new System.EventHandler(this.tb_dni_TextChanged);
            // 
            // bt_aceptar_equipo
            // 
            this.bt_aceptar_equipo.Location = new System.Drawing.Point(46, 148);
            this.bt_aceptar_equipo.Name = "bt_aceptar_equipo";
            this.bt_aceptar_equipo.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar_equipo.TabIndex = 6;
            this.bt_aceptar_equipo.Text = "Aceptar";
            this.bt_aceptar_equipo.UseVisualStyleBackColor = true;
            this.bt_aceptar_equipo.Click += new System.EventHandler(this.bt_aceptar_equipo_Click);
            // 
            // bt_cancelar_equipo
            // 
            this.bt_cancelar_equipo.Location = new System.Drawing.Point(165, 148);
            this.bt_cancelar_equipo.Name = "bt_cancelar_equipo";
            this.bt_cancelar_equipo.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar_equipo.TabIndex = 7;
            this.bt_cancelar_equipo.Text = "Cancelar";
            this.bt_cancelar_equipo.UseVisualStyleBackColor = true;
            // 
            // formEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 207);
            this.Controls.Add(this.bt_cancelar_equipo);
            this.Controls.Add(this.bt_aceptar_equipo);
            this.Controls.Add(this.tb_dni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.tb_nombre_delegado);
            this.Controls.Add(this.tb_nombre_equipo);
            this.Name = "formEquipo";
            this.Text = "formEquipo";
            this.Load += new System.EventHandler(this.formEquipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nombre_equipo;
        private System.Windows.Forms.TextBox tb_nombre_delegado;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_dni;
        private System.Windows.Forms.Button bt_aceptar_equipo;
        private System.Windows.Forms.Button bt_cancelar_equipo;
    }
}