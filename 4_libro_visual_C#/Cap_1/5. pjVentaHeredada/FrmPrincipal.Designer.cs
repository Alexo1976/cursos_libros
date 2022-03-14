
namespace pjVentaHeredada {
	partial class FrmPrincipal {
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
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.btnContado = new System.Windows.Forms.Button();
			this.btnCredito = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(38, 40);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(81, 13);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Venta al credito";
			this.linkLabel1.Click += new System.EventHandler(this.BtnCredito_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(158, 40);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(88, 13);
			this.linkLabel2.TabIndex = 2;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Venta al contado";
			this.linkLabel2.Click += new System.EventHandler(this.BtnContado_Click);
			// 
			// btnContado
			// 
			this.btnContado.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnContado.Image = global::pjVentaHeredada.Properties.Resources.coins;
			this.btnContado.Location = new System.Drawing.Point(142, 8);
			this.btnContado.Name = "btnContado";
			this.btnContado.Size = new System.Drawing.Size(120, 23);
			this.btnContado.TabIndex = 4;
			this.btnContado.Text = "Venta al contado";
			this.btnContado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnContado.UseVisualStyleBackColor = true;
			this.btnContado.Click += new System.EventHandler(this.BtnContado_Click);
			// 
			// btnCredito
			// 
			this.btnCredito.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
			this.btnCredito.Image = global::pjVentaHeredada.Properties.Resources.data;
			this.btnCredito.Location = new System.Drawing.Point(22, 8);
			this.btnCredito.Name = "btnCredito";
			this.btnCredito.Size = new System.Drawing.Size(110, 24);
			this.btnCredito.TabIndex = 3;
			this.btnCredito.Text = "Venta al credito";
			this.btnCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCredito.UseVisualStyleBackColor = true;
			this.btnCredito.Click += new System.EventHandler(this.BtnCredito_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 66);
			this.Controls.Add(this.btnContado);
			this.Controls.Add(this.btnCredito);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Venta de productos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Button btnCredito;
		private System.Windows.Forms.Button btnContado;
	}
}