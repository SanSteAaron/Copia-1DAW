
namespace Ejercicio512
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
            this.BLeerTemperaturas = new System.Windows.Forms.Button();
            this.BMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerTemperaturas
            // 
            this.BLeerTemperaturas.Location = new System.Drawing.Point(129, 219);
            this.BLeerTemperaturas.Name = "BLeerTemperaturas";
            this.BLeerTemperaturas.Size = new System.Drawing.Size(236, 112);
            this.BLeerTemperaturas.TabIndex = 0;
            this.BLeerTemperaturas.Text = "Introducir temperaturas";
            this.BLeerTemperaturas.UseVisualStyleBackColor = true;
            this.BLeerTemperaturas.Click += new System.EventHandler(this.BLeerTemperaturas_Click);
            // 
            // BMostrar
            // 
            this.BMostrar.Location = new System.Drawing.Point(438, 219);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(236, 112);
            this.BMostrar.TabIndex = 1;
            this.BMostrar.Text = "Mostrar temperatura media, máxima y mínima.";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.BLeerTemperaturas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerTemperaturas;
        private System.Windows.Forms.Button BMostrar;
    }
}

