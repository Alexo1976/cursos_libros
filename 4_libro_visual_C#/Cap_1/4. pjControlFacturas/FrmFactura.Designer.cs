namespace pjControlFacturas {
    partial class FrmFactura {
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
			this.label5 = new System.Windows.Forms.Label();
			this.LblFecha = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.LblComision = new System.Windows.Forms.Label();
			this.LblTotalSub = new System.Windows.Forms.Label();
			this.LblTotalFact = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.LVFacturas = new System.Windows.Forms.ListView();
			this.NumFactura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FechaFacturacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.MontoFacturado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TxtVendedor = new System.Windows.Forms.TextBox();
			this.TxtNumFact = new System.Windows.Forms.TextBox();
			this.TxtMonto = new System.Windows.Forms.TextBox();
			this.TxtFechaFact = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.BtnCancelar = new System.Windows.Forms.Button();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label2.Location = new System.Drawing.Point(8, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "VENDEDOR";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label3.Location = new System.Drawing.Point(8, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "No FACTURA";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label4.Location = new System.Drawing.Point(8, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "MONTO FACT.";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label5.Location = new System.Drawing.Point(312, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "FECHA FACT.";
			// 
			// LblFecha
			// 
			this.LblFecha.AutoSize = true;
			this.LblFecha.Location = new System.Drawing.Point(552, 13);
			this.LblFecha.Name = "LblFecha";
			this.LblFecha.Size = new System.Drawing.Size(63, 13);
			this.LblFecha.TabIndex = 0;
			this.LblFecha.Text = "01/01/2020";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LblComision);
			this.groupBox1.Controls.Add(this.LblTotalSub);
			this.groupBox1.Controls.Add(this.LblTotalFact);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox1.Location = new System.Drawing.Point(8, 256);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(753, 64);
			this.groupBox1.TabIndex = 100;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "MONTOS ASIGNADOS AL VENDEDOR POR EL REGISTRO DE FACTURAS";
			// 
			// LblComision
			// 
			this.LblComision.AutoSize = true;
			this.LblComision.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.LblComision.Location = new System.Drawing.Point(544, 40);
			this.LblComision.Name = "LblComision";
			this.LblComision.Size = new System.Drawing.Size(13, 13);
			this.LblComision.TabIndex = 0;
			this.LblComision.Text = "0";
			// 
			// LblTotalSub
			// 
			this.LblTotalSub.AutoSize = true;
			this.LblTotalSub.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.LblTotalSub.Location = new System.Drawing.Point(272, 40);
			this.LblTotalSub.Name = "LblTotalSub";
			this.LblTotalSub.Size = new System.Drawing.Size(13, 13);
			this.LblTotalSub.TabIndex = 0;
			this.LblTotalSub.Text = "0";
			// 
			// LblTotalFact
			// 
			this.LblTotalFact.AutoSize = true;
			this.LblTotalFact.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.LblTotalFact.Location = new System.Drawing.Point(8, 40);
			this.LblTotalFact.Name = "LblTotalFact";
			this.LblTotalFact.Size = new System.Drawing.Size(13, 13);
			this.LblTotalFact.TabIndex = 0;
			this.LblTotalFact.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(544, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "COMISION ASIGNADA";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(272, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "TOTAL SUBTOTAL";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "TOTAL FACTURAS";
			// 
			// LVFacturas
			// 
			this.LVFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumFactura,
            this.FechaFacturacion,
            this.MontoFacturado});
			this.LVFacturas.HideSelection = false;
			this.LVFacturas.Location = new System.Drawing.Point(8, 104);
			this.LVFacturas.Name = "LVFacturas";
			this.LVFacturas.Size = new System.Drawing.Size(753, 140);
			this.LVFacturas.TabIndex = 7;
			this.LVFacturas.UseCompatibleStateImageBehavior = false;
			this.LVFacturas.View = System.Windows.Forms.View.Details;
			// 
			// NumFactura
			// 
			this.NumFactura.Text = "Num. factura";
			this.NumFactura.Width = 250;
			// 
			// FechaFacturacion
			// 
			this.FechaFacturacion.Text = "Fecha facturacion";
			this.FechaFacturacion.Width = 200;
			// 
			// MontoFacturado
			// 
			this.MontoFacturado.Text = "Monto facturado";
			this.MontoFacturado.Width = 280;
			// 
			// TxtVendedor
			// 
			this.TxtVendedor.Location = new System.Drawing.Point(88, 8);
			this.TxtVendedor.Name = "TxtVendedor";
			this.TxtVendedor.Size = new System.Drawing.Size(400, 22);
			this.TxtVendedor.TabIndex = 1;
			// 
			// TxtNumFact
			// 
			this.TxtNumFact.Location = new System.Drawing.Point(88, 40);
			this.TxtNumFact.Name = "TxtNumFact";
			this.TxtNumFact.Size = new System.Drawing.Size(150, 22);
			this.TxtNumFact.TabIndex = 2;
			// 
			// TxtMonto
			// 
			this.TxtMonto.Location = new System.Drawing.Point(88, 72);
			this.TxtMonto.Name = "TxtMonto";
			this.TxtMonto.Size = new System.Drawing.Size(150, 22);
			this.TxtMonto.TabIndex = 4;
			// 
			// TxtFechaFact
			// 
			this.TxtFechaFact.Location = new System.Drawing.Point(388, 40);
			this.TxtFechaFact.Name = "TxtFechaFact";
			this.TxtFechaFact.Size = new System.Drawing.Size(100, 22);
			this.TxtFechaFact.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label6.Location = new System.Drawing.Point(504, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "FECHA";
			// 
			// BtnCancelar
			// 
			this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnCancelar.Image = global::pjControlFacturas.Properties.Resources.cancel;
			this.BtnCancelar.Location = new System.Drawing.Point(398, 72);
			this.BtnCancelar.Name = "BtnCancelar";
			this.BtnCancelar.Size = new System.Drawing.Size(90, 24);
			this.BtnCancelar.TabIndex = 6;
			this.BtnCancelar.Text = "CANCELAR";
			this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnCancelar.UseVisualStyleBackColor = true;
			this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnRegistrar.Image = global::pjControlFacturas.Properties.Resources.accept;
			this.BtnRegistrar.Location = new System.Drawing.Point(304, 72);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(90, 24);
			this.BtnRegistrar.TabIndex = 5;
			this.BtnRegistrar.Text = "REGISTRAR";
			this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnRegistrar.UseVisualStyleBackColor = true;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
			// 
			// FrmFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(784, 331);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TxtFechaFact);
			this.Controls.Add(this.TxtMonto);
			this.Controls.Add(this.TxtNumFact);
			this.Controls.Add(this.TxtVendedor);
			this.Controls.Add(this.BtnCancelar);
			this.Controls.Add(this.BtnRegistrar);
			this.Controls.Add(this.LVFacturas);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.LblFecha);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FrmFactura";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de Facturas de Vendedores";
			this.Load += new System.EventHandler(this.FrmFactura_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblComision;
        private System.Windows.Forms.Label LblTotalSub;
        private System.Windows.Forms.Label LblTotalFact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LVFacturas;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtVendedor;
        private System.Windows.Forms.TextBox TxtNumFact;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.TextBox TxtFechaFact;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader NumFactura;
		private System.Windows.Forms.ColumnHeader FechaFacturacion;
		private System.Windows.Forms.ColumnHeader MontoFacturado;
	}
}

