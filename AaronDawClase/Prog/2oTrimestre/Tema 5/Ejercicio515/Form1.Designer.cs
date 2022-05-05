
namespace Ejercicio515
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
            this.BMostrarResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerVector
            // 
            this.BLeerVector.Location = new System.Drawing.Point(151, 313);
            this.BLeerVector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BLeerVector.Name = "BLeerVector";
            this.BLeerVector.Size = new System.Drawing.Size(303, 94);
            this.BLeerVector.TabIndex = 0;
            this.BLeerVector.Text = "Introducir números";
            this.BLeerVector.UseVisualStyleBackColor = true;
            this.BLeerVector.Click += new System.EventHandler(this.BLeerVector_Click);
            // 
            // BMostrarResult
            // 
            this.BMostrarResult.Location = new System.Drawing.Point(577, 313);
            this.BMostrarResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BMostrarResult.Name = "BMostrarResult";
            this.BMostrarResult.Size = new System.Drawing.Size(303, 94);
            this.BMostrarResult.TabIndex = 1;
            this.BMostrarResult.Text = "Mostrar mayor, menor y las veces que se repite cada uno";
            this.BMostrarResult.UseVisualStyleBackColor = true;
            this.BMostrarResult.Click += new System.EventHandler(this.BMostrarResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BMostrarResult);
            this.Controls.Add(this.BLeerVector);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerVector;
        private System.Windows.Forms.Button BMostrarResult;
    }
}

