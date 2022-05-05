
namespace Ejercicio519
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
            this.BLeerMatriz = new System.Windows.Forms.Button();
            this.BMostrarMatriz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerMatriz
            // 
            this.BLeerMatriz.Location = new System.Drawing.Point(111, 244);
            this.BLeerMatriz.Name = "BLeerMatriz";
            this.BLeerMatriz.Size = new System.Drawing.Size(243, 96);
            this.BLeerMatriz.TabIndex = 0;
            this.BLeerMatriz.Text = "Introducir números";
            this.BLeerMatriz.UseVisualStyleBackColor = true;
            this.BLeerMatriz.Click += new System.EventHandler(this.BLeerMatriz_Click);
            // 
            // BMostrarMatriz
            // 
            this.BMostrarMatriz.Location = new System.Drawing.Point(439, 244);
            this.BMostrarMatriz.Name = "BMostrarMatriz";
            this.BMostrarMatriz.Size = new System.Drawing.Size(243, 96);
            this.BMostrarMatriz.TabIndex = 1;
            this.BMostrarMatriz.Text = "Mostrar resultado";
            this.BMostrarMatriz.UseVisualStyleBackColor = true;
            this.BMostrarMatriz.Click += new System.EventHandler(this.BMostrarMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrarMatriz);
            this.Controls.Add(this.BLeerMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerMatriz;
        private System.Windows.Forms.Button BMostrarMatriz;
    }
}

