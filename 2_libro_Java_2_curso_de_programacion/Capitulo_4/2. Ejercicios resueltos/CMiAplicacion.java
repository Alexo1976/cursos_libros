class CEcuacion {
    //El término de mayor grado tiene exponente 3 fijo.
    double c3, c2, c1, c0; //Coeficientes.
    
    public void Ecuacion(double a, double b, double c, double d) {
        c3 = a; c2 = b; c1 = c; c0 = d;
    }
    
    public double ValorPara(double x) {
        double resultado;
        resultado = c3*x*x*x + c2*x*x + c1*x + c0;
        return resultado; //Devolver el valor calculado.
    }
}

public class CMiAplicacion {
    public static void main(String[] args) {
        CEcuacion ec1 = new CEcuacion();
        ec1.Ecuacion(1, -3.2, 0, 7);
        
        double r = ec1.ValorPara(1);
        System.out.println(r);
        
        r = ec1.ValorPara(1.5);
        System.out.println(r);
    }
}
