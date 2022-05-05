namespace Ejercicio205
{
    partial class Ejercicio205
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
            this.TNumero1 = new System.Windows.Forms.TextBox();
            this.TNumero2 = new System.Windows.Forms.TextBox();
            this.TResultado = new System.Windows.Forms.TextBox();
            this.LNumero1 = new System.Windows.Forms.Label();
            this.LNumero2 = new System.Windows.Forms.Label();
            this.LNumero = new System.Windows.Forms.Label();
            this.BSuma = new System.Windows.Forms.Button();
            this.BRestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero1
            // 
            this.TNumero1.Location = new System.Drawing.Point(135, 67);
            this.TNumero1.Name = "TNumero1";
            this.TNumero1.Size = new System.Drawing.Size(168, 20);
            this.TNumero1.TabIndex = 0;
            // 
            // TNumero2
            // 
            this.TNumero2.Location = new System.Drawing.Point(135, 146);
            this.TNumero2.Name = "TNumero2";
            this.TNumero2.Size = new System.Drawing.Size(168, 20);
            this.TNumero2.TabIndex = 1;
            // 
            // TResultado
            // 
            this.TResultado.Location = new System.Drawing.Point(135, 326);
            this.TResultado.Name = "TResultado";
            this.TResultado.Size = new System.Drawing.Size(168, 20);
            this.TResultado.TabIndex = 2;
            // 
            // LNumero1
            // 
            this.LNumero1.AutoSize = true;
            this.LNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNumero1.ForeColor = System.Drawing.SystemColors.Control;
            this.LNumero1.Location = new System.Drawing.Point(47, 67);
            this.LNumero1.Name = "LNumero1";
            this.LNumero1.Size = new System.Drawing.Size(65, 20);
            this.LNumero1.TabIndex = 3;
            this.LNumero1.Text = "Numero";
            // 
            // LNumero2
            // 
            this.LNumero2.AutoSize = true;
            this.LNumero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNumero2.ForeColor = System.Drawing.SystemColors.Control;
            this.LNumero2.Location = new System.Drawing.Point(47, 146);
            this.LNumero2.Name = "LNumero2";
            this.LNumero2.Size = new System.Drawing.Size(65, 20);
            this.LNumero2.TabIndex = 4;
            this.LNumero2.Text = "Numero";
            // 
            // LNumero
            // 
            this.LNumero.AutoSize = true;
            this.LNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNumero.ForeColor = System.Drawing.SystemColors.Control;
            this.LNumero.Location = new System.Drawing.Point(47, 326);
            this.LNumero.Name = "LNumero";
            this.LNumero.Size = new System.Drawing.Size(82, 20);
            this.LNumero.TabIndex = 5;
            this.LNumero.Text = "Resultado";
            // 
            // BSuma
            // 
            this.BSuma.BackColor = System.Drawing.Color.White;
            this.BSuma.ForeColor = System.Drawing.Color.Black;
            this.BSuma.Location = new System.Drawing.Point(370, 67);
            this.BSuma.Name = "BSuma";
            this.BSuma.Size = new System.Drawing.Size(143, 99);
            this.BSuma.TabIndex = 6;
            this.BSuma.Text = "Sumar";
            this.BSuma.UseVisualStyleBackColor = false;
            this.BSuma.Click += new System.EventHandler(this.BSuma_Click);
            // 
            // BRestar
            // 
            this.BRestar.BackColor = System.Drawing.Color.White;
            this.BRestar.Location = new System.Drawing.Point(544, 67);
            this.BRestar.Name = "BRestar";
            this.BRestar.Size = new System.Drawing.Size(143, 99);
            this.BRestar.TabIndex = 7;
            this.BRestar.Text = "Restar";
            this.BRestar.UseVisualStyleBackColor = false;
            // 
            // Ejercicio205
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BRestar);
            this.Controls.Add(this.BSuma);
            this.Controls.Add(this.LNumero);
            this.Controls.Add(this.LNumero2);
            this.Controls.Add(this.LNumero1);
            this.Controls.Add(this.TResultado);
            this.Controls.Add(this.TNumero2);
            this.Controls.Add(this.TNumero1);
            this.Name = "Ejercicio205";
            this.Text = "Ejercicio205";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero1;
        private System.Windows.Forms.TextBox TNumero2;
        private System.Windows.Forms.TextBox TResultado;
        private System.Windows.Forms.Label LNumero1;
        private System.Windows.Forms.Label LNumero2;
        private System.Windows.Forms.Label LNumero;
        private System.Windows.Forms.Button BSuma;
        private System.Windows.Forms.Button BRestar;
    }
}

