namespace Ejercicio210
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
            this.TEuros = new System.Windows.Forms.TextBox();
            this.TPesetas = new System.Windows.Forms.TextBox();
            this.BPaE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BEaP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEuros
            // 
            this.TEuros.Location = new System.Drawing.Point(298, 146);
            this.TEuros.Name = "TEuros";
            this.TEuros.Size = new System.Drawing.Size(214, 20);
            this.TEuros.TabIndex = 0;
            // 
            // TPesetas
            // 
            this.TPesetas.Location = new System.Drawing.Point(298, 235);
            this.TPesetas.Name = "TPesetas";
            this.TPesetas.Size = new System.Drawing.Size(214, 20);
            this.TPesetas.TabIndex = 1;
            // 
            // BPaE
            // 
            this.BPaE.Location = new System.Drawing.Point(563, 80);
            this.BPaE.Name = "BPaE";
            this.BPaE.Size = new System.Drawing.Size(169, 86);
            this.BPaE.TabIndex = 2;
            this.BPaE.Text = "Pesetas a Euros";
            this.BPaE.UseVisualStyleBackColor = true;
            this.BPaE.Click += new System.EventHandler(this.BPaE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pesetas";
            // 
            // BEaP
            // 
            this.BEaP.Location = new System.Drawing.Point(563, 235);
            this.BEaP.Name = "BEaP";
            this.BEaP.Size = new System.Drawing.Size(169, 91);
            this.BEaP.TabIndex = 5;
            this.BEaP.Text = "Euros a Pesetas";
            this.BEaP.UseVisualStyleBackColor = true;
            this.BEaP.Click += new System.EventHandler(this.BEaP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BEaP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPaE);
            this.Controls.Add(this.TPesetas);
            this.Controls.Add(this.TEuros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TEuros;
        private System.Windows.Forms.TextBox TPesetas;
        private System.Windows.Forms.Button BPaE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BEaP;
    }
}

