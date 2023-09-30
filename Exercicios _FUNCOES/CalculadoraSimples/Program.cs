using System;
using System.Net.NetworkInformation;

class Program
{
    public static int Calcular(int n1, char operador, int n2)
    {
        int resultado = 0;
        switch (operador)
        {
            case '+':
                resultado = n1 + n2;
                break;
            case '-':
                resultado = n1 - n2;
                break;
            case '*':
                resultado = n1 * n2;
                break;
            case '/':
                resultado = n1 / n2;
                break;
            default:
                throw new FormatException("Operador inválido.");
        }
        return resultado;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.Write("Digite o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o operador: ");
            char operador = Convert.ToChar(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = Calcular(n1, operador, n2);
            Console.WriteLine(result);
        }

        catch (ArgumentException)
        {
            Console.WriteLine("Falta de parâmetros na função. ");
        }

        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }


    }
}