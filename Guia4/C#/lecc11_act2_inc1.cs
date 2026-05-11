Console.Write("Introduce un número entero no negativo: ");

if (int.TryParse(Console.ReadLine(), out int num))
{
    if (num < 0)
    {
        Console.WriteLine("No se puede calcular el factorial de un número negativo.");
    }
    else
    {
        long resultado = 1;

        for (int i = 1; i <= num; i++)
        {
            resultado *= i; 
        }

        Console.WriteLine($"\nEl resultado de {num}! es: {resultado}");
    }
}
else
{
    Console.WriteLine("Por favor introduce un número entero válido.");
}