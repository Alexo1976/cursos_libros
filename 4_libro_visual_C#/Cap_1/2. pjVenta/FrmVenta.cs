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

namespace pjVenta {
	public partial class FrmVenta : Form {
		// Inicialización del arreglo de productos
		static string[] Productos = { "Teclado", "Impresora", "Monitor", "Mouse", "Parlantes" };

		// Crear objeto de la clase ArrayList
		ArrayList ListaProductos = new ArrayList(Productos);

		// Objeto de la clase Venta
		Venta ObjVenta = new Venta();

		// Acumulador de totales
		double Total;

		public FrmVenta() {
			InitializeComponent();
		}

		#region Eventos
		private void FrmVenta_Load(object sender, EventArgs e) {
			LimpiarControles();
			LlenarProductos();
			MostrarFecha();
			MostrarHora();

			LblTotal.Text = 0.ToString("C");
		}

		private void CboProductos_SelectedIndexChanged(object sender, EventArgs e) {
			ObjVenta.Producto = CboProductos.Text;
			LblPrecio.Text = ObjVenta.AsignarPrecio().ToString("C");
		}

		private void BtnRegistrar_Click(object sender, EventArgs e) {
			// Enviar los valores a la clase
			ObjVenta.Producto = CboProductos.Text;
			ObjVenta.Cantidad = Convert.ToInt32(TxtCantidad.Text);

			// Imprimir las respuestas
			ListViewItem Fila = new ListViewItem(ObjVenta.Producto);
			Fila.SubItems.Add(ObjVenta.Cantidad.ToString());
			Fila.SubItems.Add(ObjVenta.AsignarPrecio().ToString("C"));
			Fila.SubItems.Add(ObjVenta.CalcularSubtotal().ToString("C"));
			Fila.SubItems.Add(ObjVenta.CalcularDescuento().ToString("C"));
			Fila.SubItems.Add(ObjVenta.CalcularNeto().ToString("C"));
			LVVenta.Items.Add(Fila);

			// Calcular el total de netos
			Total += ObjVenta.CalcularNeto();
			LblTotal.Text = Total.ToString("C");
		}
		
		private void btnCancelar_Click(object sender, EventArgs e) {
			LimpiarControles();
			LVVenta.Items.Clear();
			LblTotal.Text = 0.ToString("C");
		}
		#endregion

		// Llenar los productos en el cuadro combinado [Select/DropDown]
		void LlenarProductos() {
			foreach (string Producto in ListaProductos) {
				CboProductos.Items.Add(Producto);
			}
		}

		// Método que muestra la fecha actual
		void MostrarFecha() {
			LblFecha.Text = DateTime.Now.ToShortDateString();
		}

		// Método que muestra la hora actual
		void MostrarHora() {
			LblHora.Text = DateTime.Now.ToShortTimeString();
		}

		// Método que limpia los controles del formulario
		void LimpiarControles() {
			TxtCliente.Clear();
			CboProductos.Text = "Seleccione un producto";
			TxtCantidad.Text = "1";
			LblPrecio.Text = string.Empty;
			TxtCliente.Focus();
		}
	}
}
