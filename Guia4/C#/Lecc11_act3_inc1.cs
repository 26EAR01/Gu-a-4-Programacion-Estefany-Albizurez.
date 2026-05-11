Console.Write("Ingrese el primer número entero: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número entero: ");
int n2 = int.Parse(Console.ReadLine());

int menor = Math.Min(n1, n2);
int mayor = Math.Max(n1, n2);

int suma = 0;

for (int i = menor; i <= mayor; i++)
{
    suma += i; 
}

Console.WriteLine($"Calculando suma desde {menor} hasta {mayor}...");
Console.WriteLine($"El resultado total de la suma es: {suma}");

