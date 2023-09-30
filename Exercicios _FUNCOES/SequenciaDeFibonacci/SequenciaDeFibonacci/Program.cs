using System;
using System.Linq.Expressions;

class Program
{
    static string Fibonacci(int num)
    {
        string sequenciaFibonacci = "";

        int numeroAnterior = 0;
        int numeroAtual = 1;
        int fibonacci;

        sequenciaFibonacci = "0 1 ";
        for (int i = 0; i <= num; i++)
        {
            fibonacci = numeroAnterior + numeroAtual;
            numeroAnterior = numeroAtual;
            numeroAtual = fibonacci;

            sequenciaFibonacci += Convert.ToString(fibonacci) + " ";
        }

        return sequenciaFibonacci;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite quantas sequências de Fibonacci você deseja: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string sequenciaFibonacci = Fibonacci(num);
            Console.WriteLine(sequenciaFibonacci);
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