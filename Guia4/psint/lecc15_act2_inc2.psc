Algoritmo lecc15_act2_inc2
	Definir billete, contador100, totalDinero Como Entero
	contador100 = 0
	totalDinero = 0
	
	Mientras  totalDinero < 1000 Hacer
		leer billete
		
		si billete = 100 Entonces
			contador100 = contador100 + 1
		FinSi
		totalDinero = totalDinero + billete
	FinMientras
	Escribir "la cantida de billetes de 100: ", contador100
	Escribir "Total de dinero: ", totalDinero
FinAlgoritmo
