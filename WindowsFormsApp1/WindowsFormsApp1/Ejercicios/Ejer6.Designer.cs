namespace WindowsFormsApp1.Ejercicios
{
    partial class Ejer6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer6));
            this.label13 = new System.Windows.Forms.Label();
            this.lblEjercicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNum1 = new System.Windows.Forms.TextBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btbResultado = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.panelNumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnProcentaje = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(184)))), ((int)(((byte)(70)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(926, 38);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ejercicio5 \r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEjercicio
            // 
            this.lblEjercicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEjercicio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEjercicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEjercicio.Location = new System.Drawing.Point(0, 38);
            this.lblEjercicio.Name = "lblEjercicio";
            this.lblEjercicio.Size = new System.Drawing.Size(32, 603);
            this.lblEjercicio.TabIndex = 4;
            this.lblEjercicio.Text = "Ejercicio 6";
            this.lblEjercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblNum1);
            this.panel1.Controls.Add(this.lblOperacion);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Controls.Add(this.btnCopiar);
            this.panel1.Controls.Add(this.Pantalla);
            this.panel1.Controls.Add(this.panelNumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(52, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 600);
            this.panel1.TabIndex = 5;
            // 
            // lblNum1
            // 
            this.lblNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblNum1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNum1.Location = new System.Drawing.Point(273, 93);
            this.lblNum1.Multiline = true;
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.ReadOnly = true;
            this.lblNum1.Size = new System.Drawing.Size(206, 45);
            this.lblNum1.TabIndex = 6;
            this.lblNum1.Text = "0";
            this.lblNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lblNum1.Visible = false;
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblOperacion.Font = new System.Drawing.Font("Consolas", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(157)))), ((int)(((byte)(1)))));
            this.lblOperacion.Location = new System.Drawing.Point(454, 141);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(20, 22);
            this.lblOperacion.TabIndex = 5;
            this.lblOperacion.Text = "0";
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblOperacion.Visible = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel3.Controls.Add(this.btnSuma);
            this.flowLayoutPanel3.Controls.Add(this.btnMultiplicacion);
            this.flowLayoutPanel3.Controls.Add(this.btnResta);
            this.flowLayoutPanel3.Controls.Add(this.btbResultado);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(417, 270);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(57, 246);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // btnSuma
            // 
            this.btnSuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnSuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuma.BackgroundImage")));
            this.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuma.FlatAppearance.BorderSize = 0;
            this.btnSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuma.Location = new System.Drawing.Point(3, 3);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(42, 42);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = false;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnMultiplicacion.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_amarillo_recortado;
            this.btnMultiplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplicacion.FlatAppearance.BorderSize = 0;
            this.btnMultiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMultiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMultiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplicacion.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMultiplicacion.Location = new System.Drawing.Point(3, 51);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(42, 42);
            this.btnMultiplicacion.TabIndex = 2;
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = false;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnResta
            // 
            this.btnResta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnResta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResta.BackgroundImage")));
            this.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResta.FlatAppearance.BorderSize = 0;
            this.btnResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResta.Location = new System.Drawing.Point(3, 99);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(42, 42);
            this.btnResta.TabIndex = 3;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = false;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btbResultado
            // 
            this.btbResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btbResultado.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_amarillo_recortado;
            this.btbResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbResultado.FlatAppearance.BorderSize = 0;
            this.btbResultado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btbResultado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbResultado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btbResultado.Location = new System.Drawing.Point(3, 147);
            this.btbResultado.Name = "btbResultado";
            this.btbResultado.Size = new System.Drawing.Size(42, 42);
            this.btbResultado.TabIndex = 4;
            this.btbResultado.Text = "=";
            this.btbResultado.UseVisualStyleBackColor = false;
            this.btbResultado.Click += new System.EventHandler(this.btbResultado_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopiar.BackgroundImage")));
            this.btnCopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopiar.FlatAppearance.BorderSize = 0;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCopiar.Location = new System.Drawing.Point(243, 184);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(22, 21);
            this.btnCopiar.TabIndex = 0;
            this.btnCopiar.Text = "AC";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pantalla.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.ForeColor = System.Drawing.SystemColors.Info;
            this.Pantalla.Location = new System.Drawing.Point(271, 166);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(205, 45);
            this.Pantalla.TabIndex = 3;
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelNumerico
            // 
            this.panelNumerico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelNumerico.Location = new System.Drawing.Point(259, 270);
            this.panelNumerico.Name = "panelNumerico";
            this.panelNumerico.Size = new System.Drawing.Size(152, 246);
            this.panelNumerico.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.flowLayoutPanel1.Controls.Add(this.btnBorrar);
            this.flowLayoutPanel1.Controls.Add(this.btnProcentaje);
            this.flowLayoutPanel1.Controls.Add(this.btnApagar);
            this.flowLayoutPanel1.Controls.Add(this.btn_division);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(259, 214);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 53);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_gris__recortado;
            this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(3, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(45, 42);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "AC";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnProcentaje
            // 
            this.btnProcentaje.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_gris__recortado;
            this.btnProcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcentaje.FlatAppearance.BorderSize = 0;
            this.btnProcentaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnProcentaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcentaje.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcentaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProcentaje.Location = new System.Drawing.Point(54, 3);
            this.btnProcentaje.Name = "btnProcentaje";
            this.btnProcentaje.Size = new System.Drawing.Size(42, 42);
            this.btnProcentaje.TabIndex = 0;
            this.btnProcentaje.Text = "%";
            this.btnProcentaje.UseVisualStyleBackColor = true;
            this.btnProcentaje.Click += new System.EventHandler(this.btnProcentaje_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_gris__recortado;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApagar.Location = new System.Drawing.Point(102, 3);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(42, 42);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Of";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btn_division
            // 
            this.btn_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btn_division.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.boton_amarillo_recortado;
            this.btn_division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_division.FlatAppearance.BorderSize = 0;
            this.btn_division.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_division.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_division.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_division.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_division.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_division.Location = new System.Drawing.Point(150, 3);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(42, 42);
            this.btn_division.TabIndex = 0;
            this.btn_division.Text = "/";
            this.btn_division.UseVisualStyleBackColor = false;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // Ejer6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEjercicio);
            this.Controls.Add(this.label13);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Ejer6";
            this.Size = new System.Drawing.Size(926, 641);
            this.Load += new System.EventHandler(this.Ejer6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblEjercicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel panelNumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnProcentaje;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btbResultado;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.TextBox lblNum1;
    }
}
