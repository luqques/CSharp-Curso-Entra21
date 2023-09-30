using System;

class Program
{
    static int ContarDigitos(int num)
    {
        int numeroDigitos = Convert.ToString(num).Length;
        return numeroDigitos;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int numeroDigitos = ContarDigitos(num);
            Console.WriteLine($"Numero de dígitos: {numeroDigitos}");
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