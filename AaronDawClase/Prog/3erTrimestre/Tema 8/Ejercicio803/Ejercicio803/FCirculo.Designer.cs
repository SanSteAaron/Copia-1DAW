
namespace Ejercicio803
{
    partial class FCirculo
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
            this.TBPosicionX = new System.Windows.Forms.TextBox();
            this.TBPosicionY = new System.Windows.Forms.TextBox();
            this.TBColor = new System.Windows.Forms.TextBox();
            this.TBRadio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BAñadirCirculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BAñadirCirculo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TBRadio);
            this.groupBox1.Controls.Add(this.TBColor);
            this.groupBox1.Controls.Add(this.TBPosicionY);
            this.groupBox1.Controls.Add(this.TBPosicionX);
            this.groupBox1.Location = new System.Drawing.Point(140, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 366);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introduzca los datos del círculo";
            // 
            // TBPosicionX
            // 
            this.TBPosicionX.Location = new System.Drawing.Point(198, 71);
            this.TBPosicionX.Name = "TBPosicionX";
            this.TBPosicionX.Size = new System.Drawing.Size(218, 20);
            this.TBPosicionX.TabIndex = 0;
            // 
            // TBPosicionY
            // 
            this.TBPosicionY.Location = new System.Drawing.Point(198, 120);
            this.TBPosicionY.Name = "TBPosicionY";
            this.TBPosicionY.Size = new System.Drawing.Size(218, 20);
            this.TBPosicionY.TabIndex = 1;
            // 
            // TBColor
            // 
            this.TBColor.Location = new System.Drawing.Point(198, 165);
            this.TBColor.Name = "TBColor";
            this.TBColor.Size = new System.Drawing.Size(218, 20);
            this.TBColor.TabIndex = 2;
            // 
            // TBRadio
            // 
            this.TBRadio.Location = new System.Drawing.Point(198, 213);
            this.TBRadio.Name = "TBRadio";
            this.TBRadio.Size = new System.Drawing.Size(218, 20);
            this.TBRadio.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posición Y:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Radio:";
            // 
            // BAñadirCirculo
            // 
            this.BAñadirCirculo.Location = new System.Drawing.Point(154, 266);
            this.BAñadirCirculo.Name = "BAñadirCirculo";
            this.BAñadirCirculo.Size = new System.Drawing.Size(209, 61);
            this.BAñadirCirculo.TabIndex = 8;
            this.BAñadirCirculo.Text = "Añadir Círculo";
            this.BAñadirCirculo.UseVisualStyleBackColor = true;
            this.BAñadirCirculo.Click += new System.EventHandler(this.BAñadirCirculo_Click);
            // 
            // FCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCirculo";
            this.Text = "FCirculo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BAñadirCirculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBRadio;
        private System.Windows.Forms.TextBox TBColor;
        private System.Windows.Forms.TextBox TBPosicionY;
        private System.Windows.Forms.TextBox TBPosicionX;
    }
}