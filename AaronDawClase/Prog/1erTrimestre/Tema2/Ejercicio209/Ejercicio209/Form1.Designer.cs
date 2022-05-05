namespace Ejercicio209
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
            this.TNum1 = new System.Windows.Forms.TextBox();
            this.TNum2 = new System.Windows.Forms.TextBox();
            this.TResultado = new System.Windows.Forms.TextBox();
            this.BResta = new System.Windows.Forms.Button();
            this.BSuma = new System.Windows.Forms.Button();
            this.BDivision = new System.Windows.Forms.Button();
            this.BMultiplicar = new System.Windows.Forms.Button();
            this.BResto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TNum1
            // 
            this.TNum1.Location = new System.Drawing.Point(132, 110);
            this.TNum1.Name = "TNum1";
            this.TNum1.Size = new System.Drawing.Size(202, 20);
            this.TNum1.TabIndex = 0;
            // 
            // TNum2
            // 
            this.TNum2.Location = new System.Drawing.Point(132, 189);
            this.TNum2.Name = "TNum2";
            this.TNum2.Size = new System.Drawing.Size(202, 20);
            this.TNum2.TabIndex = 1;
            // 
            // TResultado
            // 
            this.TResultado.Location = new System.Drawing.Point(132, 288);
            this.TResultado.Name = "TResultado";
            this.TResultado.Size = new System.Drawing.Size(202, 20);
            this.TResultado.TabIndex = 2;
            // 
            // BResta
            // 
            this.BResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BResta.Location = new System.Drawing.Point(405, 110);
            this.BResta.Name = "BResta";
            this.BResta.Size = new System.Drawing.Size(75, 62);
            this.BResta.TabIndex = 3;
            this.BResta.Text = "-";
            this.BResta.UseVisualStyleBackColor = true;
            this.BResta.Click += new System.EventHandler(this.BResta_Click);
            // 
            // BSuma
            // 
            this.BSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSuma.Location = new System.Drawing.Point(505, 110);
            this.BSuma.Name = "BSuma";
            this.BSuma.Size = new System.Drawing.Size(77, 62);
            this.BSuma.TabIndex = 4;
            this.BSuma.Text = "+";
            this.BSuma.UseVisualStyleBackColor = true;
            this.BSuma.Click += new System.EventHandler(this.BSuma_Click);
            // 
            // BDivision
            // 
            this.BDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BDivision.Location = new System.Drawing.Point(405, 196);
            this.BDivision.Name = "BDivision";
            this.BDivision.Size = new System.Drawing.Size(75, 63);
            this.BDivision.TabIndex = 5;
            this.BDivision.Text = "/";
            this.BDivision.UseVisualStyleBackColor = true;
            this.BDivision.Click += new System.EventHandler(this.BDivision_Click);
            // 
            // BMultiplicar
            // 
            this.BMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMultiplicar.Location = new System.Drawing.Point(505, 196);
            this.BMultiplicar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.BMultiplicar.Name = "BMultiplicar";
            this.BMultiplicar.Size = new System.Drawing.Size(77, 63);
            this.BMultiplicar.TabIndex = 6;
            this.BMultiplicar.Text = "*";
            this.BMultiplicar.UseVisualStyleBackColor = true;
            this.BMultiplicar.Click += new System.EventHandler(this.BMultiplicar_Click);
            // 
            // BResto
            // 
            this.BResto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BResto.Location = new System.Drawing.Point(472, 288);
            this.BResto.Name = "BResto";
            this.BResto.Size = new System.Drawing.Size(110, 66);
            this.BResto.TabIndex = 7;
            this.BResto.Text = "%";
            this.BResto.UseVisualStyleBackColor = true;
            this.BResto.Click += new System.EventHandler(this.BResto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "NUM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NUM:";
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
            this.Controls.Add(this.BResto);
            this.Controls.Add(this.BMultiplicar);
            this.Controls.Add(this.BDivision);
            this.Controls.Add(this.BSuma);
            this.Controls.Add(this.BResta);
            this.Controls.Add(this.TResultado);
            this.Controls.Add(this.TNum2);
            this.Controls.Add(this.TNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNum1;
        private System.Windows.Forms.TextBox TNum2;
        private System.Windows.Forms.TextBox TResultado;
        private System.Windows.Forms.Button BResta;
        private System.Windows.Forms.Button BSuma;
        private System.Windows.Forms.Button BDivision;
        private System.Windows.Forms.Button BMultiplicar;
        private System.Windows.Forms.Button BResto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

