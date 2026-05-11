Algoritmo lecc9_Act4_Inc1
	Definir num, i, resultado Como Entero
	
	Escribir "Ingrese el numero de la tabla que desea ver:"
	leer num
	
	Escribir "Tabla de multiplocar del", num, ":"
	
	Para i = 1 Hasta 10 Hacer
		resultado = num *i
		Escribir num, "x", i, "=", resultado
	Fin Para
	
FinAlgoritmo
