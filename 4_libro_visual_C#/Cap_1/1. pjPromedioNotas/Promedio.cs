using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjPromedioNotas {
	class Promedio {
		//Atributos públicos de la clase
		public string alumno;
		public int nota1, nota2, nota3, nota4;

		//Métodos de la clase
		public int masBaja() {
			int menor = int.MaxValue;
			if (nota1 < nota2) menor = nota1; else menor = nota2;
			if (nota3 < menor) menor = nota3;
			if (nota4 < menor) menor = nota4;
			return menor;
		}

		public double calculaPromedio() {
			return (nota1 + nota2 + nota3 + nota4 - masBaja()) / 3.0;
		}

		public string asignaCondicion() {
			double promedio = calculaPromedio();
			if (promedio <= 10)
				return "Desaprobado";
			else if (promedio > 10 && promedio <= 12.5)
				return "Recuperación";
			else
				return "Aprobado";
		}
	}
}
