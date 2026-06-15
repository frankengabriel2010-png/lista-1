using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a quantidade de tarefas concluídas: ");
        int tarefas = int.Parse(Console.ReadLine());
        int meta = 50;

        if (tarefas >= meta)
        {
            Console.WriteLine("Meta atingida.");
            Console.WriteLine($"Tarefas concluídas: {tarefas}");
        }
        else
        {
            Console.WriteLine("Meta não atingida.");
            int faltaram = meta - tarefas;
            Console.WriteLine($"Faltaram {faltaram} tarefas.");
        }
    }
}
