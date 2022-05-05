
namespace Ejercicio517
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
            this.BBuscarElemento = new System.Windows.Forms.Button();
            this.BOrdenarVector = new System.Windows.Forms.Button();
            this.BMostrarVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BLeerVector
            // 
            this.BLeerVector.Location = new System.Drawing.Point(266, 35);
            this.BLeerVector.Name = "BLeerVector";
            this.BLeerVector.Size = new System.Drawing.Size(231, 92);
            this.BLeerVector.TabIndex = 0;
            this.BLeerVector.Text = "Introducir vector";
            this.BLeerVector.UseVisualStyleBackColor = true;
            this.BLeerVector.Click += new System.EventHandler(this.BLeerVector_Click);
            // 
            // BBuscarElemento
            // 
            this.BBuscarElemento.Location = new System.Drawing.Point(266, 133);
            this.BBuscarElemento.Name = "BBuscarElemento";
            this.BBuscarElemento.Size = new System.Drawing.Size(231, 92);
            this.BBuscarElemento.TabIndex = 1;
            this.BBuscarElemento.Text = "Buscar elemento";
            this.BBuscarElemento.UseVisualStyleBackColor = true;
            this.BBuscarElemento.Click += new System.EventHandler(this.BBuscarElemento_Click);
            // 
            // BOrdenarVector
            // 
            this.BOrdenarVector.Location = new System.Drawing.Point(266, 231);
            this.BOrdenarVector.Name = "BOrdenarVector";
            this.BOrdenarVector.Size = new System.Drawing.Size(231, 92);
            this.BOrdenarVector.TabIndex = 2;
            this.BOrdenarVector.Text = "Ordenar vector";
            this.BOrdenarVector.UseVisualStyleBackColor = true;
            this.BOrdenarVector.Click += new System.EventHandler(this.BOrdenarVector_Click);
            // 
            // BMostrarVector
            // 
            this.BMostrarVector.Location = new System.Drawing.Point(266, 329);
            this.BMostrarVector.Name = "BMostrarVector";
            this.BMostrarVector.Size = new System.Drawing.Size(231, 92);
            this.BMostrarVector.TabIndex = 3;
            this.BMostrarVector.Text = "Mostrar vector";
            this.BMostrarVector.UseVisualStyleBackColor = true;
            this.BMostrarVector.Click += new System.EventHandler(this.BMostrarVector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrarVector);
            this.Controls.Add(this.BOrdenarVector);
            this.Controls.Add(this.BBuscarElemento);
            this.Controls.Add(this.BLeerVector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BLeerVector;
        private System.Windows.Forms.Button BBuscarElemento;
        private System.Windows.Forms.Button BOrdenarVector;
        private System.Windows.Forms.Button BMostrarVector;
    }
}

