Proceso Iteracion_Para
	DEFINIR Contador1, Contador2 COMO ENTERO;
	
	// Primer PARA
	PARA Contador1 <- 0 HASTA 9
		
		// Segundo PARA
		PARA Contador2 <- 0 HASTA 9
			SI Contador1 = 0 O Contador1 = 9 O Contador2 = 0 O Contador2 = 9 O Contador1 = Contador2 O Contador1 + Contador2 = 9 ENTONCES
				ESCRIBIR SIN SALTAR Contador1, Contador2 ' ';	
			Sino
				ESCRIBIR SIN SALTAR '   ';
			FinSi
		FinPara
		
		ESCRIBIR '';
		
	FinPara
	
	DibujarCajon(1, 1);	
	DibujarCajon(2, 4);	
	DibujarCajon(3, 3);	
	DibujarCajon(8, 4);	
	DibujarCajon(5, 5);	
	
	// PARA hacia atrás
	// PseInt detectará que se debe decrementar si <desde> es mayor que el número <hasta>
	PARA i <- 9 HASTA 0
		ESCRIBIR i;
	FinPara
FinProceso

SUBPROCESO DibujarCajon(b, h)
	ESCRIBIR 'Cajón ', b '*', h;
	
	PARA i <- 0 HASTA b-1
		PARA j <- 0 HASTA h-1
			ESCRIBIR SIN SALTAR '* ';
		FinPara
		
		ESCRIBIR '';
	FinPara
FinSubProceso