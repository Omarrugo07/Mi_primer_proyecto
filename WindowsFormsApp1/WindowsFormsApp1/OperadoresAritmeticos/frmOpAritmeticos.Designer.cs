namespace WindowsFormsApp1.OperadoresAritmeticos
{
    partial class frmOpAritmeticos
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.Num1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.texNum1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.total = new System.Windows.Forms.TextBox();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSuma.Location = new System.Drawing.Point(387, 161);
            this.btnSuma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(48, 39);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Num1.Location = new System.Drawing.Point(54, 127);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(120, 23);
            this.Num1.TabIndex = 1;
            this.Num1.Text = "Numero 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(625, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 2;
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Num2.Location = new System.Drawing.Point(54, 189);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(120, 23);
            this.Num2.TabIndex = 3;
            this.Num2.Text = "Numero 2 :";
            // 
            // texNum1
            // 
            this.texNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.texNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texNum1.ForeColor = System.Drawing.Color.White;
            this.texNum1.Location = new System.Drawing.Point(168, 112);
            this.texNum1.Name = "texNum1";
            this.texNum1.Size = new System.Drawing.Size(200, 22);
            this.texNum1.TabIndex = 4;
            this.texNum1.TextChanged += new System.EventHandler(this.texNum1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(170, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 2);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(170, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 2);
            this.panel2.TabIndex = 6;
            // 
            // textNum2
            // 
            this.textNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.textNum2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNum2.ForeColor = System.Drawing.Color.White;
            this.textNum2.Location = new System.Drawing.Point(168, 172);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(200, 22);
            this.textNum2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(54, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resultado:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(170, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 2);
            this.panel3.TabIndex = 6;
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.Color.White;
            this.total.Location = new System.Drawing.Point(168, 307);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(113, 22);
            this.total.TabIndex = 4;
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResta.Location = new System.Drawing.Point(387, 210);
            this.btnResta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(48, 39);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMultiplicacion.Location = new System.Drawing.Point(443, 161);
            this.btnMultiplicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(48, 39);
            this.btnMultiplicacion.TabIndex = 8;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(80)))));
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDivision.Location = new System.Drawing.Point(443, 210);
            this.btnDivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(48, 39);
            this.btnDivision.TabIndex = 9;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // frmOpAritmeticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(717, 439);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.texNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.btnSuma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOpAritmeticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numero 1 : ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOpAritmeticos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.TextBox texNum1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
    }
}