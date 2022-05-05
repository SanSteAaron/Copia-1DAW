namespace Ejercicio404
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
            this.CNum = new System.Windows.Forms.TextBox();
            this.BPrimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CNum
            // 
            this.CNum.Location = new System.Drawing.Point(286, 174);
            this.CNum.Name = "CNum";
            this.CNum.Size = new System.Drawing.Size(220, 20);
            this.CNum.TabIndex = 0;
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(286, 240);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(220, 71);
            this.BPrimero.TabIndex = 1;
            this.BPrimero.Text = "Valor absoluto";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BPrimero);
            this.Controls.Add(this.CNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CNum;
        private System.Windows.Forms.Button BPrimero;
    }
}

