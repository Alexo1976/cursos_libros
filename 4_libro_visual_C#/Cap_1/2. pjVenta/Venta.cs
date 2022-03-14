using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVenta {
	public class Venta {
		// Atributos y métodos GET y SET
		private string _Producto;

		public string Producto {
			get { return _Producto; }
			set { _Producto = value; }
		}

		private int _Cantidad;

		public int Cantidad {
			get { return _Cantidad; }
			set { _Cantidad = value; }
		}

		// Métodos
		// Asignar precio a los productos
		public double AsignarPrecio() {
			switch (Producto) {
				case "Mouse": return 20;
				case "Teclado": return 35;
				case "Impresora": return 350;
				case "Monitor": return 550;
				case "Parlantes": return 50;
			}

			return 0;
		}

		// Calcular subtotal
		public double CalcularSubtotal() {
			return AsignarPrecio() * Cantidad;
		}

		// Calcular descuento
		public double CalcularDescuento() {
			double Subtotal = CalcularSubtotal();
			if (Subtotal <= 300) {
				return 5.0 / 100 * Subtotal;
			}
			else if (Subtotal > 300 && Subtotal <= 500) {
				return 10.0 / 100 * Subtotal;
			}
			else {
				return 12.5 / 100 * Subtotal;
			}
		}

		// Calcular neto
		public double CalcularNeto() {
			return CalcularSubtotal() - CalcularDescuento();
		}
	}
}
