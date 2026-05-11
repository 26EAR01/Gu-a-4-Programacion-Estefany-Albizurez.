Console.Write("Ingrese un número entero: ");

if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n >= 1)
    {
        int suma = 0;
        Console.WriteLine("\n--- CUENTA REGRESIVA ---");

        for (int i = n; i >= 1; i--)
        {
            Console.WriteLine(i);
            suma += i; 
        }

        Console.WriteLine($"SUMA TOTAL: {suma}");
    }
    else
    {
        Console.WriteLine("El número debe ser mayor a 0 para bajar hasta 1.");
    }
}
else
{
    Console.WriteLine("Ingrese un número entero valido.");
}
