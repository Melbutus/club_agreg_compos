namespace WindowsFormsApp1
{
    partial class ResultadoFinal
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
            this.Local = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_aceptar_resultadoFinal = new System.Windows.Forms.Button();
            this.bt_cancelar_resultadoFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Local
            // 
            this.Local.AutoSize = true;
            this.Local.Location = new System.Drawing.Point(23, 27);
            this.Local.Name = "Local";
            this.Local.Size = new System.Drawing.Size(69, 13);
            this.Local.TabIndex = 0;
            this.Local.Text = "Local (Goles)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visitante (Goles)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // bt_aceptar_resultadoFinal
            // 
            this.bt_aceptar_resultadoFinal.Location = new System.Drawing.Point(26, 102);
            this.bt_aceptar_resultadoFinal.Name = "bt_aceptar_resultadoFinal";
            this.bt_aceptar_resultadoFinal.Size = new System.Drawing.Size(75, 23);
            this.bt_aceptar_resultadoFinal.TabIndex = 4;
            this.bt_aceptar_resultadoFinal.Text = "Aceptar";
            this.bt_aceptar_resultadoFinal.UseVisualStyleBackColor = true;
            this.bt_aceptar_resultadoFinal.Click += new System.EventHandler(this.bt_aceptar_resultadoFinal_Click);
            // 
            // bt_cancelar_resultadoFinal
            // 
            this.bt_cancelar_resultadoFinal.Location = new System.Drawing.Point(149, 102);
            this.bt_cancelar_resultadoFinal.Name = "bt_cancelar_resultadoFinal";
            this.bt_cancelar_resultadoFinal.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar_resultadoFinal.TabIndex = 5;
            this.bt_cancelar_resultadoFinal.Text = "Cancelar";
            this.bt_cancelar_resultadoFinal.UseVisualStyleBackColor = true;
            this.bt_cancelar_resultadoFinal.Click += new System.EventHandler(this.bt_cancelar_resultadoFinal_Click);
            // 
            // ResultadoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 147);
            this.Controls.Add(this.bt_cancelar_resultadoFinal);
            this.Controls.Add(this.bt_aceptar_resultadoFinal);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Local);
            this.Name = "ResultadoFinal";
            this.Text = "ResultadoFinal";
            this.Load += new System.EventHandler(this.ResultadoFinal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Local;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_aceptar_resultadoFinal;
        private System.Windows.Forms.Button bt_cancelar_resultadoFinal;
    }
}