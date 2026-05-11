Algoritmo lecc28_act2_inc2
	definir opciones, boletosVendidos, totalCobrado Como Entero
	boletosVendidos = 0
	totalCobrado = 0
	opciones = -1
	
	Mientras  opciones <> 0 Hacer
		Escribir "--- Control de acceso ---"
		Escribir "1. Niño $10"
		Escribir "2. Adulto $15"
		Escribir "3. cerrar caja"
		leer opciones
		
		Si opciones == 1 Entonces
			boletosVendidos = boletosVendidos +1
			totalCobrado = totalCobrado + 10
			Escribir  "Boleto de niño regditrado"
			
		SiNo
			si opciones == 2 Entonces
				boletosVendidos = boletosVendidos + 1
				totalCobrado = totalCobrado + 15
				Escribir  "Boleto de adulto registrado"
			FinSi
		FinSi
		
		Escribir " Total boletos: ", boletosVendidos
		Escribir  " Total dinero: $", totalCobrado
	FinMientras
	Escribir  "Caja cerrada"
FinAlgoritmo
