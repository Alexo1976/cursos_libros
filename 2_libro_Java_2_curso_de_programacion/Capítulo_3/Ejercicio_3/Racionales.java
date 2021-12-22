public class Racionales {
    public static void main(String[] args) {
        // Punto de entrada a la aplicacion
        CRacional racional1 = new CRacional();
        racional1.AsignarDatos(1, 3);
        racional1.VisualizarRacional(); // Se visualiza 1/3
        
        CRacional racional2 = new CRacional(2, 4);
        racional2.VisualizarRacional(); // 2/4
        
        racional1.Sumar(racional2); // 10/12
        
        racional1.AsignarDatos(1, 3);
        
        racional1.Restar(racional2); // -2/12
        
        racional1.AsignarDatos(1, 3);
        
        racional1.Multiplicar(racional2); // 2/12
        
        racional1.Simplificar(); // 1/6
        
        racional1.AsignarDatos(80, 40);
        
        racional1.Simplificar(); // 2/1
        
        racional1.AsignarDatos(25, 100);
        
        racional1.Simplificar(); // 1/4
    }
}
