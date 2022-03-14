namespace pjVentaHeredada {
    partial class FrmContado {
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
			this.BtnAdquirir = new System.Windows.Forms.Button();
			this.CboProducto = new System.Windows.Forms.ComboBox();
			this.TxtCantidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.LblFecha = new System.Windows.Forms.Label();
			this.LblHora = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.LVDetalle = new System.Windows.Forms.ListView();
			this.ITEM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.DESCRIPCION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CANTIDAD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PRECIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SUBTOTAL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label10 = new System.Windows.Forms.Label();
			this.LstResumen = new System.Windows.Forms.ListView();
			this.label11 = new System.Windows.Forms.Label();
			this.LblNeto = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
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
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DATOS DEL CLIENTE";
			// 
			// TxtRUC
			// 
			this.TxtRUC.Location = new System.Drawing.Point(368, 40);
			this.TxtRUC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtRUC.Name = "TxtRUC";
			this.TxtRUC.Size = new System.Drawing.Size(172, 22);
			this.TxtRUC.TabIndex = 3;
			// 
			// TxtCliente
			// 
			this.TxtCliente.Location = new System.Drawing.Point(8, 40);
			this.TxtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtCliente.Name = "TxtCliente";
			this.TxtCliente.Size = new System.Drawing.Size(350, 22);
			this.TxtCliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(368, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 1;
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
			this.groupBox2.Controls.Add(this.CboProducto);
			this.groupBox2.Controls.Add(this.TxtCantidad);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.groupBox2.Location = new System.Drawing.Point(8, 88);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(700, 72);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "DATOS DE LA VENTA";
			// 
			// BtnAdquirir
			// 
			this.BtnAdquirir.Image = global::pjVentaHeredada.Properties.Resources.accept;
			this.BtnAdquirir.Location = new System.Drawing.Point(464, 38);
			this.BtnAdquirir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.BtnAdquirir.Name = "BtnAdquirir";
			this.BtnAdquirir.Size = new System.Drawing.Size(86, 24);
			this.BtnAdquirir.TabIndex = 5;
			this.BtnAdquirir.Text = "ADQUIRIR";
			this.BtnAdquirir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BtnAdquirir.UseVisualStyleBackColor = true;
			this.BtnAdquirir.Click += new System.EventHandler(this.BtnAdquirir_Click);
			// 
			// CboProducto
			// 
			this.CboProducto.FormattingEnabled = true;
			this.CboProducto.Location = new System.Drawing.Point(8, 40);
			this.CboProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CboProducto.Name = "CboProducto";
			this.CboProducto.Size = new System.Drawing.Size(352, 21);
			this.CboProducto.TabIndex = 4;
			// 
			// TxtCantidad
			// 
			this.TxtCantidad.Location = new System.Drawing.Point(368, 40);
			this.TxtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.TxtCantidad.Name = "TxtCantidad";
			this.TxtCantidad.Size = new System.Drawing.Size(86, 22);
			this.TxtCantidad.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(368, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 13);
			this.label4.TabIndex = 1;
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
			this.label6.TabIndex = 6;
			this.label6.Text = "FECHA";
			// 
			// LblFecha
			// 
			this.LblFecha.AutoSize = true;
			this.LblFecha.Location = new System.Drawing.Point(568, 48);
			this.LblFecha.Name = "LblFecha";
			this.LblFecha.Size = new System.Drawing.Size(63, 13);
			this.LblFecha.TabIndex = 7;
			this.LblFecha.Text = "02/12/2015";
			// 
			// LblHora
			// 
			this.LblHora.AutoSize = true;
			this.LblHora.Location = new System.Drawing.Point(632, 48);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(58, 13);
			this.LblHora.TabIndex = 9;
			this.LblHora.Text = "10:15 a.m.";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(632, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "HORA";
			// 
			// LVDetalle
			// 
			this.LVDetalle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ITEM,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.PRECIO,
            this.SUBTOTAL});
			this.LVDetalle.HideSelection = false;
			this.LVDetalle.Location = new System.Drawing.Point(8, 168);
			this.LVDetalle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LVDetalle.Name = "LVDetalle";
			this.LVDetalle.Size = new System.Drawing.Size(700, 100);
			this.LVDetalle.TabIndex = 10;
			this.LVDetalle.UseCompatibleStateImageBehavior = false;
			this.LVDetalle.View = System.Windows.Forms.View.Details;
			// 
			// ITEM
			// 
			this.ITEM.Text = "ITEM";
			// 
			// DESCRIPCION
			// 
			this.DESCRIPCION.Text = "DESCRIPCIÓN DEL PRODUCTO";
			this.DESCRIPCION.Width = 250;
			// 
			// CANTIDAD
			// 
			this.CANTIDAD.Text = "CANTIDAD";
			this.CANTIDAD.Width = 80;
			// 
			// PRECIO
			// 
			this.PRECIO.Text = "PRECIO";
			this.PRECIO.Width = 150;
			// 
			// SUBTOTAL
			// 
			this.SUBTOTAL.Text = "SUBTOTAL";
			this.SUBTOTAL.Width = 150;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label10.Location = new System.Drawing.Point(8, 280);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "RESUMEN";
			// 
			// LstResumen
			// 
			this.LstResumen.HideSelection = false;
			this.LstResumen.Location = new System.Drawing.Point(8, 296);
			this.LstResumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.LstResumen.Name = "LstResumen";
			this.LstResumen.Size = new System.Drawing.Size(429, 165);
			this.LstResumen.TabIndex = 12;
			this.LstResumen.UseCompatibleStateImageBehavior = false;
			this.LstResumen.View = System.Windows.Forms.View.List;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.label11.Location = new System.Drawing.Point(536, 296);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(82, 13);
			this.label11.TabIndex = 13;
			this.label11.Text = "NETO A PAGAR";
			// 
			// LblNeto
			// 
			this.LblNeto.AutoSize = true;
			this.LblNeto.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.LblNeto.Location = new System.Drawing.Point(536, 312);
			this.LblNeto.Name = "LblNeto";
			this.LblNeto.Size = new System.Drawing.Size(13, 13);
			this.LblNeto.TabIndex = 14;
			this.LblNeto.Text = "0";
			// 
			// FrmContado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(714, 468);
			this.Controls.Add(this.LblNeto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.LstResumen);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.LVDetalle);
			this.Controls.Add(this.LblHora);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.LblFecha);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Name = "FrmContado";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venta de productos al contado";
			this.Load += new System.EventHandler(this.FrmContado_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.ComboBox CboProducto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnAdquirir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView LVDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView LstResumen;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblNeto;
        private System.Windows.Forms.ColumnHeader ITEM;
        private System.Windows.Forms.ColumnHeader DESCRIPCION;
        private System.Windows.Forms.ColumnHeader CANTIDAD;
        private System.Windows.Forms.ColumnHeader PRECIO;
        private System.Windows.Forms.ColumnHeader SUBTOTAL;
    }
}

