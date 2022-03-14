using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjSueldoEmpleado {
	public class Empleado {
		// Constructor privado
		private Empleado() { }

		// Determinar el monto por hora según la categoría
		public static double AsignarCostoHora(string Categoria) {
			switch (Categoria) {
				case "CAS": return 15;
				case "CAP": return 25;
			}
			return 0;
		}

		// Determinar el monto bruto
		public static double CarcularBruto(int Horas, double Costo) {
			return Costo * Horas;
		}

		// Determinar el descuento
		public static double CalcularDescuento(double Bruto) {
			return 0.12 * Bruto;
		}

		// Carcular el monto neto
		public static double CalcularNeto(double Bruto, double Descuento) {
			return Bruto - Descuento;
		}
	}
}
