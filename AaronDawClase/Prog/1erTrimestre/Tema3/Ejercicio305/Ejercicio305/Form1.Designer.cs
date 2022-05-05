namespace Ejercicio305
{
    partial class Ejercicio305
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
            this.TNum1 = new System.Windows.Forms.TextBox();
            this.TNum3 = new System.Windows.Forms.TextBox();
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.BComparar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(295, 58);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(213, 20);
            this.TNum1.TabIndex = 0;
            // 
            // TNum3
            // 
            this.TNum3.Location = new System.Drawing.Point(295, 149);
            this.TNum3.Name = "TNum3";
            this.TNum3.Size = new System.Drawing.Size(213, 20);
            this.TNum3.TabIndex = 1;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(295, 103);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(213, 20);
            this.TNum2.TabIndex = 2;
            // 
            // BComparar
            // 
            this.BComparar.Location = new System.Drawing.Point(142, 194);
            this.BComparar.Name = "BComparar";
            this.BComparar.Size = new System.Drawing.Size(527, 188);
            this.BComparar.TabIndex = 3;
            this.BComparar.Text = "Comparar";
            this.BComparar.UseVisualStyleBackColor = true;
            this.BComparar.Click += new System.EventHandler(this.BComparar_Click);
            // 
            // Ejercicio305
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BComparar);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum3);
            this.Controls.Add(this.TNum1);
            this.Name = "Ejercicio305";
            this.Text = "Ejercicio305";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum3;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Button BComparar;
    }
}

