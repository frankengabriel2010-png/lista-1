using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Informe da idade do passageiro: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Informe o valor normal da passagem: ");
        double valorNormal = double.Parse(Console.ReadLine());

        double valorPagar;

        if (idade <= 5)
        {
            valorPagar = 0;
        }
        else if (idade >= 60)
        {
            valorPagar = valorNormal * 0.50;
        }
        else
        {
            valorPagar = valorNormal;
        }

        Console.WriteLine($"Valor normal da passagem: R$ {valorNormal:F2}");
        Console.WriteLine($"Valor a pagar: R$ {valorPagar:F2}");
    }
}
