
namespace Ejercicio504
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
            this.BLeerNum = new System.Windows.Forms.Button();
            this.BNegative = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerNum
            // 
            this.BLeerNum.Location = new System.Drawing.Point(152, 198);
            this.BLeerNum.Name = "BLeerNum";
            this.BLeerNum.Size = new System.Drawing.Size(201, 128);
            this.BLeerNum.TabIndex = 0;
            this.BLeerNum.Text = "Pedir números";
            this.BLeerNum.UseVisualStyleBackColor = true;
            this.BLeerNum.Click += new System.EventHandler(this.BLeerNum_Click);
            // 
            // BNegative
            // 
            this.BNegative.Location = new System.Drawing.Point(431, 198);
            this.BNegative.Name = "BNegative";
            this.BNegative.Size = new System.Drawing.Size(201, 128);
            this.BNegative.TabIndex = 1;
            this.BNegative.Text = "Mostrar negativos";
            this.BNegative.UseVisualStyleBackColor = true;
            this.BNegative.Click += new System.EventHandler(this.BNegative_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BNegative);
            this.Controls.Add(this.BLeerNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerNum;
        private System.Windows.Forms.Button BNegative;
    }
}

