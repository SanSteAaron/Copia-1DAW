
namespace Ejercicio702
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
            this.BIntroducir_Persona = new System.Windows.Forms.Button();
            this.BMostrar_Datos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroducir_Persona
            // 
            this.BIntroducir_Persona.Location = new System.Drawing.Point(203, 86);
            this.BIntroducir_Persona.Name = "BIntroducir_Persona";
            this.BIntroducir_Persona.Size = new System.Drawing.Size(398, 90);
            this.BIntroducir_Persona.TabIndex = 0;
            this.BIntroducir_Persona.Text = "Introducir persona";
            this.BIntroducir_Persona.UseVisualStyleBackColor = true;
            this.BIntroducir_Persona.Click += new System.EventHandler(this.BIntroducir_Persona_Click);
            // 
            // BMostrar_Datos
            // 
            this.BMostrar_Datos.Location = new System.Drawing.Point(203, 218);
            this.BMostrar_Datos.Name = "BMostrar_Datos";
            this.BMostrar_Datos.Size = new System.Drawing.Size(398, 90);
            this.BMostrar_Datos.TabIndex = 1;
            this.BMostrar_Datos.Text = "Mostrar datos";
            this.BMostrar_Datos.UseVisualStyleBackColor = true;
            this.BMostrar_Datos.Click += new System.EventHandler(this.BMostrar_Datos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrar_Datos);
            this.Controls.Add(this.BIntroducir_Persona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroducir_Persona;
        private System.Windows.Forms.Button BMostrar_Datos;
    }
}

