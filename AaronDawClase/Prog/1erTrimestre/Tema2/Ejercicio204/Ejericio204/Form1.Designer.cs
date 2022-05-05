namespace Ejericio204
{
    partial class Ejercicio204
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
            this.TNumero1 = new System.Windows.Forms.TextBox();
            this.TNumero2 = new System.Windows.Forms.TextBox();
            this.BSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero1
            // 
            this.TNumero1.Location = new System.Drawing.Point(295, 87);
            this.TNumero1.Name = "TNumero1";
            this.TNumero1.Size = new System.Drawing.Size(206, 20);
            this.TNumero1.TabIndex = 0;
            // 
            // TNumero2
            // 
            this.TNumero2.Location = new System.Drawing.Point(295, 142);
            this.TNumero2.Name = "TNumero2";
            this.TNumero2.Size = new System.Drawing.Size(206, 20);
            this.TNumero2.TabIndex = 1;
            // 
            // BSuma
            // 
            this.BSuma.BackColor = System.Drawing.Color.White;
            this.BSuma.Location = new System.Drawing.Point(295, 190);
            this.BSuma.Name = "BSuma";
            this.BSuma.Size = new System.Drawing.Size(206, 136);
            this.BSuma.TabIndex = 2;
            this.BSuma.Text = "Sumar";
            this.BSuma.UseVisualStyleBackColor = false;
            this.BSuma.Click += new System.EventHandler(this.BSuma_Click);
            // 
            // Ejercicio204
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSuma);
            this.Controls.Add(this.TNumero2);
            this.Controls.Add(this.TNumero1);
            this.Name = "Ejercicio204";
            this.Text = "Ejercicio204";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero1;
        private System.Windows.Forms.TextBox TNumero2;
        private System.Windows.Forms.Button BSuma;
    }
}

