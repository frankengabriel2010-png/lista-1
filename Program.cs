using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        string[] ordinais = { "primeiro", "segundo", "terceiro", "quarto", "quinto" };
        double soma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Informe o {ordinais[i]} valor: ");
            soma += double.Parse(Console.ReadLine());
        }

        double media = soma / 5;

        Console.WriteLine($"Soma dos valores: {soma}");
        Console.WriteLine($"Média dos valores: {media}");
    }
}
