
namespace Ejercicio213
{
    partial class Ejercicio213
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
            this.THoras = new System.Windows.Forms.TextBox();
            this.TPago = new System.Windows.Forms.TextBox();
            this.TExtras = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BCalculo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // THoras
            // 
            this.THoras.Location = new System.Drawing.Point(175, 195);
            this.THoras.Name = "THoras";
            this.THoras.Size = new System.Drawing.Size(154, 20);
            this.THoras.TabIndex = 0;
            // 
            // TPago
            // 
            this.TPago.Location = new System.Drawing.Point(175, 152);
            this.TPago.Name = "TPago";
            this.TPago.Size = new System.Drawing.Size(154, 20);
            this.TPago.TabIndex = 1;
            // 
            // TExtras
            // 
            this.TExtras.Location = new System.Drawing.Point(175, 236);
            this.TExtras.Name = "TExtras";
            this.TExtras.Size = new System.Drawing.Size(154, 20);
            this.TExtras.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(89, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extras:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pago por horas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(91, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas:";
            // 
            // BCalculo
            // 
            this.BCalculo.Location = new System.Drawing.Point(390, 152);
            this.BCalculo.Name = "BCalculo";
            this.BCalculo.Size = new System.Drawing.Size(227, 104);
            this.BCalculo.TabIndex = 6;
            this.BCalculo.Text = "Calcular";
            this.BCalculo.UseVisualStyleBackColor = true;
            this.BCalculo.Click += new System.EventHandler(this.BCalculo_Click);
            // 
            // Ejercicio213
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BCalculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TExtras);
            this.Controls.Add(this.TPago);
            this.Controls.Add(this.THoras);
            this.Name = "Ejercicio213";
            this.Text = "Ejercicio213";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox THoras;
        private System.Windows.Forms.TextBox TPago;
        private System.Windows.Forms.TextBox TExtras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BCalculo;
    }
}

