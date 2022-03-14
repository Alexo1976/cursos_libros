using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjPolimorfismo {
	public partial class frmEvaluacion : Form {
		public frmEvaluacion() {
			InitializeComponent();
		}

		private void btnRegistrar_Click(object sender, EventArgs e) {
			// Objeto de la clase PromedioProgramacion
			PromedioProgramacion objP = new PromedioProgramacion();

			// Enviando los valores a la clase
			objP.estudiante = txtEstudiante.Text.Trim();
			objP.evaluacion1 = Convert.ToInt32(txtEva1.Text.Trim());
			objP.evaluacion2 = Convert.ToInt32(txtEva2.Text.Trim());
			objP.evaluacion3 = Convert.ToInt32(txtEva3.Text.Trim());
			objP.actitudinal = Convert.ToInt32(txtActitudinal.Text.Trim());

			// Calculando el promedio
			double promedio = objP.calculaPromedio();
			string condicion = objP.determinaCondicion();

			// Imprimir en la lista
			ListViewItem fila = new ListViewItem(objP.estudiante);
			fila.SubItems.Add(objP.evaluacion1.ToString("0.00"));
			fila.SubItems.Add(objP.evaluacion2.ToString("0.00"));
			fila.SubItems.Add(objP.evaluacion3.ToString("0.00"));
			fila.SubItems.Add(objP.actitudinal.ToString("0.00"));
			fila.SubItems.Add(promedio.ToString("0.00"));
			fila.SubItems.Add(condicion);

			lvEvaluaciones.Items.Add(fila);

			// Imprimir las estadisticas
			estadisticas();	
		}

		private void btnNuevoDato_Click(object sender, EventArgs e) {
			limpiarControles();
		}

		// Funcion que determina la suma de todos los promedios
		double sumaPromedios() {
			double suma = 0;

			for (int i = 0; i < lvEvaluaciones.Items.Count; i++) {
				suma += Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text);
			}

			return suma;
		}

		// Funcion que determina cual es el promedio mas alto
		double promedioMasAlto() {
			double mayor = 0;

			for (int i = 0; i < lvEvaluaciones.Items.Count; i++) {
				if (Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text) > mayor) {
					mayor = Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text);
				}
			}

			return mayor;
		}

		// Funcion que determina cual es el promedio mas bajo
		double promedioMasBajo() {
			double menor = int.MaxValue;

			for (int i = 0; i < lvEvaluaciones.Items.Count; i++) {
				if (Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text) < menor) {
					menor = Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text);
				}
			}

			return menor;
		}

		// Funcion que determina el total de aprobados
		int totalAprobados() {
			int cantidadAprobados = 0;

			for (int i = 0; i < lvEvaluaciones.Items.Count; i++) {
				if (Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text) > 10) {
					cantidadAprobados++;
				}
			}

			return cantidadAprobados;
		}

		// Funcion que determina el total de desaprobados
		int totalDesaprobados() {
			int cantidadDesaprobados = 0;

			for (int i = 0; i < lvEvaluaciones.Items.Count; i++) {
				if (Convert.ToDouble(lvEvaluaciones.Items[i].SubItems[5].Text) <= 10) {
					cantidadDesaprobados++;
				}
			}

			return cantidadDesaprobados;
		}

		void estadisticas() {
			lstR.Items.Clear();
			lstR.Items.Add("Suma de promedios: " + sumaPromedios().ToString("0.00"));
			lstR.Items.Add("Promedio mas alto: " + promedioMasAlto().ToString("0.00"));
			lstR.Items.Add("Promedio mas bajo: " + promedioMasBajo().ToString("0.00"));
			lstR.Items.Add("Total de aprobados: " + totalAprobados().ToString("0.00"));
			lstR.Items.Add("Total de desaprobados: " + totalDesaprobados().ToString("0.00"));
		}

		void limpiarControles() {
			txtEstudiante.Focus();
			txtEstudiante.Text = string.Empty;
			txtEva1.Text = string.Empty;
			txtEva2.Text = string.Empty;
			txtEva3.Text = string.Empty;
			txtActitudinal.Text = string.Empty;
		}
	}
}
