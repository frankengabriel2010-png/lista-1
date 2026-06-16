using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Informe o saldo inicial: ");
        double saldo = double.Parse(Console.ReadLine());
        int operacao = 0;

        while (operacao != 3)
        {
            Console.Write("Escolha a operação: ");
            operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.Write("Informe o valor da movimentação: ");
                double valor = double.Parse(Console.ReadLine());
                saldo += valor;
                Console.WriteLine($"Entrada registrada. Saldo atual: R$ {saldo:F2}");
            }
            else if (operacao == 2)
            {
                Console.Write("Informe o valor da movimentação: ");
                double valor = double.Parse(Console.ReadLine());

                if (valor <= saldo)
                {
                    saldo -= valor;
                    Console.WriteLine($"Saída registrada. Saldo atual: R$ {saldo:F2}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
        }

        Console.WriteLine($"Saldo final: R$ {saldo:F2}");
    }
}
