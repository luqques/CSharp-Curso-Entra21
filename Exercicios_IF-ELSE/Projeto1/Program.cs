using System;

namespace Projeto1
{
    class Projeto1
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("O número digitado é positivo.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("O número digitado é 0.");
            }
            else
            {
                Console.WriteLine("O número é negativo.");
            }
        }
    }
}