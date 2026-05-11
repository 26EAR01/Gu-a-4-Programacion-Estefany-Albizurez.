Console.Write("Ingrese un número entero superior a 20: ");

if (int.TryParse(Console.ReadLine(), out int numeroUsuario))
{
    if (numeroUsuario >= 20)
    {
        Console.WriteLine($"\nListado de números IMPARES del 20 al {numeroUsuario}:");

        for (int i = 20; i <= numeroUsuario; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    else
    {
        Console.WriteLine("El número ingresado debe ser mayor a 20.");
    }
}
else
{
    Console.WriteLine("Error: Entrada no válida.");
}