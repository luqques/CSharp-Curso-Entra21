using System;
using System.Linq.Expressions;

class Program
{
    static bool Primo(int numero)
    {
        bool isNumeroPrimo = true;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                isNumeroPrimo = false;
            }
        }

        return isNumeroPrimo;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite um número para descobrir se ele é primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            bool isNumeroPrimo = Primo(numero);
            if (isNumeroPrimo == true)
            {
                Console.WriteLine("O número é primo!");
            }
            else
            {
                Console.WriteLine("O número não é primo!");
            }
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Falta de parâmetros na função.");
        }

        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }

        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado. " + ex.Message);
        }
    }
}