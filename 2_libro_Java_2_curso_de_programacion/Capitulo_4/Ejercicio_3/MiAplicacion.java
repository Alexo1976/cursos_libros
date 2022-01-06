public class MiAplicacion {
    public static void main(String[] args) {
        CEcuacion ec1 = new CEcuacion();
        ec1.Ecuacion(5, -1.7, 2, 3);

        double resultado = ec1.ResolverEcuacion(10.5);
        System.out.println("Resultado = " + resultado);
    }
}
