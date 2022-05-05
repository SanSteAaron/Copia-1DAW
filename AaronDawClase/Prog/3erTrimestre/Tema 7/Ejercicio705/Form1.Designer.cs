
namespace Ejercicio705
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
            this.BIntroducirEmpleado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BMostrarDatosEmpleados = new System.Windows.Forms.Button();
            this.BEliminarEmpleado = new System.Windows.Forms.Button();
            this.BOrdEmpleados = new System.Windows.Forms.Button();
            this.BMostrarListaEmpleados = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BOrdEmpleadosVentas = new System.Windows.Forms.Button();
            this.BEliminarVentasEmpleado = new System.Windows.Forms.Button();
            this.BAñadirVentasEmpleado = new System.Windows.Forms.Button();
            this.BMostrarEmpleadoMayorVentas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BIntroducirEmpleado
            // 
            this.BIntroducirEmpleado.Location = new System.Drawing.Point(48, 28);
            this.BIntroducirEmpleado.Name = "BIntroducirEmpleado";
            this.BIntroducirEmpleado.Size = new System.Drawing.Size(175, 23);
            this.BIntroducirEmpleado.TabIndex = 0;
            this.BIntroducirEmpleado.Text = "Introducir Empleado";
            this.BIntroducirEmpleado.UseVisualStyleBackColor = true;
            this.BIntroducirEmpleado.Click += new System.EventHandler(this.BIntroducirEmpleado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BMostrarDatosEmpleados);
            this.groupBox1.Controls.Add(this.BEliminarEmpleado);
            this.groupBox1.Controls.Add(this.BOrdEmpleados);
            this.groupBox1.Controls.Add(this.BMostrarListaEmpleados);
            this.groupBox1.Controls.Add(this.BIntroducirEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(43, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // BMostrarDatosEmpleados
            // 
            this.BMostrarDatosEmpleados.Location = new System.Drawing.Point(421, 109);
            this.BMostrarDatosEmpleados.Name = "BMostrarDatosEmpleados";
            this.BMostrarDatosEmpleados.Size = new System.Drawing.Size(214, 23);
            this.BMostrarDatosEmpleados.TabIndex = 4;
            this.BMostrarDatosEmpleados.Text = "Mostrar Datos Empleados";
            this.BMostrarDatosEmpleados.UseVisualStyleBackColor = true;
            this.BMostrarDatosEmpleados.Click += new System.EventHandler(this.BMostrarDatosEmpleados_Click);
            // 
            // BEliminarEmpleado
            // 
            this.BEliminarEmpleado.Location = new System.Drawing.Point(290, 28);
            this.BEliminarEmpleado.Name = "BEliminarEmpleado";
            this.BEliminarEmpleado.Size = new System.Drawing.Size(122, 23);
            this.BEliminarEmpleado.TabIndex = 3;
            this.BEliminarEmpleado.Text = "Eliminar empleado";
            this.BEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BEliminarEmpleado.Click += new System.EventHandler(this.BEliminarEmpleado_Click);
            // 
            // BOrdEmpleados
            // 
            this.BOrdEmpleados.Location = new System.Drawing.Point(48, 109);
            this.BOrdEmpleados.Name = "BOrdEmpleados";
            this.BOrdEmpleados.Size = new System.Drawing.Size(226, 23);
            this.BOrdEmpleados.TabIndex = 2;
            this.BOrdEmpleados.Text = "Ordenar Empleados por  Orden Alfabético";
            this.BOrdEmpleados.UseVisualStyleBackColor = true;
            this.BOrdEmpleados.Click += new System.EventHandler(this.BOrdEmpleados_Click);
            // 
            // BMostrarListaEmpleados
            // 
            this.BMostrarListaEmpleados.Location = new System.Drawing.Point(506, 28);
            this.BMostrarListaEmpleados.Name = "BMostrarListaEmpleados";
            this.BMostrarListaEmpleados.Size = new System.Drawing.Size(140, 23);
            this.BMostrarListaEmpleados.TabIndex = 1;
            this.BMostrarListaEmpleados.Text = "Mostrar Lista Empleados";
            this.BMostrarListaEmpleados.UseVisualStyleBackColor = true;
            this.BMostrarListaEmpleados.Click += new System.EventHandler(this.BMostrarListaEmpleados_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BOrdEmpleadosVentas);
            this.groupBox2.Controls.Add(this.BEliminarVentasEmpleado);
            this.groupBox2.Controls.Add(this.BAñadirVentasEmpleado);
            this.groupBox2.Controls.Add(this.BMostrarEmpleadoMayorVentas);
            this.groupBox2.Location = new System.Drawing.Point(43, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // BOrdEmpleadosVentas
            // 
            this.BOrdEmpleadosVentas.Location = new System.Drawing.Point(412, 96);
            this.BOrdEmpleadosVentas.Name = "BOrdEmpleadosVentas";
            this.BOrdEmpleadosVentas.Size = new System.Drawing.Size(216, 23);
            this.BOrdEmpleadosVentas.TabIndex = 3;
            this.BOrdEmpleadosVentas.Text = "Ordenar Empleados por Ventas";
            this.BOrdEmpleadosVentas.UseVisualStyleBackColor = true;
            this.BOrdEmpleadosVentas.Click += new System.EventHandler(this.BOrdEmpleadosVentas_Click);
            // 
            // BEliminarVentasEmpleado
            // 
            this.BEliminarVentasEmpleado.Location = new System.Drawing.Point(98, 96);
            this.BEliminarVentasEmpleado.Name = "BEliminarVentasEmpleado";
            this.BEliminarVentasEmpleado.Size = new System.Drawing.Size(190, 23);
            this.BEliminarVentasEmpleado.TabIndex = 2;
            this.BEliminarVentasEmpleado.Text = "Eliminar las ventas de un empleado";
            this.BEliminarVentasEmpleado.UseVisualStyleBackColor = true;
            this.BEliminarVentasEmpleado.Click += new System.EventHandler(this.BEliminarVentasEmpleado_Click);
            // 
            // BAñadirVentasEmpleado
            // 
            this.BAñadirVentasEmpleado.Location = new System.Drawing.Point(98, 35);
            this.BAñadirVentasEmpleado.Name = "BAñadirVentasEmpleado";
            this.BAñadirVentasEmpleado.Size = new System.Drawing.Size(190, 23);
            this.BAñadirVentasEmpleado.TabIndex = 1;
            this.BAñadirVentasEmpleado.Text = "Añadir Ventas a Empleado";
            this.BAñadirVentasEmpleado.UseVisualStyleBackColor = true;
            this.BAñadirVentasEmpleado.Click += new System.EventHandler(this.BAñadirVentasEmpleado_Click);
            // 
            // BMostrarEmpleadoMayorVentas
            // 
            this.BMostrarEmpleadoMayorVentas.Location = new System.Drawing.Point(412, 35);
            this.BMostrarEmpleadoMayorVentas.Name = "BMostrarEmpleadoMayorVentas";
            this.BMostrarEmpleadoMayorVentas.Size = new System.Drawing.Size(216, 23);
            this.BMostrarEmpleadoMayorVentas.TabIndex = 0;
            this.BMostrarEmpleadoMayorVentas.Text = "Mostrar Empleado con Mayores Ventas";
            this.BMostrarEmpleadoMayorVentas.UseVisualStyleBackColor = true;
            this.BMostrarEmpleadoMayorVentas.Click += new System.EventHandler(this.BMostrarEmpleadoMayorVentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
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

        private System.Windows.Forms.Button BIntroducirEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BMostrarDatosEmpleados;
        private System.Windows.Forms.Button BEliminarEmpleado;
        private System.Windows.Forms.Button BOrdEmpleados;
        private System.Windows.Forms.Button BMostrarListaEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BOrdEmpleadosVentas;
        private System.Windows.Forms.Button BEliminarVentasEmpleado;
        private System.Windows.Forms.Button BAñadirVentasEmpleado;
        private System.Windows.Forms.Button BMostrarEmpleadoMayorVentas;
    }
}

