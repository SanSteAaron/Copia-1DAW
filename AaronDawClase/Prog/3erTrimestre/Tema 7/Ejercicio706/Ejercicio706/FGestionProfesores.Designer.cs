
namespace Ejercicio706
{
    partial class FGestionProfesores
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
            this.GBProfesores = new System.Windows.Forms.GroupBox();
            this.BOrdenarProfesores = new System.Windows.Forms.Button();
            this.BMostrarDatosProfesor = new System.Windows.Forms.Button();
            this.BMostrarListaProfesores = new System.Windows.Forms.Button();
            this.BEliminarProfesor = new System.Windows.Forms.Button();
            this.BIntroducirProfesor = new System.Windows.Forms.Button();
            this.GBAsignaturas = new System.Windows.Forms.GroupBox();
            this.BEliminarAsignaturas = new System.Windows.Forms.Button();
            this.BAñadirAsignatura = new System.Windows.Forms.Button();
            this.BMostrarListaProfesoresAsignatura = new System.Windows.Forms.Button();
            this.GBProfesores.SuspendLayout();
            this.GBAsignaturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBProfesores
            // 
            this.GBProfesores.Controls.Add(this.BOrdenarProfesores);
            this.GBProfesores.Controls.Add(this.BMostrarDatosProfesor);
            this.GBProfesores.Controls.Add(this.BMostrarListaProfesores);
            this.GBProfesores.Controls.Add(this.BEliminarProfesor);
            this.GBProfesores.Controls.Add(this.BIntroducirProfesor);
            this.GBProfesores.Location = new System.Drawing.Point(42, 12);
            this.GBProfesores.Name = "GBProfesores";
            this.GBProfesores.Size = new System.Drawing.Size(717, 201);
            this.GBProfesores.TabIndex = 0;
            this.GBProfesores.TabStop = false;
            this.GBProfesores.Text = "Profesores";
            // 
            // BOrdenarProfesores
            // 
            this.BOrdenarProfesores.Location = new System.Drawing.Point(54, 114);
            this.BOrdenarProfesores.Name = "BOrdenarProfesores";
            this.BOrdenarProfesores.Size = new System.Drawing.Size(246, 23);
            this.BOrdenarProfesores.TabIndex = 4;
            this.BOrdenarProfesores.Text = "Ordenar Profesores por Orden Alfabético";
            this.BOrdenarProfesores.UseVisualStyleBackColor = true;
            this.BOrdenarProfesores.Click += new System.EventHandler(this.BOrdenarProfesores_Click);
            // 
            // BMostrarDatosProfesor
            // 
            this.BMostrarDatosProfesor.Location = new System.Drawing.Point(515, 114);
            this.BMostrarDatosProfesor.Name = "BMostrarDatosProfesor";
            this.BMostrarDatosProfesor.Size = new System.Drawing.Size(148, 23);
            this.BMostrarDatosProfesor.TabIndex = 3;
            this.BMostrarDatosProfesor.Text = "Mostrar Datos Profesor";
            this.BMostrarDatosProfesor.UseVisualStyleBackColor = true;
            this.BMostrarDatosProfesor.Click += new System.EventHandler(this.BMostrarDatosProfesor_Click);
            // 
            // BMostrarListaProfesores
            // 
            this.BMostrarListaProfesores.Location = new System.Drawing.Point(515, 46);
            this.BMostrarListaProfesores.Name = "BMostrarListaProfesores";
            this.BMostrarListaProfesores.Size = new System.Drawing.Size(148, 23);
            this.BMostrarListaProfesores.TabIndex = 2;
            this.BMostrarListaProfesores.Text = "Mostrar Lista Profesores";
            this.BMostrarListaProfesores.UseVisualStyleBackColor = true;
            this.BMostrarListaProfesores.Click += new System.EventHandler(this.BMostrarListaProfesores_Click);
            // 
            // BEliminarProfesor
            // 
            this.BEliminarProfesor.Location = new System.Drawing.Point(297, 46);
            this.BEliminarProfesor.Name = "BEliminarProfesor";
            this.BEliminarProfesor.Size = new System.Drawing.Size(112, 23);
            this.BEliminarProfesor.TabIndex = 1;
            this.BEliminarProfesor.Text = "Eliminar Profesor";
            this.BEliminarProfesor.UseVisualStyleBackColor = true;
            this.BEliminarProfesor.Click += new System.EventHandler(this.BEliminarProfesor_Click);
            // 
            // BIntroducirProfesor
            // 
            this.BIntroducirProfesor.Location = new System.Drawing.Point(54, 46);
            this.BIntroducirProfesor.Name = "BIntroducirProfesor";
            this.BIntroducirProfesor.Size = new System.Drawing.Size(129, 23);
            this.BIntroducirProfesor.TabIndex = 0;
            this.BIntroducirProfesor.Text = "Introducir Profesor";
            this.BIntroducirProfesor.UseVisualStyleBackColor = true;
            this.BIntroducirProfesor.Click += new System.EventHandler(this.BIntroducirProfesor_Click);
            // 
            // GBAsignaturas
            // 
            this.GBAsignaturas.Controls.Add(this.BEliminarAsignaturas);
            this.GBAsignaturas.Controls.Add(this.BAñadirAsignatura);
            this.GBAsignaturas.Controls.Add(this.BMostrarListaProfesoresAsignatura);
            this.GBAsignaturas.Location = new System.Drawing.Point(42, 237);
            this.GBAsignaturas.Name = "GBAsignaturas";
            this.GBAsignaturas.Size = new System.Drawing.Size(717, 201);
            this.GBAsignaturas.TabIndex = 1;
            this.GBAsignaturas.TabStop = false;
            this.GBAsignaturas.Text = "Asignaturas";
            // 
            // BEliminarAsignaturas
            // 
            this.BEliminarAsignaturas.Location = new System.Drawing.Point(425, 46);
            this.BEliminarAsignaturas.Name = "BEliminarAsignaturas";
            this.BEliminarAsignaturas.Size = new System.Drawing.Size(238, 23);
            this.BEliminarAsignaturas.TabIndex = 5;
            this.BEliminarAsignaturas.Text = "Eliminar las asignaturas de un profesor";
            this.BEliminarAsignaturas.UseVisualStyleBackColor = true;
            this.BEliminarAsignaturas.Click += new System.EventHandler(this.BEliminarAsignaturas_Click);
            // 
            // BAñadirAsignatura
            // 
            this.BAñadirAsignatura.Location = new System.Drawing.Point(54, 46);
            this.BAñadirAsignatura.Name = "BAñadirAsignatura";
            this.BAñadirAsignatura.Size = new System.Drawing.Size(199, 23);
            this.BAñadirAsignatura.TabIndex = 6;
            this.BAñadirAsignatura.Text = "Añadir Asignatura a Profesor";
            this.BAñadirAsignatura.UseVisualStyleBackColor = true;
            this.BAñadirAsignatura.Click += new System.EventHandler(this.BAñadirAsignatura_Click);
            // 
            // BMostrarListaProfesoresAsignatura
            // 
            this.BMostrarListaProfesoresAsignatura.Location = new System.Drawing.Point(203, 107);
            this.BMostrarListaProfesoresAsignatura.Name = "BMostrarListaProfesoresAsignatura";
            this.BMostrarListaProfesoresAsignatura.Size = new System.Drawing.Size(291, 23);
            this.BMostrarListaProfesoresAsignatura.TabIndex = 7;
            this.BMostrarListaProfesoresAsignatura.Text = "Mostrar Profesores que imparten una Asignatura";
            this.BMostrarListaProfesoresAsignatura.UseVisualStyleBackColor = true;
            this.BMostrarListaProfesoresAsignatura.Click += new System.EventHandler(this.BMostrarListaProfesoresAsignatura_Click);
            // 
            // FGestionProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBAsignaturas);
            this.Controls.Add(this.GBProfesores);
            this.Name = "FGestionProfesores";
            this.Text = "Gestion de Profesores";
            this.GBProfesores.ResumeLayout(false);
            this.GBAsignaturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBProfesores;
        private System.Windows.Forms.Button BOrdenarProfesores;
        private System.Windows.Forms.Button BMostrarDatosProfesor;
        private System.Windows.Forms.Button BMostrarListaProfesores;
        private System.Windows.Forms.Button BEliminarProfesor;
        private System.Windows.Forms.Button BIntroducirProfesor;
        private System.Windows.Forms.GroupBox GBAsignaturas;
        private System.Windows.Forms.Button BEliminarAsignaturas;
        private System.Windows.Forms.Button BAñadirAsignatura;
        private System.Windows.Forms.Button BMostrarListaProfesoresAsignatura;
    }
}