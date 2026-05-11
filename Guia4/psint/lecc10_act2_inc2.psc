Algoritmo lecc10_act2_inc2
	Definir numUsuario, i Como Entero
	
	Escribir  "Ingrese un numero entero mayor a 2: "
	leer numUsuario
	
	Si numUsuario < 2 Entonces
		Escribir "El numero debe ser mayor o iguala 2"
	SiNo
		Escribir "Numeros pares entre 2 y", numUsuario, ":"
		
		Para i = 2 Hasta numUsuario Hacer
			si i % 2 == 0 Entonces
				Escribir i
			FinSi
		Fin Para
	Fin Si
	
FinAlgoritmo
