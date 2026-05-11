Algoritmo lecc11_act3_inc2
	Definir num, suma Como Entero
	suma = 0 
	num = 0 
	
	Escribir "ingrese numeros apara sumar, ingrese 9 para terminar"
	
	Mientras num <> 9 Hacer
		leer num 
		
		si num <> 9 Entonces
			suma = suma + num 
		FinSi
	FinMientras
	
	Escribir "la suma total de los numeros ingresados es:", suma
	
FinAlgoritmo
