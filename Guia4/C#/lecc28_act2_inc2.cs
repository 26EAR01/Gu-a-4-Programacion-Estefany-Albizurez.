int boletosVendidos = 0;
int totalCobrado = 0;
int opcion;

Console.WriteLine("=== RUEDA DE LA FORTUNA ===");

do
{
    Console.WriteLine("\nventa:");
    Console.WriteLine("1 - Niño ($10)");
    Console.WriteLine("2 - Adulto ($15)");
    Console.WriteLine("0 -  Cerrar caja");
    Console.Write("Seleccione una opción: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        if (opcion == 1)
        {
            boletosVendidos++;
            totalCobrado += 10;
            Console.WriteLine("Registrado: Niño");
        }
        else if (opcion == 2)
        {
            boletosVendidos++;
            totalCobrado += 15;
            Console.WriteLine("Registrado: Adulto");
        }
        else if (opcion != 0)
        {
            Console.WriteLine("Opción no válida.");
        }

        Console.WriteLine("\n[ ESTADO ACTUAL ]");
        Console.WriteLine($"Boletos vendidos: {boletosVendidos}");
        Console.WriteLine($"Total en caja:   ${totalCobrado}");
    }
    else
    {
        Console.WriteLine("Por favor, ingrese solo números (1, 2 o 0).");
    }

} while (opcion != 0);

Console.WriteLine("          REPORTE FINAL DE CAJA           ");
Console.WriteLine($"Total Boletos: {boletosVendidos}");
Console.WriteLine($"Total Recaudado: ${totalCobrado}");

