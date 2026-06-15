88class Program
{
    static void Main()
    {
        // 1. Entrada de dados
        Console.Write("Informe a temperatura atual: ");
        string entrada = Console.ReadLine();
        
        // Conversão da entrada para número decimal (double)
        if (double.TryParse(entrada, out double temperatura))
        {
            // 2. Processamento e Saída de dados
            if (temperatura < 18)
            {
                Console.WriteLine("Ambiente frio.");
            }
            else if (temperatura >= 18 && temperatura <= 26)
            {
                Console.WriteLine("Ambiente confortável.");
            }
            else
            {
                Console.WriteLine("Ambiente quente.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, insira um valor numérico válido.");
        }
    }
}