using System;

class Program
{
    static double CalcularMedia(double n1, double n2, double n3)
    {
        double media = 0;

        media = (n1 + n2 + n3) / 3;
        return media;
    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite 3 números para realizar a média: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());

            double media = CalcularMedia(n1, n2, n3);

            Console.WriteLine($"Sua média é {media}");
        }

        catch (FormatException)
        {
            Console.WriteLine("Caractere inválido.");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado. {ex.Message}");
        }

    }
}