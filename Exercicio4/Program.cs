namespace Exercicio4;

class Program
{
    static void Main()
    {
        string texto = Console.ReadLine();
        string textoSemEspacos = texto.Trim();

        int contador = 0;
        for (int i = 0, n = textoSemEspacos.Length; i < n; i++)
        {
            if (textoSemEspacos[i] != ' ')
                contador++;
        }

        Console.WriteLine($"Quantidade de caracteres: {contador}");
    }
}