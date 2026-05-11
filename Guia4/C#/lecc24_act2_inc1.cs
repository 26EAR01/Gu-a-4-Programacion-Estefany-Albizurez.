Console.Write("¿De qué número quieres conocer sus primeros 20 múltiplos?: ");

if (int.TryParse(Console.ReadLine(), out int num))
{
    Console.WriteLine($"\n--- LISTADO DE LOS 20 PRIMEROS MÚLTIPLOS DE {num} ---");

    for (int i = 1; i <= 20; i++)
    {
        int resultado = num * i;

        Console.WriteLine($"{num} x {i} = {resultado}");
    }

}
else
{
    Console.WriteLine("Por favor, ingresa un número entero válido.");
}
