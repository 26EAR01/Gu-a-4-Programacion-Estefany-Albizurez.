Algoritmo lecc9_Act3_Inc2
	Definir num, i Como Entero
	definir esPrimo Como Logico
	
	Escribir "Ingrese un numero entero positivo:"
	leer num
	
	Si num <= 1 Entonces
		Escribir "el numero no es primo"
	SiNo
		esPrimo = Verdadero 
		
		para i = 2 hasta num - 1 Hacer
			si num % i == 0 Entonces 
				esPrimo = Falso
			FinSi
		FinPara
		si esPrimo Entonces 
			Escribir num, "es primo"
		SiNo
			Escribir "no es numero primo"
		FinSi
	Fin Si
	
FinAlgoritmo
