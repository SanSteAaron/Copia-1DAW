namespace Ejercicio408
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.CNúm1 = new System.Windows.Forms.TextBox();
            this.CNúm3 = new System.Windows.Forms.TextBox();
            this.CNúm2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(267, 275);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(278, 101);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Nota media";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // CNúm1
            // 
            this.CNúm1.Location = new System.Drawing.Point(267, 100);
            this.CNúm1.Name = "CNúm1";
            this.CNúm1.Size = new System.Drawing.Size(278, 20);
            this.CNúm1.TabIndex = 1;
            // 
            // CNúm3
            // 
            this.CNúm3.Location = new System.Drawing.Point(267, 209);
            this.CNúm3.Name = "CNúm3";
            this.CNúm3.Size = new System.Drawing.Size(278, 20);
            this.CNúm3.TabIndex = 2;
            // 
            // CNúm2
            // 
            this.CNúm2.Location = new System.Drawing.Point(267, 152);
            this.CNúm2.Name = "CNúm2";
            this.CNúm2.Size = new System.Drawing.Size(278, 20);
            this.CNúm2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CNúm2);
            this.Controls.Add(this.CNúm3);
            this.Controls.Add(this.CNúm1);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.TextBox CNúm1;
        private System.Windows.Forms.TextBox CNúm3;
        private System.Windows.Forms.TextBox CNúm2;
    }
}

