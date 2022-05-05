namespace Ejercicio314
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BFor = new System.Windows.Forms.Button();
            this.BWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 0;
            // 
            // BFor
            // 
            this.BFor.Location = new System.Drawing.Point(142, 211);
            this.BFor.Name = "BFor";
            this.BFor.Size = new System.Drawing.Size(218, 72);
            this.BFor.TabIndex = 1;
            this.BFor.Text = "FOR";
            this.BFor.UseVisualStyleBackColor = true;
            this.BFor.Click += new System.EventHandler(this.BFor_Click);
            // 
            // BWhile
            // 
            this.BWhile.Location = new System.Drawing.Point(433, 211);
            this.BWhile.Name = "BWhile";
            this.BWhile.Size = new System.Drawing.Size(218, 72);
            this.BWhile.TabIndex = 2;
            this.BWhile.Text = "WHILE";
            this.BWhile.UseVisualStyleBackColor = true;
            this.BWhile.Click += new System.EventHandler(this.BWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BWhile);
            this.Controls.Add(this.BFor);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BFor;
        private System.Windows.Forms.Button BWhile;
    }
}

