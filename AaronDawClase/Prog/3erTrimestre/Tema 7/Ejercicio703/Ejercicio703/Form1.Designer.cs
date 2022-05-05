
namespace Ejercicio703
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
            this.BIntroducirFechas = new System.Windows.Forms.Button();
            this.BMostrarFechas = new System.Windows.Forms.Button();
            this.BOrdenarFechas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BIntroducirFechas
            // 
            this.BIntroducirFechas.Location = new System.Drawing.Point(260, 57);
            this.BIntroducirFechas.Name = "BIntroducirFechas";
            this.BIntroducirFechas.Size = new System.Drawing.Size(252, 79);
            this.BIntroducirFechas.TabIndex = 0;
            this.BIntroducirFechas.Text = "Introducir fechas";
            this.BIntroducirFechas.UseVisualStyleBackColor = true;
            this.BIntroducirFechas.Click += new System.EventHandler(this.BIntroducirFechas_Click);
            // 
            // BMostrarFechas
            // 
            this.BMostrarFechas.Location = new System.Drawing.Point(260, 184);
            this.BMostrarFechas.Name = "BMostrarFechas";
            this.BMostrarFechas.Size = new System.Drawing.Size(252, 79);
            this.BMostrarFechas.TabIndex = 1;
            this.BMostrarFechas.Text = "Mostrar fechas";
            this.BMostrarFechas.UseVisualStyleBackColor = true;
            this.BMostrarFechas.Click += new System.EventHandler(this.BMostrarFechas_Click);
            // 
            // BOrdenarFechas
            // 
            this.BOrdenarFechas.Location = new System.Drawing.Point(260, 308);
            this.BOrdenarFechas.Name = "BOrdenarFechas";
            this.BOrdenarFechas.Size = new System.Drawing.Size(252, 79);
            this.BOrdenarFechas.TabIndex = 2;
            this.BOrdenarFechas.Text = "Ordenar fechas";
            this.BOrdenarFechas.UseVisualStyleBackColor = true;
            this.BOrdenarFechas.Click += new System.EventHandler(this.BOrdenarFechas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BOrdenarFechas);
            this.Controls.Add(this.BMostrarFechas);
            this.Controls.Add(this.BIntroducirFechas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BIntroducirFechas;
        private System.Windows.Forms.Button BMostrarFechas;
        private System.Windows.Forms.Button BOrdenarFechas;
    }
}

