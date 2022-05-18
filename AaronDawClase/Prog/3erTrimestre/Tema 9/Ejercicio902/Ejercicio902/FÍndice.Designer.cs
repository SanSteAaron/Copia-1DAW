
namespace Ejercicio902
{
    partial class FÍndice
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
            this.BFCursos = new System.Windows.Forms.Button();
            this.BFProfesores = new System.Windows.Forms.Button();
            this.BFAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BFCursos
            // 
            this.BFCursos.Location = new System.Drawing.Point(248, 73);
            this.BFCursos.Name = "BFCursos";
            this.BFCursos.Size = new System.Drawing.Size(280, 79);
            this.BFCursos.TabIndex = 0;
            this.BFCursos.Text = "Cursos";
            this.BFCursos.UseVisualStyleBackColor = true;
            this.BFCursos.Click += new System.EventHandler(this.BFCursos_Click);
            // 
            // BFProfesores
            // 
            this.BFProfesores.Location = new System.Drawing.Point(248, 188);
            this.BFProfesores.Name = "BFProfesores";
            this.BFProfesores.Size = new System.Drawing.Size(280, 79);
            this.BFProfesores.TabIndex = 1;
            this.BFProfesores.Text = "Profesores";
            this.BFProfesores.UseVisualStyleBackColor = true;
            this.BFProfesores.Click += new System.EventHandler(this.BFProfesores_Click);
            // 
            // BFAlumnos
            // 
            this.BFAlumnos.Location = new System.Drawing.Point(248, 298);
            this.BFAlumnos.Name = "BFAlumnos";
            this.BFAlumnos.Size = new System.Drawing.Size(280, 79);
            this.BFAlumnos.TabIndex = 2;
            this.BFAlumnos.Text = "Alumnos";
            this.BFAlumnos.UseVisualStyleBackColor = true;
            this.BFAlumnos.Click += new System.EventHandler(this.BFAlumnos_Click);
            // 
            // FÍndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BFAlumnos);
            this.Controls.Add(this.BFProfesores);
            this.Controls.Add(this.BFCursos);
            this.Name = "FÍndice";
            this.Text = "FÍndice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BFCursos;
        private System.Windows.Forms.Button BFProfesores;
        private System.Windows.Forms.Button BFAlumnos;
    }
}