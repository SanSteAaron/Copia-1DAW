
namespace Ejercicio802
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BIntroducirCuadrado = new System.Windows.Forms.Button();
            this.BIntroducirCírculo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BMostrarListaCua = new System.Windows.Forms.Button();
            this.BMostrarListaCir = new System.Windows.Forms.Button();
            this.BMostrarListaFig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BIntroducirCuadrado);
            this.groupBox1.Controls.Add(this.BIntroducirCírculo);
            this.groupBox1.Location = new System.Drawing.Point(52, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BIntroducirCuadrado
            // 
            this.BIntroducirCuadrado.Location = new System.Drawing.Point(54, 239);
            this.BIntroducirCuadrado.Name = "BIntroducirCuadrado";
            this.BIntroducirCuadrado.Size = new System.Drawing.Size(206, 55);
            this.BIntroducirCuadrado.TabIndex = 1;
            this.BIntroducirCuadrado.Text = "Introducir Cuadrado";
            this.BIntroducirCuadrado.UseVisualStyleBackColor = true;
            this.BIntroducirCuadrado.Click += new System.EventHandler(this.BIntroducirCuadrado_Click);
            // 
            // BIntroducirCírculo
            // 
            this.BIntroducirCírculo.Location = new System.Drawing.Point(54, 89);
            this.BIntroducirCírculo.Name = "BIntroducirCírculo";
            this.BIntroducirCírculo.Size = new System.Drawing.Size(206, 55);
            this.BIntroducirCírculo.TabIndex = 0;
            this.BIntroducirCírculo.Text = "Introducir Circulo";
            this.BIntroducirCírculo.UseVisualStyleBackColor = true;
            this.BIntroducirCírculo.Click += new System.EventHandler(this.BIntroducirCírculo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BMostrarListaCua);
            this.groupBox2.Controls.Add(this.BMostrarListaCir);
            this.groupBox2.Controls.Add(this.BMostrarListaFig);
            this.groupBox2.Location = new System.Drawing.Point(429, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 379);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BMostrarListaCua
            // 
            this.BMostrarListaCua.Location = new System.Drawing.Point(47, 239);
            this.BMostrarListaCua.Name = "BMostrarListaCua";
            this.BMostrarListaCua.Size = new System.Drawing.Size(206, 55);
            this.BMostrarListaCua.TabIndex = 4;
            this.BMostrarListaCua.Text = "Mostrar solo los cuadrados";
            this.BMostrarListaCua.UseVisualStyleBackColor = true;
            this.BMostrarListaCua.Click += new System.EventHandler(this.BMostrarListaCua_Click);
            // 
            // BMostrarListaCir
            // 
            this.BMostrarListaCir.Location = new System.Drawing.Point(47, 163);
            this.BMostrarListaCir.Name = "BMostrarListaCir";
            this.BMostrarListaCir.Size = new System.Drawing.Size(206, 55);
            this.BMostrarListaCir.TabIndex = 3;
            this.BMostrarListaCir.Text = "Mostrar solo los circulos";
            this.BMostrarListaCir.UseVisualStyleBackColor = true;
            this.BMostrarListaCir.Click += new System.EventHandler(this.BMostrarListaCir_Click);
            // 
            // BMostrarListaFig
            // 
            this.BMostrarListaFig.Location = new System.Drawing.Point(47, 89);
            this.BMostrarListaFig.Name = "BMostrarListaFig";
            this.BMostrarListaFig.Size = new System.Drawing.Size(206, 55);
            this.BMostrarListaFig.TabIndex = 2;
            this.BMostrarListaFig.Text = "Mostrar todas las figuras";
            this.BMostrarListaFig.UseVisualStyleBackColor = true;
            this.BMostrarListaFig.Click += new System.EventHandler(this.BMostrarListaFig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BIntroducirCuadrado;
        private System.Windows.Forms.Button BIntroducirCírculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BMostrarListaCua;
        private System.Windows.Forms.Button BMostrarListaCir;
        private System.Windows.Forms.Button BMostrarListaFig;
    }
}

