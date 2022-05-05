
namespace Ejercicio706
{
    partial class FGestionCursos
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
            this.BAñadirCurso = new System.Windows.Forms.Button();
            this.BEliminarCurso = new System.Windows.Forms.Button();
            this.BMostrarListaCursos = new System.Windows.Forms.Button();
            this.BMostrarListaAlumnosCurso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAñadirCurso
            // 
            this.BAñadirCurso.Location = new System.Drawing.Point(197, 34);
            this.BAñadirCurso.Name = "BAñadirCurso";
            this.BAñadirCurso.Size = new System.Drawing.Size(381, 67);
            this.BAñadirCurso.TabIndex = 0;
            this.BAñadirCurso.Text = "Añadir Curso";
            this.BAñadirCurso.UseVisualStyleBackColor = true;
            this.BAñadirCurso.Click += new System.EventHandler(this.BAñadirCurso_Click);
            // 
            // BEliminarCurso
            // 
            this.BEliminarCurso.Location = new System.Drawing.Point(197, 126);
            this.BEliminarCurso.Name = "BEliminarCurso";
            this.BEliminarCurso.Size = new System.Drawing.Size(381, 67);
            this.BEliminarCurso.TabIndex = 1;
            this.BEliminarCurso.Text = "Eliminar Curso";
            this.BEliminarCurso.UseVisualStyleBackColor = true;
            this.BEliminarCurso.Click += new System.EventHandler(this.BEliminarCurso_Click);
            // 
            // BMostrarListaCursos
            // 
            this.BMostrarListaCursos.Location = new System.Drawing.Point(197, 223);
            this.BMostrarListaCursos.Name = "BMostrarListaCursos";
            this.BMostrarListaCursos.Size = new System.Drawing.Size(381, 67);
            this.BMostrarListaCursos.TabIndex = 2;
            this.BMostrarListaCursos.Text = "Mostrar todos los cursos";
            this.BMostrarListaCursos.UseVisualStyleBackColor = true;
            this.BMostrarListaCursos.Click += new System.EventHandler(this.BMostrarListaCursos_Click);
            // 
            // BMostrarListaAlumnosCurso
            // 
            this.BMostrarListaAlumnosCurso.Location = new System.Drawing.Point(197, 316);
            this.BMostrarListaAlumnosCurso.Name = "BMostrarListaAlumnosCurso";
            this.BMostrarListaAlumnosCurso.Size = new System.Drawing.Size(381, 67);
            this.BMostrarListaAlumnosCurso.TabIndex = 3;
            this.BMostrarListaAlumnosCurso.Text = "Mostrar todos los alumnos de un curso";
            this.BMostrarListaAlumnosCurso.UseVisualStyleBackColor = true;
            this.BMostrarListaAlumnosCurso.Click += new System.EventHandler(this.BMostrarListaAlumnosCurso_Click);
            // 
            // FGestionCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BMostrarListaAlumnosCurso);
            this.Controls.Add(this.BMostrarListaCursos);
            this.Controls.Add(this.BEliminarCurso);
            this.Controls.Add(this.BAñadirCurso);
            this.Name = "FGestionCursos";
            this.Text = "Gestion de Cursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAñadirCurso;
        private System.Windows.Forms.Button BEliminarCurso;
        private System.Windows.Forms.Button BMostrarListaCursos;
        private System.Windows.Forms.Button BMostrarListaAlumnosCurso;
    }
}