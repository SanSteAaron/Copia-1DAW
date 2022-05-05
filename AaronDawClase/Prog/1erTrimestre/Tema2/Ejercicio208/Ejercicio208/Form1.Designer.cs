namespace Ejercicio208
{
    partial class Ejercicio208
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
            this.TNum1 = new System.Windows.Forms.TextBox();
            this.TNum3 = new System.Windows.Forms.TextBox();
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.BSolucion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(303, 65);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(207, 20);
            this.TNum1.TabIndex = 0;
            // 
            // TNum3
            // 
            this.TNum3.Location = new System.Drawing.Point(303, 177);
            this.TNum3.Name = "TNum3";
            this.TNum3.Size = new System.Drawing.Size(207, 20);
            this.TNum3.TabIndex = 1;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(303, 123);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(207, 20);
            this.TNum2.TabIndex = 2;
            // 
            // BSolucion
            // 
            this.BSolucion.Location = new System.Drawing.Point(229, 249);
            this.BSolucion.Name = "BSolucion";
            this.BSolucion.Size = new System.Drawing.Size(359, 80);
            this.BSolucion.TabIndex = 3;
            this.BSolucion.Text = "Solucion";
            this.BSolucion.UseVisualStyleBackColor = true;
            this.BSolucion.Click += new System.EventHandler(this.BSolucion_Click);
            // 
            // Ejercicio208
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSolucion);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum3);
            this.Controls.Add(this.TNum1);
            this.Name = "Ejercicio208";
            this.Text = "Ejercicio208";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum3;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Button BSolucion;
    }
}

