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
	public partial class FrmContado : Form {
		// Inicializar arreglo de productos
		static string[] Productos = { "Lavadora", "Refrigeradora", "Licuadora", "Extractora", "Radiograbadora", "DVD", "BluRay" };

		// Crear el objeto de la clase ArrayList
		ArrayList AProductos = new ArrayList(Productos);

		// Variable acumuladora de totales
		double TSubTotal = 0;

		public FrmContado() {
			InitializeComponent();
		}

		private void BtnAdquirir_Click(object sender, EventArgs e) {
			// Objeto de la clase contado
			Contado ObjC = new Contado();

			// Datos del cliente
			ObjC.Cliente = TxtCliente.Text;
			ObjC.RUC = TxtRUC.Text;
			ObjC.Fecha = DateTime.Parse(LblFecha.Text);
			ObjC.Hora = DateTime.Parse(LblHora.Text);

			// Datos del producto
			ObjC.Producto = CboProducto.Text;
			ObjC.Cantidad = int.Parse(TxtCantidad.Text);

			// Imprimir en la lista
			ListViewItem Fila = new ListViewItem(ObjC.GetN().ToString());
			Fila.SubItems.Add(ObjC.Producto);
			Fila.SubItems.Add(ObjC.Cantidad.ToString());
			Fila.SubItems.Add(ObjC.AsignarPrecio().ToString("C"));
			Fila.SubItems.Add(ObjC.CalcularSubtotal().ToString("C"));
			LVDetalle.Items.Add(Fila);

			Listado(ObjC);
		}

		private void FrmContado_Load(object sender, EventArgs e) {
			CboProducto.DataSource = AProductos;
			MostrarFecha();
			MostrarHora();
		}

		private void MostrarFecha() {
			LblFecha.Text = DateTime.Now.ToShortDateString();
		}

		private void MostrarHora() {
			LblHora.Text = DateTime.Now.ToShortTimeString();
		}

		private void Listado(Contado ObjC) {
			TSubTotal += ObjC.CalcularSubtotal();

			LstResumen.Items.Clear();
			LstResumen.Items.Add("** RESUMEN DE VENTA **");
			LstResumen.Items.Add("----------");
			LstResumen.Items.Add("CLIENTE: " + ObjC.Cliente);
			LstResumen.Items.Add("RUC: " + ObjC.RUC);
			LstResumen.Items.Add("FECHA: " + ObjC.Fecha);
			LstResumen.Items.Add("HORA: " + ObjC.Hora);
			LstResumen.Items.Add("----------");
			LstResumen.Items.Add("SUBTOTAL: " + TSubTotal.ToString("C"));

			double Descuento = ObjC.CalcularDescuento(TSubTotal);
			double Neto = ObjC.CalcularNeto(TSubTotal, Descuento);

			LstResumen.Items.Add("DESCUENTO: " + Descuento.ToString("C"));
			LstResumen.Items.Add("NETO: " + Neto.ToString("C"));

			// Mostrar el monto total sin descuento
			LblNeto.Text = Neto.ToString("C");
		}
	}
}
