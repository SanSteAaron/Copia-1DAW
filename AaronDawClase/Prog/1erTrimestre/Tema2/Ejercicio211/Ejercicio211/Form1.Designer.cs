﻿
namespace Ejercicio211
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
            this.TCantidad = new System.Windows.Forms.TextBox();
            this.TInteres = new System.Windows.Forms.TextBox();
            this.BSolucion = new System.Windows.Forms.Button();
            this.LCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TCantidad
            // 
            this.TCantidad.Location = new System.Drawing.Point(254, 75);
            this.TCantidad.Name = "TCantidad";
            this.TCantidad.Size = new System.Drawing.Size(288, 20);
            this.TCantidad.TabIndex = 0;
            // 
            // TInteres
            // 
            this.TInteres.Location = new System.Drawing.Point(254, 157);
            this.TInteres.Name = "TInteres";
            this.TInteres.Size = new System.Drawing.Size(288, 20);
            this.TInteres.TabIndex = 1;
            // 
            // BSolucion
            // 
            this.BSolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSolucion.Location = new System.Drawing.Point(299, 249);
            this.BSolucion.Name = "BSolucion";
            this.BSolucion.Size = new System.Drawing.Size(192, 105);
            this.BSolucion.TabIndex = 2;
            this.BSolucion.Text = "Capital a final de año";
            this.BSolucion.UseVisualStyleBackColor = true;
            this.BSolucion.Click += new System.EventHandler(this.BSolucion_Click);
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCantidad.ForeColor = System.Drawing.SystemColors.Control;
            this.LCantidad.Location = new System.Drawing.Point(29, 75);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(219, 20);
            this.LCantidad.TabIndex = 3;
            this.LCantidad.Text = "Cantidad Ingresada en euros:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Interés Anual en euros:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.BSolucion);
            this.Controls.Add(this.TInteres);
            this.Controls.Add(this.TCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TCantidad;
        private System.Windows.Forms.TextBox TInteres;
        private System.Windows.Forms.Button BSolucion;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label label1;
    }
}

