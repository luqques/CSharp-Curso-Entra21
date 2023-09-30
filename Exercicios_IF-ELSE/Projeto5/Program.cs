using System;

namespace Projeto5
{
    class Projeto5
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 5 == 0)
            {
                Console.WriteLine("O número digitado é múltiplo de 5.");
            }
            else
            {
                Console.WriteLine("O número digitado não é multiplo de 5.");
            }
        }
    }
}