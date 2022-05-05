
namespace Ejercicio514
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
            this.button1 = new System.Windows.Forms.Button();
            this.BMostrarTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Introducir las temperaturas en Alicante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BMostrarTemp
            // 
            this.BMostrarTemp.Location = new System.Drawing.Point(443, 224);
            this.BMostrarTemp.Name = "BMostrarTemp";
            this.BMostrarTemp.Size = new System.Drawing.Size(199, 92);
            this.BMostrarTemp.TabIndex = 1;
            this.BMostrarTemp.Text = "Mostrar las temperaturas iguales o superiores a la media";
            this.BMostrarTemp.UseVisualStyleBackColor = true;
            this.BMostrarTemp.Click += new System.EventHandler(this.BMostrarTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrarTemp);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BMostrarTemp;
    }
}

