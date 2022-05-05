
namespace Ejercicio418
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
            this.CuadroM = new System.Windows.Forms.TextBox();
            this.CuadroN = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CuadroM
            // 
            this.CuadroM.Location = new System.Drawing.Point(258, 152);
            this.CuadroM.Name = "CuadroM";
            this.CuadroM.Size = new System.Drawing.Size(263, 20);
            this.CuadroM.TabIndex = 0;
            // 
            // CuadroN
            // 
            this.CuadroN.Location = new System.Drawing.Point(258, 223);
            this.CuadroN.Name = "CuadroN";
            this.CuadroN.Size = new System.Drawing.Size(263, 20);
            this.CuadroN.TabIndex = 1;
            // 
            // BCalcular
            // 
            this.BCalcular.Location = new System.Drawing.Point(258, 305);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(263, 48);
            this.BCalcular.TabIndex = 2;
            this.BCalcular.Text = "Calcular";
            this.BCalcular.UseVisualStyleBackColor = true;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introducir M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introducir N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.CuadroN);
            this.Controls.Add(this.CuadroM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CuadroM;
        private System.Windows.Forms.TextBox CuadroN;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

