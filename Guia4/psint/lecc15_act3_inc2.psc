Algoritmo lecc15_act3_inc2
	Definir i, j, divisores, contadorPrimos, sumaPares Como Entero
	contadorPrimos = 0
	sumaPares = 0
	
	
	
	Para i = 300 Hasta 1 Con Paso -1 Hacer
		
		Si i % 2 == 0 Entonces
			sumaPares = sumaPares + i 
		FinSi
		
		divisores = 0
		Para j=1 hasta i Hacer
			si i % j == 0 Entonces
				divisores = divisores + 1
			FinSi
		FinPara
		
		si divisores == 2 Entonces
			contadorprimos = contadorprimos + 1
		FinSi
	FinPara
	
	Escribir "Numeros primos encontrados: ", contadorprimos
	Escribir "Suma total de los numeros pares: ", sumaPares
	
FinAlgoritmo
