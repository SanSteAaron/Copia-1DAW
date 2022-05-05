namespace Ejercicio401
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
            this.CNúmero2 = new System.Windows.Forms.TextBox();
            this.CNúmero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(280, 256);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(224, 103);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Suma";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // CNúmero2
            // 
            this.CNúmero2.Location = new System.Drawing.Point(280, 179);
            this.CNúmero2.Name = "CNúmero2";
            this.CNúmero2.Size = new System.Drawing.Size(224, 20);
            this.CNúmero2.TabIndex = 1;
            // 
            // CNúmero1
            // 
            this.CNúmero1.Location = new System.Drawing.Point(280, 109);
            this.CNúmero1.Name = "CNúmero1";
            this.CNúmero1.Size = new System.Drawing.Size(224, 20);
            this.CNúmero1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserte dos números para la suma. (Uno en cada cuadro).";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CNúmero1);
            this.Controls.Add(this.CNúmero2);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.TextBox CNúmero2;
        private System.Windows.Forms.TextBox CNúmero1;
        private System.Windows.Forms.Label label1;
    }
}

