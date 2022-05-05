namespace Ejercicio323
{
    partial class Form1
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.BackColor = System.Drawing.Color.FloralWhite;
            this.BPrimero.Location = new System.Drawing.Point(290, 296);
            this.BPrimero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(468, 145);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Ejecutar";
            this.BPrimero.UseVisualStyleBackColor = false;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BPrimero);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
    }
}

