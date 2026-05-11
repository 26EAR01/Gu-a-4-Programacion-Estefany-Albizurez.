double pesoTotal = 0;
const double OBJETIVO = 1000; // 1 kilo en gramos

Console.WriteLine("=== BIENVENIDO A LA FRUTERÍA ===");
Console.WriteLine("Coloca manzanas en la báscula hasta llegar a 1kg.");

// Usamos while porque no sabemos cuántas manzanas tomará
while (pesoTotal < OBJETIVO)
{
    Console.WriteLine($"\nPeso en báscula: {pesoTotal}g");
    Console.Write("¿Cuánto pesa la manzana que acabas de poner? (en gramos): ");

    if (double.TryParse(Console.ReadLine(), out double pesoManzana))
    {
        if (pesoManzana > 0)
        {
            pesoTotal += pesoManzana;
        }
        else
        {
            Console.WriteLine("Error: La manzana debe tener un peso válido.");
        }
    }
    else
    {
        Console.WriteLine(" inválida. Por favor ingresa el peso en números.");
    }
}

Console.WriteLine($"OBJETIVO ALCANZADO: {pesoTotal} gramos.");
if (pesoTotal > OBJETIVO)
{
    Console.WriteLine($"Te pasaste por {pesoTotal - OBJETIVO}g, ¡pero te las llevamos!");
}

