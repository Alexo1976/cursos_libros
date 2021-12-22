public class MiOrdenador {
	public static void main(String[] args) {
		COrdenador MiOrdenador = new COrdenador();
		MiOrdenador.EstablecerMarca("Toshiba");
		MiOrdenador.EstablecerProcesador("Intel");
		MiOrdenador.EstablecerPeso(5);
		MiOrdenador.Estado();
		
		MiOrdenador.EncenderOrdenador();
		MiOrdenador.EncenderPantalla();
		MiOrdenador.CargarAplicacion();
		MiOrdenador.Estado();
		
		MiOrdenador.CerrarAplicacion();
		MiOrdenador.ApagarPantalla();
		MiOrdenador.ApagarOrdenador();
		MiOrdenador.Estado();
	}
}

