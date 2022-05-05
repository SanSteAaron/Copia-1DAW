
namespace Ejercicio704
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
            this.BEmpleado = new System.Windows.Forms.Button();
            this.BCumpleañosEmpleado = new System.Windows.Forms.Button();
            this.BMostrarListaEmpleados = new System.Windows.Forms.Button();
            this.BAñadirVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BEmpleado
            // 
            this.BEmpleado.Location = new System.Drawing.Point(118, 107);
            this.BEmpleado.Name = "BEmpleado";
            this.BEmpleado.Size = new System.Drawing.Size(225, 58);
            this.BEmpleado.TabIndex = 0;
            this.BEmpleado.Text = "Nuevo empleado";
            this.BEmpleado.UseVisualStyleBackColor = true;
            this.BEmpleado.Click += new System.EventHandler(this.BEmpleado_Click);
            // 
            // BCumpleañosEmpleado
            // 
            this.BCumpleañosEmpleado.Location = new System.Drawing.Point(118, 233);
            this.BCumpleañosEmpleado.Name = "BCumpleañosEmpleado";
            this.BCumpleañosEmpleado.Size = new System.Drawing.Size(225, 58);
            this.BCumpleañosEmpleado.TabIndex = 1;
            this.BCumpleañosEmpleado.Text = "Cumpleaños empleado";
            this.BCumpleañosEmpleado.UseVisualStyleBackColor = true;
            this.BCumpleañosEmpleado.Click += new System.EventHandler(this.BCumpleañosEmpleado_Click);
            // 
            // BMostrarListaEmpleados
            // 
            this.BMostrarListaEmpleados.Location = new System.Drawing.Point(446, 107);
            this.BMostrarListaEmpleados.Name = "BMostrarListaEmpleados";
            this.BMostrarListaEmpleados.Size = new System.Drawing.Size(225, 58);
            this.BMostrarListaEmpleados.TabIndex = 2;
            this.BMostrarListaEmpleados.Text = "Mostrar lista empleados";
            this.BMostrarListaEmpleados.UseVisualStyleBackColor = true;
            this.BMostrarListaEmpleados.Click += new System.EventHandler(this.BMostrarListaEmpleados_Click);
            // 
            // BAñadirVenta
            // 
            this.BAñadirVenta.Location = new System.Drawing.Point(446, 233);
            this.BAñadirVenta.Name = "BAñadirVenta";
            this.BAñadirVenta.Size = new System.Drawing.Size(225, 58);
            this.BAñadirVenta.TabIndex = 3;
            this.BAñadirVenta.Text = "Añadir venta";
            this.BAñadirVenta.UseVisualStyleBackColor = true;
            this.BAñadirVenta.Click += new System.EventHandler(this.BAñadirVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAñadirVenta);
            this.Controls.Add(this.BMostrarListaEmpleados);
            this.Controls.Add(this.BCumpleañosEmpleado);
            this.Controls.Add(this.BEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BEmpleado;
        private System.Windows.Forms.Button BCumpleañosEmpleado;
        private System.Windows.Forms.Button BMostrarListaEmpleados;
        private System.Windows.Forms.Button BAñadirVenta;
    }
}

