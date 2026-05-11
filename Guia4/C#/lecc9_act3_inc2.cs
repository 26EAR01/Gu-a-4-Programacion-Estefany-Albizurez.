Console.Write("Ingrese un número entero para verificar si es primo: ");

if (int.TryParse(Console.ReadLine(), out int num))
{
    if (num <= 1)
    {
        Console.WriteLine($"{num} no es un número primo");
    }
    else
    {
        bool esPrimo = true;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                esPrimo = false;
                break; 
            }
        }

        if (esPrimo)
            Console.WriteLine($"El {num} es un número primo.");
        else
            Console.WriteLine($"El {num} no es primo");
    }
}
else
{
    Console.WriteLine("Por favor ingrese un número válido.");
}
