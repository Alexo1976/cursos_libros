using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjVentaHeredada {
	public partial class FrmCredito : Form {
		// Inicializar arreglo con cantidad de letras
		static int[] Letras = { 3, 6, 9, 12 };

		// Inicializar arreglo de productos
		static string[] Productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

		// Crear el objeto de la clase ArrayList para productos y letras
		ArrayList AProductos = new ArrayList(Productos);
		ArrayList ALetras = new ArrayList(Letras);

		double TSubTotal = 0;

		public FrmCredito() {
			InitializeComponent();
		}

		private void FrmCredito_Load(object sender, EventArgs e) {
			CboLetras.DataSource = ALetras;
			CboProductos.DataSource = AProductos;
			MostrarFecha();
			MostrarHora();
		}

		private void MostrarFecha() {
			LblFecha.Text = DateTime.Now.ToShortDateString();
		}

		private void MostrarHora() {
			LblHora.Text = DateTime.Now.ToShortTimeString();
		}

		private void BtnAdquirir_Click(object sender, EventArgs e) {
			// Objeto de la clase crédito
			Credito ObjCr = new Credito();

			// Datos del cliente
			ObjCr.Cliente = TxtCliente.Text;
			ObjCr.RUC = TxtRUC.Text;
			ObjCr.Fecha = DateTime.Parse(LblFecha.Text);
			ObjCr.Hora = DateTime.Parse(LblHora.Text);

			// Datos del producto
			ObjCr.Producto = CboProductos.Text;
			ObjCr.Cantidad = int.Parse(TxtCantidad.Text);

			// Imprimir en la lista
			ListViewItem Fila = new ListViewItem(ObjCr.GetX().ToString());
			Fila.SubItems.Add(ObjCr.Producto);
			Fila.SubItems.Add(ObjCr.Cantidad.ToString());
			Fila.SubItems.Add(ObjCr.AsignarPrecio().ToString("C"));
			Fila.SubItems.Add(ObjCr.CalcularSubtotal().ToString("C"));
			LVDetalle.Items.Add(Fila);

			TSubTotal += ObjCr.CalcularSubtotal();
			LblMonto.Text = TSubTotal.ToString("0.00");
		}

		private void MontoLetras(int Letras) {
			double MontoMensual = double.Parse(LblMonto.Text) / Letras;

			LVResumen.Items.Clear();

			for (int i = 1; i <= Letras; i++) {
				ListViewItem Fila = new ListViewItem(i.ToString());
				Fila.SubItems.Add(MontoMensual.ToString("C"));
				LVResumen.Items.Add(Fila);
			}
		}

		private void BtnMostrar_Click(object sender, EventArgs e) {
			int Letras = int.Parse(CboLetras.Text);
			switch (Letras) {
				case 3: MontoLetras(3); break;
				case 6: MontoLetras(6); break;
				case 9: MontoLetras(9); break;
				case 12: MontoLetras(12); break;
			}
		}
	}
}
