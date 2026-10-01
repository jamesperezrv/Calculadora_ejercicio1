namespace Calculadora_ejercicio1
{
    partial class Form2
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
            this.TextBB1 = new System.Windows.Forms.TextBox();
            this.TextBB2 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.Button();
            this.Potencia = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBB1
            // 
            this.TextBB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBB1.Location = new System.Drawing.Point(183, 24);
            this.TextBB1.Name = "TextBB1";
            this.TextBB1.Size = new System.Drawing.Size(100, 20);
            this.TextBB1.TabIndex = 0;
            // 
            // TextBB2
            // 
            this.TextBB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBB2.Location = new System.Drawing.Point(183, 53);
            this.TextBB2.Name = "TextBB2";
            this.TextBB2.Size = new System.Drawing.Size(100, 20);
            this.TextBB2.TabIndex = 1;
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.Lime;
            this.Suma.Location = new System.Drawing.Point(45, 21);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "S";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Visible = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Producto
            // 
            this.Producto.BackColor = System.Drawing.Color.Cyan;
            this.Producto.Location = new System.Drawing.Point(45, 50);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(75, 23);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "M";
            this.Producto.UseVisualStyleBackColor = false;
            this.Producto.Click += new System.EventHandler(this.Producto_Click);
            // 
            // Potencia
            // 
            this.Potencia.BackColor = System.Drawing.Color.Red;
            this.Potencia.Location = new System.Drawing.Point(45, 79);
            this.Potencia.Name = "Potencia";
            this.Potencia.Size = new System.Drawing.Size(75, 23);
            this.Potencia.TabIndex = 4;
            this.Potencia.Text = "P";
            this.Potencia.UseVisualStyleBackColor = false;
            this.Potencia.Click += new System.EventHandler(this.Potencia_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Division.Location = new System.Drawing.Point(45, 108);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(75, 23);
            this.Division.TabIndex = 5;
            this.Division.Text = "D";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Factorial
            // 
            this.Factorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Factorial.Location = new System.Drawing.Point(45, 137);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(75, 23);
            this.Factorial.TabIndex = 6;
            this.Factorial.Text = "F";
            this.Factorial.UseVisualStyleBackColor = false;
            this.Factorial.Click += new System.EventHandler(this.Factorial_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Potencia);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.TextBB2);
            this.Controls.Add(this.TextBB1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBB1;
        private System.Windows.Forms.TextBox TextBB2;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Producto;
        private System.Windows.Forms.Button Potencia;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Factorial;
    }
}