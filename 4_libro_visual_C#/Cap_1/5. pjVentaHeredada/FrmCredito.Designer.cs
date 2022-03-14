namespace pjVentaHeredada {
    partial class FrmCredito {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtRUC = new System.Windows.Forms.TextBox();
			this.TxtCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.CboProductos = new System.Windows.Forms.ComboBox();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LblFecha = new System.Windows.Forms.Label();
			this.LblHora = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.LVDetalle = new System.Windows.Forms.ListView();
			this.label11 = new System.Windows.Forms.Label();
			this.LblMonto = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.CboLetras = new System.Windows.Forms.ComboBox();
			this.LVResumen = new System.Windows.Forms.ListView();
			this.label13 = new System.Windows.Forms.Label();
			this.NumLetra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Monto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BtnMostrar = new System.Windows.Forms.Button();
			this.BtnAdquirir = new System.Windows.Forms.Button();
			this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DescripcionProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtRUC);
			this.groupBox1.Controls.Add(this.TxtCliente);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(552, 72);
			this.groupBox1.TabIndex = 101;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DATOS DEL CLIENTE";
			// 
			// TxtRUC
			// 
			this.TxtRUC.Location = new System.Drawing.Point(368, 40);
			this.TxtRUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtRUC.Name = "TxtRUC";
			this.TxtRUC.Size = new System.Drawing.Size(172, 22);
			this.TxtRUC.TabIndex = 2;
			// 
			// TxtCliente
			// 
			this.TxtCliente.Location = new System.Drawing.Point(8, 40);
			this.TxtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtCliente.Name = "TxtCliente";
			this.TxtCliente.Size = new System.Drawing.Size(350, 22);
			this.TxtCliente.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(368, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "RUC";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(137, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "CLIENTE O RAZÓN SOCIAL";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.BtnAdquirir);
			this.groupBox2.Controls.Add(this.CboProductos);
			this.groupBox2.Controls.Add(this.TxtCantidad);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox2.Location = new System.Drawing.Point(8, 88);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(700, 72);
			this.groupBox2.TabIndex = 102;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS DE LA VENTA";
			// 
			// CboProductos
			// 
			this.CboProductos.FormattingEnabled = true;
			this.CboProductos.Location = new System.Drawing.Point(8, 40);
			this.CboProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CboProductos.Name = "CboProductos";
			this.CboProductos.Size = new System.Drawing.Size(350, 21);
			this.CboProductos.TabIndex = 3;
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Location = new System.Drawing.Point(368, 40);
			this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(86, 22);
			this.TxtCantidad.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(368, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "CANT. SOLICITADA";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(149, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "SELECCIONE UN PRODUCTO";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(568, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "FECHA";
			// 
			// LblFecha
			// 
			this.LblFecha.AutoSize = true;
			this.LblFecha.Location = new System.Drawing.Point(568, 51);
			this.LblFecha.Name = "LblFecha";
			this.LblFecha.Size = new System.Drawing.Size(63, 13);
			this.LblFecha.TabIndex = 0;
			this.LblFecha.Text = "02/12/2015";
			// 
			// LblHora
			// 
			this.LblHora.AutoSize = true;
			this.LblHora.Location = new System.Drawing.Point(632, 51);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(58, 13);
			this.LblHora.TabIndex = 0;
			this.LblHora.Text = "10:15 a.m.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(632, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "HORA";
			// 
			// LVDetalle
			// 
			this.LVDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.DescripcionProducto,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
			this.LVDetalle.HideSelection = false;
			this.LVDetalle.Location = new System.Drawing.Point(8, 168);
			this.LVDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LVDetalle.Name = "LVDetalle";
			this.LVDetalle.Size = new System.Drawing.Size(700, 150);
			this.LVDetalle.TabIndex = 6;
			this.LVDetalle.UseCompatibleStateImageBehavior = false;
			this.LVDetalle.View = System.Windows.Forms.View.Details;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label11.Location = new System.Drawing.Point(568, 336);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(103, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "MONTO A PAGAR $";
			// 
			// LblMonto
			// 
			this.LblMonto.AutoSize = true;
			this.LblMonto.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.LblMonto.Location = new System.Drawing.Point(568, 352);
			this.LblMonto.Name = "LblMonto";
			this.LblMonto.Size = new System.Drawing.Size(13, 13);
			this.LblMonto.TabIndex = 0;
			this.LblMonto.Text = "0";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.BtnMostrar);
			this.groupBox3.Controls.Add(this.CboLetras);
			this.groupBox3.Controls.Add(this.LVResumen);
			this.groupBox3.Controls.Add(this.label13);
			this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox3.Location = new System.Drawing.Point(8, 328);
			this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox3.Size = new System.Drawing.Size(495, 128);
			this.groupBox3.TabIndex = 103;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "OPCIONES DEL CRÉDITO";
			// 
			// CboLetras
			// 
			this.CboLetras.FormattingEnabled = true;
			this.CboLetras.Location = new System.Drawing.Point(8, 40);
			this.CboLetras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CboLetras.Name = "CboLetras";
			this.CboLetras.Size = new System.Drawing.Size(80, 21);
			this.CboLetras.TabIndex = 7;
			// 
			// LVResumen
			// 
			this.LVResumen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumLetra,
            this.Monto});
			this.LVResumen.HideSelection = false;
			this.LVResumen.Location = new System.Drawing.Point(248, 16);
			this.LVResumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LVResumen.Name = "LVResumen";
			this.LVResumen.Size = new System.Drawing.Size(241, 100);
			this.LVResumen.TabIndex = 9;
			this.LVResumen.UseCompatibleStateImageBehavior = false;
			this.LVResumen.View = System.Windows.Forms.View.Details;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(152, 13);
			this.label13.TabIndex = 0;
			this.label13.Text = "Seleccione Letras de Cambio";
			// 
			// NumLetra
			// 
			this.NumLetra.Text = "No Letra";
			this.NumLetra.Width = 80;
			// 
			// Monto
			// 
			this.Monto.Text = "Monto";
			this.Monto.Width = 150;
			// 
			// BtnMostrar
			// 
			this.BtnMostrar.Image = global::pjVentaHeredada.Properties.Resources.calculator;
			this.BtnMostrar.Location = new System.Drawing.Point(8, 64);
			this.BtnMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnMostrar.Name = "BtnMostrar";
			this.BtnMostrar.Size = new System.Drawing.Size(140, 24);
			this.BtnMostrar.TabIndex = 8;
			this.BtnMostrar.Text = "MOSTRAR RESUMEN";
			this.BtnMostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnMostrar.UseVisualStyleBackColor = true;
			this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
			// 
			// BtnAdquirir
			// 
			this.BtnAdquirir.Image = global::pjVentaHeredada.Properties.Resources.accept;
			this.BtnAdquirir.Location = new System.Drawing.Point(464, 38);
			this.BtnAdquirir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnAdquirir.Name = "BtnAdquirir";
			this.BtnAdquirir.Size = new System.Drawing.Size(84, 24);
			this.BtnAdquirir.TabIndex = 5;
			this.BtnAdquirir.Text = "ADQUIRIR";
			this.BtnAdquirir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnAdquirir.UseVisualStyleBackColor = true;
			this.BtnAdquirir.Click += new System.EventHandler(this.BtnAdquirir_Click);
			// 
			// Item
			// 
			this.Item.Text = "Item";
			// 
			// DescripcionProducto
			// 
			this.DescripcionProducto.Text = "Descripcion del producto";
			this.DescripcionProducto.Width = 250;
			// 
			// Cantidad
			// 
			this.Cantidad.Text = "Cantidad";
			this.Cantidad.Width = 80;
			// 
			// Precio
			// 
			this.Precio.Text = "Precio";
			this.Precio.Width = 150;
			// 
			// SubTotal
			// 
			this.SubTotal.Text = "SubTotal";
			this.SubTotal.Width = 150;
			// 
			// FrmCredito
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 471);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.LblMonto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.LVDetalle);
			this.Controls.Add(this.LblHora);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.LblFecha);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmCredito";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venta de productos al crédito";
			this.Load += new System.EventHandler(this.FrmCredito_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CboProductos;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdquirir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView LVDetalle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CboLetras;
        private System.Windows.Forms.ListView LVResumen;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnMostrar;
		private System.Windows.Forms.ColumnHeader NumLetra;
		private System.Windows.Forms.ColumnHeader Monto;
		private System.Windows.Forms.ColumnHeader Item;
		private System.Windows.Forms.ColumnHeader DescripcionProducto;
		private System.Windows.Forms.ColumnHeader Cantidad;
		private System.Windows.Forms.ColumnHeader Precio;
		private System.Windows.Forms.ColumnHeader SubTotal;
	}
}

