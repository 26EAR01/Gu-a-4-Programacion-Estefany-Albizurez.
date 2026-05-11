Algoritmo lecc15_act3_inc1
	Definir i, multiplo, suamatotal, contadorPares Como Entero
	sumatotal = 0
	contadorPares = 0
	
	Para i = 1 Hasta 20 Hacer
		multiplo = i*7
		sumatotal = sumatotal+multiplo
		
		Si multiplo % 2 == 0 Entonces
			contadorPares = contadorPares +1
		FinSi
		Escribir  "Multiplo ", i, ":", multiplo
	FinPara
	
	Escribir "------------------------------------------"
	Escribir  "La sumatoria es: ", sumatotal
	Escribir "Cantidad de multiplos pares: ", contadorPares
	
FinAlgoritmo
