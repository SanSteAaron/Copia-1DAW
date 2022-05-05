
namespace Ejercicio603
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
            this.BLeerNúmeros = new System.Windows.Forms.Button();
            this.BMostrarNúmeros = new System.Windows.Forms.Button();
            this.BMostrarMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerNúmeros
            // 
            this.BLeerNúmeros.Location = new System.Drawing.Point(155, 278);
            this.BLeerNúmeros.Name = "BLeerNúmeros";
            this.BLeerNúmeros.Size = new System.Drawing.Size(133, 85);
            this.BLeerNúmeros.TabIndex = 0;
            this.BLeerNúmeros.Text = "Introducir números";
            this.BLeerNúmeros.UseVisualStyleBackColor = true;
            this.BLeerNúmeros.Click += new System.EventHandler(this.BLeerNúmeros_Click);
            // 
            // BMostrarNúmeros
            // 
            this.BMostrarNúmeros.Location = new System.Drawing.Point(334, 278);
            this.BMostrarNúmeros.Name = "BMostrarNúmeros";
            this.BMostrarNúmeros.Size = new System.Drawing.Size(127, 85);
            this.BMostrarNúmeros.TabIndex = 1;
            this.BMostrarNúmeros.Text = "Mostrar números";
            this.BMostrarNúmeros.UseVisualStyleBackColor = true;
            this.BMostrarNúmeros.Click += new System.EventHandler(this.BMostrarNúmeros_Click);
            // 
            // BMostrarMenor
            // 
            this.BMostrarMenor.Location = new System.Drawing.Point(510, 277);
            this.BMostrarMenor.Name = "BMostrarMenor";
            this.BMostrarMenor.Size = new System.Drawing.Size(139, 86);
            this.BMostrarMenor.TabIndex = 2;
            this.BMostrarMenor.Text = "Mostrar menor";
            this.BMostrarMenor.UseVisualStyleBackColor = true;
            this.BMostrarMenor.Click += new System.EventHandler(this.BMostrarMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrarMenor);
            this.Controls.Add(this.BMostrarNúmeros);
            this.Controls.Add(this.BLeerNúmeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerNúmeros;
        private System.Windows.Forms.Button BMostrarNúmeros;
        private System.Windows.Forms.Button BMostrarMenor;
    }
}

