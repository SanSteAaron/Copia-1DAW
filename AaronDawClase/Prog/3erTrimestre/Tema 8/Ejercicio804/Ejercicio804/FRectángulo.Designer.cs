
namespace Ejercicio804
{
    partial class FRectángulo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBBase = new System.Windows.Forms.TextBox();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBPosiciónY = new System.Windows.Forms.TextBox();
            this.TBPosiciónX = new System.Windows.Forms.TextBox();
            this.TBAltura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BAñadirRectángulo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAñadirRectángulo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBAltura);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBBase);
            this.groupBox1.Controls.Add(this.TBColor);
            this.groupBox1.Controls.Add(this.TBPosiciónY);
            this.groupBox1.Controls.Add(this.TBPosiciónX);
            this.groupBox1.Location = new System.Drawing.Point(140, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 366);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca los datos del rectángulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Base:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Posición X:";
            // 
            // TBBase
            // 
            this.TBBase.Location = new System.Drawing.Point(198, 189);
            this.TBBase.Name = "TBBase";
            this.TBBase.Size = new System.Drawing.Size(218, 20);
            this.TBBase.TabIndex = 3;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(198, 141);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(218, 20);
            this.TBColor.TabIndex = 2;
            // 
            // TBPosiciónY
            // 
            this.TBPosiciónY.Location = new System.Drawing.Point(198, 99);
            this.TBPosiciónY.Name = "TBPosiciónY";
            this.TBPosiciónY.Size = new System.Drawing.Size(218, 20);
            this.TBPosiciónY.TabIndex = 1;
            // 
            // TBPosiciónX
            // 
            this.TBPosiciónX.Location = new System.Drawing.Point(198, 60);
            this.TBPosiciónX.Name = "TBPosiciónX";
            this.TBPosiciónX.Size = new System.Drawing.Size(218, 20);
            this.TBPosiciónX.TabIndex = 0;
            // 
            // TBAltura
            // 
            this.TBAltura.Location = new System.Drawing.Point(198, 240);
            this.TBAltura.Name = "TBAltura";
            this.TBAltura.Size = new System.Drawing.Size(218, 20);
            this.TBAltura.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura:";
            // 
            // BAñadirRectángulo
            // 
            this.BAñadirRectángulo.Location = new System.Drawing.Point(136, 280);
            this.BAñadirRectángulo.Name = "BAñadirRectángulo";
            this.BAñadirRectángulo.Size = new System.Drawing.Size(209, 61);
            this.BAñadirRectángulo.TabIndex = 11;
            this.BAñadirRectángulo.Text = "Añadir Rectángulo";
            this.BAñadirRectángulo.UseVisualStyleBackColor = true;
            this.BAñadirRectángulo.Click += new System.EventHandler(this.BAñadirRectángulo_Click);
            // 
            // FRectángulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FRectángulo";
            this.Text = "FRectángulo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBBase;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBPosiciónY;
        private System.Windows.Forms.TextBox TBPosiciónX;
        private System.Windows.Forms.TextBox TBAltura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BAñadirRectángulo;
    }
}