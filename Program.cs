using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o número inicial da contagem regressiva: ");
        int numeroInicial = int.Parse(Console.ReadLine());

        for (int i = numeroInicial; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Fim da contagem.");
    }
}
