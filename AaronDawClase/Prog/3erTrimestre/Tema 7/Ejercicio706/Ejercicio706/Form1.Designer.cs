
namespace Ejercicio706
{
    partial class FGestionDelInstituto
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
            this.BGestiónCursos = new System.Windows.Forms.Button();
            this.BGestiónAlumnos = new System.Windows.Forms.Button();
            this.BGestiónProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BGestiónCursos
            // 
            this.BGestiónCursos.Location = new System.Drawing.Point(238, 50);
            this.BGestiónCursos.Name = "BGestiónCursos";
            this.BGestiónCursos.Size = new System.Drawing.Size(291, 83);
            this.BGestiónCursos.TabIndex = 0;
            this.BGestiónCursos.Text = "Gestión Cursos";
            this.BGestiónCursos.UseVisualStyleBackColor = true;
            this.BGestiónCursos.Click += new System.EventHandler(this.BGestiónCursos_Click);
            // 
            // BGestiónAlumnos
            // 
            this.BGestiónAlumnos.Location = new System.Drawing.Point(238, 180);
            this.BGestiónAlumnos.Name = "BGestiónAlumnos";
            this.BGestiónAlumnos.Size = new System.Drawing.Size(291, 83);
            this.BGestiónAlumnos.TabIndex = 1;
            this.BGestiónAlumnos.Text = "Gestión Alumnos";
            this.BGestiónAlumnos.UseVisualStyleBackColor = true;
            this.BGestiónAlumnos.Click += new System.EventHandler(this.BGestiónAlumnos_Click);
            // 
            // BGestiónProfesores
            // 
            this.BGestiónProfesores.Location = new System.Drawing.Point(238, 315);
            this.BGestiónProfesores.Name = "BGestiónProfesores";
            this.BGestiónProfesores.Size = new System.Drawing.Size(291, 83);
            this.BGestiónProfesores.TabIndex = 2;
            this.BGestiónProfesores.Text = "Gestión Profesores";
            this.BGestiónProfesores.UseVisualStyleBackColor = true;
            this.BGestiónProfesores.Click += new System.EventHandler(this.BGestiónProfesores_Click);
            // 
            // FGestionDelInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BGestiónProfesores);
            this.Controls.Add(this.BGestiónAlumnos);
            this.Controls.Add(this.BGestiónCursos);
            this.Name = "FGestionDelInstituto";
            this.Text = "Gestión del instituto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BGestiónCursos;
        private System.Windows.Forms.Button BGestiónAlumnos;
        private System.Windows.Forms.Button BGestiónProfesores;
    }
}

