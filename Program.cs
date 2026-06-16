using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a quantidade inicial em estoque: ");
        int estoque = int.Parse(Console.ReadLine());
        int operacao = 0;

        while (operacao != 4)
        {
            Console.Write("Escolha a operação: ");
            operacao = int.Parse(Console.ReadLine());

            if (operacao == 1)
            {
                Console.Write("Informe o quantidade movimentada: ");
                int quantidade = int.Parse(Console.ReadLine());
                estoque += quantidade;
                Console.WriteLine($"Entrada registrada. Estoque atual: {estoque}");
            }
            else if (operacao == 2)
            {
                Console.Write("Informe o quantidade movimentada: ");
                int quantidade = int.Parse(Console.ReadLine());

                if (quantidade <= estoque)
                {
                    estoque -= quantidade;
                    Console.WriteLine($"Saída registrada. Estoque atual: {estoque}");
                }
                else
                {
                    Console.WriteLine("Quantidade insuficiente em estoque.");
                }
            }
            else if (operacao == 3)
            {
                Console.WriteLine($"Estoque atual: {estoque}");
            }
        }

        Console.WriteLine($"Estoque final: {estoque}");
    }
}
