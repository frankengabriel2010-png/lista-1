using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Informe o valor total da compra: ");
        double valorOriginal = double.Parse(Console.ReadLine());

        double desconto = 0;
        if (valorOriginal >= 200.00)
        {
            desconto = valorOriginal * 0.10;
        }

        double valorFinal = valorOriginal - desconto;

        Console.WriteLine($"Valor original: R$ {valorOriginal:F2}");
        Console.WriteLine($"Desconto aplicado: R$ {desconto:F2}");
        Console.WriteLine($"Valor final: R$ {valorFinal:F2}");
    }
}
