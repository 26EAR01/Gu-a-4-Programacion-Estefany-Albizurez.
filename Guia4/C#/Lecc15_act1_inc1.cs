int boletosAdulto = 0;
int boletosNinos = 0;
int totalDinero = 0;
string opcion;

Console.WriteLine("===RUEDA DE LA FORTUNA ===");

do
{
    Console.WriteLine("\n--- MENÚ ---");
    Console.WriteLine("1 - Boleto Adulto ($15)");
    Console.WriteLine("2 - Boleto Niño ($10)");
    Console.WriteLine("3 - Salir y mostrar reporte");
    Console.Write("Seleccione una opción: ");

    opcion = Console.ReadLine().ToUpper(); 
    switch (opcion)
    {
        case "1":
            boletosAdulto++;
            totalDinero += 15;
            Console.WriteLine("¡Venta de Adulto exitosa!");
            break;
        case "2":
            boletosNinos++;
            totalDinero += 10;
            Console.WriteLine("¡Venta de Niño exitosa!");
            break;
        case "3":
            Console.WriteLine("Generando reporte final...");
            break;
        default:
            Console.WriteLine("Opción inválida, intente de nuevo.");
            break;
    }

    Console.WriteLine($"Total actual en caja: ${totalDinero}");

} while (opcion != "S");

Console.WriteLine();
Console.WriteLine("             REPORTE DEL SUPERVISOR          ");
Console.WriteLine();
Console.WriteLine($"Boletos de Adulto: {boletosAdulto}");
Console.WriteLine($"Boletos de Niño:   {boletosNinos}");
Console.WriteLine($"Total de Personas: {boletosAdulto + boletosNinos}");
Console.WriteLine($"RECAUDACIÓN TOTAL: ${totalDinero}");

