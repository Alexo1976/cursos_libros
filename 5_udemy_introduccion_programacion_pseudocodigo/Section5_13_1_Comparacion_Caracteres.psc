Proceso Comparacion_Caracteres
	// Concatenar caracteres
	DEFINIR Un_Texto COMO CADENA;
	Un_Texto <- 'H' + 'o' + 'l' + 'a';
	ESCRIBIR Un_Texto;
	ESCRIBIR '�Que' + 'tal' + '?';
	
	// Comparaci�n de caracteres
	ESCRIBIR 'b' > 'a';
	ESCRIBIR 'B' > 'A';
	
	// Siempre una letra may�scula es mas peque�a que una min�scula, esto
	// por el c�digo ASCII
	ESCRIBIR 'A' > 'b';
	ESCRIBIR 'A' > 'a';
	ESCRIBIR 'A' > 'h';
	ESCRIBIR 'A' > 'z';
FinProceso
