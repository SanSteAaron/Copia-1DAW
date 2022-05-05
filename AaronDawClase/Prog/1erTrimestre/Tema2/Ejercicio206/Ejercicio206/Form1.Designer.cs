
namespace Ejercicio206
{
    partial class Ejercicio206
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
            this.BOperar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNumero1
            // 
            this.TNumero1.Location = new System.Drawing.Point(288, 93);
            this.TNumero1.Name = "TNumero1";
            this.TNumero1.Size = new System.Drawing.Size(174, 20);
            this.TNumero1.TabIndex = 0;
            // 
            // TNumero2
            // 
            this.TNumero2.Location = new System.Drawing.Point(288, 166);
            this.TNumero2.Name = "TNumero2";
            this.TNumero2.Size = new System.Drawing.Size(173, 20);
            this.TNumero2.TabIndex = 1;
            // 
            // BOperar
            // 
            this.BOperar.BackColor = System.Drawing.Color.White;
            this.BOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BOperar.Location = new System.Drawing.Point(230, 231);
            this.BOperar.Name = "BOperar";
            this.BOperar.Size = new System.Drawing.Size(295, 79);
            this.BOperar.TabIndex = 2;
            this.BOperar.Text = "Dividir";
            this.BOperar.UseVisualStyleBackColor = false;
            this.BOperar.Click += new System.EventHandler(this.BOperar_Click);
            // 
            // Ejercicio206
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BOperar);
            this.Controls.Add(this.TNumero2);
            this.Controls.Add(this.TNumero1);
            this.Name = "Ejercicio206";
            this.Text = "Ejercicio206";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNumero1;
        private System.Windows.Forms.TextBox TNumero2;
        private System.Windows.Forms.Button BOperar;
    }
}

