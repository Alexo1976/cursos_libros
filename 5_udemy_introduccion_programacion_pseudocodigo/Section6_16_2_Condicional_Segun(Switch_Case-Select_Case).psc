Proceso Condicional_Segun
	DEFINIR NumeroA, NumeroB COMO NUMERICOS;
	DEFINIR Operacion COMO CARACTER;
	
	ESCRIBIR SIN SALTAR 'Escribe el n�mero A';
	LEER NumeroA;
	
	ESCRIBIR SIN SALTAR 'Escribe el n�mero B';
	LEER NumeroB;
	
	Escribir 'Operaciones disponibles:';
	ESCRIBIR 'S: Suma';
	ESCRIBIR 'R: Resta';
	ESCRIBIR 'M: Multiplicaci�n';
	
	ESCRIBIR SIN SALTAR '�Que operaci�n quer�s ejecutar?';
	ESCRIBIR SIN SALTAR 'Escribe la letra en may�scula o min�scula';
	
	LEER Operacion;
	
	SEGUN Operacion HACER
		'S', 's':
			// Aqu� la suma
			ESCRIBIR 'Has elegido la suma';
			ESCRIBIR NumeroA, ' + ', NumeroB;
			ESCRIBIR NumeroA + NumeroB;
		'R', 'r':
			// Aqu� la resta
			ESCRIBIR 'Has elegido la resta';
			ESCRIBIR NumeroA, ' - ', NumeroB;
			ESCRIBIR NumeroA - NumeroB;
		'M', 'm':
			// Aqu� la multiplicaci�n
			ESCRIBIR 'Has elegido la multiplicaci�n';
			ESCRIBIR NumeroA, ' * ', NumeroB;
			ESCRIBIR NumeroA * NumeroB;
		De Otro Modo:
			ESCRIBIR 'No has elegido la operaci�n correcta';
	FINSEGUN
	
FinProceso
