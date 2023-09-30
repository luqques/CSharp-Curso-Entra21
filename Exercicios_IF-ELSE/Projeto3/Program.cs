using System;

namespace Projeto3
{
    class Projeto3
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é PAR.");
            }
            else
            {
                Console.WriteLine("O usuário é ÍMPAR.");
            }
        }
    }
}