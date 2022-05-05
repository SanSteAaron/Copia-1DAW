
namespace Exercice604
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
            this.BIntroduceBase = new System.Windows.Forms.Button();
            this.BIntroduceExponent = new System.Windows.Forms.Button();
            this.BShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroduceBase
            // 
            this.BIntroduceBase.Location = new System.Drawing.Point(242, 51);
            this.BIntroduceBase.Name = "BIntroduceBase";
            this.BIntroduceBase.Size = new System.Drawing.Size(290, 97);
            this.BIntroduceBase.TabIndex = 0;
            this.BIntroduceBase.Text = "Introduce Base";
            this.BIntroduceBase.UseVisualStyleBackColor = true;
            this.BIntroduceBase.Click += new System.EventHandler(this.BIntroduceBase_Click);
            // 
            // BIntroduceExponent
            // 
            this.BIntroduceExponent.Location = new System.Drawing.Point(242, 165);
            this.BIntroduceExponent.Name = "BIntroduceExponent";
            this.BIntroduceExponent.Size = new System.Drawing.Size(290, 97);
            this.BIntroduceExponent.TabIndex = 1;
            this.BIntroduceExponent.Text = "Introduce Exponent";
            this.BIntroduceExponent.UseVisualStyleBackColor = true;
            this.BIntroduceExponent.Click += new System.EventHandler(this.BIntroduceExponent_Click);
            // 
            // BShowResult
            // 
            this.BShowResult.Location = new System.Drawing.Point(242, 292);
            this.BShowResult.Name = "BShowResult";
            this.BShowResult.Size = new System.Drawing.Size(290, 97);
            this.BShowResult.TabIndex = 2;
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
            this.Controls.Add(this.BIntroduceExponent);
            this.Controls.Add(this.BIntroduceBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroduceBase;
        private System.Windows.Forms.Button BIntroduceExponent;
        private System.Windows.Forms.Button BShowResult;
    }
}

