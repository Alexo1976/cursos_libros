using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjVentaHeredada {
	class Credito : Venta {
		public static int X;

		public Credito() {
			X++;
		}

		public int GetX() {
			return X;
		}

		// Atributos de la clase crédito
		public int Letras { get; set; }

		// Métodos de la clase crédito
		public double CalcularMontoIntereses() {
			switch (Letras) {
				case 3: return 5.0 / 100 * CalcularSubtotal();
				case 6: return 10.0 / 1000 * CalcularSubtotal();
				case 9: return 15.0 / 100 * CalcularSubtotal();
				case 12: return 25.0 / 100 * CalcularSubtotal();
			}
			return 0;
		}

		public double CalcularMontoMensual() {
			return (CalcularSubtotal() + CalcularMontoIntereses()) / Letras;
		}
	}
}
