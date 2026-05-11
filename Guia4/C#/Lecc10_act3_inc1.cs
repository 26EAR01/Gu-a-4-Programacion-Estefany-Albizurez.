int sumaTotal = 0;

Console.WriteLine("--- SUMATORIA DE PRIMOS (1 - 22) ---");

for (int num = 2; num <= 22; num++)
{
    bool esPrimo = true;

    for (int divisor = 2; divisor < num; divisor++)
    {
        if (num % divisor == 0)
        {
            esPrimo = false;
            break; 
        }
    }

    if (esPrimo)
    {
        Console.WriteLine($"Número {num} primo.");
        sumaTotal += num; 
    }
}

Console.WriteLine("-------------------------------------");
Console.WriteLine($"suma total: {sumaTotal}");
Console.WriteLine("-------------------------------------");
