namespace WindowsFormsApp1.Ejercicios
{
    partial class Ejer2
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalcularA = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ResulLong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.resulRadio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtArea = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRadio2 = new System.Windows.Forms.Label();
            this.lblRadio1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(115, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(677, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalcularA);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.ResulLong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.resulRadio);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtArea);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblRadio2);
            this.panel1.Controls.Add(this.lblRadio1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 236);
            this.panel1.TabIndex = 1;
            // 
            // btnCalcularA
            // 
            this.btnCalcularA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnCalcularA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcularA.Location = new System.Drawing.Point(303, 81);
            this.btnCalcularA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcularA.Name = "btnCalcularA";
            this.btnCalcularA.Size = new System.Drawing.Size(141, 39);
            this.btnCalcularA.TabIndex = 20;
            this.btnCalcularA.Text = "Calcular ";
            this.btnCalcularA.UseVisualStyleBackColor = false;
            this.btnCalcularA.Click += new System.EventHandler(this.btnCalcularA_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(632, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(111, 2);
            this.panel5.TabIndex = 19;
            // 
            // ResulLong
            // 
            this.ResulLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.ResulLong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResulLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResulLong.ForeColor = System.Drawing.Color.White;
            this.ResulLong.Location = new System.Drawing.Point(630, 118);
            this.ResulLong.Name = "ResulLong";
            this.ResulLong.Size = new System.Drawing.Size(200, 22);
            this.ResulLong.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(506, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Longitud :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(608, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 2);
            this.panel4.TabIndex = 16;
            // 
            // resulRadio
            // 
            this.resulRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.resulRadio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resulRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resulRadio.ForeColor = System.Drawing.Color.White;
            this.resulRadio.Location = new System.Drawing.Point(606, 70);
            this.resulRadio.Name = "resulRadio";
            this.resulRadio.Size = new System.Drawing.Size(200, 22);
            this.resulRadio.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(677, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Resultados : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(506, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Radio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(30, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Radio";
            // 
            // TxtArea
            // 
            this.TxtArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtArea.ForeColor = System.Drawing.Color.White;
            this.TxtArea.Location = new System.Drawing.Point(20, 64);
            this.TxtArea.Name = "TxtArea";
            this.TxtArea.Size = new System.Drawing.Size(167, 22);
            this.TxtArea.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(20, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 2);
            this.panel2.TabIndex = 9;
            // 
            // lblRadio2
            // 
            this.lblRadio2.AutoSize = true;
            this.lblRadio2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.lblRadio2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadio2.Location = new System.Drawing.Point(214, 131);
            this.lblRadio2.Name = "lblRadio2";
            this.lblRadio2.Size = new System.Drawing.Size(21, 23);
            this.lblRadio2.TabIndex = 1;
            this.lblRadio2.Text = "r";
            // 
            // lblRadio1
            // 
            this.lblRadio1.AutoSize = true;
            this.lblRadio1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.lblRadio1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRadio1.Location = new System.Drawing.Point(180, 29);
            this.lblRadio1.Name = "lblRadio1";
            this.lblRadio1.Size = new System.Drawing.Size(21, 23);
            this.lblRadio1.TabIndex = 1;
            this.lblRadio1.Text = "r";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(195, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(111, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 23);
            this.label9.TabIndex = 1;
            this.label9.Text = "2 * pi * ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(120, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "pi * ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Area";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(68)))), ((int)(((byte)(88)))));
            this.label6.Location = new System.Drawing.Point(0, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(941, 41);
            this.label6.TabIndex = 3;
            this.label6.Text = "Solucion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // Ejer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ejer2";
            this.Size = new System.Drawing.Size(941, 505);
            this.Load += new System.EventHandler(this.Ejer2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtArea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox resulRadio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox ResulLong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblRadio2;
        private System.Windows.Forms.Label lblRadio1;
    }
}
