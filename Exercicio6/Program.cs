using System.Globalization;

namespace Exercicio6;

class Program
{
    static void Main()
    {
        DateTime dataAtual = DateTime.Now;
        Dictionary<int, string> opcoes = new Dictionary<int, string>();

        opcoes.Add(1, "Formato completo");
        opcoes.Add(2, "Apenas a data no formato \"01/03/2024\"");
        opcoes.Add(3, "Apenas a hora no formato de 24 horas");
        opcoes.Add(4, "A data com o mês por extenso");

        Console.WriteLine("Escolha a forma de exibição da data: ");
        for (int i = 1; i <= opcoes.Count; i++)
        {
            Console.WriteLine($"{i} - {opcoes[i]}");
        }

        Console.WriteLine();
        Console.Write("Digite sua opção: ");
        int opcao = int.Parse(Console.ReadLine());

        Console.WriteLine();
        string resultado = opcao switch
        {
            1 => dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss"),
            2 => dataAtual.ToString("dd/MM/yyyy"),
            3 => dataAtual.ToString("HH:mm"),
            4 => dataAtual.ToString("dd 'de' MMMM 'de' yyyy")
        };

        Console.Write("Data no formato escolhido: ");
        Console.WriteLine(resultado);
    }
}