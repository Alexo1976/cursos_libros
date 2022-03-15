Proceso Condicional_Si_Entonces_Sino
	DEFINIR Numero1 COMO ENTERO;
	ESCRIBIR 'Escribe un número entero';
	LEER Numero1;
	ESCRIBIR 'La resta de ', Numero1, ' entre 2 es ', Numero1 % 2;
	
	ESCRIBIR '¿Es par?';
	//ESCRIBIR Numero1%2 = 0;
	
	SI Numero1 %2 = 0 ENTONCES
		ESCRIBIR Numero1, ' es par.';
	SINO
		ESCRIBIR Numero1, ' es impar.';
	FINSI
FinProceso
