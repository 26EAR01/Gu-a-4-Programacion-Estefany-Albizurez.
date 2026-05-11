Algoritmo lecc9_Act1_Inc1
	Definir pesoActual, pesoManzana, pesoObjetivo Como Real
	
	pesoObjetivo=1000
	pesoActual=0
	
	Mientras pesoActual < pesoObjetivo  Hacer
		Escribir "El peso actual es de:", pesoActual, "gramos"
		Escribir "Por favor añada una manzana a la bascula"
		
		leer pesoManzana
		
		pesoActual = pesoActual + pesoManzana
		
		total=total+pesoManzana
		
		Escribir "Has añadido:", total,"gramos"
	Fin Mientras
	
	Escribir "Objetivo alcanzado! Peso total: ", pesoActual, "gramos."
	Escribir "Ya tienes 1 kilo de manzanas"
	 
FinAlgoritmo
