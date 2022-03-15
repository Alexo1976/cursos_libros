Proceso Definicion_Asignacion
	
	//Definición de variables
	DEFINIR Identificacion COMO CARACTER;
	DEFINIR NombreCompleto COMO CADENA;
	DEFINIR Edad COMO ENTERO;
	DEFINIR Nota COMO REAL;
	DEFINIR Encontrado COMO LOGICO;
	
	//Asignación de variables
	Identificacion <- '206830685';
	NombreCompleto <- 'Enmanuelle Acuña';
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
	ESCRIBIR 'Introduce la identificación';
	LEER Identificacion;
	ESCRIBIR 'Introduce nombre completo';
	LEER NombreCompleto;
	
	ESCRIBIR 'La nota es: ' , Nota;
	ESCRIBIR 'La identificación es: ', Identificacion;
	ESCRIBIR 'El nombre es: ', NombreCompleto;
	
	ESCRIBIR NombreCompleto, ' ha sacado un ', Nota;
FinProceso
