class CAritmetica
{
    /*
    * Operaciones aritméticas
    */
	public static void main (String[] args)
	{
		int dato1, dato2, dato3, resultado;

		dato1 = 10;
		dato2 = 20;
		dato3 = 30;

		//Suma
		resultado = resultado = dato1 + dato2 + dato3;
		System.out.println(dato1 + " + " + dato2 + " + " + dato3 + " = " + resultado);

		//Resta
		resultado = dato1 - dato2 - dato3;
		System.out.println(dato1 + " - " + dato2 + " - " + dato3 + " = " + resultado);

		//Producto
		resultado = dato1 * dato2 * dato3;
		System.out.println(dato1 + " * " + dato2 + " + " + dato3 + " = " + resultado);

		//Cociente
		resultado = dato1 / dato2 / dato3;
		System.out.println(dato1 + " / " + dato2 + " / " + dato3 + " = " + resultado);
		
		resultado = dato1 + dato2 * dato3;
		System.out.println(dato1 + " + " + dato2 + " * " + dato3 + " = " + resultado);
		
		resultado = dato1 * dato2 - dato3;
		System.out.println(dato1 + " * " + dato2 + " - " + dato3 + " = " + resultado);
	}
}
