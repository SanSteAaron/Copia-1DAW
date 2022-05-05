namespace Ejercicio406
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
            this.CDivisor = new System.Windows.Forms.TextBox();
            this.CDividendo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(232, 257);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(326, 128);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Resultado";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // CDivisor
            // 
            this.CDivisor.Location = new System.Drawing.Point(232, 192);
            this.CDivisor.Name = "CDivisor";
            this.CDivisor.Size = new System.Drawing.Size(326, 20);
            this.CDivisor.TabIndex = 1;
            // 
            // CDividendo
            // 
            this.CDividendo.Location = new System.Drawing.Point(232, 119);
            this.CDividendo.Name = "CDividendo";
            this.CDividendo.Size = new System.Drawing.Size(326, 20);
            this.CDividendo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CDividendo);
            this.Controls.Add(this.CDivisor);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.TextBox CDivisor;
        private System.Windows.Forms.TextBox CDividendo;
    }
}

