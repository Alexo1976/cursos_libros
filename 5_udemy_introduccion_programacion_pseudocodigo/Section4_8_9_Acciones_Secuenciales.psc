Proceso Definicion_Asignacion
	
	//Definici�n de variables
	DEFINIR Identificacion COMO CARACTER;
	DEFINIR NombreCompleto COMO CADENA;
	DEFINIR Edad COMO ENTERO;
	DEFINIR Nota COMO REAL;
	DEFINIR Encontrado COMO LOGICO;
	
	//Asignaci�n de variables
	Identificacion <- '206830685';
	NombreCompleto <- 'Enmanuelle Acu�a';
	Edad <- 26;
	Nota <- 88.5;
	Encontrado <- FALSO;
	
	//Mostrar valor de variables
	ESCRIBIR Identificacion;
	ESCRIBIR NombreCompleto;
	ESCRIBIR Edad;
	ESCRIBIR Nota;
	ESCRIBIR Encontrado;
	
	ESCRIBIR 'Introduce la nota';
	LEER Nota;
	ESCRIBIR 'Introduce la identificaci�n';
	LEER Identificacion;
	ESCRIBIR 'Introduce nombre completo';
	LEER NombreCompleto;
	
	ESCRIBIR 'La nota es: ' , Nota;
	ESCRIBIR 'La identificaci�n es: ', Identificacion;
	ESCRIBIR 'El nombre es: ', NombreCompleto;
	
	ESCRIBIR NombreCompleto, ' ha sacado un ', Nota;
FinProceso
