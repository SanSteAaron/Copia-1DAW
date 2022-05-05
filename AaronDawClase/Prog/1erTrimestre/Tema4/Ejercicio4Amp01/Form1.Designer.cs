
namespace Ejercicio4Amp01
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
            this.CNum1 = new System.Windows.Forms.TextBox();
            this.CNum2 = new System.Windows.Forms.TextBox();
            this.BPrimos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CNum1
            // 
            this.CNum1.Location = new System.Drawing.Point(268, 128);
            this.CNum1.Name = "CNum1";
            this.CNum1.Size = new System.Drawing.Size(175, 20);
            this.CNum1.TabIndex = 0;
            // 
            // CNum2
            // 
            this.CNum2.Location = new System.Drawing.Point(268, 186);
            this.CNum2.Name = "CNum2";
            this.CNum2.Size = new System.Drawing.Size(175, 20);
            this.CNum2.TabIndex = 1;
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(268, 291);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(175, 94);
            this.BPrimos.TabIndex = 2;
            this.BPrimos.Text = "Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPrimos);
            this.Controls.Add(this.CNum2);
            this.Controls.Add(this.CNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CNum1;
        private System.Windows.Forms.TextBox CNum2;
        private System.Windows.Forms.Button BPrimos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

