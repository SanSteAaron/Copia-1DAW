
namespace Ejercicio801
{
    partial class FCreadorFiguras
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
            this.BIntroducirCirculo = new System.Windows.Forms.Button();
            this.BIntroducirCuadrado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroducirCirculo
            // 
            this.BIntroducirCirculo.Location = new System.Drawing.Point(170, 74);
            this.BIntroducirCirculo.Name = "BIntroducirCirculo";
            this.BIntroducirCirculo.Size = new System.Drawing.Size(465, 95);
            this.BIntroducirCirculo.TabIndex = 0;
            this.BIntroducirCirculo.Text = "Crear Circulo";
            this.BIntroducirCirculo.UseVisualStyleBackColor = true;
            this.BIntroducirCirculo.Click += new System.EventHandler(this.BIntroducirCirculo_Click);
            // 
            // BIntroducirCuadrado
            // 
            this.BIntroducirCuadrado.Location = new System.Drawing.Point(170, 253);
            this.BIntroducirCuadrado.Name = "BIntroducirCuadrado";
            this.BIntroducirCuadrado.Size = new System.Drawing.Size(465, 95);
            this.BIntroducirCuadrado.TabIndex = 1;
            this.BIntroducirCuadrado.Text = "Crear Cuadrado";
            this.BIntroducirCuadrado.UseVisualStyleBackColor = true;
            this.BIntroducirCuadrado.Click += new System.EventHandler(this.BIntroducirCuadrado_Click);
            // 
            // FCreadorFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BIntroducirCuadrado);
            this.Controls.Add(this.BIntroducirCirculo);
            this.Name = "FCreadorFiguras";
            this.Text = "Creador de Figuras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroducirCirculo;
        private System.Windows.Forms.Button BIntroducirCuadrado;
    }
}

