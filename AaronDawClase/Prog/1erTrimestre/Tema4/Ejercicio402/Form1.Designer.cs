namespace Ejercicio402
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
            this.BDividir = new System.Windows.Forms.Button();
            this.CDividendo = new System.Windows.Forms.TextBox();
            this.CDivisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BDividir
            // 
            this.BDividir.Location = new System.Drawing.Point(199, 265);
            this.BDividir.Name = "BDividir";
            this.BDividir.Size = new System.Drawing.Size(386, 108);
            this.BDividir.TabIndex = 0;
            this.BDividir.Text = "Dividir";
            this.BDividir.UseVisualStyleBackColor = true;
            this.BDividir.Click += new System.EventHandler(this.BDividir_Click);
            // 
            // CDividendo
            // 
            this.CDividendo.Location = new System.Drawing.Point(199, 144);
            this.CDividendo.Name = "CDividendo";
            this.CDividendo.Size = new System.Drawing.Size(386, 20);
            this.CDividendo.TabIndex = 1;
            // 
            // CDivisor
            // 
            this.CDivisor.Location = new System.Drawing.Point(199, 198);
            this.CDivisor.Name = "CDivisor";
            this.CDivisor.Size = new System.Drawing.Size(386, 20);
            this.CDivisor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dividendo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Divisor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CDivisor);
            this.Controls.Add(this.CDividendo);
            this.Controls.Add(this.BDividir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BDividir;
        private System.Windows.Forms.TextBox CDividendo;
        private System.Windows.Forms.TextBox CDivisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

