Proceso Definicion_Asignacion
	
	//Definici�n de variables
	Definir Identificacion como Caracter;
	Definir NombreCompleto Como Cadena;
	Definir Edad Como Entero;
	Definir Nota Como Real;
	Definir Encontrado Como Logico;
	
	//Asignaci�n de variables
	Identificacion <- '206830685';
	NombreCompleto <- 'Enmanuelle Acu�a';
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
	Escribir 'Introduce la identificaci�n';
	Leer Identificacion;
	Escribir 'Introduce nombre completo';
	Leer NombreCompleto;
	
	Escribir 'La nota es: ' , Nota;
	Escribir 'La identificaci�n es: ', Identificacion;
	Escribir 'El nombre es: ', NombreCompleto;
	
	Escribir NombreCompleto, ' ha sacado un ', Nota;
	
FinProceso
