namespace pjVenta {
    partial class FrmVenta {
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
			this.TxtCliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LblFecha = new System.Windows.Forms.Label();
			this.LblHora = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.BtnRegistrar = new System.Windows.Forms.Button();
			this.LblPrecio = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.CboProductos = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.LVVenta = new System.Windows.Forms.ListView();
			this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Subtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Descuento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Neto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label11 = new System.Windows.Forms.Label();
			this.LblTotal = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtCliente);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(8, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 72);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del cliente";
			// 
			// TxtCliente
			// 
			this.TxtCliente.Location = new System.Drawing.Point(8, 40);
			this.TxtCliente.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.TxtCliente.Name = "TxtCliente";
			this.TxtCliente.Size = new System.Drawing.Size(400, 22);
			this.TxtCliente.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Cliente";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label3.Location = new System.Drawing.Point(440, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha";
			// 
			// LblFecha
			// 
			this.LblFecha.AutoSize = true;
			this.LblFecha.Location = new System.Drawing.Point(440, 45);
			this.LblFecha.Name = "LblFecha";
			this.LblFecha.Size = new System.Drawing.Size(63, 13);
			this.LblFecha.TabIndex = 3;
			this.LblFecha.Text = "01/01/2000";
			// 
			// LblHora
			// 
			this.LblHora.AutoSize = true;
			this.LblHora.Location = new System.Drawing.Point(512, 45);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(64, 13);
			this.LblHora.TabIndex = 5;
			this.LblHora.Text = "00:00:00 TT";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label6.Location = new System.Drawing.Point(512, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Hora";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCancelar);
			this.groupBox2.Controls.Add(this.BtnRegistrar);
			this.groupBox2.Controls.Add(this.LblPrecio);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.TxtCantidad);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.CboProductos);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(8, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(632, 72);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Datos de la venta";
			// 
			// btnCancelar
			// 
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnCancelar.Image = global::pjVenta.Properties.Resources.cancel;
			this.btnCancelar.Location = new System.Drawing.Point(544, 40);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(78, 24);
			this.btnCancelar.TabIndex = 6;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// BtnRegistrar
			// 
			this.BtnRegistrar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.BtnRegistrar.Image = global::pjVenta.Properties.Resources.accept;
			this.BtnRegistrar.Location = new System.Drawing.Point(456, 40);
			this.BtnRegistrar.Name = "BtnRegistrar";
			this.BtnRegistrar.Size = new System.Drawing.Size(78, 24);
			this.BtnRegistrar.TabIndex = 5;
			this.BtnRegistrar.Text = "Registrar";
			this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnRegistrar.UseVisualStyleBackColor = true;
			this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
			// 
			// LblPrecio
			// 
			this.LblPrecio.AutoSize = true;
			this.LblPrecio.Location = new System.Drawing.Point(384, 45);
			this.LblPrecio.Name = "LblPrecio";
			this.LblPrecio.Size = new System.Drawing.Size(34, 13);
			this.LblPrecio.TabIndex = 4;
			this.LblPrecio.Text = "$0.00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label9.Location = new System.Drawing.Point(384, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 3;
			this.label9.Text = "Precio";
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Location = new System.Drawing.Point(312, 40);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(60, 22);
			this.TxtCantidad.TabIndex = 2;
			this.TxtCantidad.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label8.Location = new System.Drawing.Point(312, 24);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Cantidad";
			// 
			// CboProductos
			// 
			this.CboProductos.FormattingEnabled = true;
			this.CboProductos.Location = new System.Drawing.Point(8, 40);
			this.CboProductos.Name = "CboProductos";
			this.CboProductos.Size = new System.Drawing.Size(300, 21);
			this.CboProductos.TabIndex = 1;
			this.CboProductos.SelectedIndexChanged += new System.EventHandler(this.CboProductos_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label7.Location = new System.Drawing.Point(8, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Producto";
			// 
			// LVVenta
			// 
			this.LVVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Subtotal,
            this.Descuento,
            this.Neto});
			this.LVVenta.HideSelection = false;
			this.LVVenta.Location = new System.Drawing.Point(8, 160);
			this.LVVenta.Name = "LVVenta";
			this.LVVenta.Size = new System.Drawing.Size(632, 180);
			this.LVVenta.TabIndex = 6;
			this.LVVenta.UseCompatibleStateImageBehavior = false;
			this.LVVenta.View = System.Windows.Forms.View.Details;
			// 
			// Producto
			// 
			this.Producto.Text = "Producto";
			this.Producto.Width = 200;
			// 
			// Cantidad
			// 
			this.Cantidad.Text = "Cantidad";
			// 
			// Precio
			// 
			this.Precio.Text = "Precio";
			this.Precio.Width = 90;
			// 
			// Subtotal
			// 
			this.Subtotal.Text = "Subtotal";
			this.Subtotal.Width = 100;
			// 
			// Descuento
			// 
			this.Descuento.Text = "Descuento";
			this.Descuento.Width = 80;
			// 
			// Neto
			// 
			this.Neto.Text = "Neto";
			this.Neto.Width = 90;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label11.Location = new System.Drawing.Point(488, 352);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 13);
			this.label11.TabIndex = 7;
			this.label11.Text = "Total neto";
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Location = new System.Drawing.Point(552, 352);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(88, 13);
			this.LblTotal.TabIndex = 7;
			this.LblTotal.Text = "$000,000,000.00";
			this.LblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// FrmVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(649, 376);
			this.Controls.Add(this.LblTotal);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.LVVenta);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.LblHora);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LblFecha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "FrmVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control de venta de productos";
			this.Load += new System.EventHandler(this.FrmVenta_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CboProductos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView LVVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader Precio;
        private System.Windows.Forms.ColumnHeader Subtotal;
        private System.Windows.Forms.ColumnHeader Descuento;
        private System.Windows.Forms.ColumnHeader Neto;
    }
}

