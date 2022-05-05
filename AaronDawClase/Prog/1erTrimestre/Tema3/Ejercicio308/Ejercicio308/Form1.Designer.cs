namespace Ejercicio308
{
    partial class Ejercicio308
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LEscribir = new System.Windows.Forms.Label();
            this.TTexto = new System.Windows.Forms.TextBox();
            this.BEscribir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LEscribir
            // 
            this.LEscribir.AutoSize = true;
            this.LEscribir.ForeColor = System.Drawing.SystemColors.Control;
            this.LEscribir.Location = new System.Drawing.Point(247, 229);
            this.LEscribir.Name = "LEscribir";
            this.LEscribir.Size = new System.Drawing.Size(0, 13);
            this.LEscribir.TabIndex = 0;
            // 
            // TTexto
            // 
            this.TTexto.Location = new System.Drawing.Point(318, 41);
            this.TTexto.Name = "TTexto";
            this.TTexto.Size = new System.Drawing.Size(161, 20);
            this.TTexto.TabIndex = 1;
            // 
            // BEscribir
            // 
            this.BEscribir.Location = new System.Drawing.Point(240, 93);
            this.BEscribir.Name = "BEscribir";
            this.BEscribir.Size = new System.Drawing.Size(312, 111);
            this.BEscribir.TabIndex = 2;
            this.BEscribir.Text = "Escribir";
            this.BEscribir.UseVisualStyleBackColor = true;
            this.BEscribir.Click += new System.EventHandler(this.BEscribir_Click);
            // 
            // Ejercicio308
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BEscribir);
            this.Controls.Add(this.TTexto);
            this.Controls.Add(this.LEscribir);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Ejercicio308";
            this.Text = "Ejercicio308";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LEscribir;
        private System.Windows.Forms.TextBox TTexto;
        private System.Windows.Forms.Button BEscribir;
    }
}

