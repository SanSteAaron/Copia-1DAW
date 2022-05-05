namespace Ejercicio309
{
    partial class Ejercicio308
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
            this.BCambio = new System.Windows.Forms.Button();
            this.TPesetas = new System.Windows.Forms.TextBox();
            this.LBilletes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BCambio
            // 
            this.BCambio.Location = new System.Drawing.Point(207, 177);
            this.BCambio.Name = "BCambio";
            this.BCambio.Size = new System.Drawing.Size(236, 127);
            this.BCambio.TabIndex = 0;
            this.BCambio.Text = "Cambio";
            this.BCambio.UseVisualStyleBackColor = true;
            this.BCambio.Click += new System.EventHandler(this.BCambio_Click);
            // 
            // TPesetas
            // 
            this.TPesetas.Location = new System.Drawing.Point(207, 119);
            this.TPesetas.Name = "TPesetas";
            this.TPesetas.Size = new System.Drawing.Size(236, 20);
            this.TPesetas.TabIndex = 1;
            // 
            // LBilletes
            // 
            this.LBilletes.AutoSize = true;
            this.LBilletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBilletes.ForeColor = System.Drawing.SystemColors.Control;
            this.LBilletes.Location = new System.Drawing.Point(496, 105);
            this.LBilletes.Name = "LBilletes";
            this.LBilletes.Size = new System.Drawing.Size(0, 20);
            this.LBilletes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(130, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesetas:";
            // 
            // Ejercicio308
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBilletes);
            this.Controls.Add(this.TPesetas);
            this.Controls.Add(this.BCambio);
            this.Name = "Ejercicio308";
            this.Text = "Ejercicio308";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCambio;
        private System.Windows.Forms.TextBox TPesetas;
        private System.Windows.Forms.Label LBilletes;
        private System.Windows.Forms.Label label1;
    }
}

