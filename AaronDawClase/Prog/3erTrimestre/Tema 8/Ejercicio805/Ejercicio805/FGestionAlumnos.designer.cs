
namespace Ejercicio805
{
    partial class FGestionAlumnos
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
            this.GBAlumnos = new System.Windows.Forms.GroupBox();
            this.BMostrarListaAlumnosCurso2 = new System.Windows.Forms.Button();
            this.BMostrarDatosAlumno = new System.Windows.Forms.Button();
            this.BOrdenarAlumnos = new System.Windows.Forms.Button();
            this.BMostrarListaAlumnos = new System.Windows.Forms.Button();
            this.BEliminarAlumno = new System.Windows.Forms.Button();
            this.BIntroducirAlumno = new System.Windows.Forms.Button();
            this.GBNotas = new System.Windows.Forms.GroupBox();
            this.BAñadirNotas = new System.Windows.Forms.Button();
            this.BEliminarNotas = new System.Windows.Forms.Button();
            this.BMostrarAprobados = new System.Windows.Forms.Button();
            this.BMostrarSuspendidos = new System.Windows.Forms.Button();
            this.GBAlumnos.SuspendLayout();
            this.GBNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAlumnos
            // 
            this.GBAlumnos.Controls.Add(this.BMostrarListaAlumnosCurso2);
            this.GBAlumnos.Controls.Add(this.BMostrarDatosAlumno);
            this.GBAlumnos.Controls.Add(this.BOrdenarAlumnos);
            this.GBAlumnos.Controls.Add(this.BMostrarListaAlumnos);
            this.GBAlumnos.Controls.Add(this.BEliminarAlumno);
            this.GBAlumnos.Controls.Add(this.BIntroducirAlumno);
            this.GBAlumnos.Location = new System.Drawing.Point(51, 28);
            this.GBAlumnos.Name = "GBAlumnos";
            this.GBAlumnos.Size = new System.Drawing.Size(692, 185);
            this.GBAlumnos.TabIndex = 0;
            this.GBAlumnos.TabStop = false;
            this.GBAlumnos.Text = "Alumnos";
            // 
            // BMostrarListaAlumnosCurso2
            // 
            this.BMostrarListaAlumnosCurso2.Location = new System.Drawing.Point(231, 138);
            this.BMostrarListaAlumnosCurso2.Name = "BMostrarListaAlumnosCurso2";
            this.BMostrarListaAlumnosCurso2.Size = new System.Drawing.Size(243, 29);
            this.BMostrarListaAlumnosCurso2.TabIndex = 5;
            this.BMostrarListaAlumnosCurso2.Text = "Mostrar alumnos pertenecientes a un curso";
            this.BMostrarListaAlumnosCurso2.UseVisualStyleBackColor = true;
            this.BMostrarListaAlumnosCurso2.Click += new System.EventHandler(this.BMostrarListaAlumnosCurso2_Click);
            // 
            // BMostrarDatosAlumno
            // 
            this.BMostrarDatosAlumno.Location = new System.Drawing.Point(424, 86);
            this.BMostrarDatosAlumno.Name = "BMostrarDatosAlumno";
            this.BMostrarDatosAlumno.Size = new System.Drawing.Size(225, 29);
            this.BMostrarDatosAlumno.TabIndex = 4;
            this.BMostrarDatosAlumno.Text = "Mostrar Datos Alumno (por nombre)";
            this.BMostrarDatosAlumno.UseVisualStyleBackColor = true;
            this.BMostrarDatosAlumno.Click += new System.EventHandler(this.BMostrarDatosAlumno_Click);
            // 
            // BOrdenarAlumnos
            // 
            this.BOrdenarAlumnos.Location = new System.Drawing.Point(63, 86);
            this.BOrdenarAlumnos.Name = "BOrdenarAlumnos";
            this.BOrdenarAlumnos.Size = new System.Drawing.Size(219, 29);
            this.BOrdenarAlumnos.TabIndex = 3;
            this.BOrdenarAlumnos.Text = "Ordenar alumnos por Orden Alfabético";
            this.BOrdenarAlumnos.UseVisualStyleBackColor = true;
            this.BOrdenarAlumnos.Click += new System.EventHandler(this.BOrdenarAlumnos_Click);
            // 
            // BMostrarListaAlumnos
            // 
            this.BMostrarListaAlumnos.Location = new System.Drawing.Point(501, 37);
            this.BMostrarListaAlumnos.Name = "BMostrarListaAlumnos";
            this.BMostrarListaAlumnos.Size = new System.Drawing.Size(148, 29);
            this.BMostrarListaAlumnos.TabIndex = 2;
            this.BMostrarListaAlumnos.Text = "Mostrar todos los Alumnos";
            this.BMostrarListaAlumnos.UseVisualStyleBackColor = true;
            this.BMostrarListaAlumnos.Click += new System.EventHandler(this.BMostrarListaAlumnos_Click);
            // 
            // BEliminarAlumno
            // 
            this.BEliminarAlumno.Location = new System.Drawing.Point(279, 37);
            this.BEliminarAlumno.Name = "BEliminarAlumno";
            this.BEliminarAlumno.Size = new System.Drawing.Size(148, 29);
            this.BEliminarAlumno.TabIndex = 1;
            this.BEliminarAlumno.Text = "Eliminar Alumno";
            this.BEliminarAlumno.UseVisualStyleBackColor = true;
            this.BEliminarAlumno.Click += new System.EventHandler(this.BEliminarAlumno_Click);
            // 
            // BIntroducirAlumno
            // 
            this.BIntroducirAlumno.Location = new System.Drawing.Point(63, 37);
            this.BIntroducirAlumno.Name = "BIntroducirAlumno";
            this.BIntroducirAlumno.Size = new System.Drawing.Size(148, 29);
            this.BIntroducirAlumno.TabIndex = 0;
            this.BIntroducirAlumno.Text = "Introducir Alumno";
            this.BIntroducirAlumno.UseVisualStyleBackColor = true;
            this.BIntroducirAlumno.Click += new System.EventHandler(this.BIntroducirAlumno_Click);
            // 
            // GBNotas
            // 
            this.GBNotas.Controls.Add(this.BAñadirNotas);
            this.GBNotas.Controls.Add(this.BEliminarNotas);
            this.GBNotas.Controls.Add(this.BMostrarAprobados);
            this.GBNotas.Controls.Add(this.BMostrarSuspendidos);
            this.GBNotas.Location = new System.Drawing.Point(51, 233);
            this.GBNotas.Name = "GBNotas";
            this.GBNotas.Size = new System.Drawing.Size(692, 186);
            this.GBNotas.TabIndex = 1;
            this.GBNotas.TabStop = false;
            this.GBNotas.Text = "Notas";
            // 
            // BAñadirNotas
            // 
            this.BAñadirNotas.Location = new System.Drawing.Point(113, 35);
            this.BAñadirNotas.Name = "BAñadirNotas";
            this.BAñadirNotas.Size = new System.Drawing.Size(148, 41);
            this.BAñadirNotas.TabIndex = 6;
            this.BAñadirNotas.Text = "Añadir Notas a Alumno";
            this.BAñadirNotas.UseVisualStyleBackColor = true;
            this.BAñadirNotas.Click += new System.EventHandler(this.BAñadirNotas_Click);
            // 
            // BEliminarNotas
            // 
            this.BEliminarNotas.Location = new System.Drawing.Point(113, 101);
            this.BEliminarNotas.Name = "BEliminarNotas";
            this.BEliminarNotas.Size = new System.Drawing.Size(148, 41);
            this.BEliminarNotas.TabIndex = 7;
            this.BEliminarNotas.Text = "Eliminar las notas de un alumno";
            this.BEliminarNotas.UseVisualStyleBackColor = true;
            this.BEliminarNotas.Click += new System.EventHandler(this.BEliminarNotas_Click);
            // 
            // BMostrarAprobados
            // 
            this.BMostrarAprobados.Location = new System.Drawing.Point(390, 35);
            this.BMostrarAprobados.Name = "BMostrarAprobados";
            this.BMostrarAprobados.Size = new System.Drawing.Size(224, 41);
            this.BMostrarAprobados.TabIndex = 8;
            this.BMostrarAprobados.Text = "Mostrar alumnos con nota media igual o mayor a 5";
            this.BMostrarAprobados.UseVisualStyleBackColor = true;
            this.BMostrarAprobados.Click += new System.EventHandler(this.BMostrarAprobados_Click);
            // 
            // BMostrarSuspendidos
            // 
            this.BMostrarSuspendidos.Location = new System.Drawing.Point(381, 101);
            this.BMostrarSuspendidos.Name = "BMostrarSuspendidos";
            this.BMostrarSuspendidos.Size = new System.Drawing.Size(224, 41);
            this.BMostrarSuspendidos.TabIndex = 9;
            this.BMostrarSuspendidos.Text = "Mostrar alumnos con nota media menor a 5";
            this.BMostrarSuspendidos.UseVisualStyleBackColor = true;
            this.BMostrarSuspendidos.Click += new System.EventHandler(this.BMostrarSuspendidos_Click);
            // 
            // FGestionAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBNotas);
            this.Controls.Add(this.GBAlumnos);
            this.Name = "FGestionAlumnos";
            this.Text = "Gestion de Alumnos";
            this.GBAlumnos.ResumeLayout(false);
            this.GBNotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAlumnos;
        private System.Windows.Forms.Button BMostrarListaAlumnosCurso2;
        private System.Windows.Forms.Button BMostrarDatosAlumno;
        private System.Windows.Forms.Button BOrdenarAlumnos;
        private System.Windows.Forms.Button BMostrarListaAlumnos;
        private System.Windows.Forms.Button BEliminarAlumno;
        private System.Windows.Forms.Button BIntroducirAlumno;
        private System.Windows.Forms.GroupBox GBNotas;
        private System.Windows.Forms.Button BAñadirNotas;
        private System.Windows.Forms.Button BEliminarNotas;
        private System.Windows.Forms.Button BMostrarAprobados;
        private System.Windows.Forms.Button BMostrarSuspendidos;
    }
}