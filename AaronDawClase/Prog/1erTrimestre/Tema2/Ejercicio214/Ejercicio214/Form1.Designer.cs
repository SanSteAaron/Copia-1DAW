namespace Ejercicio214
{
    partial class Ejercicio214
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
            this.BDistinto = new System.Windows.Forms.Button();
            this.BMenor = new System.Windows.Forms.Button();
            this.BIgual = new System.Windows.Forms.Button();
            this.BMayor = new System.Windows.Forms.Button();
            this.LResulotado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(140, 80);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(247, 20);
            this.TNum1.TabIndex = 0;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(415, 80);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(246, 20);
            this.TNum2.TabIndex = 1;
            // 
            // BDistinto
            // 
            this.BDistinto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDistinto.Location = new System.Drawing.Point(544, 147);
            this.BDistinto.Name = "BDistinto";
            this.BDistinto.Size = new System.Drawing.Size(104, 70);
            this.BDistinto.TabIndex = 2;
            this.BDistinto.Text = "!=";
            this.BDistinto.UseVisualStyleBackColor = true;
            this.BDistinto.Click += new System.EventHandler(this.BDistinto_Click);
            // 
            // BMenor
            // 
            this.BMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMenor.Location = new System.Drawing.Point(283, 147);
            this.BMenor.Name = "BMenor";
            this.BMenor.Size = new System.Drawing.Size(104, 70);
            this.BMenor.TabIndex = 3;
            this.BMenor.Text = "<";
            this.BMenor.UseVisualStyleBackColor = true;
            this.BMenor.Click += new System.EventHandler(this.BMenor_Click);
            // 
            // BIgual
            // 
            this.BIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BIgual.Location = new System.Drawing.Point(415, 147);
            this.BIgual.Name = "BIgual";
            this.BIgual.Size = new System.Drawing.Size(104, 70);
            this.BIgual.TabIndex = 4;
            this.BIgual.Text = "==";
            this.BIgual.UseVisualStyleBackColor = true;
            this.BIgual.Click += new System.EventHandler(this.BIgual_Click);
            // 
            // BMayor
            // 
            this.BMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMayor.Location = new System.Drawing.Point(139, 147);
            this.BMayor.Name = "BMayor";
            this.BMayor.Size = new System.Drawing.Size(104, 70);
            this.BMayor.TabIndex = 5;
            this.BMayor.Text = ">";
            this.BMayor.UseVisualStyleBackColor = true;
            this.BMayor.Click += new System.EventHandler(this.BMayor_Click);
            // 
            // LResulotado
            // 
            this.LResulotado.AutoSize = true;
            this.LResulotado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LResulotado.ForeColor = System.Drawing.SystemColors.Control;
            this.LResulotado.Location = new System.Drawing.Point(379, 373);
            this.LResulotado.Name = "LResulotado";
            this.LResulotado.Size = new System.Drawing.Size(0, 24);
            this.LResulotado.TabIndex = 6;
            // 
            // Ejercicio214
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LResulotado);
            this.Controls.Add(this.BMayor);
            this.Controls.Add(this.BIgual);
            this.Controls.Add(this.BMenor);
            this.Controls.Add(this.BDistinto);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum1);
            this.Name = "Ejercicio214";
            this.Text = "Ejercicio214";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.Button BDistinto;
        private System.Windows.Forms.Button BMenor;
        private System.Windows.Forms.Button BIgual;
        private System.Windows.Forms.Button BMayor;
        private System.Windows.Forms.Label LResulotado;
    }
}

