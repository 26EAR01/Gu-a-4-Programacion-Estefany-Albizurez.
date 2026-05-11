Algoritmo lecc11_act3_inc3
	definir n1, n2, menor, mayor, i Como Entero 
	
	Escribir "ingrese el primer numero:"
	leer n1
	Escribir "Ingrese el segundo numero"
	leer n2
	
	Si n1 < n2 Entonces
		menor = n1
		mayor= n2
	SiNo
		menor = n2
		mayor = n1
	FinSi
	
	Escribir "Multiplos de 4 entre", menor, "y", mayor, ":"
	
	Para i = menor hasta mayor Hacer
		Si i % 4 == 0 Entonces
			Escribir i
		FinSi
	FinPara
FinAlgoritmo
