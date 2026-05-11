Algoritmo Lecc11_act2_inc1
	definir num, i, factorial Como Entero
	
	Escribir "Ingrese un numero para calcular su factorial:"
	leer num
	
	Si num < 0 Entonces
		Escribir "El factorial no esta definido para numeros negativos" 
	SiNo
		factorial = 1
		
		Para i = 1 Hasta num Hacer
			factorial = factorial * i 
		FinPara
		Escribir "El factorial de ", num,"es: ", factorial
	Fin Si
FinAlgoritmo
