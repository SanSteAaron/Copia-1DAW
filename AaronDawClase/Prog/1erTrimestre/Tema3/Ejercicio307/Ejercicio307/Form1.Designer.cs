namespace Ejercicio307
{
    partial class Ejercicio307
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
            this.Ln = new System.Windows.Forms.Label();
            this.BIntroducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(335, 200);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(123, 20);
            this.TNumero.TabIndex = 0;
            // 
            // Ln
            // 
            this.Ln.AutoSize = true;
            this.Ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ln.ForeColor = System.Drawing.SystemColors.Control;
            this.Ln.Location = new System.Drawing.Point(62, 200);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(209, 20);
            this.Ln.TabIndex = 1;
            this.Ln.Text = "Escriba un número del 1 al 5";
            // 
            // BIntroducir
            // 
            this.BIntroducir.Location = new System.Drawing.Point(496, 146);
            this.BIntroducir.Name = "BIntroducir";
            this.BIntroducir.Size = new System.Drawing.Size(223, 131);
            this.BIntroducir.TabIndex = 2;
            this.BIntroducir.Text = "Introducir";
            this.BIntroducir.UseVisualStyleBackColor = true;
            this.BIntroducir.Click += new System.EventHandler(this.BIntroducir_Click);
            // 
            // Ejercicio307
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BIntroducir);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.TNumero);
            this.Name = "Ejercicio307";
            this.Text = "Ejericio307";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label Ln;
        private System.Windows.Forms.Button BIntroducir;
    }
}

