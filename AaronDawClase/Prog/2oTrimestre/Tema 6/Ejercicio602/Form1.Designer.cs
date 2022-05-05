
namespace Ejercicio602
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
            this.BCopyList = new System.Windows.Forms.Button();
            this.BMoveList = new System.Windows.Forms.Button();
            this.BShowResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BReadList
            // 
            this.BReadList.Location = new System.Drawing.Point(280, 92);
            this.BReadList.Name = "BReadList";
            this.BReadList.Size = new System.Drawing.Size(240, 51);
            this.BReadList.TabIndex = 0;
            this.BReadList.Text = "Introduce Numbers";
            this.BReadList.UseVisualStyleBackColor = true;
            this.BReadList.Click += new System.EventHandler(this.BReadList_Click);
            // 
            // BCopyList
            // 
            this.BCopyList.Location = new System.Drawing.Point(280, 174);
            this.BCopyList.Name = "BCopyList";
            this.BCopyList.Size = new System.Drawing.Size(240, 51);
            this.BCopyList.TabIndex = 1;
            this.BCopyList.Text = "Copy";
            this.BCopyList.UseVisualStyleBackColor = true;
            this.BCopyList.Click += new System.EventHandler(this.BCopyList_Click);
            // 
            // BMoveList
            // 
            this.BMoveList.Location = new System.Drawing.Point(280, 259);
            this.BMoveList.Name = "BMoveList";
            this.BMoveList.Size = new System.Drawing.Size(240, 51);
            this.BMoveList.TabIndex = 2;
            this.BMoveList.Text = "Move";
            this.BMoveList.UseVisualStyleBackColor = true;
            this.BMoveList.Click += new System.EventHandler(this.BMoveList_Click);
            // 
            // BShowResult
            // 
            this.BShowResult.Location = new System.Drawing.Point(280, 340);
            this.BShowResult.Name = "BShowResult";
            this.BShowResult.Size = new System.Drawing.Size(240, 51);
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
            this.Controls.Add(this.BMoveList);
            this.Controls.Add(this.BCopyList);
            this.Controls.Add(this.BReadList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BReadList;
        private System.Windows.Forms.Button BCopyList;
        private System.Windows.Forms.Button BMoveList;
        private System.Windows.Forms.Button BShowResult;
    }
}

