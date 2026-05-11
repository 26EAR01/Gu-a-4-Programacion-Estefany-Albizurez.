int billete;
int contador100 = 0;
int totalDinero = 0;

while (totalDinero < 1000)
{
    Console.Write("Ingrese el valor del billete (20, 50 o 100): ");
    billete = int.Parse(Console.ReadLine());

    if (billete == 100)
    {
        contador100++;
    }

    totalDinero += billete;
}

Console.WriteLine("Cantidad de billetes de 100: " + contador100);
Console.WriteLine("Total de dinero: " + totalDinero);

Console.ReadKey();
