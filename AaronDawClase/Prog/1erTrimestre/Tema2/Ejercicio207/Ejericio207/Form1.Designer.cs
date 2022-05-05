namespace Ejericio207
{
    partial class Ejercicio207
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
            this.TCentimetros = new System.Windows.Forms.TextBox();
            this.LEstética = new System.Windows.Forms.Label();
            this.LAltura = new System.Windows.Forms.Label();
            this.LResultado = new System.Windows.Forms.Label();
            this.BSolucion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TCentimetros
            // 
            this.TCentimetros.Location = new System.Drawing.Point(287, 81);
            this.TCentimetros.Name = "TCentimetros";
            this.TCentimetros.Size = new System.Drawing.Size(243, 20);
            this.TCentimetros.TabIndex = 0;
            // 
            // LEstética
            // 
            this.LEstética.AutoSize = true;
            this.LEstética.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstética.Location = new System.Drawing.Point(552, 81);
            this.LEstética.Name = "LEstética";
            this.LEstética.Size = new System.Drawing.Size(45, 24);
            this.LEstética.TabIndex = 1;
            this.LEstética.Text = "cms";
            // 
            // LAltura
            // 
            this.LAltura.AutoSize = true;
            this.LAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAltura.Location = new System.Drawing.Point(201, 81);
            this.LAltura.Name = "LAltura";
            this.LAltura.Size = new System.Drawing.Size(58, 24);
            this.LAltura.TabIndex = 2;
            this.LAltura.Text = "Altura";
            // 
            // LResultado
            // 
            this.LResultado.AutoSize = true;
            this.LResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResultado.Location = new System.Drawing.Point(283, 366);
            this.LResultado.Name = "LResultado";
            this.LResultado.Size = new System.Drawing.Size(0, 24);
            this.LResultado.TabIndex = 3;
            // 
            // BSolucion
            // 
            this.BSolucion.Location = new System.Drawing.Point(287, 171);
            this.BSolucion.Name = "BSolucion";
            this.BSolucion.Size = new System.Drawing.Size(243, 109);
            this.BSolucion.TabIndex = 4;
            this.BSolucion.Text = "Cambiar a metros y centímetros";
            this.BSolucion.UseVisualStyleBackColor = true;
            this.BSolucion.Click += new System.EventHandler(this.BSolucion_Click);
            // 
            // Ejercicio207
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSolucion);
            this.Controls.Add(this.LResultado);
            this.Controls.Add(this.LAltura);
            this.Controls.Add(this.LEstética);
            this.Controls.Add(this.TCentimetros);
            this.Name = "Ejercicio207";
            this.Text = "Ejercicio207";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCentimetros;
        private System.Windows.Forms.Label LEstética;
        private System.Windows.Forms.Label LAltura;
        private System.Windows.Forms.Label LResultado;
        private System.Windows.Forms.Button BSolucion;
    }
}

