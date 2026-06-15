using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Informe o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("O primeiro número é maior.");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("O segundo número é maior.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}
