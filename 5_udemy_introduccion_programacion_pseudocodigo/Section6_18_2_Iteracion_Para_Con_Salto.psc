Proceso Iteracion_Para_Con_Salto
	// Se puede especificar un salto incremental diferente a 1 para cada iteración
	ESCRIBIR 'PARA tradicional de 0 a 9 de 1 en 1';
	
	PARA i <- 0 HASTA 9
		ESCRIBIR SIN SALTAR i, ' ';
	FinPara
	
	ESCRIBIR '';
	ESCRIBIR '';
	
	// Se puede especificar un salto de 2 en 2
	ESCRIBIR 'PARA de 0 a 19 de 2 en 2';
	
	PARA i<- 0 HASTA 19 CON PASO 2
		ESCRIBIR SIN SALTAR I, ' ';
	FinPara
	
	ESCRIBIR '';
	ESCRIBIR '';
	
	// Se puede espcificar salto de otro número
	ESCRIBIR 'PARA de 0 a 49 de 5 en 5';
	
	PARA i <- 0 HASTA 49 CON PASO 5
		ESCRIBIR SIN SALTAR i, ' ';
	FinPara
	
	ESCRIBIR '';
	ESCRIBIR '';
	
	// Se puede utilizar con PARA inverso
	// Se debe indicar el salto en negativo
	ESCRIBIR 'PARA inverso de 100 a 0 de -10 en -10';
	PARA i <- 100 HASTA 0 CON PASO -10
		ESCRIBIR SIN SALTAR i, ' ';
	FinPara
	
	ESCRIBIR '';
FinProceso
