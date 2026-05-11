Algoritmo lecc10_Act3_Inc1
	Definir suma, i, j, divisores Como Entero
	suma = 0
	
	Para i = 2 Hasta 22 Hacer
		divisores = 0
		
		Para j = 1 Hasta i Hacer
			si i % j == 0 Entonces
				divisores = divisores+1
			FinSi
		FinPara
		
		si divisores == 2 Entonces 
			Escribir "Primo encontrado: ", i
			
			suma = suma + i
		FinSi
	FinPara
	
	Escribir "La suma total de los numeros primos entre 1 y 22 es: ", suma
	
FinAlgoritmo
