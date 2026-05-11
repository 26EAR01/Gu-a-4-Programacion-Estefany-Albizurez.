Algoritmo lecc9_Act2_Inc1
	Definir monedasTotales, monedasGanadas Como Entero
	monedasTotales = 0
	
	Escribir "Nivel 5 Bloqueado. Necesitas 350 monedas para entrar"
	
	Mientras monedasTotales<350 Hacer
		Escribir "Actualmente tienes: ", monedasTotales, "monedas"
		Escribir "¿Cuantas monedas ganate en esta partida?"
		leer monedasGanadas
		
		monedasTotales = monedasTotales + monedasGanadas
	Fin Mientras
	
	Escribir "¡Felicidades! Tienes:", monedasTotales, "monedas"
	Escribir "Nivel 5 DESBLOQUEADO. ¡Puedes entrar!"
FinAlgoritmo
