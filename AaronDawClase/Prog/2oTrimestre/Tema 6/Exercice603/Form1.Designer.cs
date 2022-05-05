
namespace Exercice603
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
            this.BIntroduceNumbers = new System.Windows.Forms.Button();
            this.BCopyPrimeNumbers = new System.Windows.Forms.Button();
            this.BMovePrimeNumbers = new System.Windows.Forms.Button();
            this.BShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroduceNumbers
            // 
            this.BIntroduceNumbers.Location = new System.Drawing.Point(243, 95);
            this.BIntroduceNumbers.Name = "BIntroduceNumbers";
            this.BIntroduceNumbers.Size = new System.Drawing.Size(240, 51);
            this.BIntroduceNumbers.TabIndex = 0;
            this.BIntroduceNumbers.Text = "Introduce numbers";
            this.BIntroduceNumbers.UseVisualStyleBackColor = true;
            this.BIntroduceNumbers.Click += new System.EventHandler(this.BIntroduceNumbers_Click);
            // 
            // BCopyPrimeNumbers
            // 
            this.BCopyPrimeNumbers.Location = new System.Drawing.Point(243, 170);
            this.BCopyPrimeNumbers.Name = "BCopyPrimeNumbers";
            this.BCopyPrimeNumbers.Size = new System.Drawing.Size(240, 51);
            this.BCopyPrimeNumbers.TabIndex = 1;
            this.BCopyPrimeNumbers.Text = "Copy prime numbers";
            this.BCopyPrimeNumbers.UseVisualStyleBackColor = true;
            this.BCopyPrimeNumbers.Click += new System.EventHandler(this.BCopyPrimeNumbers_Click);
            // 
            // BMovePrimeNumbers
            // 
            this.BMovePrimeNumbers.Location = new System.Drawing.Point(243, 241);
            this.BMovePrimeNumbers.Name = "BMovePrimeNumbers";
            this.BMovePrimeNumbers.Size = new System.Drawing.Size(240, 51);
            this.BMovePrimeNumbers.TabIndex = 2;
            this.BMovePrimeNumbers.Text = "Move prime numbers";
            this.BMovePrimeNumbers.UseVisualStyleBackColor = true;
            this.BMovePrimeNumbers.Click += new System.EventHandler(this.BMovePrimeNumbers_Click);
            // 
            // BShowResult
            // 
            this.BShowResult.Location = new System.Drawing.Point(243, 315);
            this.BShowResult.Name = "BShowResult";
            this.BShowResult.Size = new System.Drawing.Size(240, 51);
            this.BShowResult.TabIndex = 3;
            this.BShowResult.Text = "Show result";
            this.BShowResult.UseVisualStyleBackColor = true;
            this.BShowResult.Click += new System.EventHandler(this.BShowResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BShowResult);
            this.Controls.Add(this.BMovePrimeNumbers);
            this.Controls.Add(this.BCopyPrimeNumbers);
            this.Controls.Add(this.BIntroduceNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroduceNumbers;
        private System.Windows.Forms.Button BCopyPrimeNumbers;
        private System.Windows.Forms.Button BMovePrimeNumbers;
        private System.Windows.Forms.Button BShowResult;
    }
}

