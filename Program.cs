using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Informe a quantidade de clientes atendidos: ");
        int clientes = int.Parse(Console.ReadLine());

        double tempoTotal = 0;

        for (int i = 0; i < clientes; i++)
        {
            Console.Write("Informe o tempo do atendimento: ");
            tempoTotal += double.Parse(Console.ReadLine());
        }

        double tempoMedio = clientes > 0 ? tempoTotal / clientes : 0;

        Console.WriteLine($"Tempo total de atendimento: {tempoTotal} minutos");
        Console.WriteLine($"Tempo médio por cliente: {tempoMedio} minutos");
    }
}
