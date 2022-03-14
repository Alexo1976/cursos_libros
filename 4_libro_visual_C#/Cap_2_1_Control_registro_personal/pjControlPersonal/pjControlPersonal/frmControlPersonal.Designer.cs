
namespace pjControlPersonal {
	partial class frmControlPersonal {
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Paterno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Materno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Nombres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FechaNac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FechaCont = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPaterno = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.txtMaterno = new System.Windows.Forms.TextBox();
			this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
			this.dtpFechaContrato = new System.Windows.Forms.DateTimePicker();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Paterno,
            this.Materno,
            this.Nombres,
            this.FechaNac,
            this.FechaCont});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(8, 160);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(700, 150);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Codigo
			// 
			this.Codigo.Text = "Codigo";
			// 
			// Paterno
			// 
			this.Paterno.Text = "Paterno";
			this.Paterno.Width = 125;
			// 
			// Materno
			// 
			this.Materno.Text = "Materno";
			this.Materno.Width = 125;
			// 
			// Nombres
			// 
			this.Nombres.Text = "Nombres";
			this.Nombres.Width = 175;
			// 
			// FechaNac
			// 
			this.FechaNac.Text = "Fecha nac.";
			this.FechaNac.Width = 100;
			// 
			// FechaCont
			// 
			this.FechaCont.Text = "Fecha cont.";
			this.FechaCont.Width = 100;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Codigo";
			// 
			// lblCodigo
			// 
			this.lblCodigo.AutoSize = true;
			this.lblCodigo.Location = new System.Drawing.Point(56, 8);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(50, 13);
			this.lblCodigo.TabIndex = 7;
			this.lblCodigo.Text = "lblCodigo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Paterno";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(176, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Materno";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(344, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Nombres";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 80);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Fecha de nacimiento";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(176, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Fecha de contrato";
			// 
			// txtPaterno
			// 
			this.txtPaterno.Location = new System.Drawing.Point(8, 48);
			this.txtPaterno.Name = "txtPaterno";
			this.txtPaterno.Size = new System.Drawing.Size(150, 20);
			this.txtPaterno.TabIndex = 13;
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(344, 48);
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(250, 20);
			this.txtNombres.TabIndex = 16;
			// 
			// txtMaterno
			// 
			this.txtMaterno.Location = new System.Drawing.Point(176, 48);
			this.txtMaterno.Name = "txtMaterno";
			this.txtMaterno.Size = new System.Drawing.Size(150, 20);
			this.txtMaterno.TabIndex = 17;
			// 
			// dtpFechaNacimiento
			// 
			this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaNacimiento.Location = new System.Drawing.Point(8, 96);
			this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
			this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaNacimiento.TabIndex = 18;
			// 
			// dtpFechaContrato
			// 
			this.dtpFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaContrato.Location = new System.Drawing.Point(176, 96);
			this.dtpFechaContrato.Name = "dtpFechaContrato";
			this.dtpFechaContrato.Size = new System.Drawing.Size(100, 20);
			this.dtpFechaContrato.TabIndex = 19;
			// 
			// btnSalir
			// 
			this.btnSalir.Image = global::pjControlPersonal.Properties.Resources.Turn_off;
			this.btnSalir.Location = new System.Drawing.Point(632, 128);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 23);
			this.btnSalir.TabIndex = 4;
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = global::pjControlPersonal.Properties.Resources.Delete_16x16;
			this.btnEliminar.Location = new System.Drawing.Point(264, 128);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnModificar
			// 
			this.btnModificar.Image = global::pjControlPersonal.Properties.Resources.documents_edit;
			this.btnModificar.Location = new System.Drawing.Point(176, 128);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnModificar.UseVisualStyleBackColor = true;
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Image = global::pjControlPersonal.Properties.Resources.Save_16x16;
			this.btnRegistrar.Location = new System.Drawing.Point(88, 128);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
			this.btnRegistrar.TabIndex = 1;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRegistrar.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = global::pjControlPersonal.Properties.Resources.add;
			this.btnNuevo.Location = new System.Drawing.Point(8, 128);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(70, 23);
			this.btnNuevo.TabIndex = 0;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNuevo.UseVisualStyleBackColor = true;
			// 
			// frmControlPersonal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(724, 321);
			this.Controls.Add(this.dtpFechaContrato);
			this.Controls.Add(this.dtpFechaNacimiento);
			this.Controls.Add(this.txtMaterno);
			this.Controls.Add(this.txtNombres);
			this.Controls.Add(this.txtPaterno);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.btnNuevo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmControlPersonal";
			this.Text = "Control de registro de personal - ArrayList";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Codigo;
		private System.Windows.Forms.ColumnHeader Paterno;
		private System.Windows.Forms.ColumnHeader Materno;
		private System.Windows.Forms.ColumnHeader Nombres;
		private System.Windows.Forms.ColumnHeader FechaNac;
		private System.Windows.Forms.ColumnHeader FechaCont;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPaterno;
		private System.Windows.Forms.TextBox txtNombres;
		private System.Windows.Forms.TextBox txtMaterno;
		private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
		private System.Windows.Forms.DateTimePicker dtpFechaContrato;
	}
}

