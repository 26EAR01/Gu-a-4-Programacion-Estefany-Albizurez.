Algoritmo lecc9_Act3_Inc1
	Definir numerousuario, i Como Entero
	
	Escribir "Ingrese un numero mayor a 20:"
	leer numerousuario
	
	Si numerousuario < 20 Entonces
		Escribir  	"El numero debe ser mayor a 20"
	SiNo
		Escribir "Los numeros impares entre 20 y ", numerousuario, "son:"
		
		Para i = 20 Hasta numerousuario Hacer
			si i % 2 <> 0 Entonces
				Escribir i
			FinSi
		FinPara
	Fin Si
	
FinAlgoritmo
