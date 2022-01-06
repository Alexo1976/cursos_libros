class CEcuacion {
	// El término de mayor grado tiene exponente 3 fijo.
	double c3, c2, c1, c0; // Coeficientes.

	public void Ecuacion(double a, double b, double c, double d) {
		c3 = a;
		c2 = b;
		c1 = c;
		c0 = d;
	}

	public double ResolverEcuacion(double x) {
		double monomio1 = (c3 * (Math.pow(x, 3)));
		double monomio2 = (c2 * (Math.pow(x, 2)));
		double monomio3 = (c1 * x);
		double monomio4 = c0;

		// double resultado = c3 * x * x * x + c2 * x * x + c1 * x + c0;
		double resultado = monomio1 + monomio2 - monomio3 + monomio4;

		return resultado;
	}
}
