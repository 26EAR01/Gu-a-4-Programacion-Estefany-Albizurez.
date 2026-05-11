Console.WriteLine("=== LOS PRIMEROS 20 MÚLTIPLOS DE 4 ===");

// i comienza en 1 y termina en 20
for (int i = 1; i <= 20; i++)
{
    // Calculamos el múltiplo en cada vuelta
    int resultado = i * 4;

    // Mostramos el índice y el resultado
    Console.WriteLine($"4 x {i}: {resultado}");
}

