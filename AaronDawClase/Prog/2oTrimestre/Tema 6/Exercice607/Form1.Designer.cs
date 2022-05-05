
namespace Exercice607
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
            this.BReadList = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BReadList
            // 
            this.BReadList.Location = new System.Drawing.Point(262, 90);
            this.BReadList.Name = "BReadList";
            this.BReadList.Size = new System.Drawing.Size(214, 56);
            this.BReadList.TabIndex = 0;
            this.BReadList.Text = "Introduce words";
            this.BReadList.UseVisualStyleBackColor = true;
            this.BReadList.Click += new System.EventHandler(this.BReadList_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BReadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BReadList;
        private System.Windows.Forms.Button button2;
    }
}

