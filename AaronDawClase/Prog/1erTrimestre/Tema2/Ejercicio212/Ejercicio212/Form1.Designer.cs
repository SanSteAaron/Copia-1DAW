
namespace Ejercicio212
{
    partial class Ejercicio212
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
            this.TProducto1 = new System.Windows.Forms.TextBox();
            this.TProducto2 = new System.Windows.Forms.TextBox();
            this.TProducto3 = new System.Windows.Forms.TextBox();
            this.BImporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TProducto1
            // 
            this.TProducto1.Location = new System.Drawing.Point(266, 138);
            this.TProducto1.Name = "TProducto1";
            this.TProducto1.Size = new System.Drawing.Size(239, 20);
            this.TProducto1.TabIndex = 0;
            // 
            // TProducto2
            // 
            this.TProducto2.Location = new System.Drawing.Point(266, 180);
            this.TProducto2.Name = "TProducto2";
            this.TProducto2.Size = new System.Drawing.Size(239, 20);
            this.TProducto2.TabIndex = 1;
            // 
            // TProducto3
            // 
            this.TProducto3.Location = new System.Drawing.Point(266, 219);
            this.TProducto3.Name = "TProducto3";
            this.TProducto3.Size = new System.Drawing.Size(239, 20);
            this.TProducto3.TabIndex = 2;
            // 
            // BImporte
            // 
            this.BImporte.BackColor = System.Drawing.Color.White;
            this.BImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BImporte.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BImporte.Location = new System.Drawing.Point(548, 136);
            this.BImporte.Name = "BImporte";
            this.BImporte.Size = new System.Drawing.Size(197, 103);
            this.BImporte.TabIndex = 3;
            this.BImporte.Text = "Importe";
            this.BImporte.UseVisualStyleBackColor = false;
            this.BImporte.Click += new System.EventHandler(this.BImporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(135, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "3er Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(135, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "2º Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(135, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "1er Producto";
            // 
            // Ejercicio212
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BImporte);
            this.Controls.Add(this.TProducto3);
            this.Controls.Add(this.TProducto2);
            this.Controls.Add(this.TProducto1);
            this.Name = "Ejercicio212";
            this.Text = "Ejercicio212";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TProducto1;
        private System.Windows.Forms.TextBox TProducto2;
        private System.Windows.Forms.TextBox TProducto3;
        private System.Windows.Forms.Button BImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

