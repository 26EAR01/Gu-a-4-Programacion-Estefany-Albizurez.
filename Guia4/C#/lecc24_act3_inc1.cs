int acumuladorPrimos = 0;

Console.WriteLine("=== suma numeros primos 1 al 50 ===");

for (int i = 2; i <= 50; i++)
{
    bool esPrimo = true;

    for (int j = 2; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            esPrimo = false;
            break; 
        }
    }

    if (esPrimo)
    {
        Console.WriteLine($"primo encontrado: {i}");
        acumuladorPrimos += i; 
    }
}
Console.WriteLine($"TOTAL: {acumuladorPrimos}");

