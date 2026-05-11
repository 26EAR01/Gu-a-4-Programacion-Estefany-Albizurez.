Algoritmo lecc24_act_inc1
	Definir num, i, rsultado Como Entero
	Escribir  "Ingrese el numero del cual desea ver los multiplos: "
	leer num 
	
	Escribir  "Los promeros 20 multoplos de ", num, "son:"
	
	Para  i = 1 Hasta 20 Hacer
		resultado = num * i 
		Escribir num, "X", i, "=", resultado
	FinPara
	
FinAlgoritmo
