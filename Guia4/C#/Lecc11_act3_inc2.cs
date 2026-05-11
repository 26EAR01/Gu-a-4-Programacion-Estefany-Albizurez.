int suma = 0;
int num = 0;

Console.WriteLine("--- SUMADORA INTERACTIVA ---");
Console.WriteLine("Introduce números uno a uno. Para terminar y ver el total, escribe el 9.");

while (true)
{
    Console.Write("Ingrese un número: ");

    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num == 9)
        {
            break; 
        }

        suma += num; 
    }
    else
    {
        Console.WriteLine("Por favor, ingresa un número entero.");
    }
}

Console.WriteLine($"Proceso finalizado por centinela (9).");
Console.WriteLine($"La suma total de los números es: {suma}");

