Proceso Expresiones_Anidadas
	// A + 30 % 15 < 15 * B + 10 O A ^ 2 >= 24
	// A + 0       < 15 * B + 10 O A ^ 2 >= 24
	// A = 0, B = 0
	// 0 + 0       < 15 * 0 + 10 O 0 >= 24
	// 0           < 0      + 10 O 0 >= 24
	// 0           < 10          O 0 >= 24
	// VERDADERO                 O FALSO
	// VERDADERO
	
	DEFINIR A, B COMO ENTEROS;
	A <- 0;
	B <- 0;
	
	ESCRIBIR A + 30 % 15 < 15 * B + 10 O A ^ 2 >= 24;
FinProceso
