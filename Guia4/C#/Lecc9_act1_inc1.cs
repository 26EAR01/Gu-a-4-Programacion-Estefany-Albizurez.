double pesoobjetivo = 1000.0; 
double pesoactual = 0.0;
double pesomanzana;

Console.WriteLine("---- BAscula ____");
Console.WriteLine($"Objetivo: {pesoobjetivo} gramos.");

while (pesoactual < pesoobjetivo)
{
    Console.WriteLine($"\npeso actual en bascula: {pesoobjetivo} gramos.");
    Console.Write("Coloque un amanzana y esciba su peso en gramos: ");

    String entrada = Console.ReadLine();    

    if (double.TryParse(entrada, out pesomanzana))
    {
        pesoactual += pesomanzana;
        Console.WriteLine($"añadido: {pesomanzana}g");
    }
    else
    {
        Console.WriteLine("¨por favor, ingrese un numero valido");
    }
}
Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("Proceso completado");
Console.WriteLine($"Peso final: {pesoactual}g");
