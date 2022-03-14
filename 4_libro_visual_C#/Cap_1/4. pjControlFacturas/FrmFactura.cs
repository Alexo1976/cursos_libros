using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjControlFacturas {
	public partial class FrmFactura : Form {
		public FrmFactura() {
			InitializeComponent();
		}

		private void FrmFactura_Load(object sender, EventArgs e) {
			LblFecha.Text = MostrarFecha();
		}

		private void BtnRegistrar_Click(object sender, EventArgs e) {
			// Capturar los valores del formulario
			int NumFactura = int.Parse(TxtNumFact.Text);
			DateTime FechaFact = DateTime.Parse(TxtFechaFact.Text);
			double MontoFact = double.Parse(TxtMonto.Text);

			// Objeto de clase Factura
			Factura ObjF = new Factura(NumFactura, FechaFact, MontoFact);

			// Imprimir en la lista
			ListViewItem Fila = new ListViewItem(ObjF.NumFactura.ToString());
			Fila.SubItems.Add(ObjF.FechaFact.ToShortDateString());
			Fila.SubItems.Add(ObjF.MontoFact.ToString("C"));
			LVFacturas.Items.Add(Fila);

			// Mostrar los montos
			LblTotalFact.Text = ObjF.TotalFacturas().ToString();
			LblTotalSub.Text = ObjF.CalcularTotalSubTotal().ToString("C");
			LblComision.Text = ObjF.CalcularComision().ToString("C");
		}

		private void BtnCancelar_Click(object sender, EventArgs e) {
			TxtVendedor.Focus();
			TxtVendedor.Text = string.Empty;
			TxtNumFact.Text = string.Empty;
			TxtFechaFact.Text = string.Empty;
			TxtMonto.Text = string.Empty;
			LVFacturas.Items.Clear();
			LblTotalFact.Text = "0";
			LblTotalSub.Text = "0";
			LblComision.Text = "0";
		}

		// Funcion lambda que muestra la fecha actual
		Func<string> MostrarFecha = () => DateTime.Now.ToShortDateString();
	}
}
