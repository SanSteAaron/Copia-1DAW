namespace Ejercicio306
{
    partial class Ejercicio306
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
            this.TNumero = new System.Windows.Forms.TextBox();
            this.BNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(153, 174);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(192, 20);
            this.TNumero.TabIndex = 0;
            // 
            // BNota
            // 
            this.BNota.Location = new System.Drawing.Point(467, 86);
            this.BNota.Name = "BNota";
            this.BNota.Size = new System.Drawing.Size(235, 242);
            this.BNota.TabIndex = 1;
            this.BNota.Text = "Nota";
            this.BNota.UseVisualStyleBackColor = true;
            this.BNota.Click += new System.EventHandler(this.BNota_Click);
            // 
            // Ejercicio306
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BNota);
            this.Controls.Add(this.TNumero);
            this.Name = "Ejercicio306";
            this.Text = "Ejercicio306";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Button BNota;
    }
}

