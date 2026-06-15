using System.Globalization;

Console.Write("Informe a nota final: ");
double nota = double.Parse(Console.ReadLine()!, new CultureInfo("pt-BR"));

if (nota >= 7)
{
    Console.WriteLine("Estudante aprovado.");
}
else if (nota >= 5)
{
    Console.WriteLine("Estudante em recuperação.");
}
else
{
    Console.WriteLine("Estudante reprovado.");
}