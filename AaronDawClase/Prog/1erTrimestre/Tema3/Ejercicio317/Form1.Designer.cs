namespace Ejercicio317
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
            this.BMúltiplos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BMúltiplos
            // 
            this.BMúltiplos.Location = new System.Drawing.Point(224, 158);
            this.BMúltiplos.Name = "BMúltiplos";
            this.BMúltiplos.Size = new System.Drawing.Size(312, 90);
            this.BMúltiplos.TabIndex = 0;
            this.BMúltiplos.Text = "Múltiplos de 3";
            this.BMúltiplos.UseVisualStyleBackColor = true;
            this.BMúltiplos.Click += new System.EventHandler(this.BMúltiplos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMúltiplos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BMúltiplos;
    }
}

