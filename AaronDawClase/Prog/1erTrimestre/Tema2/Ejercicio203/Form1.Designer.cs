namespace Ejercicio203
{
    partial class Ejercicio204
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.CuadrodeTexto = new System.Windows.Forms.TextBox();
            this.CuadrodeTexto2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(380, 127);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(197, 100);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Sumar";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // CuadrodeTexto
            // 
            this.CuadrodeTexto.Location = new System.Drawing.Point(141, 127);
            this.CuadrodeTexto.Name = "CuadrodeTexto";
            this.CuadrodeTexto.Size = new System.Drawing.Size(182, 20);
            this.CuadrodeTexto.TabIndex = 1;
            // 
            // CuadrodeTexto2
            // 
            this.CuadrodeTexto2.Location = new System.Drawing.Point(141, 207);
            this.CuadrodeTexto2.Name = "CuadrodeTexto2";
            this.CuadrodeTexto2.Size = new System.Drawing.Size(182, 20);
            this.CuadrodeTexto2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número 2:";
            // 
            // Ejercicio204
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadrodeTexto2);
            this.Controls.Add(this.CuadrodeTexto);
            this.Controls.Add(this.BPrimero);
            this.Name = "Ejercicio204";
            this.Text = "Ejercicio204";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.TextBox CuadrodeTexto;
        private System.Windows.Forms.TextBox CuadrodeTexto2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

