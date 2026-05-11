Algoritmo lec10_Act1_inc1
	Definir sellosTotales, nuevosSellos Como Entero
	sellosTotales = 0
	
	Escribir "___ BIENVENIDO A LA PELUQUERIA___"
	Escribir "Reune 8 sellos y obten tu proximo corte gratis"
	
	Mientras sellosTotales < 8  Hacer
		Escribir "Actualmente tienes: ", sellosTotales, "sellos"
		Escribir "¿Cuantas visitas realizaste hoy?"
		leer nuevosSellos
		
		sellosTotales = sellosTotales + nuevosSellos
		
		Si sellosTotales < 8  Entonces
			Escribir "Te falta", (8 - sellosTotales), "para tu premio"
		Fin Si
	Fin Mientras
	
	Escribir "_______________________________________"
	Escribir "Felicidades! Has completado tu cuponera"
	Escribir "Tu corte de hoy es ¡Totalmente gratis!"
	Escribir "_______________________________________"
FinAlgoritmo
