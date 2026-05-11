Algoritmo Lecc15_act1_inc1
	Definir opcion, boletosAdulto, boletosNinos, totalDinero Como Entero
    boletosAdulto = 0
    boletosNinos = 0
    totalDinero = 0
    opciones = 0
    
    Mientras opcion <> 3 Hacer
        Escribir "--- RUEDA DE LA FORTUNA ---"
        Escribir "1. Vender boleto ADULTO ($15)"
        Escribir "2. Vender boleto NIÑO ($10)"
        Escribir "3. Cerrar caja y salir"
        Escribir "Seleccione una opción:"
        Leer opcion
        
        Segun opcion Hacer
            1:
                boletosAdulto = boletosAdulto + 1
                totalDinero = totalDinero + 15
                Escribir "Boleto de adulto registrado."
            2:
                boletosNinos = boletosNinos + 1
                totalDinero = totalDinero + 10
                Escribir "Boleto de niño registrado."
            3:
                Escribir "Cerrando sistema..."
            De Otro Modo:
                Escribir "Opción no válida."
        Fin Segun
        
        Escribir "Estado actual: ", (boletosAdulto + boletosNinos), " boletos vendidos."
        Escribir "Total cobrado: $", totalDinero
        Escribir "---------------------------"
    Fin Mientras
    
    Escribir "--- RESUMEN FINAL ---"
    Escribir "Boletos Adulto: ", boletosAdulto
    Escribir "Boletos Niño: ", boletosNinos
    Escribir "Total Boletos: ", (boletosAdulto + boletosNinos)
    Escribir "Dinero Total en Caja: $", totalDinero
FinAlgoritmo
