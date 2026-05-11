const int CAPACIDAD_MAXIMA = 200;
int autosActuales = 0;

Console.WriteLine("=== BIENVENIDO AL ESTACIONAMIENTO ===");

do
{
    int disponibles = CAPACIDAD_MAXIMA - autosActuales;
    Console.WriteLine($"\nESTADO: {disponibles} cajones disponibles.");

    Console.Write("Ingrese la cantidad de autos que entran: ");
    if (int.TryParse(Console.ReadLine(), out int entrada))
    {
        if (autosActuales + entrada <= CAPACIDAD_MAXIMA)
        {
            autosActuales += entrada;
            Console.WriteLine($"Acceso concedido, utos en total: {autosActuales}");
        }
        else
        {
            Console.WriteLine("Error no hay suficiente espacio para esa cantidad de autos.");
        }
    }
    else
    {
        Console.WriteLine("Entrada no válida ingrese un número.");
    }

} while (autosActuales < CAPACIDAD_MAXIMA);

Console.WriteLine("Estacionamiento LLENO.");
Console.WriteLine("no se permiten más ingresos.");