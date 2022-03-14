Proceso Definicion_Asignacion
	
	//Definición de variables
	Definir Identificacion como Caracter;
	Definir NombreCompleto Como Cadena;
	Definir Edad Como Entero;
	Definir Nota Como Real;
	Definir Encontrado Como Logico;
	
	//Asignación de variables
	Identificacion <- '206830685';
	NombreCompleto <- 'Enmanuelle Acuña';
	Edad <- 26;
	Nota <- 88.5;
	Encontrado <- Falso;
	
	//Mostrar valor de variables
	Escribir Identificacion;
	Escribir NombreCompleto;
	Escribir Edad;
	Escribir Nota;
	Escribir Encontrado;
	
	Escribir 'Introduce la nota';
	Leer Nota;
	Escribir 'Introduce la identificación';
	Leer Identificacion;
	Escribir 'Introduce nombre completo';
	Leer NombreCompleto;
	
	Escribir 'La nota es: ' , Nota;
	Escribir 'La identificación es: ', Identificacion;
	Escribir 'El nombre es: ', NombreCompleto;
	
	Escribir NombreCompleto, ' ha sacado un ', Nota;
	
FinProceso
