using System;

class Program
{
    public static int Soma(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o primeiro número para ser somado: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número para ser somado: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = Soma(num1, num2);
            Console.WriteLine(soma);
        }

        catch (FormatException)
        {
            Console.WriteLine("Formato de caractere inválido.");
        }

        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado.");
        }
    }
}