Proceso Comparacion_Caracteres
	// Concatenar caracteres
	DEFINIR Un_Texto COMO CADENA;
	Un_Texto <- 'H' + 'o' + 'l' + 'a';
	ESCRIBIR Un_Texto;
	ESCRIBIR '¿Que' + 'tal' + '?';
	
	// Comparación de caracteres
	ESCRIBIR 'b' > 'a';
	ESCRIBIR 'B' > 'A';
	
	// Siempre una letra mayúscula es mas pequeña que una minúscula, esto
	// por el código ASCII
	ESCRIBIR 'A' > 'b';
	ESCRIBIR 'A' > 'a';
	ESCRIBIR 'A' > 'h';
	ESCRIBIR 'A' > 'z';
FinProceso
