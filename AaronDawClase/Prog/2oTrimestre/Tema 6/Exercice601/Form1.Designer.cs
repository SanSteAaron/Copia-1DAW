
namespace Exercice601
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
            this.BShowPosition = new System.Windows.Forms.Button();
            this.BShowList = new System.Windows.Forms.Button();
            this.BInsertNumbers = new System.Windows.Forms.Button();
            this.BAddNumbers = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BRemoveAllElements = new System.Windows.Forms.Button();
            this.BSortList = new System.Windows.Forms.Button();
            this.BRemovePosition = new System.Windows.Forms.Button();
            this.BRemoveValue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BShowPosition);
            this.groupBox1.Controls.Add(this.BShowList);
            this.groupBox1.Controls.Add(this.BInsertNumbers);
            this.groupBox1.Controls.Add(this.BAddNumbers);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(128, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elements";
            // 
            // BShowPosition
            // 
            this.BShowPosition.Location = new System.Drawing.Point(30, 256);
            this.BShowPosition.Name = "BShowPosition";
            this.BShowPosition.Size = new System.Drawing.Size(158, 23);
            this.BShowPosition.TabIndex = 3;
            this.BShowPosition.Text = "Show Position of value";
            this.BShowPosition.UseVisualStyleBackColor = true;
            this.BShowPosition.Click += new System.EventHandler(this.BShowPosition_Click);
            // 
            // BShowList
            // 
            this.BShowList.Location = new System.Drawing.Point(30, 195);
            this.BShowList.Name = "BShowList";
            this.BShowList.Size = new System.Drawing.Size(158, 23);
            this.BShowList.TabIndex = 2;
            this.BShowList.Text = "Show list";
            this.BShowList.UseVisualStyleBackColor = true;
            this.BShowList.Click += new System.EventHandler(this.BShowList_Click);
            // 
            // BInsertNumbers
            // 
            this.BInsertNumbers.Location = new System.Drawing.Point(30, 137);
            this.BInsertNumbers.Name = "BInsertNumbers";
            this.BInsertNumbers.Size = new System.Drawing.Size(158, 23);
            this.BInsertNumbers.TabIndex = 1;
            this.BInsertNumbers.Text = "Insert number";
            this.BInsertNumbers.UseVisualStyleBackColor = true;
            this.BInsertNumbers.Click += new System.EventHandler(this.BInsertNumbers_Click);
            // 
            // BAddNumbers
            // 
            this.BAddNumbers.Location = new System.Drawing.Point(30, 79);
            this.BAddNumbers.Name = "BAddNumbers";
            this.BAddNumbers.Size = new System.Drawing.Size(158, 23);
            this.BAddNumbers.TabIndex = 0;
            this.BAddNumbers.Text = "Add number";
            this.BAddNumbers.UseVisualStyleBackColor = true;
            this.BAddNumbers.Click += new System.EventHandler(this.BAddNumbers_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BRemoveAllElements);
            this.groupBox2.Controls.Add(this.BSortList);
            this.groupBox2.Controls.Add(this.BRemovePosition);
            this.groupBox2.Controls.Add(this.BRemoveValue);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(426, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove";
            // 
            // BRemoveAllElements
            // 
            this.BRemoveAllElements.Location = new System.Drawing.Point(30, 256);
            this.BRemoveAllElements.Name = "BRemoveAllElements";
            this.BRemoveAllElements.Size = new System.Drawing.Size(158, 23);
            this.BRemoveAllElements.TabIndex = 4;
            this.BRemoveAllElements.Text = "Remove all elements";
            this.BRemoveAllElements.UseVisualStyleBackColor = true;
            this.BRemoveAllElements.Click += new System.EventHandler(this.BRemoveAllElements_Click);
            // 
            // BSortList
            // 
            this.BSortList.Location = new System.Drawing.Point(30, 195);
            this.BSortList.Name = "BSortList";
            this.BSortList.Size = new System.Drawing.Size(158, 23);
            this.BSortList.TabIndex = 3;
            this.BSortList.Text = "Sort list";
            this.BSortList.UseVisualStyleBackColor = true;
            this.BSortList.Click += new System.EventHandler(this.BSortList_Click);
            // 
            // BRemovePosition
            // 
            this.BRemovePosition.Location = new System.Drawing.Point(30, 137);
            this.BRemovePosition.Name = "BRemovePosition";
            this.BRemovePosition.Size = new System.Drawing.Size(158, 23);
            this.BRemovePosition.TabIndex = 2;
            this.BRemovePosition.Text = "Remove position";
            this.BRemovePosition.UseVisualStyleBackColor = true;
            this.BRemovePosition.Click += new System.EventHandler(this.BRemovePosition_Click);
            // 
            // BRemoveValue
            // 
            this.BRemoveValue.Location = new System.Drawing.Point(30, 79);
            this.BRemoveValue.Name = "BRemoveValue";
            this.BRemoveValue.Size = new System.Drawing.Size(158, 23);
            this.BRemoveValue.TabIndex = 1;
            this.BRemoveValue.Text = "Remove value";
            this.BRemoveValue.UseVisualStyleBackColor = true;
            this.BRemoveValue.Click += new System.EventHandler(this.BRemoveValue_Click);
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

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BShowPosition;
        private System.Windows.Forms.Button BShowList;
        private System.Windows.Forms.Button BInsertNumbers;
        private System.Windows.Forms.Button BAddNumbers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BRemoveAllElements;
        private System.Windows.Forms.Button BSortList;
        private System.Windows.Forms.Button BRemovePosition;
        private System.Windows.Forms.Button BRemoveValue;
    }
}

