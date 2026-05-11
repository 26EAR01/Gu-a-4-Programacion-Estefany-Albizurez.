int sellosAcumulados = 0;
const int META_SELLOS = 8;

Console.WriteLine("=== PROGRAMA DE FIDELIDAD: CORTE GRATIS ===");
Console.WriteLine($"Regla: Al llegar a {META_SELLOS} sellos, no pagas nada.");

while (sellosAcumulados < META_SELLOS)
{
    Console.WriteLine($"\nEstado actual: [{sellosAcumulados}/{META_SELLOS}] sellos.");
    Console.Write("¿Cuántos sellos vas a registrar en esta visita?: ");

    if (int.TryParse(Console.ReadLine(), out int cantidadIngresada))
    {
        if (cantidadIngresada > 0)
        {
            sellosAcumulados += cantidadIngresada;
            Console.WriteLine($"¡Se han añadido {cantidadIngresada} sello(s) a tu cuenta!");
        }
        else
        {
            Console.WriteLine("Por favor, ingresa una cantidad válida.");
        }
    }
    else
    {
        Console.WriteLine("Entrada inválida. Usa números enteros.");
    }
}
Console.WriteLine("\n*********************************************");
Console.WriteLine("  ¡CUPONERA LLENA! DISFRUTA TU CORTE GRATIS  ");
Console.WriteLine("*********************************************");
Console.WriteLine($"Total de sellos recolectados: {sellosAcumulados}");
