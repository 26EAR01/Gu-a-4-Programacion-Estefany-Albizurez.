Console.Write("Ingrese el primer número: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int n2 = int.Parse(Console.ReadLine());

int menor = Math.Min(n1, n2);
int mayor = Math.Max(n1, n2);

Console.WriteLine($"\nBuscando múltiplos de 4 entre {menor} y {mayor}:");

bool encontroAlguno = false;

for (int i = menor; i <= mayor; i++)
{
    if (i % 4 == 0)
    {
        Console.WriteLine($"-> {i} es múltiplo de 4");
        encontroAlguno = true;
    }
}

if (!encontroAlguno)
{
    Console.WriteLine("No se encontraron múltiplos de 4 en este rango.");
}
