Algoritmo lecc24_act3_inc2
	Definir numinicio, i, suma Como entero 
	suma = 0
	
	Escribir "Ingrese el numero para iniciar la cuenta regresiva:"
	leer numinicio
	
	Si numinicio < 1 Entonces
		Escribir "por favor ingrese un numero mayor o igual a 1"
		
	SiNo
		Escribir  "Iniciando cuenta regresiva:"
		
		Para i  = numinicio Hasta 1 Con Paso -1 Hacer
			Escribir  i 
			suma = Suma + i 
		FinPara
		Escribir "La suma total es: ", suma
	FinSi
	
FinAlgoritmo
