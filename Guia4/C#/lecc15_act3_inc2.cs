
int contadorPrimos = 0;
        int sumaPares = 0;

        Console.WriteLine("Ejecutando análisis desde 300 hasta 1...");

        for (int i = 300; i >= 1; i--)
        {
            if (i % 2 == 0)
            {
                sumaPares += i;
            }

            if (EsPrimo(i))
            {
                contadorPrimos++;
            }
        }

        Console.WriteLine("\n======================================");
        Console.WriteLine($"CONTEO DE PRIMOS: {contadorPrimos}");
        Console.WriteLine($"SUMA DE PARES:    {sumaPares}");
        Console.WriteLine("======================================");
    

    static bool EsPrimo(int n)
{
    if (n <= 1) return false;
    for (int j = 2; j * j <= n; j++) 
    {
        if (n % j == 0) return false;
    }
    return true;
}