
namespace Exercice605
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
            this.BCopyNumbers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroduceNumbers
            // 
            this.BIntroduceNumbers.Location = new System.Drawing.Point(256, 52);
            this.BIntroduceNumbers.Name = "BIntroduceNumbers";
            this.BIntroduceNumbers.Size = new System.Drawing.Size(232, 66);
            this.BIntroduceNumbers.TabIndex = 0;
            this.BIntroduceNumbers.Text = "Introduce numbers";
            this.BIntroduceNumbers.UseVisualStyleBackColor = true;
            this.BIntroduceNumbers.Click += new System.EventHandler(this.BIntroduceNumbers_Click);
            // 
            // BCopyNumbers
            // 
            this.BCopyNumbers.Location = new System.Drawing.Point(256, 138);
            this.BCopyNumbers.Name = "BCopyNumbers";
            this.BCopyNumbers.Size = new System.Drawing.Size(232, 66);
            this.BCopyNumbers.TabIndex = 1;
            this.BCopyNumbers.Text = "Copy Numbers";
            this.BCopyNumbers.UseVisualStyleBackColor = true;
            this.BCopyNumbers.Click += new System.EventHandler(this.BCopyNumbers_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Move Numbers";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BShowResult
            // 
            this.BShowResult.Location = new System.Drawing.Point(256, 321);
            this.BShowResult.Name = "BShowResult";
            this.BShowResult.Size = new System.Drawing.Size(232, 66);
            this.BShowResult.TabIndex = 3;
            this.BShowResult.Text = "Show Result";
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BCopyNumbers);
            this.Controls.Add(this.BIntroduceNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroduceNumbers;
        private System.Windows.Forms.Button BCopyNumbers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BShowResult;
    }
}

