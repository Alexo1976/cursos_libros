using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjSueldoEmpleado {
	public partial class FrmSueldo : Form {
		public FrmSueldo() {
			InitializeComponent();
		}

		private void BtnRegistrar_Click(object sender, EventArgs e) {
			// Capturar los valores del formulario
			string Nombre = TxtEmpleado.Text;
			string Categoria = CboCategoria.Text;
			int Horas = Convert.ToInt32(TxtHoras.Text);

			// Capturar datos obtenido desde la clase
			double Costo = Empleado.AsignarCostoHora(Categoria);
			double Bruto = Empleado.CarcularBruto(Horas, Costo);
			double Descuento = Empleado.CalcularDescuento(Bruto);
			double Neto = Empleado.CalcularNeto(Bruto, Descuento);

			// Mostrar los resultados
			ListViewItem Fila = new ListViewItem(Nombre);
			Fila.SubItems.Add(Categoria);
			Fila.SubItems.Add(Horas.ToString());
			Fila.SubItems.Add(Costo.ToString("C"));
			Fila.SubItems.Add(Bruto.ToString("C"));
			Fila.SubItems.Add(Descuento.ToString("C"));
			Fila.SubItems.Add(Neto.ToString("C"));
			LVPago.Items.Add(Fila);
		}

		private void BtnSalir_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void BtnLimpiar_Click(object sender, EventArgs e) {
			TxtEmpleado.Focus();
			TxtEmpleado.Text = string.Empty;
			TxtHoras.Text = string.Empty;
			LVPago.Items.Clear();
		}
	}
}
