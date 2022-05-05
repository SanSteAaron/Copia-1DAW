
namespace Ejercicio518
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
            this.BLeerMatriz = new System.Windows.Forms.Button();
            this.BMostrarMatriz = new System.Windows.Forms.Button();
            this.TBFila = new System.Windows.Forms.TextBox();
            this.TBCOL = new System.Windows.Forms.TextBox();
            this.TBValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BLeerMatriz
            // 
            this.BLeerMatriz.Location = new System.Drawing.Point(427, 84);
            this.BLeerMatriz.Name = "BLeerMatriz";
            this.BLeerMatriz.Size = new System.Drawing.Size(261, 97);
            this.BLeerMatriz.TabIndex = 0;
            this.BLeerMatriz.Text = "Introducir números en matriz";
            this.BLeerMatriz.UseVisualStyleBackColor = true;
            this.BLeerMatriz.Click += new System.EventHandler(this.BLeerMatriz_Click);
            // 
            // BMostrarMatriz
            // 
            this.BMostrarMatriz.Location = new System.Drawing.Point(427, 227);
            this.BMostrarMatriz.Name = "BMostrarMatriz";
            this.BMostrarMatriz.Size = new System.Drawing.Size(261, 97);
            this.BMostrarMatriz.TabIndex = 1;
            this.BMostrarMatriz.Text = "Mostrar matriz";
            this.BMostrarMatriz.UseVisualStyleBackColor = true;
            this.BMostrarMatriz.Click += new System.EventHandler(this.BMostrarMatriz_Click);
            // 
            // TBFila
            // 
            this.TBFila.Location = new System.Drawing.Point(137, 84);
            this.TBFila.Name = "TBFila";
            this.TBFila.Size = new System.Drawing.Size(231, 20);
            this.TBFila.TabIndex = 2;
            // 
            // TBCOL
            // 
            this.TBCOL.Location = new System.Drawing.Point(137, 197);
            this.TBCOL.Name = "TBCOL";
            this.TBCOL.Size = new System.Drawing.Size(231, 20);
            this.TBCOL.TabIndex = 3;
            // 
            // TBValor
            // 
            this.TBValor.Location = new System.Drawing.Point(137, 304);
            this.TBValor.Name = "TBValor";
            this.TBValor.Size = new System.Drawing.Size(231, 20);
            this.TBValor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FILA (0-4) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "COLUMNA(0-4) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALOR :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBValor);
            this.Controls.Add(this.TBCOL);
            this.Controls.Add(this.TBFila);
            this.Controls.Add(this.BMostrarMatriz);
            this.Controls.Add(this.BLeerMatriz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BLeerMatriz;
        private System.Windows.Forms.Button BMostrarMatriz;
        private System.Windows.Forms.TextBox TBFila;
        private System.Windows.Forms.TextBox TBCOL;
        private System.Windows.Forms.TextBox TBValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

