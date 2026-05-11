Algoritmo lecc11_act1_inc1
	Definir capacidadMaxima, autosActuales Como Entero
	
	capacidadMaxima <- 200
	autosActuales <- 0
	
	Escribir "--- Sistema de Control de acceso ---"
	
	Repetir
		Escribir "Cajones disponibles: ", (capacidadMaxima - autosActuales)
		Escribir  "¿Cuantos autos acaban de ingresar?"
		leer autosNuevos
		
		autosActuales = autosActuales + autosNuevos
	Mientras  Que autosActuales < capacidadMaxima
	
	Escribir "Cajones llenos: ya no hay cajones libres"
	
	
FinAlgoritmo
