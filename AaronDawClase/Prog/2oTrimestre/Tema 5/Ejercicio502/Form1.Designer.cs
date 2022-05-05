
namespace Ejercicio602
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
            this.BNumeros = new System.Windows.Forms.Button();
            this.BMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNumeros
            // 
            this.BNumeros.Location = new System.Drawing.Point(165, 242);
            this.BNumeros.Name = "BNumeros";
            this.BNumeros.Size = new System.Drawing.Size(179, 105);
            this.BNumeros.TabIndex = 0;
            this.BNumeros.Text = "Introducir números";
            this.BNumeros.UseVisualStyleBackColor = true;
            this.BNumeros.Click += new System.EventHandler(this.BNumeros_Click);
            // 
            // BMedia
            // 
            this.BMedia.Location = new System.Drawing.Point(449, 242);
            this.BMedia.Name = "BMedia";
            this.BMedia.Size = new System.Drawing.Size(179, 105);
            this.BMedia.TabIndex = 1;
            this.BMedia.Text = "Calcular Media";
            this.BMedia.UseVisualStyleBackColor = true;
            this.BMedia.Click += new System.EventHandler(this.BMedia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMedia);
            this.Controls.Add(this.BNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNumeros;
        private System.Windows.Forms.Button BMedia;
    }
}

