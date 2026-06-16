using System;

class Program
{
    static void Main()
    {
        int senhaCorreta = 1234;
        int senhaDigitada;

        do
        {
            Console.Write("Informe a senha: ");
            senhaDigitada = int.Parse(Console.ReadLine());

            if (senhaDigitada != senhaCorreta)
            {
                Console.WriteLine("Senha incorreta. Tente novamente.");
            }

        } while (senhaDigitada != senhaCorreta);

        Console.WriteLine("Acesso permitido.");
    }
}
