using System.Globalization;

namespace Exercicio3;

class Program
{
    static void Main()
    {
        double valor1 = double.Parse(Console.ReadLine());
        double valor2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"Soma: {valor1 + valor2}");
        Console.WriteLine($"Subtração: {valor1 - valor2}");
        Console.WriteLine($"Multiplicação: {valor1 * valor2}");
        if (valor2 != 0)
            Console.WriteLine($"Divisão: {valor1 / valor2}");
        Console.WriteLine($"Média: {(valor1 + valor2) / 2}");
    }
}