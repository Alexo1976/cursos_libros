namespace pjSueldoEmpleado {
    partial class FrmSueldo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtEmpleado = new System.Windows.Forms.TextBox();
			this.TxtHoras = new System.Windows.Forms.TextBox();
			this.LVPago = new System.Windows.Forms.ListView();
			this.NombreEmpleado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Horas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CostoHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Bruto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Descuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Neto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CboCategoria = new System.Windows.Forms.ComboBox();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnSalir = new System.Windows.Forms.Button();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label2.Location = new System.Drawing.Point(8, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Empleado";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label3.Location = new System.Drawing.Point(8, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Categoría";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label4.Location = new System.Drawing.Point(424, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Horas trabajadas";
			// 
			// TxtEmpleado
			// 
			this.TxtEmpleado.Location = new System.Drawing.Point(72, 8);
			this.TxtEmpleado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TxtEmpleado.Name = "TxtEmpleado";
			this.TxtEmpleado.Size = new System.Drawing.Size(500, 22);
			this.TxtEmpleado.TabIndex = 1;
			// 
			// TxtHoras
			// 
			this.TxtHoras.Location = new System.Drawing.Point(520, 40);
			this.TxtHoras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.TxtHoras.Name = "TxtHoras";
			this.TxtHoras.Size = new System.Drawing.Size(50, 22);
			this.TxtHoras.TabIndex = 3;
			// 
			// LVPago
			// 
			this.LVPago.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NombreEmpleado,
            this.Cat,
            this.Horas,
            this.CostoHora,
            this.Bruto,
            this.Descuento,
            this.Neto});
			this.LVPago.HideSelection = false;
			this.LVPago.Location = new System.Drawing.Point(8, 72);
			this.LVPago.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.LVPago.Name = "LVPago";
			this.LVPago.Size = new System.Drawing.Size(760, 185);
			this.LVPago.TabIndex = 5;
			this.LVPago.UseCompatibleStateImageBehavior = false;
			this.LVPago.View = System.Windows.Forms.View.Details;
			// 
			// NombreEmpleado
			// 
			this.NombreEmpleado.Text = "Empleado";
			this.NombreEmpleado.Width = 200;
			// 
			// Cat
			// 
			this.Cat.Text = "Cat.";
			this.Cat.Width = 50;
			// 
			// Horas
			// 
			this.Horas.Text = "Horas";
			this.Horas.Width = 50;
			// 
			// CostoHora
			// 
			this.CostoHora.Text = "Costo por hora";
			this.CostoHora.Width = 110;
			// 
			// Bruto
			// 
			this.Bruto.Text = "Bruto";
			this.Bruto.Width = 125;
			// 
			// Descuento
			// 
			this.Descuento.Text = "Descuento";
			this.Descuento.Width = 100;
			// 
			// Neto
			// 
			this.Neto.Text = "Neto";
			this.Neto.Width = 115;
			// 
			// CboCategoria
			// 
			this.CboCategoria.FormattingEnabled = true;
			this.CboCategoria.Items.AddRange(new object[] {
            "CAS",
            "CAP"});
			this.CboCategoria.Location = new System.Drawing.Point(72, 40);
			this.CboCategoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.CboCategoria.Name = "CboCategoria";
			this.CboCategoria.Size = new System.Drawing.Size(250, 21);
			this.CboCategoria.TabIndex = 2;
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnLimpiar.Image = global::pjSueldoEmpleado.Properties.Resources.bin_closed;
			this.BtnLimpiar.Location = new System.Drawing.Point(80, 264);
			this.BtnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(70, 24);
			this.BtnLimpiar.TabIndex = 7;
			this.BtnLimpiar.Text = "Limpiar";
			this.BtnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
			// 
			// BtnSalir
			// 
			this.BtnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnSalir.Image = global::pjSueldoEmpleado.Properties.Resources.disconnect;
			this.BtnSalir.Location = new System.Drawing.Point(8, 264);
			this.BtnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnSalir.Name = "BtnSalir";
			this.BtnSalir.Size = new System.Drawing.Size(65, 24);
			this.BtnSalir.TabIndex = 6;
			this.BtnSalir.Text = "Salir";
			this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnSalir.UseVisualStyleBackColor = true;
			this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnRegistrar.Image = global::pjSueldoEmpleado.Properties.Resources.accept;
			this.BtnRegistrar.Location = new System.Drawing.Point(576, 40);
			this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(80, 24);
			this.BtnRegistrar.TabIndex = 4;
			this.BtnRegistrar.Text = "Registrar";
			this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnRegistrar.UseVisualStyleBackColor = true;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
			// 
			// FrmSueldo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(779, 296);
			this.Controls.Add(this.CboCategoria);
			this.Controls.Add(this.LVPago);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.BtnSalir);
			this.Controls.Add(this.BtnRegistrar);
			this.Controls.Add(this.TxtHoras);
			this.Controls.Add(this.TxtEmpleado);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FrmSueldo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de pago de empleados";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtEmpleado;
        private System.Windows.Forms.TextBox TxtHoras;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ListView LVPago;
        private System.Windows.Forms.ColumnHeader NombreEmpleado;
        private System.Windows.Forms.ColumnHeader Cat;
        private System.Windows.Forms.ColumnHeader Horas;
        private System.Windows.Forms.ColumnHeader CostoHora;
        private System.Windows.Forms.ColumnHeader Bruto;
        private System.Windows.Forms.ColumnHeader Descuento;
        private System.Windows.Forms.ColumnHeader Neto;
        private System.Windows.Forms.ComboBox CboCategoria;
    }
}

