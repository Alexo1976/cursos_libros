using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjControlFacturas {
	class Factura {
		// Declaración de atributos privados
		private int _NumFactura;
		private DateTime _FechaFact;
		private double _MontoFact;

		static private double Acumulado;
		static private int n;

		// Método constructor con parámetros
		public Factura(int NumFactura, DateTime FechaFact, double MontoFact) {
			this._NumFactura = NumFactura;
			this._FechaFact = FechaFact;
			this._MontoFact = MontoFact;
			Acumulado += MontoFact;
			n++;
		}

		// Métodos GET
		public int NumFactura {
			get { return _NumFactura; }
		}

		public DateTime FechaFact {
			get { return _FechaFact; }
		}

		public double MontoFact {
			get { return _MontoFact; }
		}

		public int TotalFacturas() {
			return n;
		}

		public double CalcularTotalSubTotal() {
			return Acumulado;
		}

		public double CalcularComision() {
			return 0.12 * CalcularTotalSubTotal();
		}
	}
}
