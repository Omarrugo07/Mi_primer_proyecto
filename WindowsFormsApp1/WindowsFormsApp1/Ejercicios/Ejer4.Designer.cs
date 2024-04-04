namespace WindowsFormsApp1.Ejercicios
{
    partial class Ejer4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer4));
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDetalle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblCamisas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBAmarillo = new System.Windows.Forms.RadioButton();
            this.RBNegro = new System.Windows.Forms.RadioButton();
            this.RBBlanco = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBtallaS = new System.Windows.Forms.RadioButton();
            this.RBtallaL = new System.Windows.Forms.RadioButton();
            this.RBTallaM = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(926, 26);
            this.label11.TabIndex = 1;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.textDetalle);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblColor);
            this.panel1.Controls.Add(this.lblCamisas);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 276);
            this.panel1.TabIndex = 5;
            // 
            // textDetalle
            // 
            this.textDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.textDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDetalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.textDetalle.Location = new System.Drawing.Point(666, 68);
            this.textDetalle.Multiline = true;
            this.textDetalle.Name = "textDetalle";
            this.textDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textDetalle.Size = new System.Drawing.Size(247, 193);
            this.textDetalle.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(69)))), ((int)(((byte)(88)))));
            this.btnAgregar.Location = new System.Drawing.Point(585, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblColor.Location = new System.Drawing.Point(431, 28);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(64, 26);
            this.lblColor.TabIndex = 1;
            this.lblColor.Text = "Color";
            // 
            // lblCamisas
            // 
            this.lblCamisas.AutoSize = true;
            this.lblCamisas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamisas.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCamisas.Location = new System.Drawing.Point(77, 28);
            this.lblCamisas.Name = "lblCamisas";
            this.lblCamisas.Size = new System.Drawing.Size(98, 26);
            this.lblCamisas.TabIndex = 1;
            this.lblCamisas.Text = "Camisas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBAmarillo);
            this.groupBox2.Controls.Add(this.RBNegro);
            this.groupBox2.Controls.Add(this.RBBlanco);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(310, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 193);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color";
            // 
            // RBAmarillo
            // 
            this.RBAmarillo.AutoSize = true;
            this.RBAmarillo.Location = new System.Drawing.Point(51, 122);
            this.RBAmarillo.Name = "RBAmarillo";
            this.RBAmarillo.Size = new System.Drawing.Size(84, 21);
            this.RBAmarillo.TabIndex = 2;
            this.RBAmarillo.TabStop = true;
            this.RBAmarillo.Text = "Amarillo";
            this.RBAmarillo.UseVisualStyleBackColor = true;
            // 
            // RBNegro
            // 
            this.RBNegro.AutoSize = true;
            this.RBNegro.Location = new System.Drawing.Point(52, 79);
            this.RBNegro.Name = "RBNegro";
            this.RBNegro.Size = new System.Drawing.Size(70, 21);
            this.RBNegro.TabIndex = 1;
            this.RBNegro.TabStop = true;
            this.RBNegro.Text = "Negro";
            this.RBNegro.UseVisualStyleBackColor = true;
            // 
            // RBBlanco
            // 
            this.RBBlanco.AutoSize = true;
            this.RBBlanco.Location = new System.Drawing.Point(52, 35);
            this.RBBlanco.Name = "RBBlanco";
            this.RBBlanco.Size = new System.Drawing.Size(75, 21);
            this.RBBlanco.TabIndex = 0;
            this.RBBlanco.TabStop = true;
            this.RBBlanco.Text = "Blanco";
            this.RBBlanco.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtallaS);
            this.groupBox1.Controls.Add(this.RBtallaL);
            this.groupBox1.Controls.Add(this.RBTallaM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(8, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talla";
            // 
            // RBtallaS
            // 
            this.RBtallaS.AutoSize = true;
            this.RBtallaS.Location = new System.Drawing.Point(51, 122);
            this.RBtallaS.Name = "RBtallaS";
            this.RBtallaS.Size = new System.Drawing.Size(173, 21);
            this.RBtallaS.TabIndex = 2;
            this.RBtallaS.TabStop = true;
            this.RBtallaS.Text = "Talla S ( $ 10 USD )";
            this.RBtallaS.UseVisualStyleBackColor = true;
            // 
            // RBtallaL
            // 
            this.RBtallaL.AutoSize = true;
            this.RBtallaL.Location = new System.Drawing.Point(52, 79);
            this.RBtallaL.Name = "RBtallaL";
            this.RBtallaL.Size = new System.Drawing.Size(172, 21);
            this.RBtallaL.TabIndex = 1;
            this.RBtallaL.TabStop = true;
            this.RBtallaL.Text = "Talla L ( $ 25 USD )\r\n";
            this.RBtallaL.UseVisualStyleBackColor = true;
            // 
            // RBTallaM
            // 
            this.RBTallaM.AutoSize = true;
            this.RBTallaM.Location = new System.Drawing.Point(52, 35);
            this.RBTallaM.Name = "RBTallaM";
            this.RBTallaM.Size = new System.Drawing.Size(175, 21);
            this.RBTallaM.TabIndex = 0;
            this.RBTallaM.TabStop = true;
            this.RBTallaM.Text = "Talla M ( $ 50 USD )";
            this.RBTallaM.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(670, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Ejer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Name = "Ejer4";
            this.Size = new System.Drawing.Size(926, 504);
            this.Load += new System.EventHandler(this.Ejer4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblCamisas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBAmarillo;
        private System.Windows.Forms.RadioButton RBNegro;
        private System.Windows.Forms.RadioButton RBBlanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBtallaS;
        private System.Windows.Forms.RadioButton RBtallaL;
        private System.Windows.Forms.RadioButton RBTallaM;
        private System.Windows.Forms.TextBox textDetalle;
        private System.Windows.Forms.Button btnAgregar;
    }
}
