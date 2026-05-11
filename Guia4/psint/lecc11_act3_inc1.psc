Algoritmo lecc11_act3_inc1
	Definir n1, n2, menor, mayor, i, suma Como Entero
	suma = 0
	
	Escribir "Ingrese el primer numero:"
	leer n1
	Escribir "Ingrese el segundo numero:"
	leer n2
	
	Si n1 < n2 Entonces
		menor = n1 
		mayor = n2 
	SiNo
		menor = n2 
		mayor = n1
	FinSi
	
	Para i = menor Hasta mayor Hacer
		suma = suma +i
	FinPara
	
	Escribir "La suma de todos los enteros entre", menor, "y", mayor, "es: ",suma
FinAlgoritmo
