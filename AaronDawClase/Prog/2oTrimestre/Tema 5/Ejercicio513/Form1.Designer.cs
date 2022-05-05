
namespace Ejercicio513
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
            this.BComprobarYMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerVector
            // 
            this.BLeerVector.Location = new System.Drawing.Point(113, 252);
            this.BLeerVector.Name = "BLeerVector";
            this.BLeerVector.Size = new System.Drawing.Size(207, 81);
            this.BLeerVector.TabIndex = 0;
            this.BLeerVector.Text = "Introducir números";
            this.BLeerVector.UseVisualStyleBackColor = true;
            this.BLeerVector.Click += new System.EventHandler(this.BLeerVector_Click);
            // 
            // BComprobarYMostrar
            // 
            this.BComprobarYMostrar.Location = new System.Drawing.Point(463, 252);
            this.BComprobarYMostrar.Name = "BComprobarYMostrar";
            this.BComprobarYMostrar.Size = new System.Drawing.Size(225, 81);
            this.BComprobarYMostrar.TabIndex = 1;
            this.BComprobarYMostrar.Text = "Comprobar si hay un número en el vector";
            this.BComprobarYMostrar.UseVisualStyleBackColor = true;
            this.BComprobarYMostrar.Click += new System.EventHandler(this.BComprobarYMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BComprobarYMostrar);
            this.Controls.Add(this.BLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerVector;
        private System.Windows.Forms.Button BComprobarYMostrar;
    }
}

