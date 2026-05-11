int sumaTotal = 0;
int contadorPares = 0;

Console.WriteLine("=== los primeros 20 multiplos de 7 ===");

for (int i = 1; i <= 20; i++)
{
    int multiplo = i * 7;
    sumaTotal += multiplo; 

    if (multiplo % 2 == 0)
    {
        contadorPares++;
    }

    Console.WriteLine($"#{i}: {multiplo} {(multiplo % 2 == 0 ? "[Par]" : "[Impar]")}");
}

Console.WriteLine($"SUMATORIA TOTAL: {sumaTotal}");
Console.WriteLine($"TOTAL DE PARES:  {contadorPares}");

