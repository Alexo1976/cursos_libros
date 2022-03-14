Proceso Condicional_Segun
	DEFINIR NumeroA, NumeroB COMO NUMERICOS;
	DEFINIR Operacion COMO CARACTER;
	
	ESCRIBIR SIN SALTAR 'Escribe el número A';
	LEER NumeroA;
	
	ESCRIBIR SIN SALTAR 'Escribe el número B';
	LEER NumeroB;
	
	Escribir 'Operaciones disponibles:';
	ESCRIBIR 'S: Suma';
	ESCRIBIR 'R: Resta';
	ESCRIBIR 'M: Multiplicación';
	
	ESCRIBIR SIN SALTAR '¿Que operación querés ejecutar?';
	ESCRIBIR SIN SALTAR 'Escribe la letra en mayúscula o minúscula';
	
	LEER Operacion;
	
	SEGUN Operacion HACER
		'S', 's':
			// Aquí la suma
			ESCRIBIR 'Has elegido la suma';
			ESCRIBIR NumeroA, ' + ', NumeroB;
			ESCRIBIR NumeroA + NumeroB;
		'R', 'r':
			// Aquí la resta
			ESCRIBIR 'Has elegido la resta';
			ESCRIBIR NumeroA, ' - ', NumeroB;
			ESCRIBIR NumeroA - NumeroB;
		'M', 'm':
			// Aquí la multiplicación
			ESCRIBIR 'Has elegido la multiplicación';
			ESCRIBIR NumeroA, ' * ', NumeroB;
			ESCRIBIR NumeroA * NumeroB;
		De Otro Modo:
			ESCRIBIR 'No has elegido la operación correcta';
	FINSEGUN
	
FinProceso
