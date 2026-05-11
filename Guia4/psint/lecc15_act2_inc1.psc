Algoritmo lecc15_act2_inc1
	Definir  i, j, divisores, contadorprimos, sumaTotal Como Entero
	contadorprimos = 0
	sumaTotal = 0
	
	Escribir "Analizando numeros primos entre 1 y 100..."
	
	para i = 2 hasta 100 hacer 
		divisores = 0
		
		Para j = 1 hasta i Hacer 
			si i % j == 0 Entonces
				divisores = divisores + 1 
				
			FinSi
		FinPara
		
		Si divisores == 2 Entonces
			contadorprimos = contadorprimos + 1
			sumaTotal = sumaTotal + i 
			Escribir "Primo encontrado: ", i
		FinSi
	FinPara
	
	Escribir  "---------------------------------------"
	Escribir  "resultados:"
	Escribir  "Cantidad de nuemros primos: ", contadorprimos
	Escribir  "Suma total de los primos: ", sumaTotal
	Escribir  "---------------------------------------"
	
FinAlgoritmo
