Console.Write("Ingrese un número: ");

if (int.TryParse(Console.ReadLine(), out int numUsuario))
{
    if (numUsuario >= 2)
    {
        Console.WriteLine($"\nNúmeros pares del 2 al {numUsuario}:");

        for (int i = 2; i <= numUsuario; i += 2)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("Por favor ingrese un número mayor o igual a 2.");
    }
}
else
{
    Console.WriteLine("Error: Debe ingresar un número entero.");
}
