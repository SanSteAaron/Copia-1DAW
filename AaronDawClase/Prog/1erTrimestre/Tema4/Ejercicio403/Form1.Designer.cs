namespace Ejercicio403
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
            this.button1 = new System.Windows.Forms.Button();
            this.CNum1 = new System.Windows.Forms.TextBox();
            this.CNum2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Intercambio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CNum1
            // 
            this.CNum1.Location = new System.Drawing.Point(269, 113);
            this.CNum1.Name = "CNum1";
            this.CNum1.Size = new System.Drawing.Size(261, 20);
            this.CNum1.TabIndex = 1;
            // 
            // CNum2
            // 
            this.CNum2.Location = new System.Drawing.Point(269, 186);
            this.CNum2.Name = "CNum2";
            this.CNum2.Size = new System.Drawing.Size(261, 20);
            this.CNum2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CNum2);
            this.Controls.Add(this.CNum1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CNum1;
        private System.Windows.Forms.TextBox CNum2;
    }
}

