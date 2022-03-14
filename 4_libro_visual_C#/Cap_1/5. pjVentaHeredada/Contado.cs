using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaHeredada {
	class Contado : Venta {
		public static int N;

		public Contado() {
			N++;
		}

		public int GetN() {
			return N;
		}

		// Métodos de la clase contado
		public double CalcularDescuento(double SubTotal) {
			if (SubTotal < 1000) {
				return 2.0 / 100 * SubTotal;
			}
			else if (SubTotal >= 100 && SubTotal <= 3000) {
				return 5.0 / 100 * SubTotal;
			}
			else {
				return 12.0 / 100 * SubTotal;
			}
		}

		public double CalcularNeto(double SubTotal, double Descuento) {
			return SubTotal - Descuento;
		}
	}
}
