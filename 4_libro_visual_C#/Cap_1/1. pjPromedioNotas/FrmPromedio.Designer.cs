namespace pjPromedioNotas
{
    partial class FrmPromedio
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtNota4 = new System.Windows.Forms.TextBox();
			this.txtNota3 = new System.Windows.Forms.TextBox();
			this.txtNota2 = new System.Windows.Forms.TextBox();
			this.txtNota1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.lblBaja = new System.Windows.Forms.Label();
			this.lblCondicion = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "ALUMNO";
			// 
			// txtNombre
			// 
			this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.txtNombre.Location = new System.Drawing.Point(8, 40);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNombre.MaxLength = 300;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(300, 22);
			this.txtNombre.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtNota4);
			this.groupBox1.Controls.Add(this.txtNota3);
			this.groupBox1.Controls.Add(this.txtNota2);
			this.groupBox1.Controls.Add(this.txtNota1);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox1.Location = new System.Drawing.Point(312, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(232, 72);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registro de notas";
			// 
			// txtNota4
			// 
			this.txtNota4.Location = new System.Drawing.Point(176, 40);
			this.txtNota4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNota4.MaxLength = 5;
			this.txtNota4.Name = "txtNota4";
			this.txtNota4.Size = new System.Drawing.Size(48, 22);
			this.txtNota4.TabIndex = 6;
			// 
			// txtNota3
			// 
			this.txtNota3.Location = new System.Drawing.Point(120, 40);
			this.txtNota3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNota3.MaxLength = 5;
			this.txtNota3.Name = "txtNota3";
			this.txtNota3.Size = new System.Drawing.Size(48, 22);
			this.txtNota3.TabIndex = 5;
			// 
			// txtNota2
			// 
			this.txtNota2.Location = new System.Drawing.Point(64, 40);
			this.txtNota2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNota2.MaxLength = 5;
			this.txtNota2.Name = "txtNota2";
			this.txtNota2.Size = new System.Drawing.Size(48, 22);
			this.txtNota2.TabIndex = 4;
			// 
			// txtNota1
			// 
			this.txtNota1.Location = new System.Drawing.Point(8, 40);
			this.txtNota1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtNota1.MaxLength = 5;
			this.txtNota1.Name = "txtNota1";
			this.txtNota1.Size = new System.Drawing.Size(48, 22);
			this.txtNota1.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(176, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "NOTA 4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(120, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "NOTA 3";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(64, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "NOTA 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "NOTA 1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label7.Location = new System.Drawing.Point(8, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "PROMEDIO DE NOTAS";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label8.Location = new System.Drawing.Point(32, 136);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(89, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "NOTA MAS BAJA";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label9.Location = new System.Drawing.Point(56, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "CONDICIÓN";
			// 
			// lblPromedio
			// 
			this.lblPromedio.AutoSize = true;
			this.lblPromedio.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.lblPromedio.Location = new System.Drawing.Point(128, 112);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(22, 13);
			this.lblPromedio.TabIndex = 0;
			this.lblPromedio.Text = "0.0";
			// 
			// lblBaja
			// 
			this.lblBaja.AutoSize = true;
			this.lblBaja.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.lblBaja.Location = new System.Drawing.Point(128, 136);
			this.lblBaja.Name = "lblBaja";
			this.lblBaja.Size = new System.Drawing.Size(22, 13);
			this.lblBaja.TabIndex = 0;
			this.lblBaja.Text = "0.0";
			// 
			// lblCondicion
			// 
			this.lblCondicion.AutoSize = true;
			this.lblCondicion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.lblCondicion.Location = new System.Drawing.Point(128, 160);
			this.lblCondicion.Name = "lblCondicion";
			this.lblCondicion.Size = new System.Drawing.Size(42, 13);
			this.lblCondicion.TabIndex = 0;
			this.lblCondicion.Text = "Estado";
			// 
			// btnSalir
			// 
			this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnSalir.Image = global::pjPromedioNotas.Properties.Resources.disconnect;
			this.btnSalir.Location = new System.Drawing.Point(168, 72);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(55, 24);
			this.btnSalir.TabIndex = 9;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnLimpiar.Image = global::pjPromedioNotas.Properties.Resources.bin_closed;
			this.btnLimpiar.Location = new System.Drawing.Point(88, 72);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(71, 24);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnCalcular.Image = global::pjPromedioNotas.Properties.Resources.calculator;
			this.btnCalcular.Location = new System.Drawing.Point(8, 72);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(71, 24);
			this.btnCalcular.TabIndex = 7;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// FrmPromedio
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(554, 191);
			this.Controls.Add(this.lblCondicion);
			this.Controls.Add(this.lblBaja);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FrmPromedio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de promedio de notas";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblBaja;
        private System.Windows.Forms.Label lblCondicion;
    }
}

