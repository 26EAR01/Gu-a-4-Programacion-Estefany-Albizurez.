int monedasTotales = 0;
const int REQUISITO_MONEDAS = 350;

Console.WriteLine("=== ESTADO DEL JUEGO ===");
Console.WriteLine("Nivel 5: BLOQUEADO (Requisito: 350 monedas)");

while (monedasTotales < REQUISITO_MONEDAS)
{
    Console.WriteLine($"\nSaldo actual: {monedasTotales} monedas.");
    Console.Write("Ingresa la cantidad de monedas obtenidas en esta ronda: ");

    if (int.TryParse(Console.ReadLine(), out int monedasGanadas))
    {
        monedasTotales += monedasGanadas;
        Console.WriteLine($"¡Has recolectado {monedasGanadas} monedas más!");
    }
    else
    {
        Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero.");
    }
}
Console.WriteLine($"¡LOGRO ALCANZADO: {monedasTotales} MONEDAS!");
Console.WriteLine("EL NIVEL 5 AHORA ESTÁ DESBLOQUEADO.");
