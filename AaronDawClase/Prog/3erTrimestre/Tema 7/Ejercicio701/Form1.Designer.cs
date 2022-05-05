
namespace Ejercicio701
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
            this.B_Introducir_datos = new System.Windows.Forms.Button();
            this.B_Mostrar_datos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Introducir_datos
            // 
            this.B_Introducir_datos.Location = new System.Drawing.Point(68, 68);
            this.B_Introducir_datos.Name = "B_Introducir_datos";
            this.B_Introducir_datos.Size = new System.Drawing.Size(398, 103);
            this.B_Introducir_datos.TabIndex = 0;
            this.B_Introducir_datos.Text = "Introducir datos";
            this.B_Introducir_datos.UseVisualStyleBackColor = true;
            this.B_Introducir_datos.Click += new System.EventHandler(this.B_Introducir_datos_Click);
            // 
            // B_Mostrar_datos
            // 
            this.B_Mostrar_datos.Location = new System.Drawing.Point(68, 234);
            this.B_Mostrar_datos.Name = "B_Mostrar_datos";
            this.B_Mostrar_datos.Size = new System.Drawing.Size(398, 102);
            this.B_Mostrar_datos.TabIndex = 1;
            this.B_Mostrar_datos.Text = "Mostrar datos";
            this.B_Mostrar_datos.UseVisualStyleBackColor = true;
            this.B_Mostrar_datos.Click += new System.EventHandler(this.B_Mostrar_datos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(531, 450);
            this.Controls.Add(this.B_Mostrar_datos);
            this.Controls.Add(this.B_Introducir_datos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Introducir_datos;
        private System.Windows.Forms.Button B_Mostrar_datos;
    }
}

