
namespace Ejercicio508
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
            this.BMostrarVector = new System.Windows.Forms.Button();
            this.BDuplicados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerVector
            // 
            this.BLeerVector.Location = new System.Drawing.Point(97, 113);
            this.BLeerVector.Name = "BLeerVector";
            this.BLeerVector.Size = new System.Drawing.Size(175, 104);
            this.BLeerVector.TabIndex = 0;
            this.BLeerVector.Text = "Pedir números";
            this.BLeerVector.UseVisualStyleBackColor = true;
            this.BLeerVector.Click += new System.EventHandler(this.BLeerVector_Click);
            // 
            // BMostrarVector
            // 
            this.BMostrarVector.Location = new System.Drawing.Point(325, 113);
            this.BMostrarVector.Name = "BMostrarVector";
            this.BMostrarVector.Size = new System.Drawing.Size(175, 104);
            this.BMostrarVector.TabIndex = 1;
            this.BMostrarVector.Text = "Mostrar texto introducido";
            this.BMostrarVector.UseVisualStyleBackColor = true;
            this.BMostrarVector.Click += new System.EventHandler(this.BMostrarVector_Click);
            // 
            // BDuplicados
            // 
            this.BDuplicados.Location = new System.Drawing.Point(553, 113);
            this.BDuplicados.Name = "BDuplicados";
            this.BDuplicados.Size = new System.Drawing.Size(175, 104);
            this.BDuplicados.TabIndex = 2;
            this.BDuplicados.Text = "Cambiar duplicados";
            this.BDuplicados.UseVisualStyleBackColor = true;
            this.BDuplicados.Click += new System.EventHandler(this.BDuplicados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BDuplicados);
            this.Controls.Add(this.BMostrarVector);
            this.Controls.Add(this.BLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerVector;
        private System.Windows.Forms.Button BMostrarVector;
        private System.Windows.Forms.Button BDuplicados;
    }
}

