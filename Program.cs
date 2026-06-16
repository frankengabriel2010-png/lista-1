using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
        double nota;

        while (true)
        {
            Console.Write("Informe uma nota de 0 a 10: ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                break;
            }

            Console.WriteLine("Nota inválida. Informe novamente.");
        }

        Console.WriteLine($"Nota registrada: {nota}");
    }
}
