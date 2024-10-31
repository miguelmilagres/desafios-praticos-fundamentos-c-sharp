namespace Exercicio2;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome} {sobrenome}");
    }
}