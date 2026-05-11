Algoritmo lecc23_act4_inc1
	Definir pesoTotal, pesoManzana Como Real
	pesoTotal = 0
	
	Escribir "--- Bascula de mercado ---"
	Escribir "Objetivo: 1000 gramos (1kg)"
	
	Mientras pesoTotal < 1000 Hacer
		Escribir  "Peso actual: ", pesoTotal, "gramos"
		Escribir  "Pon una manzana en la bascula e indica su peso en gramos:"
		leer pesoManzana
		
		pesoTotal = pesoTotal + pesoManzana
		
		si pesoTotal < 1000 Entonces
			Escribir  "Aun falta para el kilo..."
		FinSi
	FinMientras
	
	Escribir  "Listo, Peso final: ", pesoTotal, "gramos"
	Escribir  "Ya puedes llevar tus manzanas"
	
FinAlgoritmo
