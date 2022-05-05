
namespace Ejercicio417
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
            this.CDividendo = new System.Windows.Forms.TextBox();
            this.CDivisor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CDividendo
            // 
            this.CDividendo.Location = new System.Drawing.Point(282, 160);
            this.CDividendo.Name = "CDividendo";
            this.CDividendo.Size = new System.Drawing.Size(147, 20);
            this.CDividendo.TabIndex = 0;
            // 
            // CDivisor
            // 
            this.CDivisor.Location = new System.Drawing.Point(282, 226);
            this.CDivisor.Name = "CDivisor";
            this.CDivisor.Size = new System.Drawing.Size(147, 20);
            this.CDivisor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dividir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CDivisor);
            this.Controls.Add(this.CDividendo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CDividendo;
        private System.Windows.Forms.TextBox CDivisor;
        private System.Windows.Forms.Button button1;
    }
}

