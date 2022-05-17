
namespace Ejercicio902
{
    partial class FProfesores
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
            this.TBDni = new System.Windows.Forms.TextBox();
            this.TBNombre = new System.Windows.Forms.TextBox();
            this.TBTelefono = new System.Windows.Forms.TextBox();
            this.TBApellidos = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BÚltimo = new System.Windows.Forms.Button();
            this.BSiguiente = new System.Windows.Forms.Button();
            this.BAnterior = new System.Windows.Forms.Button();
            this.BPrimero = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BActualizar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BAñadir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBDni
            // 
            this.TBDni.Location = new System.Drawing.Point(166, 39);
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(141, 20);
            this.TBDni.TabIndex = 0;
            // 
            // TBNombre
            // 
            this.TBNombre.Location = new System.Drawing.Point(166, 85);
            this.TBNombre.Name = "TBNombre";
            this.TBNombre.Size = new System.Drawing.Size(141, 20);
            this.TBNombre.TabIndex = 1;
            // 
            // TBTelefono
            // 
            this.TBTelefono.Location = new System.Drawing.Point(166, 133);
            this.TBTelefono.Name = "TBTelefono";
            this.TBTelefono.Size = new System.Drawing.Size(141, 20);
            this.TBTelefono.TabIndex = 2;
            // 
            // TBApellidos
            // 
            this.TBApellidos.Location = new System.Drawing.Point(496, 39);
            this.TBApellidos.Name = "TBApellidos";
            this.TBApellidos.Size = new System.Drawing.Size(141, 20);
            this.TBApellidos.TabIndex = 3;
            // 
            // TBEmail
            // 
            this.TBEmail.Location = new System.Drawing.Point(496, 85);
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(141, 20);
            this.TBEmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tlf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apellidos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BÚltimo);
            this.groupBox1.Controls.Add(this.BSiguiente);
            this.groupBox1.Controls.Add(this.BAnterior);
            this.groupBox1.Controls.Add(this.BPrimero);
            this.groupBox1.Location = new System.Drawing.Point(166, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 106);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegar";
            // 
            // BÚltimo
            // 
            this.BÚltimo.Location = new System.Drawing.Point(348, 44);
            this.BÚltimo.Name = "BÚltimo";
            this.BÚltimo.Size = new System.Drawing.Size(75, 23);
            this.BÚltimo.TabIndex = 3;
            this.BÚltimo.Text = "Último";
            this.BÚltimo.UseVisualStyleBackColor = true;
            this.BÚltimo.Click += new System.EventHandler(this.BÚltimo_Click);
            // 
            // BSiguiente
            // 
            this.BSiguiente.Location = new System.Drawing.Point(244, 44);
            this.BSiguiente.Name = "BSiguiente";
            this.BSiguiente.Size = new System.Drawing.Size(75, 23);
            this.BSiguiente.TabIndex = 2;
            this.BSiguiente.Text = "Siguiente";
            this.BSiguiente.UseVisualStyleBackColor = true;
            this.BSiguiente.Click += new System.EventHandler(this.BSiguiente_Click);
            // 
            // BAnterior
            // 
            this.BAnterior.Location = new System.Drawing.Point(140, 44);
            this.BAnterior.Name = "BAnterior";
            this.BAnterior.Size = new System.Drawing.Size(75, 23);
            this.BAnterior.TabIndex = 1;
            this.BAnterior.Text = "Anterior";
            this.BAnterior.UseVisualStyleBackColor = true;
            this.BAnterior.Click += new System.EventHandler(this.BAnterior_Click);
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(34, 44);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(75, 23);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Primero";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.BPrimero_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BEliminar);
            this.groupBox2.Controls.Add(this.BActualizar);
            this.groupBox2.Controls.Add(this.BGuardar);
            this.groupBox2.Controls.Add(this.BAñadir);
            this.groupBox2.Location = new System.Drawing.Point(166, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 106);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // BEliminar
            // 
            this.BEliminar.Location = new System.Drawing.Point(348, 36);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(75, 23);
            this.BEliminar.TabIndex = 3;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BActualizar
            // 
            this.BActualizar.Location = new System.Drawing.Point(244, 36);
            this.BActualizar.Name = "BActualizar";
            this.BActualizar.Size = new System.Drawing.Size(75, 23);
            this.BActualizar.TabIndex = 2;
            this.BActualizar.Text = "Actualizar";
            this.BActualizar.UseVisualStyleBackColor = true;
            this.BActualizar.Click += new System.EventHandler(this.BActualizar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(140, 36);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(75, 23);
            this.BGuardar.TabIndex = 1;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BAñadir
            // 
            this.BAñadir.Location = new System.Drawing.Point(34, 36);
            this.BAñadir.Name = "BAñadir";
            this.BAñadir.Size = new System.Drawing.Size(75, 23);
            this.BAñadir.TabIndex = 0;
            this.BAñadir.Text = "Añadir";
            this.BAñadir.UseVisualStyleBackColor = true;
            this.BAñadir.Click += new System.EventHandler(this.BAñadir_Click);
            // 
            // FProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.TBApellidos);
            this.Controls.Add(this.TBTelefono);
            this.Controls.Add(this.TBNombre);
            this.Controls.Add(this.TBDni);
            this.Name = "FProfesores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBDni;
        private System.Windows.Forms.TextBox TBNombre;
        private System.Windows.Forms.TextBox TBTelefono;
        private System.Windows.Forms.TextBox TBApellidos;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BÚltimo;
        private System.Windows.Forms.Button BSiguiente;
        private System.Windows.Forms.Button BAnterior;
        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Button BActualizar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BAñadir;
    }
}

