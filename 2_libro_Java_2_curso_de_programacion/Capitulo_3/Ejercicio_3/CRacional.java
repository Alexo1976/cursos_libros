class CRacional {
    private Integer Numerador;
    private Integer Denominador;

    public CRacional() {
    };

    public CRacional(Integer Num, Integer Den) {
        AsignarDatos(Num, Den);
    }

    public void AsignarDatos(Integer num, Integer den) {
        Numerador = num;
        if (den == 0)
            den = 1; // El denominador no puede ser cero.
        Denominador = den;
    }

    public void VisualizarRacional() {
        System.out.println(Numerador + "/" + Denominador);
    }

    public void Sumar(CRacional racional) {
        Numerador = Numerador * racional.Denominador + Denominador * racional.Numerador;
        Denominador = Denominador * racional.Denominador;
        VisualizarRacional();
    }

    public void Restar(CRacional racional) {
        Numerador = Numerador * racional.Denominador - Denominador * racional.Numerador;
        Denominador = Denominador * racional.Denominador;
        VisualizarRacional();
    }

    public void Multiplicar(CRacional racional) {
        Numerador = Numerador * racional.Numerador;
        Denominador = Denominador * racional.Denominador;
        VisualizarRacional();
    }

    public void Simplificar() {
        Integer divisor = 2;

        while (divisor <= 12) {
            if (Numerador % divisor == 0 & Denominador % divisor == 0) {
                Numerador = Numerador / divisor;
                Denominador = Denominador / divisor;
                divisor = 2;
            } else {
                divisor = divisor + 1;
            }
        }

        VisualizarRacional();
    }
}
