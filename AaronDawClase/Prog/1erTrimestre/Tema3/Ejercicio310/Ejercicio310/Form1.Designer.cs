namespace Ejercicio310
{
    partial class Ejercicio310
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
            this.BCambio = new System.Windows.Forms.Button();
            this.TEuros = new System.Windows.Forms.TextBox();
            this.LEuros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCambio
            // 
            this.BCambio.Location = new System.Drawing.Point(294, 109);
            this.BCambio.Name = "BCambio";
            this.BCambio.Size = new System.Drawing.Size(188, 76);
            this.BCambio.TabIndex = 0;
            this.BCambio.Text = "Cambio";
            this.BCambio.UseVisualStyleBackColor = true;
            this.BCambio.Click += new System.EventHandler(this.BCambio_Click);
            // 
            // TEuros
            // 
            this.TEuros.Location = new System.Drawing.Point(294, 44);
            this.TEuros.Name = "TEuros";
            this.TEuros.Size = new System.Drawing.Size(188, 20);
            this.TEuros.TabIndex = 1;
            // 
            // LEuros
            // 
            this.LEuros.AutoSize = true;
            this.LEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEuros.ForeColor = System.Drawing.SystemColors.Control;
            this.LEuros.Location = new System.Drawing.Point(290, 217);
            this.LEuros.Name = "LEuros";
            this.LEuros.Size = new System.Drawing.Size(0, 20);
            this.LEuros.TabIndex = 2;
            // 
            // Ejercicio310
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LEuros);
            this.Controls.Add(this.TEuros);
            this.Controls.Add(this.BCambio);
            this.Name = "Ejercicio310";
            this.Text = "Ejercicio310";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCambio;
        private System.Windows.Forms.TextBox TEuros;
        private System.Windows.Forms.Label LEuros;
    }
}

