
namespace Ejercicio804
{
    partial class FCuadrado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BAñadirCuadrado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBLado = new System.Windows.Forms.TextBox();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBPosiciónY = new System.Windows.Forms.TextBox();
            this.TBPosiciónX = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAñadirCuadrado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBLado);
            this.groupBox1.Controls.Add(this.TBColor);
            this.groupBox1.Controls.Add(this.TBPosiciónY);
            this.groupBox1.Controls.Add(this.TBPosiciónX);
            this.groupBox1.Location = new System.Drawing.Point(140, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 366);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca los datos del cuadrado";
            // 
            // BAñadirCuadrado
            // 
            this.BAñadirCuadrado.Location = new System.Drawing.Point(154, 266);
            this.BAñadirCuadrado.Name = "BAñadirCuadrado";
            this.BAñadirCuadrado.Size = new System.Drawing.Size(209, 61);
            this.BAñadirCuadrado.TabIndex = 8;
            this.BAñadirCuadrado.Text = "Añadir Cuadrado";
            this.BAñadirCuadrado.UseVisualStyleBackColor = true;
            this.BAñadirCuadrado.Click += new System.EventHandler(this.BAñadirCuadrado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posición X:";
            // 
            // TBLado
            // 
            this.TBLado.Location = new System.Drawing.Point(198, 213);
            this.TBLado.Name = "TBLado";
            this.TBLado.Size = new System.Drawing.Size(218, 20);
            this.TBLado.TabIndex = 3;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(198, 165);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(218, 20);
            this.TBColor.TabIndex = 2;
            // 
            // TBPosiciónY
            // 
            this.TBPosiciónY.Location = new System.Drawing.Point(198, 120);
            this.TBPosiciónY.Name = "TBPosiciónY";
            this.TBPosiciónY.Size = new System.Drawing.Size(218, 20);
            this.TBPosiciónY.TabIndex = 1;
            // 
            // TBPosiciónX
            // 
            this.TBPosiciónX.Location = new System.Drawing.Point(198, 71);
            this.TBPosiciónX.Name = "TBPosiciónX";
            this.TBPosiciónX.Size = new System.Drawing.Size(218, 20);
            this.TBPosiciónX.TabIndex = 0;
            // 
            // FCuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCuadrado";
            this.Text = "FCuadrado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAñadirCuadrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLado;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBPosiciónY;
        private System.Windows.Forms.TextBox TBPosiciónX;
    }
}