namespace Ejercicio413
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
            this.CYear = new System.Windows.Forms.TextBox();
            this.CMonth = new System.Windows.Forms.TextBox();
            this.CDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 111);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fecha siguiente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CYear
            // 
            this.CYear.Location = new System.Drawing.Point(236, 209);
            this.CYear.Name = "CYear";
            this.CYear.Size = new System.Drawing.Size(100, 20);
            this.CYear.TabIndex = 1;
            // 
            // CMonth
            // 
            this.CMonth.Location = new System.Drawing.Point(236, 158);
            this.CMonth.Name = "CMonth";
            this.CMonth.Size = new System.Drawing.Size(100, 20);
            this.CMonth.TabIndex = 2;
            // 
            // CDay
            // 
            this.CDay.Location = new System.Drawing.Point(236, 104);
            this.CDay.Name = "CDay";
            this.CDay.Size = new System.Drawing.Size(100, 20);
            this.CDay.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CDay);
            this.Controls.Add(this.CMonth);
            this.Controls.Add(this.CYear);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CYear;
        private System.Windows.Forms.TextBox CMonth;
        private System.Windows.Forms.TextBox CDay;
    }
}

