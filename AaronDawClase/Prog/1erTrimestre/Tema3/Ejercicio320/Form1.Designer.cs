namespace Ejercicio320
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
            this.BPotencia = new System.Windows.Forms.Button();
            this.CNumero = new System.Windows.Forms.TextBox();
            this.CPotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BPotencia
            // 
            this.BPotencia.Location = new System.Drawing.Point(236, 213);
            this.BPotencia.Name = "BPotencia";
            this.BPotencia.Size = new System.Drawing.Size(336, 80);
            this.BPotencia.TabIndex = 0;
            this.BPotencia.Text = "Calcular potencia";
            this.BPotencia.UseVisualStyleBackColor = true;
            this.BPotencia.Click += new System.EventHandler(this.BPotencia_Click);
            // 
            // CNumero
            // 
            this.CNumero.Location = new System.Drawing.Point(236, 69);
            this.CNumero.Name = "CNumero";
            this.CNumero.Size = new System.Drawing.Size(336, 20);
            this.CNumero.TabIndex = 1;
            // 
            // CPotencia
            // 
            this.CPotencia.Location = new System.Drawing.Point(236, 130);
            this.CPotencia.Name = "CPotencia";
            this.CPotencia.Size = new System.Drawing.Size(336, 20);
            this.CPotencia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Potencia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPotencia);
            this.Controls.Add(this.CNumero);
            this.Controls.Add(this.BPotencia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPotencia;
        private System.Windows.Forms.TextBox CNumero;
        private System.Windows.Forms.TextBox CPotencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

