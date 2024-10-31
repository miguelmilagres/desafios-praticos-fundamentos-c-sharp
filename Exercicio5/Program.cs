namespace Exercicio5;

class Program
{
    static void Main()
    {
        bool result = false;

        Console.Write("Digite a placa do seu veículo: ");
        string? placa = Console.ReadLine();

        if (placa is not null)
            if (placa.All(Char.IsLetterOrDigit) && placa.Length == 7)
                if (placa.Substring(0, 3).All(Char.IsLetter))
                    if (placa.Substring(3).All(Char.IsNumber))
                        result = true;

        if (result)
            Console.WriteLine("Verdadeiro");
        else
            Console.WriteLine("Falso");
    }
}