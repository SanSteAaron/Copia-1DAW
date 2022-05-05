namespace Ejercicio302
{
    partial class Ejercicio302
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
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.BComprobar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(304, 49);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(203, 20);
            this.TNum1.TabIndex = 0;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(304, 111);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(202, 20);
            this.TNum2.TabIndex = 1;
            // 
            // BComprobar
            // 
            this.BComprobar.Location = new System.Drawing.Point(304, 165);
            this.BComprobar.Name = "BComprobar";
            this.BComprobar.Size = new System.Drawing.Size(203, 86);
            this.BComprobar.TabIndex = 2;
            this.BComprobar.Text = "Comprobar";
            this.BComprobar.UseVisualStyleBackColor = true;
            this.BComprobar.Click += new System.EventHandler(this.BComprobar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(187, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(187, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero 2:";
            // 
            // Ejercicio302
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BComprobar);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum1);
            this.Name = "Ejercicio302";
            this.Text = "Ejercicio302";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Button BComprobar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

