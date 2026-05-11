int contadorPrimos = 0;
int sumaTotal = 0;

Console.WriteLine("=== numeros primos entre 1 y 100 ===");

for (int num = 2; num <= 100; num++)
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
        Console.Write($"{num} "); 
        contadorPrimos++;        
        sumaTotal += num;        
    }
}

Console.WriteLine($"Encontrados: {contadorPrimos}");
Console.WriteLine($"Suma total:   {sumaTotal}");

