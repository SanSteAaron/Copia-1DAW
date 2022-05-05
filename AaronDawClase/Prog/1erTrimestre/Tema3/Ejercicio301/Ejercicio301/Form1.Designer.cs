namespace Ejercicio301
{
    partial class Ejerciocio301
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
            this.BComprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(292, 131);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(181, 20);
            this.TNumero.TabIndex = 0;
            // 
            // BComprobar
            // 
            this.BComprobar.Location = new System.Drawing.Point(250, 168);
            this.BComprobar.Name = "BComprobar";
            this.BComprobar.Size = new System.Drawing.Size(278, 173);
            this.BComprobar.TabIndex = 1;
            this.BComprobar.Text = "Comprobar";
            this.BComprobar.UseVisualStyleBackColor = true;
            this.BComprobar.Click += new System.EventHandler(this.BComprobar_Click);
            // 
            // Ejerciocio301
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BComprobar);
            this.Controls.Add(this.TNumero);
            this.Name = "Ejerciocio301";
            this.Text = "Ejercicio301";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Button BComprobar;
    }
}

