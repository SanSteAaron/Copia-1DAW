namespace Ejercicio311
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
            this.CHora = new System.Windows.Forms.TextBox();
            this.CMinutos = new System.Windows.Forms.TextBox();
            this.CSegundos = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CHora
            // 
            this.CHora.Location = new System.Drawing.Point(253, 99);
            this.CHora.Name = "CHora";
            this.CHora.Size = new System.Drawing.Size(247, 20);
            this.CHora.TabIndex = 0;
            // 
            // CMinutos
            // 
            this.CMinutos.Location = new System.Drawing.Point(253, 152);
            this.CMinutos.Name = "CMinutos";
            this.CMinutos.Size = new System.Drawing.Size(247, 20);
            this.CMinutos.TabIndex = 1;
            // 
            // CSegundos
            // 
            this.CSegundos.Location = new System.Drawing.Point(253, 211);
            this.CSegundos.Name = "CSegundos";
            this.CSegundos.Size = new System.Drawing.Size(247, 20);
            this.CSegundos.TabIndex = 2;
            // 
            // BCalcular
            // 
            this.BCalcular.Location = new System.Drawing.Point(253, 270);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(247, 55);
            this.BCalcular.TabIndex = 3;
            this.BCalcular.Text = "Calcular";
            this.BCalcular.UseVisualStyleBackColor = true;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minutos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Segundos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.CSegundos);
            this.Controls.Add(this.CMinutos);
            this.Controls.Add(this.CHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CHora;
        private System.Windows.Forms.TextBox CMinutos;
        private System.Windows.Forms.TextBox CSegundos;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

