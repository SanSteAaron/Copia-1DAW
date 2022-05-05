
namespace Ejercicio510
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
            this.BLeerVector = new System.Windows.Forms.Button();
            this.BMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerVector
            // 
            this.BLeerVector.Location = new System.Drawing.Point(95, 239);
            this.BLeerVector.Name = "BLeerVector";
            this.BLeerVector.Size = new System.Drawing.Size(243, 128);
            this.BLeerVector.TabIndex = 0;
            this.BLeerVector.Text = "Introducir vector";
            this.BLeerVector.UseVisualStyleBackColor = true;
            this.BLeerVector.Click += new System.EventHandler(this.BLeerVector_Click);
            // 
            // BMostrar
            // 
            this.BMostrar.Location = new System.Drawing.Point(447, 239);
            this.BMostrar.Name = "BMostrar";
            this.BMostrar.Size = new System.Drawing.Size(243, 128);
            this.BMostrar.TabIndex = 1;
            this.BMostrar.Text = "Mostrar resultado";
            this.BMostrar.UseVisualStyleBackColor = true;
            this.BMostrar.Click += new System.EventHandler(this.BMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrar);
            this.Controls.Add(this.BLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerVector;
        private System.Windows.Forms.Button BMostrar;
    }
}

