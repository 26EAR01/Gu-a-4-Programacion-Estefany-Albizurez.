Algoritmo lecc24_act3_inc1
	Definir sumaAcumulada, num, divisor, divisoresEncontrados Como Entero
	sumaAcumulada = 0
	
	Para num = 2 Hasta 50 Hacer
		divisoresEncontrados = 0
		
		para divisor = 1 Hasta num Hacer
			Si num % divisor == 0 Entonces
				divisoresEncontrados = divisoresEncontrados + 1
			FinSi
		FinPara
		Si divisoresEncontrados == 2 Entonces
			Escribir "Encontrado: ", num
			sumaAcumulada = sumaAcumulada + num
		FinSi
	FinPara
	Escribir "la suma total acumulada es: ", sumaAcumulada
FinAlgoritmo
